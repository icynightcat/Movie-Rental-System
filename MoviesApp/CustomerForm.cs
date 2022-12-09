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
            current_rentals();
            history();
            suggestion();
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
                        empViewCustStartDate.Text = customerData["start_date"].ToString();
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
            string first_name = customerFirstNameTextBox.Text.ToString();
            string last_name = customerLastNameTextBox.Text.ToString();
            string address = empViewCustAddress.Text.ToString();
            string city = empViewCustCity.Text.ToString();
            string state = empViewCustState.Text.ToString();
            string zip_code = empViewCustZip.Text.ToString();
            string telephone = empViewCustPhone.Text.ToString();
            string email = empViewCustEmail.Text.ToString();
            string credit_card = customerCCTextBox.Text.ToString();
            string plan_number = (customerPlanComboBox.SelectedIndex + 1).ToString();
            string customer_rating = empViewCustRating.Text.ToString();

            if (account_number == "")
            { 
                string create_cust_date = DateTime.UtcNow.ToString("yyyy-MM-dd");
                string start_date = DateTime.UtcNow.ToString("yyyy-MM-dd"); ;
                string end_date = DateTime.UtcNow.AddMonths(1).ToString("yyyy-MM-dd"); 

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
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Something went wrong!");
                };
            }
            else
            {
                // update account 
                string create_cust_date = customerCreatedTextBox.Text.ToString();
                string start_date = empViewCustStartDate.Text.ToString();
                string end_date = empViewCustomerEndDate.Text.ToString();
                string account_number = customerIDTextBox.Text.ToString();
                List<String> argList = new List<String>();
                argList.Add(account_number);
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

                if (argList.Contains(""))
                {
                    MessageBox.Show("All fields must be filled for new customer");
                    return;
                }
                if (!int.TryParse(customer_rating, out _))
                {
                    MessageBox.Show("Please enter an integer rating");
                    return;
                }

                string update_mutation = "UPDATE Customer " +
                    "SET " + 
                    $"first_name = '{first_name}', " +
                    $"last_name = '{last_name}', " +
                    $"address = '{address}', " +
                    $"city = '{city}', " +
                    $"state = '{state}', " +
                    $"zip_code = '{zip_code}', " +
                    $"telephone = '{telephone}', " +
                    $"email = '{email}', " +
                    $"create_cust_date = '{create_cust_date}', " +
                    $"start_date = '{start_date}', " +
                    $"end_date = '{end_date}', " +
                    $"customer_rating = {int.Parse(customer_rating)}, " +
                    $"plan_number = {customerPlanComboBox.SelectedIndex + 1}, " +
                    $"credit_card = '{credit_card}'" +
                    $"WHERE account_number = '{account_number}'";

                int rows_updated = connection.ExecuteMutation(update_mutation);
                if (rows_updated == 1)
                {
                    MessageBox.Show($"Successfully updated {first_name} {last_name}");
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Something went wrong! Rows Updated {rows_updated}");
                }
            }
        
            
        }

        private void current_rentals()
        {
            string date = DateTime.Now.ToString("yyyy") + "-" + DateTime.Now.ToString("MM") + "-" + DateTime.Now.ToString("dd"); // today's date

            string query3 = $"select movie_name, start_datetime,end_datetime, format, account_number" +
                $" from Movie M, Movie_copies MC, Orders O" +
                $" where M.movie_id = MC.movie_id and M.movie_id = O.movie_id and Mc.copy_id = O.copy_id and account_number = {account_number} and start_datetime >= '{date}' order by start_datetime desc";

            SqlDataReader? orderData = connection.GetDataReader(query3);
            if (orderData != null && orderData.HasRows)
            {
                customerCurrentRentalsDataGridView.Rows.Clear();
                while (orderData.Read())
                {
                    customerCurrentRentalsDataGridView.Rows.Add(
                        orderData["start_datetime"].ToString(),
                        orderData["end_datetime"].ToString(),
                        orderData["movie_name"].ToString(),
                        orderData["format"].ToString(),
                        ""
                        );
                }
            }
            if (orderData != null)
            {
                orderData.Close();
            }

        }

        private void history()
        {
            string date = DateTime.Now.ToString("yyyy") + "-" + DateTime.Now.ToString("MM") + "-" + DateTime.Now.ToString("dd"); // today's date

            string query2 = $"select movie_name, start_datetime,end_datetime, format, account_number" +
                $" from Movie M, Movie_copies MC, Orders O" +
                $" where M.movie_id = MC.movie_id and M.movie_id = O.movie_id and Mc.copy_id = O.copy_id and account_number = {account_number} and start_datetime < '{date}' order by start_datetime desc";

            SqlDataReader? wishData = connection.GetDataReader(query2);
            if (wishData != null && wishData.HasRows)
            {
                customerHistoryDataGridView.Rows.Clear();
                while (wishData.Read())
                {
                    customerHistoryDataGridView.Rows.Add(
                        wishData["start_datetime"].ToString(),
                        wishData["end_datetime"].ToString(),
                        wishData["movie_name"].ToString(),
                        wishData["format"].ToString(),
                        ""
                        );
                }
            }

            if (wishData != null)
            {
                wishData.Close();
            }
        }

        private void suggestion()
        {
            string query3 = $"select t.movie_name, STRING_AGG(t.type_of_movie, ', ') as 'genres'" +
            $" from(select M.movie_name, Mt2.type_of_movie from Movie_type MT2, Movie M," +
            $" (select Top 3 type_of_movie, count(*) as fav" +
            $" from Movie_type MT, Orders O" +
            $" where MT.movie_id = O.movie_id and O.account_number = {account_number}" +
            $" group by type_of_movie" +
            $" order by fav desc) T1 where MT2.movie_id = M.movie_id and MT2.type_of_movie in (T1.type_of_movie)) t" +
            $" group by t.movie_name";


            SqlDataReader? allData = connection.GetDataReader(query3);
            if (allData != null && allData.HasRows)
            {
                customerSuggestDataGridView.Rows.Clear();
                while (allData.Read())
                {
                    customerSuggestDataGridView.Rows.Add(
                        allData["movie_name"].ToString(),
                        allData["genres"].ToString()
                        );
                }
            }
            if (allData != null)
            {
                allData.Close();
            }

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void customerCreatedTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
