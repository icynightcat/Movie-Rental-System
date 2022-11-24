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
using MoviesApp.SQL; //This needs to be referenced to do DBConnection();

namespace MoviesApp
{
    public partial class EmployeeForm : Form
    {
        private string ID = ""; //id initalized to use

        //allows us to call dbconnections to make sql calls faster
        private DBConnection connection = new DBConnection(); //must be within the partial class form DOES THIS NEED TO BE CALLED MANY TIMES?? DOES IT STAY OPEN??


        public EmployeeForm(string input)
        {
            ID = input; //ID from form sent back

            string query = $"select * from Employees where employee_id = {ID}";
            SqlDataReader? empdata = connection.GetDataReader(query);
            empdata.Read(); //read the data back from the tables

            string emp_ID = empdata["employee_id"].ToString();
            employeeFirstNameTextBox.Text = emp_ID;

            empdata.Close();                //closes the reader after the data is read in THIS MUST BE CLOSED EVERYTIME
            connection.CloseConnection();   //close the connection  TODO WHEN YOU MOVE AROUND DOES IT CLOSE?? OR DO WE KEEP OPEN TILL DONE??
            InitializeComponent();
        }
        private void employeeDoneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void employeeCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
