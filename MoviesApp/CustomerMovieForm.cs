using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoviesApp.SQL;
using System.Data.SqlClient;

namespace MoviesApp
{
    public partial class CustomerMovieForm : Form
    {
        protected DBConnection connection;
        public CustomerMovieForm(DataGridViewRow r, DBConnection inputConnection)
        {
            InitializeComponent();
            connection = inputConnection;
            movieName.Text = r.Cells[0].Value.ToString(); // initialize name
            movieGenre.Text = r.Cells[1].Value.ToString(); // intialize genre
        }

        /*private void Format()
        {
            string query3 = $"select t.movie_name, t.formats from" +
            "(select  m.movie_name, STRING_AGG(MC.format, ', ') as 'formats'" +
            "from movie m, Movie_copies MC where m.movie_id = MC.movie_id group by m.movie_name) t";

            SqlDataReader? sData = connection.GetDataReader(query3);

            if (sData != null)
            {
                while (sData.Read())
                {

                }
        }*/

        private void movieName_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void CustomerMovieForm_Load(object sender, EventArgs e)
        {

        }
        private void backButtonCustMovie(object sender, EventArgs e)
        {
            this.Close();
        }
        private void rentButtonCustMovie(object sender, EventArgs e)
        {

        }

        private void movieGenre_Click(object sender, EventArgs e)
        {

        }
    }
}
