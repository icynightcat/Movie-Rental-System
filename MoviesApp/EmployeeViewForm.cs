using System.Data.SqlClient;
using System.DirectoryServices;
using System.Runtime.InteropServices;
using MoviesApp.SQL;

namespace MoviesApp
{
    public partial class EmployeeViewForm : Form
    {
        private string ID = ""; //id initalized to use

        private DBConnection connection;
        public EmployeeViewForm(string input, DBConnection input_connection) //takes the id in
        {
            InitializeComponent(); //create the forms
            connection = input_connection;
            ID = input; //call this ID to get the current id, needs to be sent to others as well when tranfering
        }

        //dataGridView2
        private void hideSearchElements()
        {
            movieNameTextBox.Visible = false;
            genreComboBox.Visible = false;
            actorsNamesTextBox.Visible = false;
            moviesSearchClearButton.Visible = false;
            moviesSearchButton.Visible = false;
        }
        private void showSearchElements()
        {
            movieNameTextBox.Visible = true;
            genreComboBox.Visible = true;
            actorsNamesTextBox.Visible = true;
            moviesSearchClearButton.Visible = true;
            moviesSearchButton.Visible = true;
        }

        private void searchAllMovies(Object sender, EventArgs e)
        {
            hideSearchElements();
            empMoviesDataGridView.Rows.Clear();

            string query = $"select M.movie_id, M.movie_name, " +

                $"case when exists (select * from Movie_type T2 where T2.movie_id = M.movie_id) " +
                $"then temp.genres else '' end as genres " +

                $"from Movie M left join (select M2.movie_id, STRING_AGG(T.type_of_movie, ', ') as genres " +
                $"from Movie M2, Movie_type T where M2.movie_id = T.movie_id group by M2.movie_id) temp on temp.movie_id = M.movie_id " +
                $"order by M.movie_name";

            SqlDataReader? empdata = connection.GetDataReader(query);

            while (empdata != null && empdata.Read())
            {
                int movie_id = Int32.Parse(empdata["movie_id"].ToString());
                empMoviesDataGridView.Rows.Add(empdata["movie_id"].ToString(), empdata["movie_name"].ToString(), empdata["genres"].ToString());
            }

            if (empdata != null)
                empdata.Close();                //closes the reader after the data is read in

        }

        private void clearMoviesSearchForm(Object sender, EventArgs e)
        {
            movieNameTextBox.Clear();
            actorsNamesTextBox.Clear();
            genreComboBox.Text = "Genre";
        }

        private void newSearchFilters(Object sender, EventArgs e)
        {
            showSearchElements();
            empMoviesDataGridView.Rows.Clear();
        }
        
        private void searchActors(Object sender, EventArgs e)
        {
            empActorsDataGridView.Rows.Clear();

            string[] actorsSearchParams = empActorSearchTextBox.Text.Split(' ');

            string query = $"select distinct actor_id, first_name, last_name, gender, age " +
                $"from Actors ";


            if (actorsSearchParams.Count() > 0) {

                query += "where ";

                for (int i = 0; i < actorsSearchParams.Count(); i++) {
                    query += $"(first_name like '%{actorsSearchParams[i]}%' or last_name like '%{actorsSearchParams[i]}%') ";

                    if (i < actorsSearchParams.Count() - 1)
                        query += "and ";
                }
            }

            query += "order by first_name";

            SqlDataReader? empdata = connection.GetDataReader(query);

            while (empdata != null && empdata.Read())
            {
                int actor_id = Int32.Parse(empdata["actor_id"].ToString()!);
                empActorsDataGridView.Rows.Add(empdata["actor_id"].ToString(), empdata["first_name"].ToString(), empdata["last_name"].ToString(), empdata["gender"].ToString(), empdata["age"].ToString());
            }

            if (empdata != null)
                empdata.Close();                //closes the reader after the data is read in
        }

        private void searchMoviesWithFilters(Object sender, EventArgs e)
        {
            empMoviesDataGridView.Rows.Clear();

            // If actors are specified in the search bar then get a comma-separated list
            string[] actors = actorsNamesTextBox.Text.Split(',');

            string query = $"select distinct M.movie_id, M.movie_name, " +

                $"case when exists (select * from Movie_type T2 where T2.movie_id = M.movie_id) " +
                $"then temp.genres else '' end as genres, " +

                $"case when exists (select * from Acts_in AI2 where AI2.movie_id = M.movie_id) " +
                $"then temp2.actors else '' end as actors " +

                $"from Movie_type T2, Movie M " +

                $"left join (select M2.movie_id, STRING_AGG(T.type_of_movie, ', ') as genres " +
                $"from Movie M2, Movie_type T where M2.movie_id = T.movie_id group by M2.movie_id) temp on temp.movie_id = M.movie_id " +

                $"left join (select M3.movie_id, STRING_AGG(A2.first_name + ' ' + A2.last_name, ', ') as actors " +
                $"from Movie M3, Acts_in AI, Actors A2 where M3.movie_id = AI.movie_id and A2.actor_id = AI.actor_id " +
                $"group by M3.movie_id) temp2 on temp2.movie_id = M.movie_id " +

                $"where M.movie_name like '%{movieNameTextBox.Text}%' ";

            if (actors.Length > 0)
                query += $"and temp2.actors like '%" + String.Join("%' and temp2.actors like '%", actors) + "%' ";

            query += $"and ('{genreComboBox.Text}' = 'Genre' or genres like '%{genreComboBox.Text}%') " +
                $"order by M.movie_name";

            SqlDataReader? empdata = connection.GetDataReader(query);

            while (empdata != null && empdata.Read())
            {
                int movie_id = Int32.Parse(empdata["movie_id"].ToString()!);
                empMoviesDataGridView.Rows.Add(empdata["movie_id"].ToString(), empdata["movie_name"].ToString(), empdata["genres"].ToString());
            }

            if (empdata != null)
                empdata.Close();                //closes the reader after the data is read in
        }

        private void mostActivelyRented(object sender, EventArgs e)
        {
            hideSearchElements();
            empMoviesDataGridView.Rows.Clear();

            string query = $"select M.movie_id, M.movie_name, " +

                $"case when exists (select * from Movie_type T2 where T2.movie_id = M.movie_id) " +
                $"then temp.genres else '' end as genres, " +

                $"isnull(temp2.count, 0) as count " +

                $"from Movie M left join (select M2.movie_id, STRING_AGG(T.type_of_movie, ', ') as genres from Movie M2, Movie_type T " +
                $"where M2.movie_id = T.movie_id group by M2.movie_id) temp on temp.movie_id = M.movie_id " +

                $"left join (select O.movie_id, count(*) as count from Orders O group by O.movie_id) temp2 on temp2.movie_id = M.movie_id " +

                $"order by temp2.count desc, M.movie_name asc";

            SqlDataReader? empdata = connection.GetDataReader(query);

            while (empdata != null && empdata.Read())
            {
                empMoviesDataGridView.Rows.Add(empdata["movie_id"].ToString(), empdata["movie_name"].ToString(), empdata["genres"].ToString());
            }

            if (empdata != null)
                empdata.Close();

        }
        private void empLogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
            private void launchMovieButton_Click(object sender, EventArgs e)
        {
            new MovieForm(ID, connection, -1).ShowDialog();
        }
        private void actorsAddButton_Click(object sender, EventArgs e)
        {
            new ActorForm(ID, connection, -1).ShowDialog();

        }
        private void launchCustomerButton_Click(object sender, EventArgs e)
        {
            new CustomerForm().ShowDialog();

        }
        private void launchEmployeeButton_Click(object sender, EventArgs e)
        {
            new EmployeeForm(ID).ShowDialog();

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0: this.AcceptButton = moviesSearchButton;break;
                case 1: this.AcceptButton = actorsSearchButton;break;
                case 2: this.AcceptButton = searchCustomersButton;break;
                case 3: this.AcceptButton = searchEmployeesButton;break;
                case 4: this.AcceptButton = transactionsSearchButton; break;
                case 5: this.AcceptButton = reportsGenerateButton;break;
                default: this.AcceptButton = moviesSearchButton;break;
            }
        }

        private void EmployeeViewForm_Load(object sender, EventArgs e)
        {
            empMoviesDataGridView.AllowUserToAddRows = false;
            empActorsDataGridView.AllowUserToAddRows = false;

            // Set default search button on page load
            tabControl1.TabIndex = 0;
            this.AcceptButton = moviesSearchButton;

            // Populate combo box on movies page
            string query = $"select * from Genre order by type_of_movie";
            SqlDataReader? empdata = connection.GetDataReader(query);

            while (empdata.Read())
            {
                genreComboBox.Items.Add(empdata["type_of_movie"].ToString());
            }

            // Close the reader after data is read in
            empdata.Close();
        }

        private void empMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            // Get clicked movie id
            int clickedMovieId = Int32.Parse(empMoviesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            
            // Pass movie id of clicked-on row into MovieForm
            MovieForm f2 = new MovieForm(ID, connection, clickedMovieId);

            // Open the window
            f2.ShowDialog(); //showing form after creation

        }

        private void empActors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex < 0)
                return;

            // Get clicked movie id
            int clickedActorId = Int32.Parse(empActorsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());

            // Pass movie id of clicked-on row into MovieForm
            ActorForm f2 = new ActorForm(ID, connection, clickedActorId);

            // Open the window
            f2.ShowDialog(); //showing form after creation

        }





        /************** Transactions Page ********************/

        private void empNewTransactionButton_Click(object sender, EventArgs e)
        {
            // Pass movie id of clicked-on row into MovieForm
            TransactionForm f = new TransactionForm(ID, connection);

            // Open the window
            f.ShowDialog(); //showing form after creation
        }

        
        /******************* reports **************************/
        public int RBCN = 1; //report button click number, picks the report to generate when a report button is chosen
        public string Month_picked = "NONE"; //basic starting month chosen, full names
        public int Year_picked = 2022; //starting year
        public string Quarter_picked = "NONE"; //quarter picked, First Quarter, Second Quarter, Third Quarter, Forth Quarter

        //when clicking a button, on of the grid views will display
        private void report2Button_Click_1(object sender, EventArgs e)
        {
            reportsDataGridView.Visible = false;
            dataGridView2.Visible = true;
            dataGridView3.Visible = false;
            dataGridView6.Visible = false;
            dataGridView5.Visible = false;
            reportsDescriptionTextBox.Text = "Report 2: Best Movie Genre";
            dataGridView2.BringToFront();
            RBCN = 2;
        }
        private void report3Button_Click_1(object sender, EventArgs e)
        {
            reportsDataGridView.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = true;
            dataGridView6.Visible = false;
            dataGridView5.Visible = false;
            reportsDescriptionTextBox.Text = "Report 3: top 5 movies per genre";
            dataGridView3.BringToFront();
            RBCN = 3;
        }
        private void report4Button_Click_1(object sender, EventArgs e)
        {
            reportsDataGridView.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView6.Visible = true;
            dataGridView5.Visible = false;
            reportsDescriptionTextBox.Text = "Report 4: profit earnings";
            dataGridView6.BringToFront();
            RBCN = 4;
        }
        private void report5Button_Click_1(object sender, EventArgs e)
        {
            reportsDataGridView.Visible = false;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView6.Visible = false;
            dataGridView5.Visible = true;
            reportsDescriptionTextBox.Text = "Report 5: people to recomend to upgrade based on usage";
            dataGridView5.BringToFront();
            RBCN = 5;
        }

        private void report1Button_Click1(object sender, EventArgs e)
        {
            reportsDataGridView.Visible = true;
            dataGridView2.Visible = false;
            dataGridView3.Visible = false;
            dataGridView6.Visible = false;
            dataGridView5.Visible = false;
            reportsDescriptionTextBox.Text = "Report 1: profit per month";
            reportsDataGridView.BringToFront();
            RBCN = 1;
        }

        private void QuarterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MonthComboBox.Text = "Month";
            Month_picked = "NONE";
            MonthComboBox.Refresh();
            Quarter_picked = QuarterComboBox.Text;
            
        }

        private void MonthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            QuarterComboBox.Text = "Quarter";
            Quarter_picked = "NONE";
            QuarterComboBox.Refresh();
            Month_picked = MonthComboBox.Text;
        }

        private void reportsGenerateButton_Click(object sender, EventArgs e)
        {
            //needs to know all the info from each value to call functions and send over info

        }

        private void YearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Year_picked = Int32.Parse(YearComboBox.Text);
            YearComboBox.Text = Year_picked.ToString();
        }
    }
}