using System.Data.SqlClient;
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
            dataGridView2.Rows.Clear();

            string query = $"select temp.movie_id, temp.movie_name, temp.genres from " +
                $"(select M.movie_id, M.movie_name, STRING_AGG(T.type_of_movie, ', ') as 'genres' " +
                $"from Movie M, Movie_type T where M.movie_id = T.movie_id group by M.movie_name, M.movie_id) temp " +
                $"order by temp.movie_name";

            SqlDataReader? empdata = connection.GetDataReader(query);

            while (empdata.Read())
            {
                dataGridView2.Rows.Add(empdata["movie_id"].ToString(), empdata["movie_name"].ToString(), empdata["genres"].ToString());
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
            dataGridView2.Rows.Clear();
        }
        
        private void searchMoviesWithFilters(Object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();

            // If actors are specified in the search bar then get a comma-separated list
            string[] actors = actorsNamesTextBox.Text.Split(',');

            string query = $"select distinct temp.movie_id, temp.movie_name, temp.genres from " +
                $"(select distinct M.movie_id, M.movie_name, STRING_AGG(T.type_of_movie, ', ') as 'genres', " +
                $"STRING_AGG(A.first_name + ' ' + A.last_name, ', ') as 'actors' " +
                $"from Movie M, Movie_type T, Acts_in AI, Actors A where " +
                $"AI.movie_id = M.movie_id and A.actor_id = AI.actor_id " +
                $"and movie_name like '%{movieNameTextBox.Text}%' and M.movie_id = T.movie_id " +
                $"group by M.movie_name, M.movie_id) temp ";

            query += $"where ('{genreComboBox.Text}' = 'Genre' or temp.genres like '%{genreComboBox.Text}%') ";

            if (actors.Length > 0)
                query += $"and temp.actors like '%" + String.Join("%' and temp.actors like '%", actors) + "%' ";


            query += $"order by temp.movie_name";

            SqlDataReader? empdata = connection.GetDataReader(query);

            while (empdata.Read())
            {
                dataGridView2.Rows.Add(empdata["movie_id"].ToString(), empdata["movie_name"].ToString(), empdata["genres"].ToString());
            }

            empdata.Close();                //closes the reader after the data is read in
        }

        private void mostActivelyRented(object sender, EventArgs e)
        {
            hideSearchElements();
            dataGridView2.Rows.Clear();
        }

        private void launchMovieButton_Click(object sender, EventArgs e)
        {
            new MovieForm().ShowDialog();
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

        private void EmployeeViewForm_Load(object sender, EventArgs e)
        {
            tabControl1.TabIndex = 0;
            this.AcceptButton = moviesSearchButton;
        }
    }
}