﻿using MoviesApp.SQL;
using System.Data.SqlClient;

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

            populate_customer_data();

            populate_genre_selecter();
            connection.CloseConnection();//closes the database connection not the DBconnection.cs file

        }

        private void populate_customer_data()
        {
            string query = $"select * from Customer where account_number = {id}";
            SqlDataReader? custdata = connection.GetDataReader(query); //get data reader must be initalized like line 9

            if (custdata != null && custdata.HasRows) //checks if there is data in the table as well as a table
            {
                custdata.Read();                                     //to see the data you must read() first


                // set all data
                accountNumber.Text = custdata["account_number"].ToString();
                planType.Text = custdata["plan_number"].ToString();
                custFirstName.Text = custdata["first_name"].ToString();
                custLastName.Text = custdata["last_name"].ToString();
                custAddress.Text = custdata["address"].ToString();
                custCity.Text = custdata["city"].ToString();
                custZipCode.Text = custdata["zip_code"].ToString();
                custPhoneNumber.Text = custdata["telephone"].ToString();
                custState.Text = custdata["state"].ToString();
                custCreditCardNumber.Text = custdata["credit_card"].ToString();
                custExpiryDate.Text = custdata["end_date"].ToString();

                custdata.Close();                //closes the reader after the data is read in

            }
        }
        private void toggle_cust_edit(object sender, EventArgs e)
        {
            custFirstName.ReadOnly = !custFirstName.ReadOnly; 
            custLastName.ReadOnly = !custLastName.ReadOnly;
            custAddress.ReadOnly = !custAddress.ReadOnly;
            custCity.ReadOnly = !custCity.ReadOnly;
            custZipCode.ReadOnly = !custZipCode.ReadOnly;
            custPhoneNumber.ReadOnly = !custPhoneNumber.ReadOnly;
            custState.ReadOnly = !custState.ReadOnly;
            custCreditCardNumber.ReadOnly = !custCreditCardNumber.ReadOnly;
            custExpiryDate.ReadOnly = !custExpiryDate.ReadOnly;
        }

        private void lock_cust_edit(object sender, EventArgs e)
        {
            custFirstName.ReadOnly = false;
            custLastName.ReadOnly = false;
            custAddress.ReadOnly = false;
            custCity.ReadOnly = false;     
            custZipCode.ReadOnly = false;
            custPhoneNumber.ReadOnly = false;
            custState.ReadOnly = false;
            custCreditCardNumber.ReadOnly = false;
            custExpiryDate.ReadOnly = false;
        }

        private void save_cust_edit(object sender, EventArgs e)
        {
            string query = $"update Customer set first_name = '{custFirstName.Text}', " +
                $"last_name = '{custLastName.Text}', " +
                $"address = '{custAddress.Text}', " +
                $"city = '{custCity.Text}', " +
                $"zip_code = '{custZipCode.Text}', " +
                $"telephone = '{custPhoneNumber.Text}', " +
                $"state = '{custState.Text}', " +
                $"credit_card = '{custCreditCardNumber.Text}', " +
                $"end_date = '{custExpiryDate.Text}' " +
                $"where account_number = {id}";
            
            connection.ExecuteMutation(query);

            lock_cust_edit(sender, e);
            MessageBox.Show("Customer Information Updated");
        }

        private void populate_genre_selecter()
        {
            string query = "Select * from Genre";
            SqlDataReader? genreData = connection.GetDataReader(query);

            if (genreData != null && genreData.HasRows)
            {
                while (genreData.Read())
                {
                    movieGenre.Items.Add(genreData["type_of_movie"].ToString());
                }

                genreData.Close();
            }
            
        }

        private void cust_movie_search(object sender, EventArgs e)
        {
            string title = movieTitleSearch.Text;
            string query = $"select * from Movie m, Movie_copies c" +
                $" where m.movie_id = c.movie_id and m.movie_name like '%{title}%' order by m.movie_name";
            
            SqlDataReader? searchData = connection.GetDataReader(query);

            if (searchData != null && searchData.HasRows) {
                searchResults.Rows.Clear();
                while (searchData.Read())
                {
                    searchResults.Rows.Add(
                        searchData["movie_name"].ToString(), 
                        "tempType", 
                        "tempAvailable",
                        searchData["format"].ToString());

                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void custLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void custAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void custCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void custZipCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void custState_TextChanged(object sender, EventArgs e)
        {

        }

        private void custPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void custFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void custCreditCardNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void custExpiryDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
