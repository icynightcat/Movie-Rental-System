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
using MoviesApp.SQL;

namespace MoviesApp
{
    public partial class CustomerViewForm : Form
    {
        private DBConnection connection = new DBConnection();
        
        string id;
        public CustomerViewForm(string input)
        {
            InitializeComponent();
            id = input;
            
            string query = $"select * from Customer where account_number = {id}";
            SqlDataReader? custdata = connection.GetDataReader(query); //get data reader must be initalized like line 9

            if (custdata != null && custdata.HasRows) //checks if there is data in the table as well as a table
            {
                custdata.Read();                                     //to see the data you must read() first
                

                // set all data
                accountNumber.Text = custdata["account_number"].ToString();
                planType.Text = custdata["plan_number"].ToString();


                custdata.Close();                //closes the reader after the data is read in
                connection.CloseConnection();//closes the database connection not the DBconnection.cs file
                
            }
                
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click_1(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void movieTitleSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label44_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
