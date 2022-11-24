using System.Data.SqlClient;
using MoviesApp.SQL;

namespace MoviesApp
{
    public partial class EmployeeViewForm : Form
    {
        private DBConnection connection = new DBConnection();

        private string ID = ""; //id initalized to use

        public EmployeeViewForm(string input) //takes the id in
        {

            InitializeComponent(); //create the forms

            ID = input; //call this ID to get the current id, needs to be sent to others as well when tranfering

            string query = $"select * from movie";
            SqlDataReader? empdata = connection.GetDataReader(query);

            while (empdata.Read())
            {
                dataGridView2.Rows.Add(empdata["movie_id"].ToString(), empdata["movie_name"].ToString());
            }

            empdata.Close();                //closes the reader after the data is read in
            connection.CloseConnection();//closes the database connection not the DBconnection.cs file
           
        }

        //dataGridView2

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