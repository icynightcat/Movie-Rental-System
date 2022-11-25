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
            fromYearTextBox.Visible = false;
            toYearTextBox.Visible = false;
            moviesSearchButton.Visible = false;
        }
        private void showSearchElements()
        {
            movieNameTextBox.Visible = true;
            genreComboBox.Visible = true;
            actorsNamesTextBox.Visible = true;
            fromYearTextBox.Visible = true;
            toYearTextBox.Visible = true;
            moviesSearchButton.Visible = true;
        }

        private void searchAllMovies(Object sender, EventArgs e)
        {
            hideSearchElements();

            string query = $"select * from movie order by movie_name";
            SqlDataReader? empdata = connection.GetDataReader(query);

            while (empdata.Read())
            {
                dataGridView2.Rows.Add(empdata["movie_id"].ToString(), empdata["movie_name"].ToString());
            }

            empdata.Close();                //closes the reader after the data is read in

        }

        private void newSearchFilters(Object sender, EventArgs e)
        {
            showSearchElements();
            dataGridView2.Rows.Clear();
        }
        
        private void searchMoviesWithFilters(Object sender, EventArgs e)
        {
            string query = $"select * from movie where movie_name like '%{movieNameTextBox.Text}%' order by movie_name";
            SqlDataReader? empdata = connection.GetDataReader(query);

            while (empdata.Read())
            {
                dataGridView2.Rows.Add(empdata["movie_id"].ToString(), empdata["movie_name"].ToString());
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
    }
}