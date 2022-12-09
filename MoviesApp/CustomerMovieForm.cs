using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoviesApp.SQL;
using System.Data.SqlClient;
using System.Collections.Immutable;

namespace MoviesApp
{
    public partial class CustomerMovieForm : Form
    {
        string id;
        int allowed;
        int moviesOut;
        int plan_number;
        int movieID;
        int copyID;

        protected DBConnection connection;
        public CustomerMovieForm(DataGridViewRow r, DBConnection inputConnection, string input)
        {
            InitializeComponent();
            connection = inputConnection;
            movieName.Text = r.Cells[0].Value.ToString(); // initialize name
            movieGenre.Text = r.Cells[1].Value.ToString(); // intialize genre
            id =  input; 
            allowed = Customer_info();// have to get plan number and orders from wihlist and compare to check limit

        }
        
        private int Customer_info() 
        {
            string date = DateTime.Now.ToString("yyyy") + "-" + DateTime.Now.ToString("MM") + "-" + DateTime.Now.ToString("dd"); // todays date

            // gets plan number for customer
            string query1 = $"select plan_number from Customer where account_number = {id}";

            SqlDataReader? custdata = connection.GetDataReader(query1); 

            if (custdata != null && custdata.HasRows) 
            {
                custdata.Read();

                string plan_num = custdata["plan_number"].ToString(); 
                plan_number = Convert.ToInt32(plan_num);
                custdata.Close();
            }

            // getting list of movies the customer already has in plan
            string query2 = $"select count (*) as moviesrented from" +
            $" (select movie_name, start_datetime,end_datetime, format, account_number" +
            $" from Movie M, Movie_copies MC, Orders O" +
            $" where M.movie_id = MC.movie_id and M.movie_id = O.movie_id and Mc.copy_id = O.copy_id and account_number = {id}" +
            $" and start_datetime >= '{date}') tab1";

            
            SqlDataReader? wishldata = connection.GetDataReader(query2);

            if (wishldata != null && wishldata.HasRows)
            {

                wishldata.Read();
                string moviesO = wishldata["moviesrented"].ToString();
                moviesOut = Convert.ToInt32(moviesO);
                wishldata.Close();
            }

            //trying to see if limit is reached or not
            if (plan_number == 1)
            {
                if (moviesOut == 1)
                { return 1; } // limit reached
                else 
                { return 0; } // limit not reached
            }
            else if(plan_number == 2)
            {
                if (moviesOut == 1)
                { return 1; } // limit reached
                else 
                { return 0; } // limit not reached
            }
            else if (plan_number == 3)
            {
                if (moviesOut == 2)
                {
                    return 1; // limit reached
                } // true
                else 
                { return 0; } // limit not reached
            }
            else if (plan_number == 4)
            {
                if (moviesOut == 3)
                { return 1; } // limit reached
                else 
                { return 0; } // limit not reached
            }

            return -1;
        }
        
        private void rentButtonCustMovie(object sender, EventArgs e)
        {
            string format = movieFormat.Text;
            string title = movieName.Text;

            DateTime rentalDate = dateToRent.Value;
            DateTime returnDate = dateToReturn.Value;
          
            string rentDate = rentalDate.ToString("yyyy-MM-dd");
            string returnD = returnDate.ToString("yyyy-MM-dd");

            string date = DateTime.Now.ToString("yyyy") + "-" + DateTime.Now.ToString("MM") + "-" + DateTime.Now.ToString("dd"); // getting todays date

            // trying to see if the order is available to rent or not for the customer
            string query = $"select Top 1 table5.movie_id, table5.copy_id from" +
            $" (select table3.movie_id, table3.copy_id, table3.format, table4.movie_name from" +
            $" (select table1.movie_id, table1.copy_id, table2.format from" +
            $" ((select MC.movie_id, MC.copy_id from Movie_copies MC)" +
            $" except" +
            $" (select O.movie_id, O.copy_id from Orders O" +
            $" where O.end_datetime >= '{date}')) table1, Movie_copies table2" +
            $" where table2.movie_id = table1.movie_id and table2.copy_id = table1.copy_id) table3, Movie table4" +
            $" where table3.movie_id = table4.movie_id) table5" +
            $" where table5.movie_name = '{title}' and table5.format = '{format}'";

            SqlDataReader? c_orderData = connection.GetDataReader(query);

            if (c_orderData != null && c_orderData.HasRows) //means order is possible 
            {
                
                c_orderData.Read();
                string movID = c_orderData["movie_id"].ToString();
                movieID = Convert.ToInt32(movID);
                string copID = c_orderData["copy_id"].ToString();
                copyID = Convert.ToInt32(copID);

                c_orderData.Close();

                // check customer's plan to make sure they are not maxed out

                if (allowed == -1)
                {   // customer does not have a plan
                    MessageBox.Show("Plan number invalid");
                }
                else if (allowed == 1)
                {
                    //if they are maxed out
                    MessageBox.Show("Order not possible, max limit reached.");
                }
                else if (allowed == 0) // if limit is not reached then
                {

                    //push order into order table with proper dates

                    string mutation = $"insert into Orders(movie_id, copy_id, order_placed_time, start_datetime, end_datetime," +
                        $" account_number) values({movieID}, {copyID}, '{date}', '{rentDate}', '{returnD}', {id})";

                    int result = connection.ExecuteMutation(mutation);

                    if (result == 0)
                    {
                        MessageBox.Show("Sorry, there is a problem at our end, please try again later");
                    }
                    else
                    {
                        // show message box saying that order has been added successfully
                        MessageBox.Show("Movie successfully rented.");
                    }

                    // close form
                    this.Close();
                }

            }
            else // if order is not possible
            {
                MessageBox.Show("Sorry we do not have that format available at the moment for this time, please choose another date or format");
            }
        }

        private void backButtonCustMovie(object sender, EventArgs e)
        {
            this.Close();
        }

        private void movieName_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void CustomerMovieForm_Load(object sender, EventArgs e)
        {
            
        }
        
        

        private void movieGenre_Click(object sender, EventArgs e)
        {

        }
    }
}
