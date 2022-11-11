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
    public partial class ActorForm : Form
    {
        public ActorForm()
        {
            InitializeComponent();
        }
        private void actorDoneButton_Click(object sender, EventArgs e)
        {
            this.Close();
            //new EmployeeViewForm().Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
