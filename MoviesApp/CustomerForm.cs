using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoviesApp.SQL;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MoviesApp
{
    public partial class CustomerForm : Form
    {
        private string account_number = "";
        private DBConnection connection;
        public CustomerForm(string input, DBConnection input_connection)
        {
            InitializeComponent();
            connection = input_connection;
            account_number = input;
            
            if (account_number != "")
            {
                {
                    string query = "SELECT * FROM customer WHERE account_number = " + account_number;
                    SqlDataReader? customerData = connection.GetDataReader(query);
                    if(customerData != null && customerData.HasRows)
                    {
                        customerData.Read();
                        customerIDTextBox.Text = customerData["account_number"].ToString();
                        customerCreatedTextBox.Text = customerData["create_cust_date"].ToString();
                        customerFirstNameTextBox.Text = customerData["first_name"].ToString();
                        customerLastNameTextBox.Text = customerData["last_name"].ToString();
                        customerCCTextBox.Text = customerData["credit_card"].ToString();
                        empViewCustomerEndDate.Text = customerData["end_date"].ToString();
                        empViewCustAddress.Text = customerData["address"].ToString();
                        empViewCustCity.Text = customerData["city"].ToString();
                        empViewCustRating.Text = customerData["customer_rating"].ToString();
                        empViewCustZip.Text = customerData["zip_code"].ToString();
                        empViewCustState.Text = customerData["state"].ToString();
                        empViewCustEmail.Text = customerData["email"].ToString();
                        empViewCustPhone.Text = customerData["telephone"].ToString();
                        // im not going to make up a business rule for this
                        customerNextPaymentLabel2.Text = (DateTime.UtcNow.AddMonths(1)).ToString("yyyy-MM-dd");

                        string plan = customerData["plan_number"].ToString();
                        
                        switch(plan)
                        {
                            case "1":
                                customerPlanComboBox.SelectedIndex = 0;
                                break;
                            case "2":
                                customerPlanComboBox.SelectedIndex = 1;
                                break;
                            case "3":
                                customerPlanComboBox.SelectedIndex = 2;
                                break;
                            case "4":
                                customerPlanComboBox.SelectedIndex = 3;
                                break;
                            default:
                                break;
                        }
                    }
                    customerData.Close();
                }
            }
        }
        private void customerDoneButton_Click(object sender, EventArgs e)
        {
            if (account_number == "")
            { 
                string first_name = customerFirstNameTextBox.Text.ToString();
                string last_name = customerLastNameTextBox.Text.ToString();
                string address = empViewCustAddress.Text.ToString();
                string city = empViewCustCity.Text.ToString();
                string state = empViewCustState.Text.ToString();
                string zip_code = empViewCustZip.Text.ToString();
                string telephone = empViewCustPhone.Text.ToString();
                string email = empViewCustEmail.Text.ToString();
                string create_cust_date = DateTime.UtcNow.ToString("yyyy-MM-dd");
                string credit_card = customerCCTextBox.Text.ToString();
                string plan_number = (customerPlanComboBox.SelectedIndex + 1).ToString();
                string start_date = DateTime.UtcNow.ToString("yyyy-MM-dd"); ;
                string end_date = DateTime.UtcNow.AddMonths(1).ToString("yyyy-MM-dd"); ;
                string customer_rating = empViewCustRating.Text.ToString();

                List<String> argList = new List<String>();
                argList.Add(first_name);
                argList.Add(last_name);
                argList.Add(address);
                argList.Add(city);
                argList.Add(state);
                argList.Add(zip_code);
                argList.Add(telephone);
                argList.Add(email);
                argList.Add(create_cust_date);
                argList.Add(start_date);
                argList.Add(end_date);
                argList.Add(customer_rating);
                argList.Add(plan_number);
                argList.Add(credit_card);

                if(argList.Contains(""))
                {
                    MessageBox.Show("All fields must be filled for new customer");
                    return;
                }
                if (!int.TryParse(customer_rating, out _)) {
                    MessageBox.Show("Please enter an integer rating");
                    return;
                }

                // new account
                string mutation = "insert into Customer(first_name, last_name, address, city, state, zip_code, telephone, email, create_cust_date, credit_card, plan_number, start_date, end_date, customer_rating) " +
                    $"values('{first_name}','{last_name}', '{address}', '{city}', '{state}', '{zip_code}', '{telephone}', '{email}', '{create_cust_date}', '{credit_card}', " +
                    $"{customerPlanComboBox.SelectedIndex + 1}, '{start_date}', '{end_date}', {int.Parse(customer_rating)})";


                if (connection.ExecuteMutation(mutation) == 1)
                {
                    MessageBox.Show($"Successfully added {first_name} {last_name}");
                }
                else
                {
                    MessageBox.Show("Something went wrong!");
                };
            }
            else
            {
                // update account 
            }
            this.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void customerNextPaymentLabel2_Click(object sender, EventArgs e)
        {
        }

        private void empViewCustAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void customerNextPaymentLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
