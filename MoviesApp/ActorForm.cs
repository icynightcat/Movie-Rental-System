using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using MoviesApp.SQL;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace MoviesApp
{
    public partial class ActorForm : Form
    {

        private string empId = ""; //id initalized to use
        private DBConnection connection;
        private int whichActor;
        private List<string> movies = new List<string>();
        private bool readOnlyMode = true;
        private Boolean newActor = false;

        public ActorForm(string empId, DBConnection connection, int whichActor)
        {
            this.connection = connection;
            this.empId = empId;
            this.whichActor = whichActor;
            InitializeComponent();


        }

        private void ActorForm_Load(object sender, EventArgs e) {

            string query = "";
            SqlDataReader? empdata;

            // If new movie, generate movie id
            if (whichActor == -1)
            {
                // If a new actor is being made, then generate an id
                query = $"insert into Actors(first_name, last_name, gender, age) output Inserted.actor_id values('', '', '', 0)";

                empdata = connection.GetDataReader(query);

                // Populate actor info on actor page
                if (empdata != null && empdata.Read())
                {
                    whichActor = Int32.Parse(empdata["actor_id"].ToString());

                    // Display the new id
                    actorIdLabel.Text = whichActor.ToString();

                }

                // Close the reader after data is read in
                if (empdata != null)
                    empdata.Close();


                // Remember that we're making a new movie
                newActor = true;

                // Fields should be editable
                toggleFieldsEditable();
            }

            // Else, populate the actor's info and display it
            else
            {
                query = $"select distinct first_name, last_name, gender, age from Actors where actor_id = {whichActor}";

                empdata = connection.GetDataReader(query);

                // If there's a result, then populate the datagrid view
                if (empdata != null && empdata.Read())
                {
                    actorIdLabel.Text = whichActor.ToString();
                    actorFirstNameTextBox.Text = empdata["first_name"].ToString();
                    actorLastNameTextBox.Text = empdata["last_name"].ToString();
                    actorGenderComboBox.Text = empdata["gender"].ToString();
                    actorAgeTextBox.Text = empdata["age"].ToString();
                }
                // Otherwise, soemthing went wrong. Return
                else
                    this.Close();

                if (empdata != null)
                    empdata.Close();                //closes the reader after the data is read in
            }


            actorMoviesDataGridView.AllowUserToAddRows = false;

            populateActorMovies();

        }

        private void populateActorMovies()
        {
            // Get what movies the actor has performed in and display in bottom DataGridView
            string query = $"select M.movie_id, M.movie_name from Movie M, Acts_in AI where M.movie_id = AI.movie_id and AI.actor_id = {whichActor}";

            SqlDataReader? empdata = connection.GetDataReader(query);

            // If there's a result, then populate the datagrid view
            while (empdata != null && empdata.Read())
            {
                actorMoviesDataGridView.Rows.Add(false, empdata["movie_id"].ToString(), empdata["movie_name"].ToString());
            }

            if (empdata != null)
                empdata.Close();                //closes the reader after the data is read in
        }

        private void movieSearchTextBox_Leave(object sender, EventArgs e)
        {
            if (actorMovieSearchListBox.ContainsFocus == false)
            {
                actorMovieSearchListBox.Items.Clear();
                actorMovieSearchListBox.Visible = false;
            }
        }

        private void clearActorMovieSearchButton_Click(object sender, EventArgs e)
        {
            actorMovieSearchTextBox.Text = "";
            actorMovieSearchListBox.Items.Clear();
            actorMovieSearchListBox.Visible = false;
        }

        private void actorMovieSearchListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            // Get the currently selected item in the ListBox.
            actorMovieSearchTextBox.Text = actorMovieSearchListBox.SelectedItem.ToString();
            actorMovieSearchListBox.Items.Clear();
            actorMovieSearchListBox.Visible = false;
        }

        private void addActorMovieButton_Click(object sender, EventArgs e)
        {
            int movieAddId;
            string message;
            string title;

            // Get movie titles
            String query = $"select movie_id from Movie where movie_name = '{actorMovieSearchTextBox.Text}' order by movie_name";

            SqlDataReader? empdata = connection.GetDataReader(query);

            if (empdata == null)
            {
                message = "Please enter a valid movie title";
                title = "Invalid";
                MessageBox.Show(message, title);
                return;
            }

            // A movie was found. Get ID
            if (empdata.Read())
                movieAddId = Int32.Parse(empdata["movie_id"].ToString());
            else
                return;

            // Close the reader after data is read in
            if (empdata != null)
                empdata.Close();

            // Add movie to this actor if it isn't already there
            String mutation = $"insert into Acts_in(actor_id, movie_id) values({whichActor}, {movieAddId})";
            int result = connection.ExecuteMutation(mutation);

            if (result == 0)
            {
                message = $"Could not insert";
                title = "Info";
                MessageBox.Show(message, title);
            }

            actorMovieSearchTextBox.Text = "";
            actorMovieSearchListBox.Visible = false;
            actorMoviesDataGridView.Rows.Clear();
            populateActorMovies();
        }

        private void actorMovieSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            actorMovieSearchListBox.Items.Clear();
            actorMovieSearchListBox.Visible = true;
            String[] actorMovieSearch = actorMovieSearchTextBox.Text.Split(' ');

            // Get the movies
            String query = $"select * from Movie " +
                $"where movie_name like '%" + String.Join("%' or movie_name like '%", actorMovieSearch) + "%' " +
                $"order by movie_name";

            SqlDataReader? empdata = connection.GetDataReader(query);

            while (empdata != null && empdata.Read())
            {
                actorMovieSearchListBox.Items.Add(empdata["movie_name"].ToString());
            }

            // Close the reader after data is read in
            if (empdata != null)
                empdata.Close();
        }

        private void removeActorMovieButton_click(object sender, EventArgs e)
        {
            DataGridViewCheckBoxCell oCell;
            List<int> selectedActorMovies = new List<int>();

            foreach (DataGridViewRow row in actorMoviesDataGridView.Rows)
            {
                oCell = row.Cells[0] as DataGridViewCheckBoxCell;
                bool bChecked = (null != oCell && null != oCell.Value && true == (bool)oCell.Value);
                if (bChecked == true)
                {
                    selectedActorMovies.Add(Int32.Parse(row.Cells[1].Value.ToString()));
                }
            }

            if (selectedActorMovies.Count > 0)
            {
                String mutation = $"delete from Acts_in where actor_id = {whichActor} and movie_id in ({String.Join(',', selectedActorMovies)})";
                connection.ExecuteMutation(mutation);
                actorMoviesDataGridView.Rows.Clear();
                populateActorMovies();
            }
        }

        /* Makes fields editable */
        private void empActorEditButton_click(object sender, EventArgs e)
        {
            toggleFieldsEditable();
        }

        private void actorCancelButton_Click(object sender, EventArgs e)
        {
            // Ensure, if a new actor was added, that it is deleted
            if (newActor)
            {
                String message = "Changes will be lost. Click yes to discard changes or no to stay on this page.";
                String title = "Caution";

                DialogResult dialogResult = MessageBox.Show(message, title, MessageBoxButtons.YesNo);

                // Delete changes and leave form
                if (dialogResult == DialogResult.Yes)
                {
                    String mutation = $"delete from Actors where actor_id = {whichActor}";
                    connection.ExecuteMutation(mutation);
                    this.Close();
                }

                // Stay on page
                else if (dialogResult == DialogResult.No)
                    return;
            }

            this.Close();
        }



        private void toggleFieldsEditable()
        {
            readOnlyMode = !readOnlyMode;
            actorFirstNameTextBox.ReadOnly = readOnlyMode;
            actorLastNameTextBox.ReadOnly = readOnlyMode;
            actorGenderComboBox.Enabled = !readOnlyMode;
            actorAgeTextBox.ReadOnly = readOnlyMode;
            actorMoviesDataGridView.Columns[0].Visible = !readOnlyMode;
            removeActorMovieButton.Visible = !readOnlyMode;
            actorMovieSearchTextBox.Visible = !readOnlyMode;
            addActorMovieButton.Visible = !readOnlyMode;
            clearActorMovieSearchButton.Visible = !readOnlyMode;

            if (readOnlyMode)
                actorEditButton.Text = "Edit";
            else
            {
                actorEditButton.Text = "Done Editing";
            }
        }

        private string formValidationCheck()
        {
            if (actorFirstNameTextBox.Text == "" || actorLastNameTextBox.Text == "")
                return "Actor first and last name are required.";
            if (actorGenderComboBox.Text != "Male" && actorGenderComboBox.Text != "Female" && actorGenderComboBox.Text != "Bigender")
                return "Please select a valid gender";
            if (!actorAgeTextBox.Text.All(char.IsDigit))
                return "Please input a valid age";
            return "";
        }

        private void actorDoneButton_Click(object sender, EventArgs e)
        {
            String message;
            String title;

            // Ensure, if a new actor is being added, that a name is provided
            if (newActor && formValidationCheck() != "")
            {
                message = formValidationCheck() +"\nWould you like to proceed?\nClick yes to discard changes or no to stay on this page.";
                title = "Caution";

                DialogResult dialogResult = MessageBox.Show(message, title, MessageBoxButtons.YesNo);

                // Delete changes and leave form
                if (dialogResult == DialogResult.Yes)
                {
                    deleteActor();
                    this.Close();
                }

                // Stay on page
                else if (dialogResult == DialogResult.No)
                    return;

            }
            else
            {
                if (formValidationCheck() != "")
                {
                    message = formValidationCheck();
                    title = "notice";
                    MessageBox.Show(message, title);
                    return;
                }
                saveChanges();
            }

            this.Close();
        }

        /* Function does a confirmation message and then deletes the actor from the database */
        private void actorDeleteButton_Click(object sender, EventArgs e)
        {

            String message = "Are you sure you want to delete this actor?\nClick yes to proceed or no to stay on this page.";
            String title = "Caution";

            DialogResult dialogResult = MessageBox.Show(message, title, MessageBoxButtons.YesNo);

            // Delete changes and leave form
            if (dialogResult == DialogResult.Yes)
            {
                deleteActor();
                this.Close();
            }

            // Stay on page
            else if (dialogResult == DialogResult.No)
                return;


            this.Close();
        }

        private void deleteActor()
        {

            // Remove all acts_in records for this actor
            string mutation = $"delete from Acts_in where actor_id = {whichActor}";
            connection.ExecuteMutation(mutation);

            // Delete this actor record
            mutation = $"delete from Actors where actor_id = {whichActor}";
            connection.ExecuteMutation(mutation);
        }

        private void saveChanges()
        {

            String mutation = $"update Actors set first_name = '{actorFirstNameTextBox.Text}', last_name = '{actorLastNameTextBox.Text}', gender = '{actorGenderComboBox.Text}', age = {Int32.Parse(actorAgeTextBox.Text)} where actor_id = {whichActor}";
            connection.ExecuteMutation(mutation);

            string message = $"Movie details saved";
            string title = "notice";
            MessageBox.Show(message, title);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
