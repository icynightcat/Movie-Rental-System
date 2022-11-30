using System.Data.SqlClient;
using System.DirectoryServices;
using MoviesApp.SQL;

namespace MoviesApp
{
    public partial class EmployeeViewForm : Form
    {
        private string ID = ""; //id initalized to use

        // Used on Movies tab to keep track of search results
        private List<int> movieResultsList = new List<int>();

        private DBConnection connection;
        public EmployeeViewForm(string input, DBConnection input_connection) //takes the id in
        {
            InitializeComponent(); //create the forms
            connection = input_connection;
            ID = input; //call this ID to get the current id, needs to be sent to others as well when tranfering
        }

        //dataGridView2
        private void hideSearchElements()
        {
            movieNameTextBox.Visible = false;
            genreComboBox.Visible = false;
            actorsNamesTextBox.Visible = false;
            moviesSearchClearButton.Visible = false;
            moviesSearchButton.Visible = false;
        }
        private void showSearchElements()
        {
            movieNameTextBox.Visible = true;
            genreComboBox.Visible = true;
            actorsNamesTextBox.Visible = true;
            moviesSearchClearButton.Visible = true;
            moviesSearchButton.Visible = true;
        }

        private void searchAllMovies(Object sender, EventArgs e)
        {
            hideSearchElements();
            empMoviesDataGridView.Rows.Clear();

            string query = $"select temp.movie_id, temp.movie_name, temp.genres from " +
                $"(select M.movie_id, M.movie_name, STRING_AGG(T.type_of_movie, ', ') as 'genres' " +
                $"from Movie M, Movie_type T where M.movie_id = T.movie_id group by M.movie_name, M.movie_id) temp " +
                $"order by temp.movie_name";

            SqlDataReader? empdata = connection.GetDataReader(query);

            // Empty the movieResultsList
            movieResultsList.Clear();

            while (empdata.Read())
            {
                int movie_id = Int32.Parse(empdata["movie_id"].ToString());
                movieResultsList.Add(movie_id);
                empMoviesDataGridView.Rows.Add(empdata["movie_id"].ToString(), empdata["movie_name"].ToString(), empdata["genres"].ToString());
            }

            empdata.Close();                //closes the reader after the data is read in

        }

        private void clearMoviesSearchForm(Object sender, EventArgs e)
        {
            movieNameTextBox.Clear();
            actorsNamesTextBox.Clear();
            genreComboBox.Text = "Genre";
        }

        private void newSearchFilters(Object sender, EventArgs e)
        {
            showSearchElements();
            empMoviesDataGridView.Rows.Clear();
        }
        
        private void searchMoviesWithFilters(Object sender, EventArgs e)
        {
            empMoviesDataGridView.Rows.Clear();

            // If actors are specified in the search bar then get a comma-separated list
            string[] actors = actorsNamesTextBox.Text.Split(',');

            string query = $"select temp.movie_id, temp.movie_name, STRING_AGG(temp.type_of_movie, ', ') as 'genres' from " +
                $"(select M.movie_id, M.movie_name, T.type_of_movie, " +
                $"STRING_AGG(A.first_name + ' ' + A.last_name, ', ') as 'actors' " +
                $"from Movie M, Movie_type T, Acts_in AI, Actors A where " +
                $"AI.movie_id = M.movie_id and A.actor_id = AI.actor_id " +
                $"and movie_name like '%{movieNameTextBox.Text}%' and M.movie_id = T.movie_id " +
                $"group by M.movie_name, M.movie_id, T.type_of_movie) temp ";

            if (actors.Length > 0)
                query += $"where temp.actors like '%" + String.Join("%' and temp.actors like '%", actors) + "%' ";

            query += $"group by temp.movie_id, temp.movie_name " +
                $"having ('{genreComboBox.Text}' = 'Genre' or STRING_AGG(temp.type_of_movie, ', ') like '%{genreComboBox.Text}%') " +
                $"order by temp.movie_name";

            SqlDataReader? empdata = connection.GetDataReader(query);

            // Empty the movieResultsList
            movieResultsList.Clear();

            while (empdata != null && empdata.Read())
            {
                int movie_id = Int32.Parse(empdata["movie_id"].ToString()!);
                movieResultsList.Add(movie_id);
                empMoviesDataGridView.Rows.Add(empdata["movie_id"].ToString(), empdata["movie_name"].ToString(), empdata["genres"].ToString());
            }

            empdata.Close();                //closes the reader after the data is read in
        }

        private void mostActivelyRented(object sender, EventArgs e)
        {
            hideSearchElements();
            empMoviesDataGridView.Rows.Clear();
        }
        private void empLogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
            private void launchMovieButton_Click(object sender, EventArgs e)
        {
            new MovieForm(ID, connection, -1, this).ShowDialog();
        }
        private void launchActorButton_Click(object sender, EventArgs e)
        {
            new ActorForm().ShowDialog();

        }
        private void launchCustomerButton_Click(object sender, EventArgs e)
        {
            new CustomerForm().ShowDialog();

        }
        private void launchEmployeeButton_Click(object sender, EventArgs e)
        {
            new EmployeeForm(ID).ShowDialog();

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0: this.AcceptButton = moviesSearchButton;break;
                case 1: this.AcceptButton = actorsSearchButton;break;
                case 2: this.AcceptButton = searchCustomersButton;break;
                case 3: this.AcceptButton = searchEmployeesButton;break;
                case 4: this.AcceptButton = transactionsNewSearchButton;break;
                case 5: this.AcceptButton = reportsGenerateButton;break;
                default: this.AcceptButton = moviesSearchButton;break;
            }
        }

        public void changeTabs(int whichTab)
        {
            tabControl1.SelectedIndex = whichTab;
        }

        private void EmployeeViewForm_Load(object sender, EventArgs e)
        {
            // Set default search button on page load
            tabControl1.TabIndex = 0;
            this.AcceptButton = moviesSearchButton;

            // Populate combo box on movies page
            string query = $"select * from Genre order by type_of_movie";
            SqlDataReader? empdata = connection.GetDataReader(query);

            while (empdata.Read())
            {
                genreComboBox.Items.Add(empdata["type_of_movie"].ToString());
            }

            // Close the reader after data is read in
            empdata.Close();
        }

        private void empMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            // Get clicked row number
            int r = empMoviesDataGridView.SelectedCells[0].RowIndex; //clickable row
            //MessageBox.Show(r.ToString() +" " + movieResultsList[r]);
            // Pass movie id of clicked-on row into MovieForm
            MovieForm f2 = new MovieForm(ID, connection, movieResultsList[r], this);

            // Open the window
            f2.ShowDialog(); //showing form after creation
        }
    }
}