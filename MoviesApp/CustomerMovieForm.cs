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
            allowed = Customer_info();// have to get customer id and plan number

        }
        
        private int Customer_info() // this should be an int
        {
            string date = DateTime.Now.ToString("yyyy") + "-" + DateTime.Now.ToString("MM") + "-" + DateTime.Now.ToString("dd");

            string query1 = $"select plan_number from Customer where account_number = {id}";

            SqlDataReader? custdata = connection.GetDataReader(query1); //get data reader must be initalized like line 9

            if (custdata != null) //checks if there is data in the table as well as a table
            {
                custdata.Read();

                string plan_num = custdata["plan_number"].ToString(); // what is wrong with this? how do i just set plan numebr to a variable
                plan_number = Convert.ToInt32(plan_num);
                custdata.Close();
            }

            

            string query2 = $"select count (*) as moviesrented from" +
            $" (select movie_name, start_datetime,end_datetime, format, account_number" +
            $" from Movie M, Movie_copies MC, Orders O" +
            $" where M.movie_id = MC.movie_id and M.movie_id = O.movie_id and Mc.copy_id = O.copy_id and account_number = {id}" +
            $" and start_datetime >= '{date}') tab1";

            
            SqlDataReader? wishldata = connection.GetDataReader(query2);

            if (wishldata != null)
            {

                wishldata.Read();
                string moviesO = wishldata["moviesrented"].ToString();
                moviesOut = Convert.ToInt32(moviesO);
                wishldata.Close();
            }
           

            
            //MessageBox.Show(p);
            //MessageBox.Show(m);

            if (plan_number == 1)
            {
                if (moviesOut == 1)
                { return 1; } // true
                else 
                { return 0; } // false
            }
            else if(plan_number == 2)
            {
                if (moviesOut == 1)
                { return 1; } // true
                else 
                { return 0; } // false
            }
            else if (plan_number == 3)
            {
                if (moviesOut == 2)
                {
                    return 1;
                } // true
                else 
                { return 0; } // false
            }
            else if (plan_number == 4)
            {
                if (moviesOut == 3)
                { return 1; } // true
                else 
                { return 0; } // false
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

            string date = DateTime.Now.ToString("yyyy") + "-" + DateTime.Now.ToString("MM") + "-" + DateTime.Now.ToString("dd");

            string query = $"select TOP 1 M1.movie_id, M1.movie_name, MT1.copy_id, MT1.format" +
            $" from Movie_copies MT1, Movie M1" +
            $" where M1.movie_name = '{title}' and MT1.format = '{format}' and" +
            $" exists" +
            $" (select M2.movie_id, MT.copy_id, M2.movie_name, Mt.format" +
            $" from Movie_copies MT, Movie M2" +
            $" where M2.movie_id = Mt.movie_id and" +
            $" not exists" +
            $" (select * from Orders O" +
            $" where O.movie_id = MT.movie_id and O.copy_id = MT.copy_id and O.end_datetime >= '{date}'))";

            //textBox23.Text = query;

            SqlDataReader? c_orderData = connection.GetDataReader(query);
            Console.WriteLine(query);

            if (c_orderData != null) //means order is possible 
            {

                // check customer's plan to make sure they are not maxed out
                c_orderData.Read();
                string movID = c_orderData["movie_id"].ToString();
                movieID = Convert.ToInt32(movID);
                string copID = c_orderData["copy_id"].ToString();
                copyID = Convert.ToInt32(copID);

                c_orderData.Close();

                if (allowed == -1)
                {
                    MessageBox.Show("Plan number invalid");
                }
                else if (allowed == 1)
                {
                    //if they are maxed out, then show message box error saying movie limit exceeded, please try again after returning
                    MessageBox.Show("Order not possible, max limit reached.");
                }
                else if (allowed == 0) // if they arent then
                {

                    //push order into order table with start date time

                    string mutation = $"insert into Orders(movie_id, copy_id, order_placed_time, start_datetime, end_datetime," +
                        $" account_number) values({movieID}, {copyID}, '{date}', '{rentDate}', '{returnD}', {id})";

                    textBox23.Text = mutation;

                    int result = connection.ExecuteMutation(mutation);

                    if (result == 0)
                    {
                        MessageBox.Show("Sorry, we do not have that format available at the moment. Please choose another format.");
                    }
                    else
                    {
                        MessageBox.Show("it works");
                    }

                        // show message box saying that order has been added successfully
                        MessageBox.Show("Movie successfully rented.");

                    // close form
                    //this.Close();
                }

                
            }
            else // means order is not possible
            {
                MessageBox.Show("Order not possible, please choose another date");
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
