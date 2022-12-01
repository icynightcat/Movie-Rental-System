using System.Data.SqlClient;
using System.DirectoryServices;
using MoviesApp.SQL;

namespace MoviesApp
{
    public partial class EmployeeViewForm : Form
    {
        private string ID = ""; //id initalized to use

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

            string query = $"select M.movie_id, M.movie_name, " +

                $"case when exists (select * from Movie_type T2 where T2.movie_id = M.movie_id) " +
                $"then temp.genres else '' end as genres " +

                $"from Movie M left join (select M2.movie_id, STRING_AGG(T.type_of_movie, ', ') as genres " +
                $"from Movie M2, Movie_type T where M2.movie_id = T.movie_id group by M2.movie_id) temp on temp.movie_id = M.movie_id " +
                $"order by M.movie_name";

            SqlDataReader? empdata = connection.GetDataReader(query);

            while (empdata != null && empdata.Read())
            {
                int movie_id = Int32.Parse(empdata["movie_id"].ToString());
                empMoviesDataGridView.Rows.Add(empdata["movie_id"].ToString(), empdata["movie_name"].ToString(), empdata["genres"].ToString());
            }

            if (empdata != null)
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

            string query = $"select distinct M.movie_id, M.movie_name, " +

                $"case when exists (select * from Movie_type T2 where T2.movie_id = M.movie_id) " +
                $"then temp.genres else '' end as genres, " +

                $"case when exists (select * from Acts_in AI2 where AI2.movie_id = M.movie_id) " +
                $"then temp2.actors else '' end as actors " +

                $"from Movie_type T2, Movie M " +

                $"left join (select M2.movie_id, STRING_AGG(T.type_of_movie, ', ') as genres " +
                $"from Movie M2, Movie_type T where M2.movie_id = T.movie_id group by M2.movie_id) temp on temp.movie_id = M.movie_id " +

                $"left join (select M3.movie_id, STRING_AGG(A2.first_name + ' ' + A2.last_name, ', ') as actors " +
                $"from Movie M3, Acts_in AI, Actors A2 where M3.movie_id = AI.movie_id and A2.actor_id = AI.actor_id " +
                $"group by M3.movie_id) temp2 on temp2.movie_id = M.movie_id " +

                $"where M.movie_name like '%{movieNameTextBox.Text}%' ";

            if (actors.Length > 0)
                query += $"and temp2.actors like '%" + String.Join("%' and temp2.actors like '%", actors) + "%' ";

            query += $"and ('{genreComboBox.Text}' = 'Genre' or genres like '%{genreComboBox.Text}%') " +
                $"order by M.movie_name";

            SqlDataReader? empdata = connection.GetDataReader(query);

            while (empdata != null && empdata.Read())
            {
                int movie_id = Int32.Parse(empdata["movie_id"].ToString()!);
                empMoviesDataGridView.Rows.Add(empdata["movie_id"].ToString(), empdata["movie_name"].ToString(), empdata["genres"].ToString());
            }

            if (empdata != null)
                empdata.Close();                //closes the reader after the data is read in
        }

        private void mostActivelyRented(object sender, EventArgs e)
        {
            hideSearchElements();
            empMoviesDataGridView.Rows.Clear();

            string query = $"select M.movie_id, M.movie_name, " +

                $"case when exists (select * from Movie_type T2 where T2.movie_id = M.movie_id) " +
                $"then temp.genres else '' end as genres, " +

                $"isnull(temp2.count, 0) as count " +

                $"from Movie M left join (select M2.movie_id, STRING_AGG(T.type_of_movie, ', ') as genres from Movie M2, Movie_type T " +
                $"where M2.movie_id = T.movie_id group by M2.movie_id) temp on temp.movie_id = M.movie_id " +

                $"left join (select O.movie_id, count(*) as count from Orders O group by O.movie_id) temp2 on temp2.movie_id = M.movie_id " +

                $"order by temp2.count desc, M.movie_name asc";

            SqlDataReader? empdata = connection.GetDataReader(query);

            while (empdata != null && empdata.Read())
            {
                empMoviesDataGridView.Rows.Add(empdata["movie_id"].ToString(), empdata["movie_name"].ToString(), empdata["genres"].ToString());
            }

            if (empdata != null)
                empdata.Close();

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
            empMoviesDataGridView.AllowUserToAddRows = false;

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

            // Get clicked movie id
            int clickedMovieId = Int32.Parse(empMoviesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            
            // Pass movie id of clicked-on row into MovieForm
            MovieForm f2 = new MovieForm(ID, connection, clickedMovieId, this);

            // Open the window
            f2.ShowDialog(); //showing form after creation

        }
    }
}