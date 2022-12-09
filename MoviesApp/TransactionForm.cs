using MoviesApp.SQL;
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

namespace MoviesApp
{
    public partial class TransactionForm : Form
    {
        private string empId = ""; //id initalized to use
        private DBConnection connection;
        private int whichMovie;
        private int whichCopy;
        private string orderId;

        // Constructor for initiating new transaction
        public TransactionForm(string empId, DBConnection connection, string orderId)
        {
            this.empId = empId;
            this.connection = connection;
            this.orderId = orderId;
            InitializeComponent();


            string query = $"select o.order_id, o.account_number, o.start_datetime, o.end_datetime, o.copy_id, o.employee_id, m.movie_name, concat(c.first_name, ' ', c.last_name) name from Orders o " +
                $"left Outer JOIN customer c " +
                $"on o.account_number = c.account_number " +
                $"left outer Join Movie m " +
                $"on m.movie_id = o.movie_id " +
                $"where o.order_id = {orderId}";
            
            
            SqlDataReader? txData = connection.GetDataReader(query);
            if (txData != null && txData.HasRows)
            {
                txData.Read();


                txOrderIdTextBox.Text = txData["order_id"].ToString();
                transactionCustomerIDTextBox.Text = txData["account_number"].ToString();
                txStartTextBox.Text =  txData["start_datetime"].ToString();
                txEndTextBox.Text = txData["end_datetime"].ToString();
                txCIDTextBox.Text =  txData["copy_id"].ToString();
                txEmpIdTextBox.Text = txData["employee_id"].ToString();
                txMovieNameTextBox.Text = txData["movie_name"].ToString();
                txCustNameTextbox.Text = txData["name"].ToString();



                txData.Close();
            }
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
            string mutation = $"Update Orders Set employee_id = {empId} where order_id = {orderId}";

            int rows_changed = connection.ExecuteMutation(mutation);

            string message = $"Transaction completed";
            string title = "Notice";
            if (rows_changed == 1)
            {
                MessageBox.Show(message, title);
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }

            this.Close();
        }

    }
}
