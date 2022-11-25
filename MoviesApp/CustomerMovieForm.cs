using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviesApp
{
    public partial class CustomerMovieForm : Form
    {
        public CustomerMovieForm(DataGridViewRow r)
        {
            InitializeComponent();
            movieName.Text = r.Cells[0].Value.ToString(); // initialize name
            movieGenre.Text = r.Cells[1].Value.ToString(); // intialize genre
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
        private void backButtonCustMovie(object sender, EventArgs e)
        {
            this.Close();
        }
        private void rentButtonCustMovie(object sender, EventArgs e)
        {

        }
    }
}
