namespace MoviesApp
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.moviesAddMovieButton = new System.Windows.Forms.Button();
            this.moviesSearchButton = new System.Windows.Forms.Button();
            this.toYearTextBox = new MoviesApp.ExTextBox();
            this.fromYearTextBox = new MoviesApp.ExTextBox();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.actorsNamesTextBox = new MoviesApp.ExTextBox();
            this.movieNameTextBox = new MoviesApp.ExTextBox();
            this.mostRentedRadioButton = new System.Windows.Forms.RadioButton();
            this.searchFiltersRadioButton = new System.Windows.Forms.RadioButton();
            this.allMoviesRadioButton = new System.Windows.Forms.RadioButton();
            this.actorsTabPage = new System.Windows.Forms.TabPage();
            this.launchActorButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.actorsAddButton = new System.Windows.Forms.Button();
            this.actorBirthdateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.lastNameTextBox = new MoviesApp.ExTextBox();
            this.firstNameTextBox = new MoviesApp.ExTextBox();
            this.actorsSearchButton = new System.Windows.Forms.Button();
            this.exTextBox1 = new MoviesApp.ExTextBox();
            this.customersTabPage = new System.Windows.Forms.TabPage();
            this.customersTabControl = new System.Windows.Forms.TabControl();
            this.searchCustomersTabPage = new System.Windows.Forms.TabPage();
            this.launchCustomerButton = new System.Windows.Forms.Button();
            this.searchCustomersButton = new System.Windows.Forms.Button();
            this.searchCustomersTextBox = new MoviesApp.ExTextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.mailingListTabPage = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.mailingListLabel = new System.Windows.Forms.Label();
            this.employeesTabPage = new System.Windows.Forms.TabPage();
            this.searchEmployeesDataGridView = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.exTextBox2 = new MoviesApp.ExTextBox();
            this.transactionsTabPage = new System.Windows.Forms.TabPage();
            this.transactionsTabControl = new System.Windows.Forms.TabControl();
            this.newTransactionTabPage = new System.Windows.Forms.TabPage();
            this.transactionsNewCheckoutButton = new System.Windows.Forms.Button();
            this.TransactionsNewDataGridView = new System.Windows.Forms.DataGridView();
            this.transactionsNewSearchButton = new System.Windows.Forms.Button();
            this.exTextBox3 = new MoviesApp.ExTextBox();
            this.transactionsCustomerIDTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rentalHistoryTabPage = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.transactionsHistorySearchButton = new System.Windows.Forms.Button();
            this.transactionsHistoryCustomerNameTextBox = new MoviesApp.ExTextBox();
            this.transactionsHistoryGenreComboBox = new System.Windows.Forms.ComboBox();
            this.transactionsHistoryMovieNameTextBox = new MoviesApp.ExTextBox();
            this.reportsTabPage = new System.Windows.Forms.TabPage();
            this.reportsDataGridView = new System.Windows.Forms.DataGridView();
            this.report5Button = new System.Windows.Forms.Button();
            this.report4Button = new System.Windows.Forms.Button();
            this.report3Button = new System.Windows.Forms.Button();
            this.report2Button = new System.Windows.Forms.Button();
            this.report1Button = new System.Windows.Forms.Button();
            this.reportsDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Movie_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Movie_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.moviesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.actorsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.customersTabPage.SuspendLayout();
            this.customersTabControl.SuspendLayout();
            this.searchCustomersTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.mailingListTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.employeesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchEmployeesDataGridView)).BeginInit();
            this.transactionsTabPage.SuspendLayout();
            this.transactionsTabControl.SuspendLayout();
            this.newTransactionTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsNewDataGridView)).BeginInit();
            this.rentalHistoryTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.reportsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataGridView)).BeginInit();
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
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(986, 562);
            this.tabControl1.TabIndex = 0;
            // 
            // moviesTabPage
            // 
            this.moviesTabPage.Controls.Add(this.dataGridView2);
            this.moviesTabPage.Controls.Add(this.moviesAddMovieButton);
            this.moviesTabPage.Controls.Add(this.moviesSearchButton);
            this.moviesTabPage.Controls.Add(this.toYearTextBox);
            this.moviesTabPage.Controls.Add(this.fromYearTextBox);
            this.moviesTabPage.Controls.Add(this.genreComboBox);
            this.moviesTabPage.Controls.Add(this.actorsNamesTextBox);
            this.moviesTabPage.Controls.Add(this.movieNameTextBox);
            this.moviesTabPage.Controls.Add(this.mostRentedRadioButton);
            this.moviesTabPage.Controls.Add(this.searchFiltersRadioButton);
            this.moviesTabPage.Controls.Add(this.allMoviesRadioButton);
            this.moviesTabPage.Location = new System.Drawing.Point(4, 24);
            this.moviesTabPage.Name = "moviesTabPage";
            this.moviesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.moviesTabPage.Size = new System.Drawing.Size(978, 534);
            this.moviesTabPage.TabIndex = 0;
            this.moviesTabPage.Text = "Movies";
            this.moviesTabPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Movie_ID,
            this.Movie_name});
            this.dataGridView2.Location = new System.Drawing.Point(17, 165);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(938, 344);
            this.dataGridView2.TabIndex = 11;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // moviesAddMovieButton
            // 
            this.moviesAddMovieButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.moviesAddMovieButton.Location = new System.Drawing.Point(841, 9);
            this.moviesAddMovieButton.Name = "moviesAddMovieButton";
            this.moviesAddMovieButton.Size = new System.Drawing.Size(114, 28);
            this.moviesAddMovieButton.TabIndex = 12;
            this.moviesAddMovieButton.Text = "Add Movie";
            this.moviesAddMovieButton.UseVisualStyleBackColor = true;
            this.moviesAddMovieButton.Click += new System.EventHandler(this.launchMovieButton_Click);
            // 
            // moviesSearchButton
            // 
            this.moviesSearchButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.moviesSearchButton.Location = new System.Drawing.Point(762, 105);
            this.moviesSearchButton.Name = "moviesSearchButton";
            this.moviesSearchButton.Size = new System.Drawing.Size(193, 28);
            this.moviesSearchButton.TabIndex = 10;
            this.moviesSearchButton.Text = "Search";
            this.moviesSearchButton.UseVisualStyleBackColor = true;
            // 
            // toYearTextBox
            // 
            this.toYearTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toYearTextBox.Hint = "To year";
            this.toYearTextBox.Location = new System.Drawing.Point(288, 107);
            this.toYearTextBox.Name = "toYearTextBox";
            this.toYearTextBox.Size = new System.Drawing.Size(265, 26);
            this.toYearTextBox.TabIndex = 9;
            // 
            // fromYearTextBox
            // 
            this.fromYearTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fromYearTextBox.Hint = "From year";
            this.fromYearTextBox.Location = new System.Drawing.Point(17, 107);
            this.fromYearTextBox.Name = "fromYearTextBox";
            this.fromYearTextBox.Size = new System.Drawing.Size(265, 26);
            this.fromYearTextBox.TabIndex = 8;
            // 
            // genreComboBox
            // 
            this.genreComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Items.AddRange(new object[] {
            "Comedy",
            "Drama",
            "Action",
            "Foreign"});
            this.genreComboBox.Location = new System.Drawing.Point(762, 43);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(193, 26);
            this.genreComboBox.TabIndex = 7;
            this.genreComboBox.Text = "Genre";
            // 
            // actorsNamesTextBox
            // 
            this.actorsNamesTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.actorsNamesTextBox.Hint = "Actor(s) names (comma separated)";
            this.actorsNamesTextBox.Location = new System.Drawing.Point(17, 75);
            this.actorsNamesTextBox.Name = "actorsNamesTextBox";
            this.actorsNamesTextBox.Size = new System.Drawing.Size(938, 26);
            this.actorsNamesTextBox.TabIndex = 6;
            // 
            // movieNameTextBox
            // 
            this.movieNameTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.movieNameTextBox.Hint = "Movie Name";
            this.movieNameTextBox.Location = new System.Drawing.Point(17, 43);
            this.movieNameTextBox.Name = "movieNameTextBox";
            this.movieNameTextBox.Size = new System.Drawing.Size(739, 26);
            this.movieNameTextBox.TabIndex = 5;
            // 
            // mostRentedRadioButton
            // 
            this.mostRentedRadioButton.AutoSize = true;
            this.mostRentedRadioButton.Checked = true;
            this.mostRentedRadioButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mostRentedRadioButton.Location = new System.Drawing.Point(249, 6);
            this.mostRentedRadioButton.Name = "mostRentedRadioButton";
            this.mostRentedRadioButton.Size = new System.Drawing.Size(170, 22);
            this.mostRentedRadioButton.TabIndex = 3;
            this.mostRentedRadioButton.TabStop = true;
            this.mostRentedRadioButton.Text = "Most Actively Rented";
            this.mostRentedRadioButton.UseVisualStyleBackColor = true;
            this.mostRentedRadioButton.Click += new System.EventHandler(this.mostActivelyRented);
            // 
            // searchFiltersRadioButton
            // 
            this.searchFiltersRadioButton.AutoSize = true;
            this.searchFiltersRadioButton.Checked = true;
            this.searchFiltersRadioButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchFiltersRadioButton.Location = new System.Drawing.Point(120, 6);
            this.searchFiltersRadioButton.Name = "searchFiltersRadioButton";
            this.searchFiltersRadioButton.Size = new System.Drawing.Size(123, 22);
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
            this.allMoviesRadioButton.Location = new System.Drawing.Point(17, 6);
            this.allMoviesRadioButton.Name = "allMoviesRadioButton";
            this.allMoviesRadioButton.Size = new System.Drawing.Size(97, 22);
            this.allMoviesRadioButton.TabIndex = 1;
            this.allMoviesRadioButton.Text = "All Movies";
            this.allMoviesRadioButton.UseVisualStyleBackColor = true;
            this.allMoviesRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.allMoviesRadioButton.Click += new System.EventHandler(this.searchAll);
            // 
            // actorsTabPage
            // 
            this.actorsTabPage.Controls.Add(this.launchActorButton);
            this.actorsTabPage.Controls.Add(this.dataGridView1);
            this.actorsTabPage.Controls.Add(this.actorsAddButton);
            this.actorsTabPage.Controls.Add(this.actorBirthdateDateTimePicker);
            this.actorsTabPage.Controls.Add(this.genderComboBox);
            this.actorsTabPage.Controls.Add(this.lastNameTextBox);
            this.actorsTabPage.Controls.Add(this.firstNameTextBox);
            this.actorsTabPage.Controls.Add(this.actorsSearchButton);
            this.actorsTabPage.Controls.Add(this.exTextBox1);
            this.actorsTabPage.Location = new System.Drawing.Point(4, 24);
            this.actorsTabPage.Name = "actorsTabPage";
            this.actorsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.actorsTabPage.Size = new System.Drawing.Size(978, 534);
            this.actorsTabPage.TabIndex = 1;
            this.actorsTabPage.Text = "Actors";
            this.actorsTabPage.UseVisualStyleBackColor = true;
            // 
            // launchActorButton
            // 
            this.launchActorButton.Location = new System.Drawing.Point(402, 63);
            this.launchActorButton.Name = "launchActorButton";
            this.launchActorButton.Size = new System.Drawing.Size(175, 23);
            this.launchActorButton.TabIndex = 9;
            this.launchActorButton.Text = "Temporary launch actor";
            this.launchActorButton.UseVisualStyleBackColor = true;
            this.launchActorButton.Click += new System.EventHandler(this.launchActorButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(912, 361);
            this.dataGridView1.TabIndex = 8;
            // 
            // actorsAddButton
            // 
            this.actorsAddButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.actorsAddButton.Location = new System.Drawing.Point(858, 101);
            this.actorsAddButton.Name = "actorsAddButton";
            this.actorsAddButton.Size = new System.Drawing.Size(87, 28);
            this.actorsAddButton.TabIndex = 7;
            this.actorsAddButton.Text = "Add";
            this.actorsAddButton.UseVisualStyleBackColor = true;
            // 
            // actorBirthdateDateTimePicker
            // 
            this.actorBirthdateDateTimePicker.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.actorBirthdateDateTimePicker.CustomFormat = "MMM dd, yyyy";
            this.actorBirthdateDateTimePicker.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.actorBirthdateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.actorBirthdateDateTimePicker.Location = new System.Drawing.Point(700, 102);
            this.actorBirthdateDateTimePicker.MaxDate = new System.DateTime(2500, 12, 31, 0, 0, 0, 0);
            this.actorBirthdateDateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.actorBirthdateDateTimePicker.Name = "actorBirthdateDateTimePicker";
            this.actorBirthdateDateTimePicker.Size = new System.Drawing.Size(152, 26);
            this.actorBirthdateDateTimePicker.TabIndex = 6;
            // 
            // genderComboBox
            // 
            this.genderComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderComboBox.Location = new System.Drawing.Point(599, 102);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(95, 26);
            this.genderComboBox.TabIndex = 5;
            this.genderComboBox.Tag = "";
            this.genderComboBox.Text = "Gender";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNameTextBox.Hint = "Last Name";
            this.lastNameTextBox.Location = new System.Drawing.Point(307, 102);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(286, 26);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameTextBox.Hint = "First Name";
            this.firstNameTextBox.Location = new System.Drawing.Point(33, 102);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(268, 26);
            this.firstNameTextBox.TabIndex = 2;
            // 
            // actorsSearchButton
            // 
            this.actorsSearchButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.actorsSearchButton.Location = new System.Drawing.Point(791, 18);
            this.actorsSearchButton.Name = "actorsSearchButton";
            this.actorsSearchButton.Size = new System.Drawing.Size(154, 28);
            this.actorsSearchButton.TabIndex = 1;
            this.actorsSearchButton.Text = "Search";
            this.actorsSearchButton.UseVisualStyleBackColor = true;
            // 
            // exTextBox1
            // 
            this.exTextBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exTextBox1.Hint = "Search Actor";
            this.exTextBox1.Location = new System.Drawing.Point(33, 20);
            this.exTextBox1.Name = "exTextBox1";
            this.exTextBox1.Size = new System.Drawing.Size(752, 26);
            this.exTextBox1.TabIndex = 0;
            // 
            // customersTabPage
            // 
            this.customersTabPage.Controls.Add(this.customersTabControl);
            this.customersTabPage.Location = new System.Drawing.Point(4, 24);
            this.customersTabPage.Name = "customersTabPage";
            this.customersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.customersTabPage.Size = new System.Drawing.Size(978, 534);
            this.customersTabPage.TabIndex = 2;
            this.customersTabPage.Text = "Customers";
            this.customersTabPage.UseVisualStyleBackColor = true;
            // 
            // customersTabControl
            // 
            this.customersTabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.customersTabControl.Controls.Add(this.searchCustomersTabPage);
            this.customersTabControl.Controls.Add(this.mailingListTabPage);
            this.customersTabControl.Location = new System.Drawing.Point(-2, 0);
            this.customersTabControl.Name = "customersTabControl";
            this.customersTabControl.SelectedIndex = 0;
            this.customersTabControl.Size = new System.Drawing.Size(982, 525);
            this.customersTabControl.TabIndex = 2;
            // 
            // searchCustomersTabPage
            // 
            this.searchCustomersTabPage.Controls.Add(this.launchCustomerButton);
            this.searchCustomersTabPage.Controls.Add(this.searchCustomersButton);
            this.searchCustomersTabPage.Controls.Add(this.searchCustomersTextBox);
            this.searchCustomersTabPage.Controls.Add(this.dataGridView3);
            this.searchCustomersTabPage.Location = new System.Drawing.Point(4, 4);
            this.searchCustomersTabPage.Name = "searchCustomersTabPage";
            this.searchCustomersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.searchCustomersTabPage.Size = new System.Drawing.Size(974, 497);
            this.searchCustomersTabPage.TabIndex = 0;
            this.searchCustomersTabPage.Text = "Search Customers";
            this.searchCustomersTabPage.UseVisualStyleBackColor = true;
            // 
            // launchCustomerButton
            // 
            this.launchCustomerButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.launchCustomerButton.Location = new System.Drawing.Point(773, 17);
            this.launchCustomerButton.Name = "launchCustomerButton";
            this.launchCustomerButton.Size = new System.Drawing.Size(169, 28);
            this.launchCustomerButton.TabIndex = 6;
            this.launchCustomerButton.Text = "Add New";
            this.launchCustomerButton.UseVisualStyleBackColor = true;
            this.launchCustomerButton.Click += new System.EventHandler(this.launchCustomerButton_Click);
            // 
            // searchCustomersButton
            // 
            this.searchCustomersButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchCustomersButton.Location = new System.Drawing.Point(590, 17);
            this.searchCustomersButton.Name = "searchCustomersButton";
            this.searchCustomersButton.Size = new System.Drawing.Size(177, 28);
            this.searchCustomersButton.TabIndex = 5;
            this.searchCustomersButton.Text = "Search";
            this.searchCustomersButton.UseVisualStyleBackColor = true;
            // 
            // searchCustomersTextBox
            // 
            this.searchCustomersTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchCustomersTextBox.Hint = "Search Customer";
            this.searchCustomersTextBox.Location = new System.Drawing.Point(32, 18);
            this.searchCustomersTextBox.Name = "searchCustomersTextBox";
            this.searchCustomersTextBox.Size = new System.Drawing.Size(552, 26);
            this.searchCustomersTextBox.TabIndex = 4;
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(31, 66);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(912, 425);
            this.dataGridView3.TabIndex = 0;
            // 
            // mailingListTabPage
            // 
            this.mailingListTabPage.Controls.Add(this.dataGridView4);
            this.mailingListTabPage.Controls.Add(this.mailingListLabel);
            this.mailingListTabPage.Location = new System.Drawing.Point(4, 4);
            this.mailingListTabPage.Name = "mailingListTabPage";
            this.mailingListTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.mailingListTabPage.Size = new System.Drawing.Size(974, 497);
            this.mailingListTabPage.TabIndex = 1;
            this.mailingListTabPage.Text = "Mailing List";
            this.mailingListTabPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(31, 65);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 25;
            this.dataGridView4.Size = new System.Drawing.Size(912, 422);
            this.dataGridView4.TabIndex = 1;
            // 
            // mailingListLabel
            // 
            this.mailingListLabel.AutoSize = true;
            this.mailingListLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mailingListLabel.Location = new System.Drawing.Point(31, 24);
            this.mailingListLabel.Name = "mailingListLabel";
            this.mailingListLabel.Size = new System.Drawing.Size(87, 18);
            this.mailingListLabel.TabIndex = 0;
            this.mailingListLabel.Text = "Mailing List";
            // 
            // employeesTabPage
            // 
            this.employeesTabPage.Controls.Add(this.searchEmployeesDataGridView);
            this.employeesTabPage.Controls.Add(this.button4);
            this.employeesTabPage.Controls.Add(this.button3);
            this.employeesTabPage.Controls.Add(this.exTextBox2);
            this.employeesTabPage.Location = new System.Drawing.Point(4, 24);
            this.employeesTabPage.Name = "employeesTabPage";
            this.employeesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.employeesTabPage.Size = new System.Drawing.Size(978, 534);
            this.employeesTabPage.TabIndex = 3;
            this.employeesTabPage.Text = "Employees";
            this.employeesTabPage.UseVisualStyleBackColor = true;
            // 
            // searchEmployeesDataGridView
            // 
            this.searchEmployeesDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.searchEmployeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchEmployeesDataGridView.Location = new System.Drawing.Point(33, 70);
            this.searchEmployeesDataGridView.Name = "searchEmployeesDataGridView";
            this.searchEmployeesDataGridView.RowTemplate.Height = 25;
            this.searchEmployeesDataGridView.Size = new System.Drawing.Size(912, 429);
            this.searchEmployeesDataGridView.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(774, 21);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(171, 28);
            this.button4.TabIndex = 2;
            this.button4.Text = "Add New";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.launchEmployeeButton_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(591, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 28);
            this.button3.TabIndex = 1;
            this.button3.Text = "Search";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // exTextBox2
            // 
            this.exTextBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exTextBox2.Hint = "Search Employee";
            this.exTextBox2.Location = new System.Drawing.Point(33, 22);
            this.exTextBox2.Name = "exTextBox2";
            this.exTextBox2.Size = new System.Drawing.Size(552, 26);
            this.exTextBox2.TabIndex = 0;
            // 
            // transactionsTabPage
            // 
            this.transactionsTabPage.Controls.Add(this.transactionsTabControl);
            this.transactionsTabPage.Location = new System.Drawing.Point(4, 24);
            this.transactionsTabPage.Name = "transactionsTabPage";
            this.transactionsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.transactionsTabPage.Size = new System.Drawing.Size(978, 534);
            this.transactionsTabPage.TabIndex = 4;
            this.transactionsTabPage.Text = "Transactions";
            this.transactionsTabPage.UseVisualStyleBackColor = true;
            // 
            // transactionsTabControl
            // 
            this.transactionsTabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.transactionsTabControl.Controls.Add(this.newTransactionTabPage);
            this.transactionsTabControl.Controls.Add(this.rentalHistoryTabPage);
            this.transactionsTabControl.Location = new System.Drawing.Point(-2, 0);
            this.transactionsTabControl.Name = "transactionsTabControl";
            this.transactionsTabControl.SelectedIndex = 0;
            this.transactionsTabControl.Size = new System.Drawing.Size(982, 525);
            this.transactionsTabControl.TabIndex = 1;
            // 
            // newTransactionTabPage
            // 
            this.newTransactionTabPage.Controls.Add(this.transactionsNewCheckoutButton);
            this.newTransactionTabPage.Controls.Add(this.TransactionsNewDataGridView);
            this.newTransactionTabPage.Controls.Add(this.transactionsNewSearchButton);
            this.newTransactionTabPage.Controls.Add(this.exTextBox3);
            this.newTransactionTabPage.Controls.Add(this.transactionsCustomerIDTextBox);
            this.newTransactionTabPage.Controls.Add(this.label3);
            this.newTransactionTabPage.Controls.Add(this.label2);
            this.newTransactionTabPage.Location = new System.Drawing.Point(4, 4);
            this.newTransactionTabPage.Name = "newTransactionTabPage";
            this.newTransactionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.newTransactionTabPage.Size = new System.Drawing.Size(974, 497);
            this.newTransactionTabPage.TabIndex = 0;
            this.newTransactionTabPage.Text = "New Transaction";
            this.newTransactionTabPage.UseVisualStyleBackColor = true;
            // 
            // transactionsNewCheckoutButton
            // 
            this.transactionsNewCheckoutButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.transactionsNewCheckoutButton.Location = new System.Drawing.Point(832, 63);
            this.transactionsNewCheckoutButton.Name = "transactionsNewCheckoutButton";
            this.transactionsNewCheckoutButton.Size = new System.Drawing.Size(110, 28);
            this.transactionsNewCheckoutButton.TabIndex = 8;
            this.transactionsNewCheckoutButton.Text = "Checkout";
            this.transactionsNewCheckoutButton.UseVisualStyleBackColor = true;
            // 
            // TransactionsNewDataGridView
            // 
            this.TransactionsNewDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.TransactionsNewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionsNewDataGridView.Location = new System.Drawing.Point(31, 121);
            this.TransactionsNewDataGridView.Name = "TransactionsNewDataGridView";
            this.TransactionsNewDataGridView.RowTemplate.Height = 25;
            this.TransactionsNewDataGridView.Size = new System.Drawing.Size(912, 342);
            this.TransactionsNewDataGridView.TabIndex = 7;
            // 
            // transactionsNewSearchButton
            // 
            this.transactionsNewSearchButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.transactionsNewSearchButton.Location = new System.Drawing.Point(716, 63);
            this.transactionsNewSearchButton.Name = "transactionsNewSearchButton";
            this.transactionsNewSearchButton.Size = new System.Drawing.Size(110, 28);
            this.transactionsNewSearchButton.TabIndex = 6;
            this.transactionsNewSearchButton.Text = "Search";
            this.transactionsNewSearchButton.UseVisualStyleBackColor = true;
            // 
            // exTextBox3
            // 
            this.exTextBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exTextBox3.Hint = "ex. 1234567-001";
            this.exTextBox3.Location = new System.Drawing.Point(210, 63);
            this.exTextBox3.Name = "exTextBox3";
            this.exTextBox3.Size = new System.Drawing.Size(500, 26);
            this.exTextBox3.TabIndex = 5;
            // 
            // transactionsCustomerIDTextBox
            // 
            this.transactionsCustomerIDTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.transactionsCustomerIDTextBox.Location = new System.Drawing.Point(210, 26);
            this.transactionsCustomerIDTextBox.Name = "transactionsCustomerIDTextBox";
            this.transactionsCustomerIDTextBox.Size = new System.Drawing.Size(500, 26);
            this.transactionsCustomerIDTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(96, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Movie Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(94, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer ID";
            // 
            // rentalHistoryTabPage
            // 
            this.rentalHistoryTabPage.Controls.Add(this.dataGridView5);
            this.rentalHistoryTabPage.Controls.Add(this.label4);
            this.rentalHistoryTabPage.Controls.Add(this.transactionsHistorySearchButton);
            this.rentalHistoryTabPage.Controls.Add(this.transactionsHistoryCustomerNameTextBox);
            this.rentalHistoryTabPage.Controls.Add(this.transactionsHistoryGenreComboBox);
            this.rentalHistoryTabPage.Controls.Add(this.transactionsHistoryMovieNameTextBox);
            this.rentalHistoryTabPage.Location = new System.Drawing.Point(4, 4);
            this.rentalHistoryTabPage.Name = "rentalHistoryTabPage";
            this.rentalHistoryTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.rentalHistoryTabPage.Size = new System.Drawing.Size(974, 497);
            this.rentalHistoryTabPage.TabIndex = 1;
            this.rentalHistoryTabPage.Text = "Rental History";
            this.rentalHistoryTabPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(31, 122);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowTemplate.Height = 25;
            this.dataGridView5.Size = new System.Drawing.Size(912, 342);
            this.dataGridView5.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(31, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Search History";
            // 
            // transactionsHistorySearchButton
            // 
            this.transactionsHistorySearchButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.transactionsHistorySearchButton.Location = new System.Drawing.Point(739, 84);
            this.transactionsHistorySearchButton.Name = "transactionsHistorySearchButton";
            this.transactionsHistorySearchButton.Size = new System.Drawing.Size(207, 28);
            this.transactionsHistorySearchButton.TabIndex = 3;
            this.transactionsHistorySearchButton.Text = "Search";
            this.transactionsHistorySearchButton.UseVisualStyleBackColor = true;
            // 
            // transactionsHistoryCustomerNameTextBox
            // 
            this.transactionsHistoryCustomerNameTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.transactionsHistoryCustomerNameTextBox.Hint = "Customer Name";
            this.transactionsHistoryCustomerNameTextBox.Location = new System.Drawing.Point(260, 85);
            this.transactionsHistoryCustomerNameTextBox.Name = "transactionsHistoryCustomerNameTextBox";
            this.transactionsHistoryCustomerNameTextBox.Size = new System.Drawing.Size(473, 26);
            this.transactionsHistoryCustomerNameTextBox.TabIndex = 2;
            // 
            // transactionsHistoryGenreComboBox
            // 
            this.transactionsHistoryGenreComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.transactionsHistoryGenreComboBox.FormattingEnabled = true;
            this.transactionsHistoryGenreComboBox.Items.AddRange(new object[] {
            "Comedy",
            "Drama",
            "Action",
            "Foreign"});
            this.transactionsHistoryGenreComboBox.Location = new System.Drawing.Point(31, 85);
            this.transactionsHistoryGenreComboBox.Name = "transactionsHistoryGenreComboBox";
            this.transactionsHistoryGenreComboBox.Size = new System.Drawing.Size(223, 26);
            this.transactionsHistoryGenreComboBox.TabIndex = 1;
            this.transactionsHistoryGenreComboBox.Text = "Genre";
            // 
            // transactionsHistoryMovieNameTextBox
            // 
            this.transactionsHistoryMovieNameTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.transactionsHistoryMovieNameTextBox.Hint = "Movie Name";
            this.transactionsHistoryMovieNameTextBox.Location = new System.Drawing.Point(31, 53);
            this.transactionsHistoryMovieNameTextBox.Name = "transactionsHistoryMovieNameTextBox";
            this.transactionsHistoryMovieNameTextBox.Size = new System.Drawing.Size(915, 26);
            this.transactionsHistoryMovieNameTextBox.TabIndex = 0;
            // 
            // reportsTabPage
            // 
            this.reportsTabPage.Controls.Add(this.reportsDataGridView);
            this.reportsTabPage.Controls.Add(this.report5Button);
            this.reportsTabPage.Controls.Add(this.report4Button);
            this.reportsTabPage.Controls.Add(this.report3Button);
            this.reportsTabPage.Controls.Add(this.report2Button);
            this.reportsTabPage.Controls.Add(this.report1Button);
            this.reportsTabPage.Controls.Add(this.reportsDescriptionTextBox);
            this.reportsTabPage.Controls.Add(this.label1);
            this.reportsTabPage.Location = new System.Drawing.Point(4, 24);
            this.reportsTabPage.Name = "reportsTabPage";
            this.reportsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.reportsTabPage.Size = new System.Drawing.Size(978, 534);
            this.reportsTabPage.TabIndex = 5;
            this.reportsTabPage.Text = "Reports";
            this.reportsTabPage.UseVisualStyleBackColor = true;
            // 
            // reportsDataGridView
            // 
            this.reportsDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.reportsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportsDataGridView.Location = new System.Drawing.Point(8, 82);
            this.reportsDataGridView.Name = "reportsDataGridView";
            this.reportsDataGridView.RowTemplate.Height = 25;
            this.reportsDataGridView.Size = new System.Drawing.Size(960, 407);
            this.reportsDataGridView.TabIndex = 9;
            // 
            // report5Button
            // 
            this.report5Button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.report5Button.Location = new System.Drawing.Point(448, 489);
            this.report5Button.Name = "report5Button";
            this.report5Button.Size = new System.Drawing.Size(104, 30);
            this.report5Button.TabIndex = 8;
            this.report5Button.Text = "Report 5";
            this.report5Button.UseVisualStyleBackColor = true;
            // 
            // report4Button
            // 
            this.report4Button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.report4Button.Location = new System.Drawing.Point(338, 489);
            this.report4Button.Name = "report4Button";
            this.report4Button.Size = new System.Drawing.Size(104, 30);
            this.report4Button.TabIndex = 7;
            this.report4Button.Text = "Report 4";
            this.report4Button.UseVisualStyleBackColor = true;
            // 
            // report3Button
            // 
            this.report3Button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.report3Button.Location = new System.Drawing.Point(228, 489);
            this.report3Button.Name = "report3Button";
            this.report3Button.Size = new System.Drawing.Size(104, 30);
            this.report3Button.TabIndex = 6;
            this.report3Button.Text = "Report 3";
            this.report3Button.UseVisualStyleBackColor = true;
            // 
            // report2Button
            // 
            this.report2Button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.report2Button.Location = new System.Drawing.Point(118, 489);
            this.report2Button.Name = "report2Button";
            this.report2Button.Size = new System.Drawing.Size(104, 30);
            this.report2Button.TabIndex = 5;
            this.report2Button.Text = "Report 2";
            this.report2Button.UseVisualStyleBackColor = true;
            // 
            // report1Button
            // 
            this.report1Button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.report1Button.Location = new System.Drawing.Point(8, 489);
            this.report1Button.Name = "report1Button";
            this.report1Button.Size = new System.Drawing.Size(104, 30);
            this.report1Button.TabIndex = 4;
            this.report1Button.Text = "Report 1";
            this.report1Button.UseVisualStyleBackColor = true;
            // 
            // reportsDescriptionTextBox
            // 
            this.reportsDescriptionTextBox.Location = new System.Drawing.Point(8, 24);
            this.reportsDescriptionTextBox.Name = "reportsDescriptionTextBox";
            this.reportsDescriptionTextBox.Size = new System.Drawing.Size(960, 23);
            this.reportsDescriptionTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Report Description";
            // 
            // Movie_ID
            // 
            this.Movie_ID.HeaderText = "Movie ID";
            this.Movie_ID.MinimumWidth = 150;
            this.Movie_ID.Name = "Movie_ID";
            this.Movie_ID.Width = 150;
            // 
            // Movie_name
            // 
            this.Movie_name.HeaderText = "Movie Title";
            this.Movie_name.MinimumWidth = 550;
            this.Movie_name.Name = "Movie_name";
            this.Movie_name.Width = 550;
            // 
            // EmployeeViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "EmployeeViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee View";
            this.tabControl1.ResumeLayout(false);
            this.moviesTabPage.ResumeLayout(false);
            this.moviesTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.actorsTabPage.ResumeLayout(false);
            this.actorsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.customersTabPage.ResumeLayout(false);
            this.customersTabControl.ResumeLayout(false);
            this.searchCustomersTabPage.ResumeLayout(false);
            this.searchCustomersTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.mailingListTabPage.ResumeLayout(false);
            this.mailingListTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.employeesTabPage.ResumeLayout(false);
            this.employeesTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchEmployeesDataGridView)).EndInit();
            this.transactionsTabPage.ResumeLayout(false);
            this.transactionsTabControl.ResumeLayout(false);
            this.newTransactionTabPage.ResumeLayout(false);
            this.newTransactionTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsNewDataGridView)).EndInit();
            this.rentalHistoryTabPage.ResumeLayout(false);
            this.rentalHistoryTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.reportsTabPage.ResumeLayout(false);
            this.reportsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage moviesTabPage;
        private TabPage actorsTabPage;
        private TabPage customersTabPage;
        private TabPage employeesTabPage;
        private TabPage reportsTabPage;
        private ExTextBox exTextBox1;
        private ComboBox genderComboBox;
        private ExTextBox lastNameTextBox;
        private ExTextBox firstNameTextBox;
        private Button actorsSearchButton;
        private DateTimePicker actorBirthdateDateTimePicker;
        private Button actorsAddButton;
        private DataGridView dataGridView1;
        private Button launchActorButton;
        private RadioButton allMoviesRadioButton;
        private RadioButton mostRentedRadioButton;
        private RadioButton searchFiltersRadioButton;
        private ExTextBox fromYearTextBox;
        private ComboBox genreComboBox;
        private ExTextBox actorsNamesTextBox;
        private ExTextBox movieNameTextBox;
        private ExTextBox toYearTextBox;
        private DataGridView dataGridView2;
        private Button button2;
        private TabControl customersTabControl;
        private TabPage searchCustomersTabPage;
        private TabPage mailingListTabPage;
        private TabPage transactionsTabPage;
        private TabControl transactionsTabControl;
        private TabPage newTransactionTabPage;
        private TabPage rentalHistoryTabPage;
        private Button launchCustomerButton;
        private Button searchCustomersButton;
        private ExTextBox searchCustomersTextBox;
        private DataGridView dataGridView3;
        private DataGridView dataGridView4;
        private Label mailingListLabel;
        private DataGridView searchEmployeesDataGridView;
        private Button button4;
        private Button button3;
        private ExTextBox exTextBox2;
        private DataGridView reportsDataGridView;
        private Button report5Button;
        private Button report4Button;
        private Button report3Button;
        private Button report2Button;
        private Button report1Button;
        private TextBox reportsDescriptionTextBox;
        private Label label1;
        private Button transactionsNewCheckoutButton;
        private DataGridView TransactionsNewDataGridView;
        private Button transactionsNewSearchButton;
        private ExTextBox exTextBox3;
        private TextBox transactionsCustomerIDTextBox;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView5;
        private Label label4;
        private Button transactionsHistorySearchButton;
        private ExTextBox transactionsHistoryCustomerNameTextBox;
        private ComboBox transactionsHistoryGenreComboBox;
        private ExTextBox transactionsHistoryMovieNameTextBox;
        private Button moviesAddMovieButton;
        private Button moviesSearchButton;
        private DataGridViewTextBoxColumn Movie_ID;
        private DataGridViewTextBoxColumn Movie_name;
    }
}