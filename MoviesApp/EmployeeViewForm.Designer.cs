﻿namespace MoviesApp
{
    partial class EmployeeViewForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.moviesTabPage = new System.Windows.Forms.TabPage();
            this.moviesSearchClearButton = new System.Windows.Forms.Button();
            this.empMoviesDataGridView = new System.Windows.Forms.DataGridView();
            this.Movie_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Movie_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_of_movie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moviesAddMovieButton = new System.Windows.Forms.Button();
            this.moviesSearchButton = new System.Windows.Forms.Button();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.actorsNamesTextBox = new MoviesApp.ExTextBox();
            this.movieNameTextBox = new MoviesApp.ExTextBox();
            this.mostRentedRadioButton = new System.Windows.Forms.RadioButton();
            this.searchFiltersRadioButton = new System.Windows.Forms.RadioButton();
            this.allMoviesRadioButton = new System.Windows.Forms.RadioButton();
            this.actorsTabPage = new System.Windows.Forms.TabPage();
            this.empActorsDataGridView = new System.Windows.Forms.DataGridView();
            this.actorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actorFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actorLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actorGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actorAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actorsAddButton = new System.Windows.Forms.Button();
            this.actorsSearchButton = new System.Windows.Forms.Button();
            this.empActorSearchTextBox = new MoviesApp.ExTextBox();
            this.customersTabPage = new System.Windows.Forms.TabPage();
            this.customersTabControl = new System.Windows.Forms.TabControl();
            this.searchCustomersTabPage = new System.Windows.Forms.TabPage();
            this.launchCustomerButton = new System.Windows.Forms.Button();
            this.searchCustomersButton = new System.Windows.Forms.Button();
            this.searchCustomersTextBox = new MoviesApp.ExTextBox();
            this.empCustomerGridView = new System.Windows.Forms.DataGridView();
            this.account_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zip_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.create_cust_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credit_card = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailingListTabPage = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.mailingListLabel = new System.Windows.Forms.Label();
            this.employeesTabPage = new System.Windows.Forms.TabPage();
            this.empEmployeesDataGridView = new System.Windows.Forms.DataGridView();
            this.empId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_zip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button4 = new System.Windows.Forms.Button();
            this.searchEmployeesButton = new System.Windows.Forms.Button();
            this.searchEmpTextBox = new MoviesApp.ExTextBox();
            this.transactionsTabPage = new System.Windows.Forms.TabPage();
            this.txGridView = new System.Windows.Forms.DataGridView();
            this.order_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tx_account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start_datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tx_copyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tx_employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tx_moveName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tx_cust_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.transactionsSearchButton = new System.Windows.Forms.Button();
            this.exTextBox4 = new MoviesApp.ExTextBox();
            this.reportsTabPage = new System.Windows.Forms.TabPage();
            this.MonthComboBox = new System.Windows.Forms.ComboBox();
            this.QuarterComboBox = new System.Windows.Forms.ComboBox();
            this.YearComboBox = new System.Windows.Forms.ComboBox();
            this.reportsGenerateButton = new System.Windows.Forms.Button();
            this.report5Button = new System.Windows.Forms.Button();
            this.report4Button = new System.Windows.Forms.Button();
            this.report3Button = new System.Windows.Forms.Button();
            this.report2Button = new System.Windows.Forms.Button();
            this.report1Button = new System.Windows.Forms.Button();
            this.reportsDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count_of_genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportsDataGridView = new System.Windows.Forms.DataGridView();
            this.Revenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_Movie_Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.util = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.Plan_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plan_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_revenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empLogoutButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.moviesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empMoviesDataGridView)).BeginInit();
            this.actorsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empActorsDataGridView)).BeginInit();
            this.customersTabPage.SuspendLayout();
            this.customersTabControl.SuspendLayout();
            this.searchCustomersTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empCustomerGridView)).BeginInit();
            this.mailingListTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.employeesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empEmployeesDataGridView)).BeginInit();
            this.transactionsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txGridView)).BeginInit();
            this.reportsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.moviesTabPage);
            this.tabControl1.Controls.Add(this.actorsTabPage);
            this.tabControl1.Controls.Add(this.customersTabPage);
            this.tabControl1.Controls.Add(this.employeesTabPage);
            this.tabControl1.Controls.Add(this.transactionsTabPage);
            this.tabControl1.Controls.Add(this.reportsTabPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl1.MaximumSize = new System.Drawing.Size(1857, 1280);
            this.tabControl1.MinimumSize = new System.Drawing.Size(1857, 1280);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1857, 1280);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // moviesTabPage
            // 
            this.moviesTabPage.Controls.Add(this.moviesSearchClearButton);
            this.moviesTabPage.Controls.Add(this.empMoviesDataGridView);
            this.moviesTabPage.Controls.Add(this.moviesAddMovieButton);
            this.moviesTabPage.Controls.Add(this.moviesSearchButton);
            this.moviesTabPage.Controls.Add(this.genreComboBox);
            this.moviesTabPage.Controls.Add(this.actorsNamesTextBox);
            this.moviesTabPage.Controls.Add(this.movieNameTextBox);
            this.moviesTabPage.Controls.Add(this.mostRentedRadioButton);
            this.moviesTabPage.Controls.Add(this.searchFiltersRadioButton);
            this.moviesTabPage.Controls.Add(this.allMoviesRadioButton);
            this.moviesTabPage.Location = new System.Drawing.Point(8, 46);
            this.moviesTabPage.Margin = new System.Windows.Forms.Padding(6);
            this.moviesTabPage.Name = "moviesTabPage";
            this.moviesTabPage.Padding = new System.Windows.Forms.Padding(6);
            this.moviesTabPage.Size = new System.Drawing.Size(1841, 1226);
            this.moviesTabPage.TabIndex = 0;
            this.moviesTabPage.Text = "Movies";
            this.moviesTabPage.UseVisualStyleBackColor = true;
            // 
            // moviesSearchClearButton
            // 
            this.moviesSearchClearButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.moviesSearchClearButton.Location = new System.Drawing.Point(1339, 224);
            this.moviesSearchClearButton.Margin = new System.Windows.Forms.Padding(6);
            this.moviesSearchClearButton.Name = "moviesSearchClearButton";
            this.moviesSearchClearButton.Size = new System.Drawing.Size(212, 60);
            this.moviesSearchClearButton.TabIndex = 13;
            this.moviesSearchClearButton.Text = "Clear";
            this.moviesSearchClearButton.UseVisualStyleBackColor = true;
            this.moviesSearchClearButton.Click += new System.EventHandler(this.clearMoviesSearchForm);
            // 
            // empMoviesDataGridView
            // 
            this.empMoviesDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.empMoviesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empMoviesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Movie_ID,
            this.Movie_name,
            this.type_of_movie});
            this.empMoviesDataGridView.Location = new System.Drawing.Point(32, 352);
            this.empMoviesDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.empMoviesDataGridView.Name = "empMoviesDataGridView";
            this.empMoviesDataGridView.RowHeadersWidth = 51;
            this.empMoviesDataGridView.RowTemplate.Height = 25;
            this.empMoviesDataGridView.Size = new System.Drawing.Size(1742, 734);
            this.empMoviesDataGridView.TabIndex = 11;
            this.empMoviesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.empMovies_CellContentClick);
            // 
            // Movie_ID
            // 
            this.Movie_ID.HeaderText = "Movie ID";
            this.Movie_ID.MinimumWidth = 100;
            this.Movie_ID.Name = "Movie_ID";
            this.Movie_ID.Width = 125;
            // 
            // Movie_name
            // 
            this.Movie_name.HeaderText = "Movie Title";
            this.Movie_name.MinimumWidth = 500;
            this.Movie_name.Name = "Movie_name";
            this.Movie_name.Width = 500;
            // 
            // type_of_movie
            // 
            this.type_of_movie.HeaderText = "Genre";
            this.type_of_movie.MinimumWidth = 350;
            this.type_of_movie.Name = "type_of_movie";
            this.type_of_movie.Width = 350;
            // 
            // moviesAddMovieButton
            // 
            this.moviesAddMovieButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.moviesAddMovieButton.Location = new System.Drawing.Point(1562, 19);
            this.moviesAddMovieButton.Margin = new System.Windows.Forms.Padding(6);
            this.moviesAddMovieButton.Name = "moviesAddMovieButton";
            this.moviesAddMovieButton.Size = new System.Drawing.Size(212, 60);
            this.moviesAddMovieButton.TabIndex = 12;
            this.moviesAddMovieButton.Text = "Add Movie";
            this.moviesAddMovieButton.UseVisualStyleBackColor = true;
            this.moviesAddMovieButton.Click += new System.EventHandler(this.launchMovieButton_Click);
            // 
            // moviesSearchButton
            // 
            this.moviesSearchButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.moviesSearchButton.Location = new System.Drawing.Point(1562, 224);
            this.moviesSearchButton.Margin = new System.Windows.Forms.Padding(6);
            this.moviesSearchButton.Name = "moviesSearchButton";
            this.moviesSearchButton.Size = new System.Drawing.Size(212, 60);
            this.moviesSearchButton.TabIndex = 10;
            this.moviesSearchButton.Text = "Search";
            this.moviesSearchButton.UseVisualStyleBackColor = true;
            this.moviesSearchButton.Click += new System.EventHandler(this.searchMoviesWithFilters);
            // 
            // genreComboBox
            // 
            this.genreComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Location = new System.Drawing.Point(32, 228);
            this.genreComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(775, 44);
            this.genreComboBox.TabIndex = 7;
            this.genreComboBox.Text = "Genre";
            // 
            // actorsNamesTextBox
            // 
            this.actorsNamesTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.actorsNamesTextBox.Hint = "Actor(s) names (comma separated)";
            this.actorsNamesTextBox.Location = new System.Drawing.Point(32, 160);
            this.actorsNamesTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.actorsNamesTextBox.Name = "actorsNamesTextBox";
            this.actorsNamesTextBox.Size = new System.Drawing.Size(1739, 44);
            this.actorsNamesTextBox.TabIndex = 6;
            // 
            // movieNameTextBox
            // 
            this.movieNameTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.movieNameTextBox.Hint = "Movie Name";
            this.movieNameTextBox.Location = new System.Drawing.Point(32, 92);
            this.movieNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.movieNameTextBox.Name = "movieNameTextBox";
            this.movieNameTextBox.Size = new System.Drawing.Size(1739, 44);
            this.movieNameTextBox.TabIndex = 5;
            // 
            // mostRentedRadioButton
            // 
            this.mostRentedRadioButton.AutoSize = true;
            this.mostRentedRadioButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mostRentedRadioButton.Location = new System.Drawing.Point(462, 13);
            this.mostRentedRadioButton.Margin = new System.Windows.Forms.Padding(6);
            this.mostRentedRadioButton.Name = "mostRentedRadioButton";
            this.mostRentedRadioButton.Size = new System.Drawing.Size(339, 40);
            this.mostRentedRadioButton.TabIndex = 3;
            this.mostRentedRadioButton.Text = "Most Actively Rented";
            this.mostRentedRadioButton.UseVisualStyleBackColor = true;
            this.mostRentedRadioButton.Click += new System.EventHandler(this.mostActivelyRented);
            // 
            // searchFiltersRadioButton
            // 
            this.searchFiltersRadioButton.AutoSize = true;
            this.searchFiltersRadioButton.Checked = true;
            this.searchFiltersRadioButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchFiltersRadioButton.Location = new System.Drawing.Point(223, 13);
            this.searchFiltersRadioButton.Margin = new System.Windows.Forms.Padding(6);
            this.searchFiltersRadioButton.Name = "searchFiltersRadioButton";
            this.searchFiltersRadioButton.Size = new System.Drawing.Size(242, 40);
            this.searchFiltersRadioButton.TabIndex = 2;
            this.searchFiltersRadioButton.TabStop = true;
            this.searchFiltersRadioButton.Text = "Search Filters";
            this.searchFiltersRadioButton.UseVisualStyleBackColor = true;
            this.searchFiltersRadioButton.Click += new System.EventHandler(this.newSearchFilters);
            // 
            // allMoviesRadioButton
            // 
            this.allMoviesRadioButton.AutoSize = true;
            this.allMoviesRadioButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.allMoviesRadioButton.Location = new System.Drawing.Point(32, 13);
            this.allMoviesRadioButton.Margin = new System.Windows.Forms.Padding(6);
            this.allMoviesRadioButton.Name = "allMoviesRadioButton";
            this.allMoviesRadioButton.Size = new System.Drawing.Size(189, 40);
            this.allMoviesRadioButton.TabIndex = 1;
            this.allMoviesRadioButton.Text = "All Movies";
            this.allMoviesRadioButton.UseVisualStyleBackColor = true;
            this.allMoviesRadioButton.Click += new System.EventHandler(this.searchAllMovies);
            // 
            // actorsTabPage
            // 
            this.actorsTabPage.Controls.Add(this.empActorsDataGridView);
            this.actorsTabPage.Controls.Add(this.actorsAddButton);
            this.actorsTabPage.Controls.Add(this.actorsSearchButton);
            this.actorsTabPage.Controls.Add(this.empActorSearchTextBox);
            this.actorsTabPage.Location = new System.Drawing.Point(8, 46);
            this.actorsTabPage.Margin = new System.Windows.Forms.Padding(6);
            this.actorsTabPage.Name = "actorsTabPage";
            this.actorsTabPage.Padding = new System.Windows.Forms.Padding(6);
            this.actorsTabPage.Size = new System.Drawing.Size(1841, 1226);
            this.actorsTabPage.TabIndex = 1;
            this.actorsTabPage.Text = "Actors";
            this.actorsTabPage.UseVisualStyleBackColor = true;
            // 
            // empActorsDataGridView
            // 
            this.empActorsDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.empActorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empActorsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.actorId,
            this.actorFirstName,
            this.actorLastName,
            this.actorGender,
            this.actorAge});
            this.empActorsDataGridView.Location = new System.Drawing.Point(61, 141);
            this.empActorsDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.empActorsDataGridView.Name = "empActorsDataGridView";
            this.empActorsDataGridView.RowHeadersWidth = 51;
            this.empActorsDataGridView.RowTemplate.Height = 25;
            this.empActorsDataGridView.Size = new System.Drawing.Size(1694, 907);
            this.empActorsDataGridView.TabIndex = 8;
            this.empActorsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.empActors_CellContentClick);
            // 
            // actorId
            // 
            this.actorId.HeaderText = "Id";
            this.actorId.MinimumWidth = 10;
            this.actorId.Name = "actorId";
            this.actorId.Visible = false;
            this.actorId.Width = 200;
            // 
            // actorFirstName
            // 
            this.actorFirstName.HeaderText = "First Name";
            this.actorFirstName.MinimumWidth = 300;
            this.actorFirstName.Name = "actorFirstName";
            this.actorFirstName.Width = 300;
            // 
            // actorLastName
            // 
            this.actorLastName.HeaderText = "Last Name";
            this.actorLastName.MinimumWidth = 300;
            this.actorLastName.Name = "actorLastName";
            this.actorLastName.Width = 300;
            // 
            // actorGender
            // 
            this.actorGender.HeaderText = "Gender";
            this.actorGender.MinimumWidth = 10;
            this.actorGender.Name = "actorGender";
            this.actorGender.Width = 200;
            // 
            // actorAge
            // 
            this.actorAge.HeaderText = "Age";
            this.actorAge.MinimumWidth = 10;
            this.actorAge.Name = "actorAge";
            this.actorAge.Width = 200;
            // 
            // actorsAddButton
            // 
            this.actorsAddButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.actorsAddButton.Location = new System.Drawing.Point(1426, 36);
            this.actorsAddButton.Margin = new System.Windows.Forms.Padding(6);
            this.actorsAddButton.Name = "actorsAddButton";
            this.actorsAddButton.Size = new System.Drawing.Size(329, 60);
            this.actorsAddButton.TabIndex = 7;
            this.actorsAddButton.Text = "Add Actor";
            this.actorsAddButton.UseVisualStyleBackColor = true;
            this.actorsAddButton.Click += new System.EventHandler(this.actorsAddButton_Click);
            // 
            // actorsSearchButton
            // 
            this.actorsSearchButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.actorsSearchButton.Location = new System.Drawing.Point(1094, 36);
            this.actorsSearchButton.Margin = new System.Windows.Forms.Padding(6);
            this.actorsSearchButton.Name = "actorsSearchButton";
            this.actorsSearchButton.Size = new System.Drawing.Size(329, 60);
            this.actorsSearchButton.TabIndex = 1;
            this.actorsSearchButton.Text = "Search";
            this.actorsSearchButton.UseVisualStyleBackColor = true;
            this.actorsSearchButton.Click += new System.EventHandler(this.searchActors);
            // 
            // empActorSearchTextBox
            // 
            this.empActorSearchTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.empActorSearchTextBox.Hint = "Search Actor";
            this.empActorSearchTextBox.Location = new System.Drawing.Point(59, 38);
            this.empActorSearchTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.empActorSearchTextBox.Name = "empActorSearchTextBox";
            this.empActorSearchTextBox.Size = new System.Drawing.Size(1022, 44);
            this.empActorSearchTextBox.TabIndex = 0;
            // 
            // customersTabPage
            // 
            this.customersTabPage.Controls.Add(this.customersTabControl);
            this.customersTabPage.Location = new System.Drawing.Point(8, 46);
            this.customersTabPage.Margin = new System.Windows.Forms.Padding(6);
            this.customersTabPage.Name = "customersTabPage";
            this.customersTabPage.Padding = new System.Windows.Forms.Padding(6);
            this.customersTabPage.Size = new System.Drawing.Size(1841, 1226);
            this.customersTabPage.TabIndex = 2;
            this.customersTabPage.Text = "Customers";
            this.customersTabPage.UseVisualStyleBackColor = true;
            // 
            // customersTabControl
            // 
            this.customersTabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.customersTabControl.Controls.Add(this.searchCustomersTabPage);
            this.customersTabControl.Controls.Add(this.mailingListTabPage);
            this.customersTabControl.Location = new System.Drawing.Point(-4, 0);
            this.customersTabControl.Margin = new System.Windows.Forms.Padding(6);
            this.customersTabControl.Name = "customersTabControl";
            this.customersTabControl.SelectedIndex = 0;
            this.customersTabControl.Size = new System.Drawing.Size(1824, 1120);
            this.customersTabControl.TabIndex = 2;
            // 
            // searchCustomersTabPage
            // 
            this.searchCustomersTabPage.Controls.Add(this.launchCustomerButton);
            this.searchCustomersTabPage.Controls.Add(this.searchCustomersButton);
            this.searchCustomersTabPage.Controls.Add(this.searchCustomersTextBox);
            this.searchCustomersTabPage.Controls.Add(this.empCustomerGridView);
            this.searchCustomersTabPage.Location = new System.Drawing.Point(8, 8);
            this.searchCustomersTabPage.Margin = new System.Windows.Forms.Padding(6);
            this.searchCustomersTabPage.Name = "searchCustomersTabPage";
            this.searchCustomersTabPage.Padding = new System.Windows.Forms.Padding(6);
            this.searchCustomersTabPage.Size = new System.Drawing.Size(1808, 1066);
            this.searchCustomersTabPage.TabIndex = 0;
            this.searchCustomersTabPage.Text = "Search Customers";
            this.searchCustomersTabPage.UseVisualStyleBackColor = true;
            // 
            // launchCustomerButton
            // 
            this.launchCustomerButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.launchCustomerButton.Location = new System.Drawing.Point(1436, 36);
            this.launchCustomerButton.Margin = new System.Windows.Forms.Padding(6);
            this.launchCustomerButton.Name = "launchCustomerButton";
            this.launchCustomerButton.Size = new System.Drawing.Size(314, 60);
            this.launchCustomerButton.TabIndex = 6;
            this.launchCustomerButton.Text = "Add New";
            this.launchCustomerButton.UseVisualStyleBackColor = true;
            this.launchCustomerButton.Click += new System.EventHandler(this.launchCustomerButton_Click);
            // 
            // searchCustomersButton
            // 
            this.searchCustomersButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchCustomersButton.Location = new System.Drawing.Point(1096, 36);
            this.searchCustomersButton.Margin = new System.Windows.Forms.Padding(6);
            this.searchCustomersButton.Name = "searchCustomersButton";
            this.searchCustomersButton.Size = new System.Drawing.Size(329, 60);
            this.searchCustomersButton.TabIndex = 5;
            this.searchCustomersButton.Text = "Search";
            this.searchCustomersButton.UseVisualStyleBackColor = true;
            this.searchCustomersButton.Click += new System.EventHandler(this.searchCustomersButton_Click);
            // 
            // searchCustomersTextBox
            // 
            this.searchCustomersTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchCustomersTextBox.Hint = "Search Customer";
            this.searchCustomersTextBox.Location = new System.Drawing.Point(59, 38);
            this.searchCustomersTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.searchCustomersTextBox.Name = "searchCustomersTextBox";
            this.searchCustomersTextBox.Size = new System.Drawing.Size(1022, 44);
            this.searchCustomersTextBox.TabIndex = 4;
            // 
            // empCustomerGridView
            // 
            this.empCustomerGridView.AllowUserToAddRows = false;
            this.empCustomerGridView.AllowUserToDeleteRows = false;
            this.empCustomerGridView.AllowUserToOrderColumns = true;
            this.empCustomerGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.empCustomerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empCustomerGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.account_number,
            this.first_name,
            this.last_name,
            this.address,
            this.city,
            this.state,
            this.zip_code,
            this.telephone,
            this.email,
            this.create_cust_date,
            this.credit_card,
            this.dataGridViewTextBoxColumn3,
            this.start_date,
            this.end_date,
            this.customer_rating});
            this.empCustomerGridView.Location = new System.Drawing.Point(58, 141);
            this.empCustomerGridView.Margin = new System.Windows.Forms.Padding(6);
            this.empCustomerGridView.Name = "empCustomerGridView";
            this.empCustomerGridView.RowHeadersWidth = 51;
            this.empCustomerGridView.RowTemplate.Height = 25;
            this.empCustomerGridView.Size = new System.Drawing.Size(1694, 907);
            this.empCustomerGridView.TabIndex = 0;
            this.empCustomerGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.empCustomerGridView_CellContentClick);
            this.empCustomerGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.empCustomerGridView_CellContentClick);
            // 
            // account_number
            // 
            this.account_number.HeaderText = "Account Number";
            this.account_number.MinimumWidth = 10;
            this.account_number.Name = "account_number";
            this.account_number.ReadOnly = true;
            this.account_number.Width = 200;
            // 
            // first_name
            // 
            this.first_name.HeaderText = "First Name";
            this.first_name.MinimumWidth = 10;
            this.first_name.Name = "first_name";
            this.first_name.ReadOnly = true;
            this.first_name.Width = 200;
            // 
            // last_name
            // 
            this.last_name.HeaderText = "Last Name";
            this.last_name.MinimumWidth = 10;
            this.last_name.Name = "last_name";
            this.last_name.ReadOnly = true;
            this.last_name.Width = 200;
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.MinimumWidth = 10;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Width = 200;
            // 
            // city
            // 
            this.city.HeaderText = "City";
            this.city.MinimumWidth = 10;
            this.city.Name = "city";
            this.city.ReadOnly = true;
            this.city.Width = 200;
            // 
            // state
            // 
            this.state.HeaderText = "State";
            this.state.MinimumWidth = 10;
            this.state.Name = "state";
            this.state.ReadOnly = true;
            this.state.Width = 200;
            // 
            // zip_code
            // 
            this.zip_code.HeaderText = "Zip Code";
            this.zip_code.MinimumWidth = 10;
            this.zip_code.Name = "zip_code";
            this.zip_code.ReadOnly = true;
            this.zip_code.Width = 200;
            // 
            // telephone
            // 
            this.telephone.HeaderText = "Telephone";
            this.telephone.MinimumWidth = 10;
            this.telephone.Name = "telephone";
            this.telephone.ReadOnly = true;
            this.telephone.Width = 200;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 10;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 200;
            // 
            // create_cust_date
            // 
            this.create_cust_date.HeaderText = "Creation Date";
            this.create_cust_date.MinimumWidth = 10;
            this.create_cust_date.Name = "create_cust_date";
            this.create_cust_date.ReadOnly = true;
            this.create_cust_date.Width = 200;
            // 
            // credit_card
            // 
            this.credit_card.HeaderText = "Credit Card";
            this.credit_card.MinimumWidth = 10;
            this.credit_card.Name = "credit_card";
            this.credit_card.ReadOnly = true;
            this.credit_card.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Plan Number";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // start_date
            // 
            this.start_date.HeaderText = "Start Date";
            this.start_date.MinimumWidth = 10;
            this.start_date.Name = "start_date";
            this.start_date.ReadOnly = true;
            this.start_date.Width = 200;
            // 
            // end_date
            // 
            this.end_date.HeaderText = "End Date";
            this.end_date.MinimumWidth = 10;
            this.end_date.Name = "end_date";
            this.end_date.ReadOnly = true;
            this.end_date.Width = 200;
            // 
            // customer_rating
            // 
            this.customer_rating.HeaderText = "Rating";
            this.customer_rating.MinimumWidth = 10;
            this.customer_rating.Name = "customer_rating";
            this.customer_rating.ReadOnly = true;
            this.customer_rating.Width = 200;
            // 
            // mailingListTabPage
            // 
            this.mailingListTabPage.Controls.Add(this.dataGridView4);
            this.mailingListTabPage.Controls.Add(this.mailingListLabel);
            this.mailingListTabPage.Location = new System.Drawing.Point(8, 8);
            this.mailingListTabPage.Margin = new System.Windows.Forms.Padding(6);
            this.mailingListTabPage.Name = "mailingListTabPage";
            this.mailingListTabPage.Padding = new System.Windows.Forms.Padding(6);
            this.mailingListTabPage.Size = new System.Drawing.Size(1808, 1066);
            this.mailingListTabPage.TabIndex = 1;
            this.mailingListTabPage.Text = "Mailing List";
            this.mailingListTabPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(58, 139);
            this.dataGridView4.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 25;
            this.dataGridView4.Size = new System.Drawing.Size(1694, 900);
            this.dataGridView4.TabIndex = 1;
            // 
            // mailingListLabel
            // 
            this.mailingListLabel.AutoSize = true;
            this.mailingListLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mailingListLabel.Location = new System.Drawing.Point(58, 51);
            this.mailingListLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.mailingListLabel.Name = "mailingListLabel";
            this.mailingListLabel.Size = new System.Drawing.Size(174, 36);
            this.mailingListLabel.TabIndex = 0;
            this.mailingListLabel.Text = "Mailing List";
            // 
            // employeesTabPage
            // 
            this.employeesTabPage.Controls.Add(this.empEmployeesDataGridView);
            this.employeesTabPage.Controls.Add(this.button4);
            this.employeesTabPage.Controls.Add(this.searchEmployeesButton);
            this.employeesTabPage.Controls.Add(this.searchEmpTextBox);
            this.employeesTabPage.Location = new System.Drawing.Point(8, 46);
            this.employeesTabPage.Margin = new System.Windows.Forms.Padding(6);
            this.employeesTabPage.Name = "employeesTabPage";
            this.employeesTabPage.Padding = new System.Windows.Forms.Padding(6);
            this.employeesTabPage.Size = new System.Drawing.Size(1841, 1226);
            this.employeesTabPage.TabIndex = 3;
            this.employeesTabPage.Text = "Employees";
            this.employeesTabPage.UseVisualStyleBackColor = true;
            // 
            // empEmployeesDataGridView
            // 
            this.empEmployeesDataGridView.AllowUserToAddRows = false;
            this.empEmployeesDataGridView.AllowUserToDeleteRows = false;
            this.empEmployeesDataGridView.AllowUserToOrderColumns = true;
            this.empEmployeesDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.empEmployeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empEmployeesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empId,
            this.sin,
            this.emp_first_name,
            this.emp_last_name,
            this.emp_address,
            this.emp_city,
            this.emp_state,
            this.emp_zip,
            this.emp_phone,
            this.emp_start,
            this.emp_rate});
            this.empEmployeesDataGridView.Location = new System.Drawing.Point(61, 149);
            this.empEmployeesDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.empEmployeesDataGridView.Name = "empEmployeesDataGridView";
            this.empEmployeesDataGridView.RowHeadersWidth = 51;
            this.empEmployeesDataGridView.RowTemplate.Height = 25;
            this.empEmployeesDataGridView.Size = new System.Drawing.Size(1694, 915);
            this.empEmployeesDataGridView.TabIndex = 3;
            this.empEmployeesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.empEmployeesDataGridView_CellClick);
            // 
            // empId
            // 
            this.empId.HeaderText = "Employee Id";
            this.empId.MinimumWidth = 10;
            this.empId.Name = "empId";
            this.empId.ReadOnly = true;
            this.empId.Width = 200;
            // 
            // sin
            // 
            this.sin.HeaderText = "Social Insurance Number";
            this.sin.MinimumWidth = 10;
            this.sin.Name = "sin";
            this.sin.ReadOnly = true;
            this.sin.Width = 200;
            // 
            // emp_first_name
            // 
            this.emp_first_name.HeaderText = "First Name";
            this.emp_first_name.MinimumWidth = 10;
            this.emp_first_name.Name = "emp_first_name";
            this.emp_first_name.ReadOnly = true;
            this.emp_first_name.Width = 200;
            // 
            // emp_last_name
            // 
            this.emp_last_name.HeaderText = "Last Name";
            this.emp_last_name.MinimumWidth = 10;
            this.emp_last_name.Name = "emp_last_name";
            this.emp_last_name.ReadOnly = true;
            this.emp_last_name.Width = 200;
            // 
            // emp_address
            // 
            this.emp_address.HeaderText = "Address";
            this.emp_address.MinimumWidth = 10;
            this.emp_address.Name = "emp_address";
            this.emp_address.ReadOnly = true;
            this.emp_address.Width = 200;
            // 
            // emp_city
            // 
            this.emp_city.HeaderText = "City";
            this.emp_city.MinimumWidth = 10;
            this.emp_city.Name = "emp_city";
            this.emp_city.ReadOnly = true;
            this.emp_city.Width = 200;
            // 
            // emp_state
            // 
            this.emp_state.HeaderText = "State";
            this.emp_state.MinimumWidth = 10;
            this.emp_state.Name = "emp_state";
            this.emp_state.ReadOnly = true;
            this.emp_state.Width = 200;
            // 
            // emp_zip
            // 
            this.emp_zip.HeaderText = "Zip Code";
            this.emp_zip.MinimumWidth = 10;
            this.emp_zip.Name = "emp_zip";
            this.emp_zip.ReadOnly = true;
            this.emp_zip.Width = 200;
            // 
            // emp_phone
            // 
            this.emp_phone.HeaderText = "Telephone #";
            this.emp_phone.MinimumWidth = 10;
            this.emp_phone.Name = "emp_phone";
            this.emp_phone.ReadOnly = true;
            this.emp_phone.Width = 200;
            // 
            // emp_start
            // 
            this.emp_start.HeaderText = "Start Date";
            this.emp_start.MinimumWidth = 10;
            this.emp_start.Name = "emp_start";
            this.emp_start.ReadOnly = true;
            this.emp_start.Width = 200;
            // 
            // emp_rate
            // 
            this.emp_rate.HeaderText = "Hourly Rate";
            this.emp_rate.MinimumWidth = 10;
            this.emp_rate.Name = "emp_rate";
            this.emp_rate.ReadOnly = true;
            this.emp_rate.Width = 200;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(1437, 45);
            this.button4.Margin = new System.Windows.Forms.Padding(6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(318, 60);
            this.button4.TabIndex = 2;
            this.button4.Text = "Add New";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.launchEmployeeButton_Click);
            // 
            // searchEmployeesButton
            // 
            this.searchEmployeesButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchEmployeesButton.Location = new System.Drawing.Point(1098, 45);
            this.searchEmployeesButton.Margin = new System.Windows.Forms.Padding(6);
            this.searchEmployeesButton.Name = "searchEmployeesButton";
            this.searchEmployeesButton.Size = new System.Drawing.Size(329, 60);
            this.searchEmployeesButton.TabIndex = 1;
            this.searchEmployeesButton.Text = "Search";
            this.searchEmployeesButton.UseVisualStyleBackColor = true;
            this.searchEmployeesButton.Click += new System.EventHandler(this.searchEmployeesButton_Click);
            // 
            // searchEmpTextBox
            // 
            this.searchEmpTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchEmpTextBox.Hint = "Search Employee";
            this.searchEmpTextBox.Location = new System.Drawing.Point(61, 47);
            this.searchEmpTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.searchEmpTextBox.Name = "searchEmpTextBox";
            this.searchEmpTextBox.Size = new System.Drawing.Size(1022, 44);
            this.searchEmpTextBox.TabIndex = 0;
            // 
            // transactionsTabPage
            // 
            this.transactionsTabPage.Controls.Add(this.txGridView);
            this.transactionsTabPage.Controls.Add(this.label5);
            this.transactionsTabPage.Controls.Add(this.transactionsSearchButton);
            this.transactionsTabPage.Controls.Add(this.exTextBox4);
            this.transactionsTabPage.Location = new System.Drawing.Point(8, 46);
            this.transactionsTabPage.Margin = new System.Windows.Forms.Padding(6);
            this.transactionsTabPage.Name = "transactionsTabPage";
            this.transactionsTabPage.Padding = new System.Windows.Forms.Padding(6);
            this.transactionsTabPage.Size = new System.Drawing.Size(1841, 1226);
            this.transactionsTabPage.TabIndex = 4;
            this.transactionsTabPage.Text = "Transactions";
            this.transactionsTabPage.UseVisualStyleBackColor = true;
            // 
            // txGridView
            // 
            this.txGridView.AllowUserToAddRows = false;
            this.txGridView.AllowUserToDeleteRows = false;
            this.txGridView.AllowUserToOrderColumns = true;
            this.txGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.txGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.txGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.order_id,
            this.tx_account,
            this.start_datetime,
            this.end_datetime,
            this.tx_copyId,
            this.tx_employee,
            this.tx_moveName,
            this.tx_cust_name});
            this.txGridView.Location = new System.Drawing.Point(59, 260);
            this.txGridView.Margin = new System.Windows.Forms.Padding(6);
            this.txGridView.Name = "txGridView";
            this.txGridView.RowHeadersWidth = 51;
            this.txGridView.RowTemplate.Height = 25;
            this.txGridView.Size = new System.Drawing.Size(1694, 730);
            this.txGridView.TabIndex = 14;
            this.txGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.txGridView_CellClick);
            // 
            // order_id
            // 
            this.order_id.HeaderText = "Order Id";
            this.order_id.MinimumWidth = 10;
            this.order_id.Name = "order_id";
            this.order_id.ReadOnly = true;
            this.order_id.Width = 200;
            // 
            // tx_account
            // 
            this.tx_account.HeaderText = "Account Number";
            this.tx_account.MinimumWidth = 10;
            this.tx_account.Name = "tx_account";
            this.tx_account.ReadOnly = true;
            this.tx_account.Width = 200;
            // 
            // start_datetime
            // 
            this.start_datetime.HeaderText = "Start Date";
            this.start_datetime.MinimumWidth = 10;
            this.start_datetime.Name = "start_datetime";
            this.start_datetime.ReadOnly = true;
            this.start_datetime.Width = 200;
            // 
            // end_datetime
            // 
            this.end_datetime.HeaderText = "End Date";
            this.end_datetime.MinimumWidth = 10;
            this.end_datetime.Name = "end_datetime";
            this.end_datetime.ReadOnly = true;
            this.end_datetime.Width = 200;
            // 
            // tx_copyId
            // 
            this.tx_copyId.HeaderText = "Copy Id";
            this.tx_copyId.MinimumWidth = 10;
            this.tx_copyId.Name = "tx_copyId";
            this.tx_copyId.ReadOnly = true;
            this.tx_copyId.Width = 200;
            // 
            // tx_employee
            // 
            this.tx_employee.HeaderText = "Employee Id";
            this.tx_employee.MinimumWidth = 10;
            this.tx_employee.Name = "tx_employee";
            this.tx_employee.ReadOnly = true;
            this.tx_employee.Width = 200;
            // 
            // tx_moveName
            // 
            this.tx_moveName.HeaderText = "Movie Name";
            this.tx_moveName.MinimumWidth = 10;
            this.tx_moveName.Name = "tx_moveName";
            this.tx_moveName.ReadOnly = true;
            this.tx_moveName.Width = 200;
            // 
            // tx_cust_name
            // 
            this.tx_cust_name.HeaderText = "Customer Name";
            this.tx_cust_name.MinimumWidth = 10;
            this.tx_cust_name.Name = "tx_cust_name";
            this.tx_cust_name.ReadOnly = true;
            this.tx_cust_name.Width = 200;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(59, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(361, 36);
            this.label5.TabIndex = 13;
            this.label5.Text = "Orders and Transactions";
            // 
            // transactionsSearchButton
            // 
            this.transactionsSearchButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.transactionsSearchButton.Location = new System.Drawing.Point(1439, 181);
            this.transactionsSearchButton.Margin = new System.Windows.Forms.Padding(6);
            this.transactionsSearchButton.Name = "transactionsSearchButton";
            this.transactionsSearchButton.Size = new System.Drawing.Size(314, 60);
            this.transactionsSearchButton.TabIndex = 12;
            this.transactionsSearchButton.Text = "Search";
            this.transactionsSearchButton.UseVisualStyleBackColor = true;
            this.transactionsSearchButton.Click += new System.EventHandler(this.transactionsSearchButton_Click);
            // 
            // exTextBox4
            // 
            this.exTextBox4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exTextBox4.Hint = "Enter Name OR Movie Name OR Order Id OR Account Number";
            this.exTextBox4.Location = new System.Drawing.Point(59, 113);
            this.exTextBox4.Margin = new System.Windows.Forms.Padding(6);
            this.exTextBox4.Name = "exTextBox4";
            this.exTextBox4.Size = new System.Drawing.Size(1690, 44);
            this.exTextBox4.TabIndex = 9;
            this.exTextBox4.TextChanged += new System.EventHandler(this.exTextBox4_TextChanged);
            // 
            // reportsTabPage
            // 
            this.reportsTabPage.Controls.Add(this.MonthComboBox);
            this.reportsTabPage.Controls.Add(this.QuarterComboBox);
            this.reportsTabPage.Controls.Add(this.YearComboBox);
            this.reportsTabPage.Controls.Add(this.reportsGenerateButton);
            this.reportsTabPage.Controls.Add(this.report5Button);
            this.reportsTabPage.Controls.Add(this.report4Button);
            this.reportsTabPage.Controls.Add(this.report3Button);
            this.reportsTabPage.Controls.Add(this.report2Button);
            this.reportsTabPage.Controls.Add(this.report1Button);
            this.reportsTabPage.Controls.Add(this.reportsDescriptionTextBox);
            this.reportsTabPage.Controls.Add(this.label1);
            this.reportsTabPage.Controls.Add(this.dataGridView2);
            this.reportsTabPage.Controls.Add(this.reportsDataGridView);
            this.reportsTabPage.Controls.Add(this.dataGridView5);
            this.reportsTabPage.Controls.Add(this.dataGridView3);
            this.reportsTabPage.Controls.Add(this.dataGridView6);
            this.reportsTabPage.Location = new System.Drawing.Point(8, 46);
            this.reportsTabPage.Margin = new System.Windows.Forms.Padding(6);
            this.reportsTabPage.Name = "reportsTabPage";
            this.reportsTabPage.Padding = new System.Windows.Forms.Padding(6);
            this.reportsTabPage.Size = new System.Drawing.Size(1841, 1226);
            this.reportsTabPage.TabIndex = 5;
            this.reportsTabPage.Text = "Reports";
            this.reportsTabPage.UseVisualStyleBackColor = true;
            // 
            // MonthComboBox
            // 
            this.MonthComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MonthComboBox.FormattingEnabled = true;
            this.MonthComboBox.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.MonthComboBox.Location = new System.Drawing.Point(628, 107);
            this.MonthComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.MonthComboBox.Name = "MonthComboBox";
            this.MonthComboBox.Size = new System.Drawing.Size(303, 44);
            this.MonthComboBox.TabIndex = 17;
            this.MonthComboBox.Text = "Month";
            this.MonthComboBox.SelectedIndexChanged += new System.EventHandler(this.MonthComboBox_SelectedIndexChanged);
            // 
            // QuarterComboBox
            // 
            this.QuarterComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QuarterComboBox.FormattingEnabled = true;
            this.QuarterComboBox.Items.AddRange(new object[] {
            "First Quarter",
            "Second Quarter",
            "Third Quarter",
            "Forth Quarter",
            "Full Year"});
            this.QuarterComboBox.Location = new System.Drawing.Point(310, 107);
            this.QuarterComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.QuarterComboBox.Name = "QuarterComboBox";
            this.QuarterComboBox.Size = new System.Drawing.Size(303, 44);
            this.QuarterComboBox.TabIndex = 16;
            this.QuarterComboBox.Text = "Quarter";
            this.QuarterComboBox.SelectedIndexChanged += new System.EventHandler(this.QuarterComboBox_SelectedIndexChanged);
            // 
            // YearComboBox
            // 
            this.YearComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.YearComboBox.FormattingEnabled = true;
            this.YearComboBox.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026"});
            this.YearComboBox.Location = new System.Drawing.Point(15, 107);
            this.YearComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.YearComboBox.Name = "YearComboBox";
            this.YearComboBox.Size = new System.Drawing.Size(281, 44);
            this.YearComboBox.TabIndex = 15;
            this.YearComboBox.Text = "Year";
            this.YearComboBox.SelectedIndexChanged += new System.EventHandler(this.YearComboBox_SelectedIndexChanged);
            // 
            // reportsGenerateButton
            // 
            this.reportsGenerateButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reportsGenerateButton.Location = new System.Drawing.Point(1519, 107);
            this.reportsGenerateButton.Margin = new System.Windows.Forms.Padding(6);
            this.reportsGenerateButton.Name = "reportsGenerateButton";
            this.reportsGenerateButton.Size = new System.Drawing.Size(279, 60);
            this.reportsGenerateButton.TabIndex = 10;
            this.reportsGenerateButton.Text = "Generate Report";
            this.reportsGenerateButton.UseVisualStyleBackColor = true;
            this.reportsGenerateButton.Click += new System.EventHandler(this.reportsGenerateButton_Click);
            // 
            // report5Button
            // 
            this.report5Button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.report5Button.Location = new System.Drawing.Point(832, 1043);
            this.report5Button.Margin = new System.Windows.Forms.Padding(6);
            this.report5Button.Name = "report5Button";
            this.report5Button.Size = new System.Drawing.Size(193, 64);
            this.report5Button.TabIndex = 8;
            this.report5Button.Text = "Report 5";
            this.report5Button.UseVisualStyleBackColor = true;
            this.report5Button.Click += new System.EventHandler(this.report5Button_Click_1);
            // 
            // report4Button
            // 
            this.report4Button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.report4Button.Location = new System.Drawing.Point(628, 1043);
            this.report4Button.Margin = new System.Windows.Forms.Padding(6);
            this.report4Button.Name = "report4Button";
            this.report4Button.Size = new System.Drawing.Size(193, 64);
            this.report4Button.TabIndex = 7;
            this.report4Button.Text = "Report 4";
            this.report4Button.UseVisualStyleBackColor = true;
            this.report4Button.Click += new System.EventHandler(this.report4Button_Click_1);
            // 
            // report3Button
            // 
            this.report3Button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.report3Button.Location = new System.Drawing.Point(423, 1043);
            this.report3Button.Margin = new System.Windows.Forms.Padding(6);
            this.report3Button.Name = "report3Button";
            this.report3Button.Size = new System.Drawing.Size(193, 64);
            this.report3Button.TabIndex = 6;
            this.report3Button.Text = "Report 3";
            this.report3Button.UseVisualStyleBackColor = true;
            this.report3Button.Click += new System.EventHandler(this.report3Button_Click_1);
            // 
            // report2Button
            // 
            this.report2Button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.report2Button.Location = new System.Drawing.Point(219, 1043);
            this.report2Button.Margin = new System.Windows.Forms.Padding(6);
            this.report2Button.Name = "report2Button";
            this.report2Button.Size = new System.Drawing.Size(193, 64);
            this.report2Button.TabIndex = 5;
            this.report2Button.Text = "Report 2";
            this.report2Button.UseVisualStyleBackColor = true;
            this.report2Button.Click += new System.EventHandler(this.report2Button_Click_1);
            // 
            // report1Button
            // 
            this.report1Button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.report1Button.Location = new System.Drawing.Point(15, 1043);
            this.report1Button.Margin = new System.Windows.Forms.Padding(6);
            this.report1Button.Name = "report1Button";
            this.report1Button.Size = new System.Drawing.Size(193, 64);
            this.report1Button.TabIndex = 4;
            this.report1Button.Text = "Report 1";
            this.report1Button.UseVisualStyleBackColor = true;
            this.report1Button.Click += new System.EventHandler(this.report1Button_Click1);
            // 
            // reportsDescriptionTextBox
            // 
            this.reportsDescriptionTextBox.Location = new System.Drawing.Point(15, 51);
            this.reportsDescriptionTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.reportsDescriptionTextBox.Name = "reportsDescriptionTextBox";
            this.reportsDescriptionTextBox.ReadOnly = true;
            this.reportsDescriptionTextBox.Size = new System.Drawing.Size(1779, 39);
            this.reportsDescriptionTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reports";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Count_of_genre});
            this.dataGridView2.Location = new System.Drawing.Point(15, 175);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(1783, 868);
            this.dataGridView2.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Genre";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // Count_of_genre
            // 
            this.Count_of_genre.HeaderText = "Number of rentals";
            this.Count_of_genre.MinimumWidth = 10;
            this.Count_of_genre.Name = "Count_of_genre";
            this.Count_of_genre.ReadOnly = true;
            this.Count_of_genre.Width = 200;
            // 
            // reportsDataGridView
            // 
            this.reportsDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.reportsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Revenue,
            this.Total_Movie_Cost,
            this.Profits});
            this.reportsDataGridView.Location = new System.Drawing.Point(15, 175);
            this.reportsDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.reportsDataGridView.Name = "reportsDataGridView";
            this.reportsDataGridView.RowHeadersWidth = 51;
            this.reportsDataGridView.RowTemplate.Height = 25;
            this.reportsDataGridView.Size = new System.Drawing.Size(1783, 868);
            this.reportsDataGridView.TabIndex = 9;
            // 
            // Revenue
            // 
            this.Revenue.HeaderText = "Revenue";
            this.Revenue.MinimumWidth = 10;
            this.Revenue.Name = "Revenue";
            this.Revenue.ReadOnly = true;
            this.Revenue.Width = 200;
            // 
            // Total_Movie_Cost
            // 
            this.Total_Movie_Cost.HeaderText = "Movie Cost";
            this.Total_Movie_Cost.MinimumWidth = 10;
            this.Total_Movie_Cost.Name = "Total_Movie_Cost";
            this.Total_Movie_Cost.ReadOnly = true;
            this.Total_Movie_Cost.Width = 200;
            // 
            // Profits
            // 
            this.Profits.HeaderText = "Profits";
            this.Profits.MinimumWidth = 10;
            this.Profits.Name = "Profits";
            this.Profits.ReadOnly = true;
            this.Profits.Width = 200;
            // 
            // dataGridView5
            // 
            this.dataGridView5.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.account,
            this.first,
            this.last,
            this.plan,
            this.util,
            this.rec});
            this.dataGridView5.Location = new System.Drawing.Point(15, 175);
            this.dataGridView5.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 51;
            this.dataGridView5.RowTemplate.Height = 25;
            this.dataGridView5.Size = new System.Drawing.Size(1783, 868);
            this.dataGridView5.TabIndex = 13;
            // 
            // account
            // 
            this.account.HeaderText = "Account Number";
            this.account.MinimumWidth = 10;
            this.account.Name = "account";
            this.account.ReadOnly = true;
            this.account.Width = 200;
            // 
            // first
            // 
            this.first.HeaderText = "First Name";
            this.first.MinimumWidth = 10;
            this.first.Name = "first";
            this.first.ReadOnly = true;
            this.first.Width = 200;
            // 
            // last
            // 
            this.last.HeaderText = "Last Name";
            this.last.MinimumWidth = 10;
            this.last.Name = "last";
            this.last.ReadOnly = true;
            this.last.Width = 200;
            // 
            // plan
            // 
            this.plan.HeaderText = "Plan Number";
            this.plan.MinimumWidth = 10;
            this.plan.Name = "plan";
            this.plan.ReadOnly = true;
            this.plan.Width = 200;
            // 
            // util
            // 
            this.util.HeaderText = "Utilization Percent";
            this.util.MinimumWidth = 10;
            this.util.Name = "util";
            this.util.ReadOnly = true;
            this.util.Width = 200;
            // 
            // rec
            // 
            this.rec.HeaderText = "Upgrade Recommended";
            this.rec.MinimumWidth = 10;
            this.rec.Name = "rec";
            this.rec.ReadOnly = true;
            this.rec.Width = 200;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.name,
            this.formats});
            this.dataGridView3.Location = new System.Drawing.Point(15, 175);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(1783, 868);
            this.dataGridView3.TabIndex = 12;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Id";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // name
            // 
            this.name.HeaderText = "Movie Name";
            this.name.MinimumWidth = 10;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 200;
            // 
            // formats
            // 
            this.formats.HeaderText = "Top 3 Formats";
            this.formats.MinimumWidth = 10;
            this.formats.Name = "formats";
            this.formats.ReadOnly = true;
            this.formats.Width = 200;
            // 
            // dataGridView6
            // 
            this.dataGridView6.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Plan_number,
            this.Plan_count,
            this.cost,
            this.total_revenue});
            this.dataGridView6.Location = new System.Drawing.Point(15, 175);
            this.dataGridView6.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.RowHeadersWidth = 51;
            this.dataGridView6.RowTemplate.Height = 25;
            this.dataGridView6.Size = new System.Drawing.Size(1783, 868);
            this.dataGridView6.TabIndex = 14;
            // 
            // Plan_number
            // 
            this.Plan_number.HeaderText = "plan number";
            this.Plan_number.MinimumWidth = 10;
            this.Plan_number.Name = "Plan_number";
            this.Plan_number.ReadOnly = true;
            this.Plan_number.Width = 200;
            // 
            // Plan_count
            // 
            this.Plan_count.HeaderText = "Number of users";
            this.Plan_count.MinimumWidth = 10;
            this.Plan_count.Name = "Plan_count";
            this.Plan_count.ReadOnly = true;
            this.Plan_count.Width = 200;
            // 
            // cost
            // 
            this.cost.HeaderText = "Price";
            this.cost.MinimumWidth = 10;
            this.cost.Name = "cost";
            this.cost.ReadOnly = true;
            this.cost.Width = 200;
            // 
            // total_revenue
            // 
            this.total_revenue.HeaderText = "total revenue";
            this.total_revenue.MinimumWidth = 10;
            this.total_revenue.Name = "total_revenue";
            this.total_revenue.ReadOnly = true;
            this.total_revenue.Width = 200;
            // 
            // empLogoutButton
            // 
            this.empLogoutButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.empLogoutButton.Location = new System.Drawing.Point(1684, 0);
            this.empLogoutButton.Margin = new System.Windows.Forms.Padding(6);
            this.empLogoutButton.Name = "empLogoutButton";
            this.empLogoutButton.Size = new System.Drawing.Size(139, 45);
            this.empLogoutButton.TabIndex = 1;
            this.empLogoutButton.Text = "Logout";
            this.empLogoutButton.UseVisualStyleBackColor = true;
            this.empLogoutButton.Click += new System.EventHandler(this.empLogoutButton_Click);
            // 
            // EmployeeViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1809, 1129);
            this.Controls.Add(this.empLogoutButton);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximumSize = new System.Drawing.Size(1835, 1200);
            this.MinimumSize = new System.Drawing.Size(1835, 1200);
            this.Name = "EmployeeViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee View";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EmployeeViewForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.moviesTabPage.ResumeLayout(false);
            this.moviesTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empMoviesDataGridView)).EndInit();
            this.actorsTabPage.ResumeLayout(false);
            this.actorsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empActorsDataGridView)).EndInit();
            this.customersTabPage.ResumeLayout(false);
            this.customersTabControl.ResumeLayout(false);
            this.searchCustomersTabPage.ResumeLayout(false);
            this.searchCustomersTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empCustomerGridView)).EndInit();
            this.mailingListTabPage.ResumeLayout(false);
            this.mailingListTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.employeesTabPage.ResumeLayout(false);
            this.employeesTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empEmployeesDataGridView)).EndInit();
            this.transactionsTabPage.ResumeLayout(false);
            this.transactionsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txGridView)).EndInit();
            this.reportsTabPage.ResumeLayout(false);
            this.reportsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage moviesTabPage;
        private TabPage actorsTabPage;
        private TabPage customersTabPage;
        private TabPage employeesTabPage;
        private TabPage reportsTabPage;
        private ExTextBox empActorSearchTextBox;
        private Button actorsSearchButton;
        private Button actorsAddButton;
        private DataGridView empActorsDataGridView;
        private RadioButton allMoviesRadioButton;
        private RadioButton mostRentedRadioButton;
        private RadioButton searchFiltersRadioButton;
        private ComboBox genreComboBox;
        private ExTextBox actorsNamesTextBox;
        private ExTextBox movieNameTextBox;
        private DataGridView empMoviesDataGridView;
        private Button button2;
        private TabControl customersTabControl;
        private TabPage searchCustomersTabPage;
        private TabPage mailingListTabPage;
        private TabPage transactionsTabPage;
        private Button launchCustomerButton;
        private Button searchCustomersButton;
        private ExTextBox searchCustomersTextBox;
        private DataGridView empCustomerGridView;
        private DataGridView dataGridView4;
        private Label mailingListLabel;
        private DataGridView empEmployeesDataGridView;
        private Button button4;
        private Button searchEmployeesButton;
        private ExTextBox searchEmpTextBox;
        private DataGridView reportsDataGridView;
        private Button report5Button;
        private Button report4Button;
        private Button report3Button;
        private Button report2Button;
        private Button report1Button;
        private Label label1;
        private Button moviesAddMovieButton;
        private Button moviesSearchButton;
        private Button moviesSearchClearButton;
        private DataGridViewTextBoxColumn Movie_ID;
        private DataGridViewTextBoxColumn Movie_name;
        private DataGridViewTextBoxColumn type_of_movie;
        private Button reportsGenerateButton;
        private Button empLogoutButton;
        private DataGridViewTextBoxColumn actorId;
        private DataGridViewTextBoxColumn actorFirstName;
        private DataGridViewTextBoxColumn actorLastName;
        private DataGridViewTextBoxColumn actorGender;
        private DataGridViewTextBoxColumn actorAge;
        private DataGridView txGridView;
        private Label label5;
        private Button transactionsSearchButton;
        private ExTextBox exTextBox4;
        private DataGridView dataGridView5;
        private DataGridView dataGridView3;
        private DataGridView dataGridView2;
        private DataGridView dataGridView6;
        public TextBox reportsDescriptionTextBox;
        private ComboBox MonthComboBox;
        private ComboBox QuarterComboBox;
        private ComboBox YearComboBox;
        private DataGridViewTextBoxColumn Revenue;
        private DataGridViewTextBoxColumn Total_Movie_Cost;
        private DataGridViewTextBoxColumn Profits;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn formats;
        private DataGridViewTextBoxColumn Plan_number;
        private DataGridViewTextBoxColumn Plan_count;
        private DataGridViewTextBoxColumn cost;
        private DataGridViewTextBoxColumn total_revenue;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Count_of_genre;
        private DataGridViewTextBoxColumn account;
        private DataGridViewTextBoxColumn first;
        private DataGridViewTextBoxColumn last;
        private DataGridViewTextBoxColumn plan;
        private DataGridViewTextBoxColumn util;
        private DataGridViewTextBoxColumn rec;
        private DataGridViewTextBoxColumn account_number;
        private DataGridViewTextBoxColumn first_name;
        private DataGridViewTextBoxColumn last_name;
        private DataGridViewTextBoxColumn address;
        private DataGridViewTextBoxColumn city;
        private DataGridViewTextBoxColumn state;
        private DataGridViewTextBoxColumn zip_code;
        private DataGridViewTextBoxColumn telephone;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn create_cust_date;
        private DataGridViewTextBoxColumn credit_card;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn start_date;
        private DataGridViewTextBoxColumn end_date;
        private DataGridViewTextBoxColumn customer_rating;
        private DataGridViewTextBoxColumn empId;
        private DataGridViewTextBoxColumn sin;
        private DataGridViewTextBoxColumn emp_first_name;
        private DataGridViewTextBoxColumn emp_last_name;
        private DataGridViewTextBoxColumn emp_address;
        private DataGridViewTextBoxColumn emp_city;
        private DataGridViewTextBoxColumn emp_state;
        private DataGridViewTextBoxColumn emp_zip;
        private DataGridViewTextBoxColumn emp_phone;
        private DataGridViewTextBoxColumn emp_start;
        private DataGridViewTextBoxColumn emp_rate;
        private DataGridViewTextBoxColumn order_id;
        private DataGridViewTextBoxColumn tx_account;
        private DataGridViewTextBoxColumn start_datetime;
        private DataGridViewTextBoxColumn end_datetime;
        private DataGridViewTextBoxColumn tx_copyId;
        private DataGridViewTextBoxColumn tx_employee;
        private DataGridViewTextBoxColumn tx_moveName;
        private DataGridViewTextBoxColumn tx_cust_name;
    }
}