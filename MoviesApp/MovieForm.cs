using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices;
using MoviesApp.SQL;
using System.Collections;
using System.Reflection.Metadata;

namespace MoviesApp
{
    public partial class MovieForm : Form
    {
        private string empId = ""; //id initalized to use
        private DBConnection connection;
        private int whichMovie;
        private List<string> movieGenres = new List<string>();
        private List<int> movieActors = new List<int>();
        private bool readOnlyMode = true;

        public MovieForm(string empId, DBConnection input_connection, int whichMovie)
        {
            this.connection = input_connection;
            this.empId = empId;
            this.whichMovie = whichMovie;
            InitializeComponent();
        }

        private void MovieForm_Load(object sender, EventArgs e)
        {
            // Populate combo box on movies page
            string query = $"select movie_id, movie_name, distribution_fee from Movie where movie_id = {whichMovie}";
            SqlDataReader? empdata = connection.GetDataReader(query);

            // Populate movie info on movies page
            while (empdata != null && empdata.Read())
            {
                movieAboutLabel.Text = empdata["movie_id"].ToString();
                titleTextBox.Text = empdata["movie_name"].ToString();
                distrFeeTextBox.Text = empdata["distribution_fee"].ToString();
            }

            // Close the reader after data is read in
            if (empdata != null)
                empdata.Close();

            populateMovieCopies();
            populateMovieActors();

        }

        private void populateMovieCopies()
        {
            // Get the movie genres
            String query = $"select type_of_movie from Movie_types " +
                $"where movie_id = {whichMovie}";
            SqlDataReader? empdata = connection.GetDataReader(query);

            while (empdata != null && empdata.Read())
            {
                movieGenres.Add(empdata["type_of_movie"].ToString()!);
            }

            // Close the reader after data is read in
            if (empdata != null)
                empdata.Close();
        }

        private void populateMovieActors()
        {
            // Get the movie actors
            String query = $"select * from Actors A, Acts_in AI where AI.movie_id = {whichMovie} " +
                $" and AI.actor_id = A.actor_id order by A.first_name";

            SqlDataReader? empdata = connection.GetDataReader(query);

            while (empdata != null && empdata.Read())
            {
                movieActorsDataGridView.Rows.Add(false, empdata["actor_id"].ToString(), empdata["first_name"].ToString(), empdata["last_name"].ToString(), empdata["gender"].ToString(), empdata["age"].ToString());
            }

            // Close the reader after data is read in
            if (empdata != null)
                empdata.Close();
        }

        private void addCopyButton_click(object sender, EventArgs e)
        {
            if(addCopyComboBox.Text != "Movie Type" && addCopyResComboBox.Text != "Resolution")
            {
                String mutation = $"insert into Movie_copies(movie_id, format, resolution) values({whichMovie}, {addCopyComboBox.Text}, {addCopyResComboBox.Text})";

                connection.ExecuteMutation(mutation);
                movieCopiesDataGridView.Rows.Clear();
                populateMovieCopies();
            }
        }
        private void actorSearchTextBox_Leave(object sender, EventArgs e)
        {
            if (actorSearchListBox.ContainsFocus == false) {
                actorSearchListBox.Items.Clear();
                actorSearchListBox.Visible = false;
            }
        }

        private void clearActorSearchButton_Click(object sender, EventArgs e)
        {
            actorSearchTextBox.Text = "";
            actorSearchListBox.Items.Clear();
            actorSearchListBox.Visible = false;
        }
        private void actorSearchListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            // Get the currently selected item in the ListBox.
            actorSearchTextBox.Text = actorSearchListBox.SelectedItem.ToString();
            actorSearchListBox.Items.Clear();
            actorSearchListBox.Visible=false;
        }

            private void addActorButton_Click(object sender, EventArgs e)
        {
            int actorAddId;

            // Get the movie actors
            String query = $"select actor_id from Actors where first_name + ' ' + last_name = '{actorSearchTextBox.Text}' order by first_name";

            SqlDataReader? empdata = connection.GetDataReader(query);

            if (empdata == null)
            {
                string message = "Please enter a valid actor";
                string title = "Invalid";
                MessageBox.Show(message, title);
                return;
            }

            // An actor was found. Get ID
            if (empdata.Read())
                actorAddId = Int32.Parse(empdata["actor_id"].ToString());
            else
                return;

            // Close the reader after data is read in
            if (empdata != null)
                empdata.Close();

            // Add actor to this movie if they aren't already there
            String mutation = $"insert into Acts_in(actor_id, movie_id) values({actorAddId}, {whichMovie})";
            int result = connection.ExecuteMutation(mutation);

            if (result == 0)
            {
                string message3 = $"Could not insert";
                string title3 = "Info";
                MessageBox.Show(message3, title3);
            }

            actorSearchTextBox.Text = "";
            actorSearchListBox.Visible = false;
            movieActorsDataGridView.Rows.Clear();
            populateMovieActors();
        }
        private void actorSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            actorSearchListBox.Items.Clear();
            actorSearchListBox.Visible = true;
            String[] actorSearch = actorSearchTextBox.Text.Split(' ');

            // Get the movie actors
            String query = $"select * from Actors A " +
                $"where A.first_name like '%" + String.Join("%' or A.first_name like '%", actorSearch) + "%' " +
                $"or A.last_name like '%" + String.Join("%' or A.last_name like '%", actorSearch) + "%' " +
                $"order by A.first_name";

            SqlDataReader? empdata = connection.GetDataReader(query);

            while (empdata != null && empdata.Read())
            {
                actorSearchListBox.Items.Add(empdata["first_name"].ToString() + " " + empdata["last_name"].ToString());
            }

            // Close the reader after data is read in
            if (empdata != null)
                empdata.Close();
        }
        private void removeCopyButton_click(object sender, EventArgs e)
        {
            DataGridViewCheckBoxCell oCell;
            List<int> selectedCopies = new List<int>();

            foreach (DataGridViewRow row in movieCopiesDataGridView.Rows)
            {
                oCell = row.Cells[0] as DataGridViewCheckBoxCell;
                bool bChecked = (null != oCell && null != oCell.Value && true == (bool)oCell.Value);
                if (bChecked == true)
                {
                    selectedCopies.Add(Int32.Parse(row.Cells[1].Value.ToString()));
                }
            }

            if (selectedCopies.Count > 0)
            {
                String mutation = $"delete from Movie_copies where movie_id = {whichMovie} and copy_id in ({String.Join(',', selectedCopies)})";
                connection.ExecuteMutation(mutation);
                movieCopiesDataGridView.Rows.Clear();
                populateMovieCopies();
            }
        }

        private void removeActorButton_click(object sender, EventArgs e)
        {
            DataGridViewCheckBoxCell oCell;
            List<int> selectedActors = new List<int>();

            foreach (DataGridViewRow row in movieActorsDataGridView.Rows)
            {
                oCell = row.Cells[0] as DataGridViewCheckBoxCell;
                bool bChecked = (null != oCell && null != oCell.Value && true == (bool)oCell.Value);
                if (bChecked == true)
                {
                    selectedActors.Add(Int32.Parse(row.Cells[1].Value.ToString()));
                }
            }

            if (selectedActors.Count > 0)
            {
                String mutation = $"delete from Acts_in where movie_id = {whichMovie} and actor_id in ({String.Join(',', selectedActors)})";
                connection.ExecuteMutation(mutation);
                movieActorsDataGridView.Rows.Clear();
                populateMovieActors();
            }
        }
        private void empMovieEditButton_click(object sender, EventArgs e)
        {
            readOnlyMode = !readOnlyMode;
            titleTextBox.ReadOnly = readOnlyMode;
            distrFeeTextBox.ReadOnly = readOnlyMode;
            movieActorsDataGridView.Columns[0].Visible = !readOnlyMode;
            movieCopiesDataGridView.Columns[0].Visible = !readOnlyMode;
            removeCopyButton.Visible = !readOnlyMode;
            removeActorButton.Visible = !readOnlyMode;
            actorSearchTextBox.Visible = !readOnlyMode;
            addCopyComboBox.Visible = !readOnlyMode;
            addCopyResComboBox.Visible = !readOnlyMode;
            addCopyButton.Visible = !readOnlyMode;
            clearActorSearchButton.Visible = !readOnlyMode;
            addActorButton.Visible = !readOnlyMode;

            if (readOnlyMode)
                empMovieEditButton.Text = "Edit";
            else
            {
                empMovieEditButton.Text = "Done Editing";
            }
        }
        private void movieDoneButton_Click(object sender, EventArgs e)
        {
            //verifiy if it is not a real movie already then do it and close or dont close and do a popup that says no
            string title = titleTextBox.Text; //all that is needed to get the info once someone clicks it

            this.Close();
        }
    }
}
