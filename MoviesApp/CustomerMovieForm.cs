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

        private void rentButtonCustMovie(object sender, EventArgs e)
        {
            string format = movieFormat.Text;
            string title = movieName.Text;

            MessageBox.Show(title);

            //WORK IN PROGRESS

            /*if a customer order is avaiable
            select TOP 1 M1.movie_id, M1.movie_name, MT1.copy_id, MT1.format
            from Movie_copies MT1, Movie M1
            where M1.movie_name = 'Graceland' and MT1.format = 'DVD' and
            exists
            (select M2.movie_id, MT.copy_id, M2.movie_name, Mt.format
            from Movie_copies MT, Movie M2
            where M2.movie_id = Mt.movie_id and
            not exists
            (select * from Orders O
            where O.movie_id = MT.movie_id and O.copy_id = MT.copy_id
            ));*/

        }

        private void Format()
        {
            // populating combo box on page
            /*string title = movieName.Text;
            string query3 = $"select t.movie_name, t.formats from" +
            $"(select  m.movie_name, STRING_AGG(MC.format, ', ') as 'formats'" +
            $"from movie m, Movie_copies MC where m.movie_id = MC.movie_id group by m.movie_name) t where t.movie_name = {title}";

            SqlDataReader? sData = connection.GetDataReader(query3);

            if (sData != null)
            {
                while (sData.Read())
                {
                    movieFormat.Items.Add(sData.GetString(0));
                }*/

        }

        private void backButtonCustMovie(object sender, EventArgs e)
        {
            this.Close();
        }

        private void movieName_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void CustomerMovieForm_Load(object sender, EventArgs e)
        {
            
        }
        
        

        private void movieGenre_Click(object sender, EventArgs e)
        {

        }
    }
}
