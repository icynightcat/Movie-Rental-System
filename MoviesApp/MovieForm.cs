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
    public partial class MovieForm : Form
    {
        public MovieForm()
        {
            InitializeComponent();
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
