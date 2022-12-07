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
        private Boolean newMovie = false;

        public MovieForm(string empId, DBConnection input_connection, int whichMovie)
        {
            this.connection = input_connection;
            this.empId = empId;
            this.whichMovie = whichMovie;
            InitializeComponent();
        }

        private void MovieForm_Load(object sender, EventArgs e)
        {
            // If new movie, generate movie id
            if (whichMovie == -1)
            {
                // If a new movie is being made, then generate an id
                string insertQuery = $"insert into Movie(movie_name, distribution_fee) output Inserted.movie_id values('', 0)";
                SqlDataReader? empdata1 = connection.GetDataReader(insertQuery);

                // Populate movie info on movies page
                if (empdata1 != null && empdata1.Read())
                {
                    whichMovie = Int32.Parse(empdata1["movie_id"].ToString());
                    // Display the new id
                    movieWhichIdLabel.Text = whichMovie.ToString();

                }

                // Close the reader after data is read in
                if (empdata1 != null)
                    empdata1.Close();


                // Remember that we're making a new movie
                newMovie = true;

                // Fields should be editable
                toggleFieldsEditable();
                
            }

            string query = $"select movie_id, movie_name, distribution_fee from Movie where movie_id = {whichMovie}";
            SqlDataReader? empdata = connection.GetDataReader(query);

            // Populate movie info on movies page
            while (empdata != null && empdata.Read())
            {
                movieWhichIdLabel.Text = empdata["movie_id"].ToString();
                titleTextBox.Text = empdata["movie_name"].ToString();
                distrFeeTextBox.Text = empdata["distribution_fee"].ToString();
            }

            // Close the reader after data is read in
            if (empdata != null)
                empdata.Close();


            movieCopiesDataGridView.AllowUserToAddRows = false;
            movieActorsDataGridView.AllowUserToAddRows = false;

            populateMovieCopies();
            populateMovieActors();
            populateGenresComboBox();
            populateGenresTextBox();

        }

        private void populateGenresComboBox()
        {
            // Get the movie genres
            String query = $"select type_of_movie from Genre order by type_of_movie";

            SqlDataReader? empdata = connection.GetDataReader(query);

            genresComboBox.Items.Add("Genres");

            while (empdata != null && empdata.Read())
            {
                genresComboBox.Items.Add(empdata["type_of_movie"].ToString());
            }

            // Close the reader after data is read in
            if (empdata != null)
                empdata.Close();
        }

        private void populateGenresTextBox()
        {

            movieGenres.Clear();

            // Get the movie genres
            String query = $"select type_of_movie from Movie_type where movie_id = {whichMovie} order by type_of_movie";

            SqlDataReader? empdata = connection.GetDataReader(query);

            while (empdata != null && empdata.Read())
            {
                movieGenres.Add(empdata["type_of_movie"].ToString());
            }

            genresTextBox.Text = String.Join(", ", movieGenres);

            // Close the reader after data is read in
            if (empdata != null)
                empdata.Close();
        }

        private void populateMovieCopies()
        {
            // Get the movie genres
            String query = $"select MC.copy_id, MC.format, MC.resolution, " +
                $"case when exists(select * from Orders O where O.movie_id = {whichMovie} and O.copy_id = MC.copy_id and end_datetime > GETDATE()) " +
                $"then 'Rented' else 'Available' end as status " +
                $"from Movie_copies MC where MC.movie_id = {whichMovie} order by format";
            SqlDataReader? empdata = connection.GetDataReader(query);

            while (empdata != null && empdata.Read())
            {
                String buttonText = "";

                if (empdata["status"].ToString() == "Available")
                    buttonText = "Rent It";
                else
                    buttonText = "Return";

                movieCopiesDataGridView.Rows.Add(false, empdata["copy_id"].ToString(), empdata["format"].ToString(), empdata["resolution"].ToString(), empdata["status"].ToString(), buttonText);
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

        /* Capture button clicks on movie copies buttons */
        private void movieCopiesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            // Check if a valid non-header button is clicked
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {

                int clickedCopyId = Int32.Parse(movieCopiesDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());

                // Pass movie id of clicked-on row into MovieForm
                TransactionForm f = new TransactionForm(empId, connection, whichMovie, clickedCopyId);

                // Open the window
                f.ShowDialog(); //showing form after creation
            }
        }

        private void addCopyButton_Click(object sender, EventArgs e)
        {
            string message;
            string title;

            // If no format or resolution selected, set invalid message and don't proceed
            if (addCopyComboBox.Text == "Movie Format") {
                message = "Please select a Movie Format";
                title = "Invalid";
                MessageBox.Show(message, title);
                return;
            }

            if (addCopyResComboBox.Text == "Resolution")
            {
                message = "Please select a Resolution";
                title = "Invalid";
                MessageBox.Show(message, title);
                return;
            }

            // All good. Update database
            String mutation = $"insert into Movie_copies(movie_id, format, resolution) values({whichMovie}, '{addCopyComboBox.Text}', '{addCopyResComboBox.Text}')";

            int result = connection.ExecuteMutation(mutation);
            message = $"Result of insert: {result}";
            title = "Outcome";
            MessageBox.Show(message, title);
            movieCopiesDataGridView.Rows.Clear();
            populateMovieCopies();
            
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

        private void toggleFieldsEditable()
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
            genresComboBox.Visible = !readOnlyMode;
            addActorButton.Visible = !readOnlyMode;
            addGenreButton.Visible = !readOnlyMode;
            removeGenreButton.Visible = !readOnlyMode;

            if (readOnlyMode)
                empMovieEditButton.Text = "Edit";
            else
            {
                empMovieEditButton.Text = "Done Editing";
            }
        }


        /* Makes fields editable */
        private void empMovieEditButton_click(object sender, EventArgs e)
        {
            toggleFieldsEditable();
        }


        /* When clicking the add button, adds the genre selected in the combo box to the movie */
        private void addGenreButton_Click(object sender, EventArgs e)
        {
            // If nothing is selected then return
            if (genresComboBox.Text == "Genres" || movieGenres.Contains(genresComboBox.Text))
                return;

            // Add genre to the list
            movieGenres.Add(genresComboBox.Text);

            // Regenerate the string in the textbox
            genresTextBox.Text = String.Join(", ", movieGenres);
            genresComboBox.Text = "";
        }

        /* When clicking the remove button, removes the genre selected in the combo box from the movie */
        private void removeGenreButton_Click(object sender, EventArgs e)
        {
            // If nothing selected then return
            if (genresComboBox.Text == "Genres" || !movieGenres.Contains(genresComboBox.Text))
                return;

            // Remove genre from the list
            movieGenres.Remove(genresComboBox.Text);

            // Regenerate the string in the textbox
            genresTextBox.Text = String.Join(", ", movieGenres);
            genresComboBox.Text = "";
        }

        private void movieCancelButton_Click(object sender, EventArgs e)
        {
            // Ensure, if a new movie was added, that it is deleted
            if (newMovie)
            {
                String message = "Changes will be lost. Click yes to discard changes or no to stay on this page.";
                String title = "Caution";

                DialogResult dialogResult = MessageBox.Show(message, title, MessageBoxButtons.YesNo);

                // Delete changes and leave form
                if (dialogResult == DialogResult.Yes)
                {
                    String mutation = $"delete from Movie where movie_id = {whichMovie}";
                    connection.ExecuteMutation(mutation);
                    this.Close();
                }

                // Stay on page
                else if (dialogResult == DialogResult.No)
                    return;
            }

            this.Close();
        }

        private void movieDoneButton_Click(object sender, EventArgs e)
        {
            // Ensure, if a new movie is being added, that a title is provided
            if (newMovie && titleTextBox.Text == "")
            {
                String message = "No movie title was entered.\nClick yes to discard changes or no to stay on this page.";
                String title = "Caution";

                DialogResult dialogResult = MessageBox.Show(message, title, MessageBoxButtons.YesNo);

                // Delete changes and leave form
                if (dialogResult == DialogResult.Yes)
                {
                    deleteMovie();
                    this.Close();
                }

                // Stay on page
                else if (dialogResult == DialogResult.No)
                    return;

            }
            else
            {
                saveChanges();
            }

            this.Close();
        }

        /* Function does a confirmation message and then deletes the movie from the database */
        private void movieDeleteButton_Click(object sender, EventArgs e)
        {
            
            String message = "Are you sure you want to delete this movie?\nClick yes to proceed or no to stay on this page.";
            String title = "Caution";

            DialogResult dialogResult = MessageBox.Show(message, title, MessageBoxButtons.YesNo);

            // Delete changes and leave form
            if (dialogResult == DialogResult.Yes)
            {
                deleteMovie();
                this.Close();
            }

            // Stay on page
            else if (dialogResult == DialogResult.No)
                return;


            this.Close();
        }

        private void deleteMovie()
        {

            // Remove all genres for this movie
            string mutation = $"delete from Movie_type where movie_id = {whichMovie}";
            connection.ExecuteMutation(mutation);

            // Remove all actors for this movie
            mutation = $"delete from Acts_in where movie_id = {whichMovie}";
            connection.ExecuteMutation(mutation);

            // Delete this movie record
            mutation = $"delete from Movie where movie_id = {whichMovie}";
            connection.ExecuteMutation(mutation);
        }

        private void saveChanges()
        {
            // Save movie details
            Decimal dFee;

            // ensure a digits-only value is present in the distribution fee textbox
            if (distrFeeTextBox.Text != "" && distrFeeTextBox.Text.All(char.IsDigit))
                dFee = Decimal.Parse(distrFeeTextBox.Text);
            else
                dFee = Decimal.Parse("0.00");

            String mutation = $"update Movie set movie_name = '{titleTextBox.Text}', distribution_fee = {dFee} where movie_id = {whichMovie}";
            connection.ExecuteMutation(mutation);

            // Clear all genres listed
            mutation = $"delete from Movie_type where movie_id = {whichMovie}";
            connection.ExecuteMutation(mutation);

            // Add new specified genres
            if (movieGenres.Count > 0) {
                string genresJoined = String.Join("'),("+whichMovie+",'", movieGenres);
                mutation = $"insert into Movie_type(movie_id, type_of_movie) values({whichMovie},'{genresJoined}')";
                connection.ExecuteMutation(mutation);
            }

            string message = $"Movie details saved";
            string title = "notice";
            MessageBox.Show(message, title);

        }


    }
}
