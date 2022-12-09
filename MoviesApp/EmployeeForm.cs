using System;
using System.Collections;
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
        private string employeeId = ""; //id initalized to use

        //allows us to call dbconnections to make sql calls faster
        private DBConnection connection; //must be within the partial class form DOES THIS NEED TO BE CALLED MANY TIMES?? DOES IT STAY OPEN??


        public EmployeeForm(string input, DBConnection input_connection)
        {
            InitializeComponent();
            employeeId = input;
            connection = input_connection;

            if (employeeId != "")
            {
                // populate the form
                string emp_query = $"Select * from Employees where employee_id = {employeeId}";
                SqlDataReader? employeeData = connection.GetDataReader(emp_query);
                if (employeeData != null && employeeData.HasRows)
                {
                    employeeData.Read();
                    employeeIDLabel.Text = employeeData["employee_id"].ToString();
                    employeeFirstNameTextBox.Text = employeeData["first_name"].ToString();
                    employeeLastNameTextBox.Text = employeeData["last_name"].ToString();
                    employeeSocSecTextBox.Text = employeeData["social_insurance_number"].ToString();
                    employeeTelephoneTextBox.Text = employeeData["telephone"].ToString();
                    employeeAddressTextBox.Text = employeeData["address"].ToString();
                    employeeCityTextBox.Text = employeeData["city"].ToString();
                    employeeStateTextBox.Text = employeeData["state"].ToString();
                    employeeZipTextBox.Text = employeeData["zip_code"].ToString();
                    employeeStartDateTextBox.Text = employeeData["start_date"].ToString();
                    employeeHourlyRateTextBox.Text = employeeData["hourly_rate"].ToString();

                }
                else
                {
                    employeeIDLabel.Text = "New Employee";
                }
                employeeData.Close();
            }
        }
        private void employeeDoneButton_Click(object sender, EventArgs e)
        {
            string first_name = employeeFirstNameTextBox.Text;
            string last_name = employeeLastNameTextBox.Text;
            string social_insurance_number = employeeSocSecTextBox.Text;
            string telephone = employeeTelephoneTextBox.Text;
            string address = employeeAddressTextBox.Text;
            string city = employeeCityTextBox.Text;
            string state = employeeStateTextBox.Text;
            string zip_code = employeeZipTextBox.Text;
            string start_date = employeeStartDateTextBox.Text;
            string hourly_rate = employeeHourlyRateTextBox.Text;

            List<String> argList = new List<String>();

            argList.Add(first_name);
            argList.Add(last_name);
            argList.Add(social_insurance_number);
            argList.Add(telephone);
            argList.Add(address);
            argList.Add(city);
            argList.Add(state);
            argList.Add(zip_code);
            argList.Add(start_date);
            argList.Add(hourly_rate);

            if (argList.Contains(""))
            {
                MessageBox.Show("All fields must be filled for new employee");
                return;
            }
            if (!decimal.TryParse(hourly_rate, out _))
            {
                MessageBox.Show("Please enter a valid hourly rate");
                return;
            }
            if (employeeId == "")
            {
                // create new employee

                string insert_mutation = $"INSERT INTO Employees (first_name, last_name, social_insurance_number, telephone, address, city, state, zip_code, start_date, hourly_rate) " +
                    $"VALUES ('{first_name}', '{last_name}', '{social_insurance_number}', '{telephone}', '{address}', '{city}', '{state}', '{zip_code}', '{start_date}', {hourly_rate})";

                if (connection.ExecuteMutation(insert_mutation) == 1)
                {
                    MessageBox.Show($"Successfully added {first_name} {last_name}");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Something went wrong!");
                }

            }
            else
            {
                // update existing employee
                string update_mutation = "UPDATE Employees SET " +
                    $"first_name = '{first_name}', " +
                    $"last_name = '{last_name}', " +
                    $"social_insurance_number = '{social_insurance_number}', " +
                    $"telephone = '{telephone}', " +
                    $"address = '{address}', " +
                    $"city = '{city}', " +
                    $"state = '{state}', " +
                    $"zip_code = '{zip_code}', " +
                    $"start_date = '{start_date}', " +
                    $"hourly_rate = {hourly_rate} " +
                    $"WHERE employee_id = {employeeId}";
                
                int rows = connection.ExecuteMutation(update_mutation);
                
                if (rows == 1)
                {
                    MessageBox.Show($"Successfully added {first_name} {last_name}");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Something went wrong!");
                }
            }
        
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
