using MoviesApp.SQL;
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
    public partial class TransactionForm : Form
    {
        private string empId = ""; //id initalized to use
        private DBConnection connection;
        private int whichMovie;
        private int whichCopy;

        // Constructor for initiating new transaction
        public TransactionForm(string empId, DBConnection connection)
        {
            this.empId = empId;
            this.connection = connection;
            InitializeComponent();
        }

        // Constructor for pre-populating movie code into a transaction
        public TransactionForm(string empId, DBConnection connection, int whichMovie, int whichCopy)
        {
            this.empId = empId;
            this.connection = connection;
            this.whichMovie = whichMovie;
            this.whichCopy = whichCopy;
            InitializeComponent();

            transactionMovieCodeTextBox.Text = whichMovie.ToString() + "-" + whichCopy.ToString();

        }

        private void transactionNewSearchButton_Click(object sender, EventArgs e)
        {

        }

        private void transactionNewCancelButton_Click(object sender, EventArgs e)
        {
            string message = $"Transaction cancelled";
            string title = "Notice";
            MessageBox.Show(message, title);

            this.Close();
        }

        private void transactionNewCheckoutButton_Click(object sender, EventArgs e)
        {
            string message = $"Transaction completed";
            string title = "Notice";
            MessageBox.Show(message, title);

            this.Close();
        }

    }
}
