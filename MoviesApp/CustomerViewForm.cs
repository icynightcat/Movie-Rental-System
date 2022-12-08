using Microsoft.VisualBasic.Devices;
using MoviesApp.SQL;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MoviesApp
{
    public partial class CustomerViewForm : Form
    {
        string id;
        protected DBConnection connection;
        public CustomerViewForm(string input, DBConnection input_connection)
        {
            InitializeComponent();
            id = input;
            connection = input_connection;
            populate_customer_data();

            cust_wishlists();
            cust_orders();

            bestSelllers();
            recommendation();

            populate_genre_selecter();

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
        private void customerLogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
            string selectedGenre = movieGenre.Text;
            // get and split actors from input
            // add actors to query
            string query = $"select t.movie_name, t.genres from " +
                $"  (select  m.movie_name, STRING_AGG(t.type_of_movie, ', ') as 'genres' " +
                $"  from movie m, Movie_type t where m.movie_id = t.movie_id and " +
                $"  m.movie_name like '%{title}%' group by m.movie_name) t ";

             if (selectedGenre != "")
                {
                    query += $"where t.genres like '%{selectedGenre}%'";
                }

             // if actors is not empty, change query.
            
            SqlDataReader? searchData = connection.GetDataReader(query);

            if (searchData != null && searchData.HasRows) {
                searchResults.Rows.Clear();
                while (searchData.Read())
                {
                    searchResults.Rows.Add(
                        searchData["movie_name"].ToString(),
                        searchData["genres"].ToString()
                        );
                }
            }
            if(searchData != null)
            {
                searchData.Close();
            }
        }

        private void cust_orders()
        {
            string date = DateTime.Now.ToString("yyyy") + "-" + DateTime.Now.ToString("MM") + "-" + DateTime.Now.ToString("dd"); // today's date
            
            string query1 = $"select movie_name, start_datetime,end_datetime, format, account_number" +
                $" from Movie M, Movie_copies MC, Orders O" +
                $" where M.movie_id = MC.movie_id and M.movie_id = O.movie_id and Mc.copy_id = O.copy_id and account_number = {id} and start_datetime < '{date}' order by start_datetime desc";


            SqlDataReader? orderData = connection.GetDataReader(query1);
            if (orderData != null && orderData.HasRows)
            {
                pastOrderGridView.Rows.Clear();
                while (orderData.Read())
                {
                    pastOrderGridView.Rows.Add(
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

        private void cust_wishlists()
        {

            string date = DateTime.Now.ToString("yyyy") + "-" + DateTime.Now.ToString("MM") + "-" + DateTime.Now.ToString("dd"); // today's date

            string query2 = $"select movie_name, start_datetime,end_datetime, format, account_number" +
                $" from Movie M, Movie_copies MC, Orders O" +
                $" where M.movie_id = MC.movie_id and M.movie_id = O.movie_id and Mc.copy_id = O.copy_id and account_number = {id} and start_datetime >= '{date}' order by start_datetime desc";

            SqlDataReader? wishData = connection.GetDataReader(query2);
            if (wishData != null && wishData.HasRows)
            {
                wishGridView.Rows.Clear();
                while (wishData.Read())
                {
                    wishGridView.Rows.Add(
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

        private void recommendation()
        {
            string query3 = $"select t.movie_name, STRING_AGG(t.type_of_movie, ', ') as 'genres'" +
            $" from(select M.movie_name, Mt2.type_of_movie from Movie_type MT2, Movie M," +
            $" (select Top 3 type_of_movie, count(*) as fav" +
            $" from Movie_type MT, Orders O" +
            $" where MT.movie_id = O.movie_id and O.account_number = {id}" +
            $" group by type_of_movie" +
            $" order by fav desc) T1 where MT2.movie_id = M.movie_id and MT2.type_of_movie in (T1.type_of_movie)) t" +
            $" group by t.movie_name";


            SqlDataReader? allData = connection.GetDataReader(query3);
            if (allData != null && allData.HasRows)
            {
                recommendedGridView.Rows.Clear();
                while (allData.Read())
                {
                    recommendedGridView.Rows.Add(
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

        private void bestSelllers()
        {

            string query5 = $"select al.movie_name, al.genres from" +
            $" (select Top 15 M.movie_name, count(*) as cnt" +
            $" from Orders O, Movie M" +
            $" where M.movie_id = O.movie_id" +
            $" group by movie_name" +
            $" order by cnt desc) pop, (select t.movie_name, t.genres from" +
            $" (select m.movie_name, STRING_AGG(Mt.type_of_movie, ', ') as 'genres'" +
            $" from movie m, Movie_type Mt where m.movie_id = Mt.movie_id" +
            $" group by m.movie_name) t ) al" +
            $" where al.movie_name = pop.movie_name";

            SqlDataReader? bsData = connection.GetDataReader(query5);
            if (bsData != null && bsData.HasRows)
            {
                bestSellerGridView.Rows.Clear();
                while (bsData.Read())
                {

                    bestSellerGridView.Rows.Add(
                        bsData["movie_name"].ToString(),
                        bsData["genres"].ToString());

                }
            }
            if (bsData != null)
            {
                bsData.Close();
            }
        }
        private void searchResults_CellContentClick(object sender, EventArgs e)
        {

            DataGridViewRow r = searchResults.Rows[searchResults.SelectedCells[0].RowIndex]; //clickable row
            CustomerMovieForm f2 = new CustomerMovieForm(r, connection,id); // creating the 2nd form from first
            f2.ShowDialog(); //showing form after creation
            cust_wishlists();
            cust_orders();
            bestSelllers();
            recommendation();
        }

        private void dataGridView3_CellContentClick(object sender, EventArgs e)
        {
            DataGridViewRow r = recommendedGridView.Rows[recommendedGridView.SelectedCells[0].RowIndex]; //clickable row
            CustomerMovieForm f2 = new CustomerMovieForm(r, connection,id); // creating the 2nd form from first
            f2.ShowDialog(); //showing form after creation
            cust_wishlists();
            cust_orders();
            bestSelllers();
            recommendation();
        }

        private void bestSellerGridView_CellContentClick(object sender, EventArgs e)
        {
            DataGridViewRow r = bestSellerGridView.Rows[bestSellerGridView.SelectedCells[0].RowIndex]; //clickable row, if they choose the header, ti automatically picks the first row in the table
            CustomerMovieForm f2 = new CustomerMovieForm(r, connection,id); // creating the 2nd form from first
            f2.ShowDialog(); //showing form after creation
            cust_wishlists();
            cust_orders();
            bestSelllers();
            recommendation();
        }

        private void CustomerViewForm_Load_1(object sender, EventArgs e)
        {
            //This takes care of the last rows not being shown
            recommendedGridView.AllowUserToAddRows = false;
            wishGridView.AllowUserToAddRows = false;
            pastOrderGridView.AllowUserToAddRows = false;
            searchResults.AllowUserToAddRows = false;
            bestSellerGridView.AllowUserToAddRows = false;
        }
        private void CustomerViewForm_Load(object sender, EventArgs e)
        {
            

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

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
