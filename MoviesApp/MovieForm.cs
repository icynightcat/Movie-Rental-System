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

namespace MoviesApp
{
    public partial class MovieForm : Form
    {
        private string empId = ""; //id initalized to use
        private DBConnection connection;
        private int whichMovie;
        private List<string> movieGenres = new List<string>();
        private List<int> movieActors = new List<int>();

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

            while (empdata != null && empdata.Read())
            {
                movieAboutLabel.Text = empdata["movie_id"].ToString();
                titleTextBox.Text = empdata["movie_name"].ToString();
                distrFeeTextBox.Text = empdata["distribution_fee"].ToString();
            }

            // Close the reader after data is read in
            if (empdata != null)
                empdata.Close();

            // Get the movie genres
            query = $"select type_of_movie from Movie_types " +
                $"where movie_id = {whichMovie}";
            empdata = connection.GetDataReader(query);

            while (empdata != null && empdata.Read())
            {
                movieGenres.Add(empdata["type_of_movie"].ToString()!);
            }

            // Close the reader after data is read in
            if (empdata != null)
                empdata.Close();

            // Get the movie actors
            query = $"select * from Actors A, Acts_in AI where AI.movie_id = {whichMovie} " +
                $" and AI.actor_id = A.actor_id order by A.first_name";

            empdata = connection.GetDataReader(query);

            while (empdata != null && empdata.Read())
            {
                movieActorsDataGridView.Rows.Add(empdata["actor_id"].ToString(), empdata["first_name"].ToString(), empdata["last_name"].ToString(), empdata["gender"].ToString(), empdata["age"].ToString());
            }

            // Close the reader after data is read in
            if (empdata != null)
                empdata.Close();


        }

        private void movieDoneButton_Click(object sender, EventArgs e)
        {
            //verifiy if it is not a real movie already then do it and close or dont close and do a popup that says no
            string title = titleTextBox.Text; //all that is needed to get the info once someone clicks it

            this.Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
