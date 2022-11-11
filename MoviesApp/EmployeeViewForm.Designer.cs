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
            this.button2 = new System.Windows.Forms.Button();
            this.toYearTextBox = new MoviesApp.ExTextBox();
            this.fromYearTextBox = new MoviesApp.ExTextBox();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.actorsNamesTextBox = new MoviesApp.ExTextBox();
            this.movieNameTextBox = new MoviesApp.ExTextBox();
            this.addActorButton = new System.Windows.Forms.Button();
            this.mostRentedRadioButton = new System.Windows.Forms.RadioButton();
            this.searchFiltersRadioButton = new System.Windows.Forms.RadioButton();
            this.allMoviesRadioButton = new System.Windows.Forms.RadioButton();
            this.launchMovieButton = new System.Windows.Forms.Button();
            this.actorsTabPage = new System.Windows.Forms.TabPage();
            this.launchActorButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.actorBirthdateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.lastNameTextBox = new MoviesApp.ExTextBox();
            this.firstNameTextBox = new MoviesApp.ExTextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.exTextBox1 = new MoviesApp.ExTextBox();
            this.customersTabPage = new System.Windows.Forms.TabPage();
            this.employeesTabPage = new System.Windows.Forms.TabPage();
            this.reportsTabPage = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.report1TabPage = new System.Windows.Forms.TabPage();
            this.report2TabPage = new System.Windows.Forms.TabPage();
            this.report3TabPage = new System.Windows.Forms.TabPage();
            this.report4TabPage = new System.Windows.Forms.TabPage();
            this.report5TabPage = new System.Windows.Forms.TabPage();
            this.transactionsTabControl = new System.Windows.Forms.TabControl();
            this.rentalHistoryTabPage = new System.Windows.Forms.TabPage();
            this.newTransactionTabPage = new System.Windows.Forms.TabPage();
            this.transactionsTabPage = new System.Windows.Forms.TabPage();
            this.customersTabControl = new System.Windows.Forms.TabControl();
            this.searchCustomersTabPage = new System.Windows.Forms.TabPage();
            this.mailingListTabPage = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.moviesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.actorsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.customersTabPage.SuspendLayout();
            this.reportsTabPage.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.transactionsTabControl.SuspendLayout();
            this.transactionsTabPage.SuspendLayout();
            this.customersTabControl.SuspendLayout();
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
            this.moviesTabPage.Controls.Add(this.button2);
            this.moviesTabPage.Controls.Add(this.toYearTextBox);
            this.moviesTabPage.Controls.Add(this.fromYearTextBox);
            this.moviesTabPage.Controls.Add(this.genreComboBox);
            this.moviesTabPage.Controls.Add(this.actorsNamesTextBox);
            this.moviesTabPage.Controls.Add(this.movieNameTextBox);
            this.moviesTabPage.Controls.Add(this.addActorButton);
            this.moviesTabPage.Controls.Add(this.mostRentedRadioButton);
            this.moviesTabPage.Controls.Add(this.searchFiltersRadioButton);
            this.moviesTabPage.Controls.Add(this.allMoviesRadioButton);
            this.moviesTabPage.Controls.Add(this.launchMovieButton);
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
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(17, 165);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(938, 344);
            this.dataGridView2.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(762, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 30);
            this.button2.TabIndex = 10;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
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
            // addActorButton
            // 
            this.addActorButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addActorButton.Location = new System.Drawing.Point(850, 6);
            this.addActorButton.Name = "addActorButton";
            this.addActorButton.Size = new System.Drawing.Size(105, 30);
            this.addActorButton.TabIndex = 4;
            this.addActorButton.Text = "Add Actor";
            this.addActorButton.UseVisualStyleBackColor = true;
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
            // 
            // launchMovieButton
            // 
            this.launchMovieButton.Location = new System.Drawing.Point(373, 136);
            this.launchMovieButton.Name = "launchMovieButton";
            this.launchMovieButton.Size = new System.Drawing.Size(232, 23);
            this.launchMovieButton.TabIndex = 0;
            this.launchMovieButton.Text = "Temporary Launch Movie";
            this.launchMovieButton.UseVisualStyleBackColor = true;
            this.launchMovieButton.Click += new System.EventHandler(this.launchMovieButton_Click);
            // 
            // actorsTabPage
            // 
            this.actorsTabPage.Controls.Add(this.launchActorButton);
            this.actorsTabPage.Controls.Add(this.dataGridView1);
            this.actorsTabPage.Controls.Add(this.button1);
            this.actorsTabPage.Controls.Add(this.actorBirthdateDateTimePicker);
            this.actorsTabPage.Controls.Add(this.genderComboBox);
            this.actorsTabPage.Controls.Add(this.lastNameTextBox);
            this.actorsTabPage.Controls.Add(this.firstNameTextBox);
            this.actorsTabPage.Controls.Add(this.searchButton);
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
            this.launchActorButton.Location = new System.Drawing.Point(402, 502);
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(858, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // actorBirthdateDateTimePicker
            // 
            this.actorBirthdateDateTimePicker.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.actorBirthdateDateTimePicker.CustomFormat = "MMM dd, yyyy";
            this.actorBirthdateDateTimePicker.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.actorBirthdateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.actorBirthdateDateTimePicker.Location = new System.Drawing.Point(700, 104);
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
            this.genderComboBox.Location = new System.Drawing.Point(599, 104);
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
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchButton.Location = new System.Drawing.Point(791, 18);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(154, 28);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
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
            // employeesTabPage
            // 
            this.employeesTabPage.Location = new System.Drawing.Point(4, 24);
            this.employeesTabPage.Name = "employeesTabPage";
            this.employeesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.employeesTabPage.Size = new System.Drawing.Size(978, 534);
            this.employeesTabPage.TabIndex = 3;
            this.employeesTabPage.Text = "Employees";
            this.employeesTabPage.UseVisualStyleBackColor = true;
            // 
            // reportsTabPage
            // 
            this.reportsTabPage.Controls.Add(this.tabControl2);
            this.reportsTabPage.Location = new System.Drawing.Point(4, 24);
            this.reportsTabPage.Name = "reportsTabPage";
            this.reportsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.reportsTabPage.Size = new System.Drawing.Size(978, 534);
            this.reportsTabPage.TabIndex = 5;
            this.reportsTabPage.Text = "Reports";
            this.reportsTabPage.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl2.Controls.Add(this.report1TabPage);
            this.tabControl2.Controls.Add(this.report2TabPage);
            this.tabControl2.Controls.Add(this.report3TabPage);
            this.tabControl2.Controls.Add(this.report4TabPage);
            this.tabControl2.Controls.Add(this.report5TabPage);
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(982, 525);
            this.tabControl2.TabIndex = 0;
            // 
            // report1TabPage
            // 
            this.report1TabPage.Location = new System.Drawing.Point(4, 4);
            this.report1TabPage.Name = "report1TabPage";
            this.report1TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.report1TabPage.Size = new System.Drawing.Size(974, 497);
            this.report1TabPage.TabIndex = 0;
            this.report1TabPage.Text = "Report 1";
            this.report1TabPage.UseVisualStyleBackColor = true;
            // 
            // report2TabPage
            // 
            this.report2TabPage.Location = new System.Drawing.Point(4, 4);
            this.report2TabPage.Name = "report2TabPage";
            this.report2TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.report2TabPage.Size = new System.Drawing.Size(974, 497);
            this.report2TabPage.TabIndex = 1;
            this.report2TabPage.Text = "Report 2";
            this.report2TabPage.UseVisualStyleBackColor = true;
            // 
            // report3TabPage
            // 
            this.report3TabPage.Location = new System.Drawing.Point(4, 4);
            this.report3TabPage.Name = "report3TabPage";
            this.report3TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.report3TabPage.Size = new System.Drawing.Size(974, 397);
            this.report3TabPage.TabIndex = 2;
            this.report3TabPage.Text = "Report 3";
            this.report3TabPage.UseVisualStyleBackColor = true;
            // 
            // report4TabPage
            // 
            this.report4TabPage.Location = new System.Drawing.Point(4, 4);
            this.report4TabPage.Name = "report4TabPage";
            this.report4TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.report4TabPage.Size = new System.Drawing.Size(974, 397);
            this.report4TabPage.TabIndex = 3;
            this.report4TabPage.Text = "Report4";
            this.report4TabPage.UseVisualStyleBackColor = true;
            // 
            // report5TabPage
            // 
            this.report5TabPage.Location = new System.Drawing.Point(4, 4);
            this.report5TabPage.Name = "report5TabPage";
            this.report5TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.report5TabPage.Size = new System.Drawing.Size(974, 497);
            this.report5TabPage.TabIndex = 4;
            this.report5TabPage.Text = "Report 5";
            this.report5TabPage.UseVisualStyleBackColor = true;
            // 
            // transactionsTabControl
            // 
            this.transactionsTabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.transactionsTabControl.Controls.Add(this.newTransactionTabPage);
            this.transactionsTabControl.Controls.Add(this.rentalHistoryTabPage);
            this.transactionsTabControl.Location = new System.Drawing.Point(-2, 5);
            this.transactionsTabControl.Name = "transactionsTabControl";
            this.transactionsTabControl.SelectedIndex = 0;
            this.transactionsTabControl.Size = new System.Drawing.Size(982, 525);
            this.transactionsTabControl.TabIndex = 1;
            // 
            // rentalHistoryTabPage
            // 
            this.rentalHistoryTabPage.Location = new System.Drawing.Point(4, 4);
            this.rentalHistoryTabPage.Name = "rentalHistoryTabPage";
            this.rentalHistoryTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.rentalHistoryTabPage.Size = new System.Drawing.Size(974, 497);
            this.rentalHistoryTabPage.TabIndex = 1;
            this.rentalHistoryTabPage.Text = "Rental History";
            this.rentalHistoryTabPage.UseVisualStyleBackColor = true;
            // 
            // newTransactionTabPage
            // 
            this.newTransactionTabPage.Location = new System.Drawing.Point(4, 4);
            this.newTransactionTabPage.Name = "newTransactionTabPage";
            this.newTransactionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.newTransactionTabPage.Size = new System.Drawing.Size(974, 497);
            this.newTransactionTabPage.TabIndex = 0;
            this.newTransactionTabPage.Text = "New Transaction";
            this.newTransactionTabPage.UseVisualStyleBackColor = true;
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
            // customersTabControl
            // 
            this.customersTabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.customersTabControl.Controls.Add(this.searchCustomersTabPage);
            this.customersTabControl.Controls.Add(this.mailingListTabPage);
            this.customersTabControl.Location = new System.Drawing.Point(-2, 5);
            this.customersTabControl.Name = "customersTabControl";
            this.customersTabControl.SelectedIndex = 0;
            this.customersTabControl.Size = new System.Drawing.Size(982, 525);
            this.customersTabControl.TabIndex = 2;
            // 
            // searchCustomersTabPage
            // 
            this.searchCustomersTabPage.Location = new System.Drawing.Point(4, 4);
            this.searchCustomersTabPage.Name = "searchCustomersTabPage";
            this.searchCustomersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.searchCustomersTabPage.Size = new System.Drawing.Size(974, 497);
            this.searchCustomersTabPage.TabIndex = 0;
            this.searchCustomersTabPage.Text = "Search Customers";
            this.searchCustomersTabPage.UseVisualStyleBackColor = true;
            // 
            // mailingListTabPage
            // 
            this.mailingListTabPage.Location = new System.Drawing.Point(4, 4);
            this.mailingListTabPage.Name = "mailingListTabPage";
            this.mailingListTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.mailingListTabPage.Size = new System.Drawing.Size(974, 497);
            this.mailingListTabPage.TabIndex = 1;
            this.mailingListTabPage.Text = "Mailing List";
            this.mailingListTabPage.UseVisualStyleBackColor = true;
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
            this.reportsTabPage.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.transactionsTabControl.ResumeLayout(false);
            this.transactionsTabPage.ResumeLayout(false);
            this.customersTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage moviesTabPage;
        private TabPage actorsTabPage;
        private TabPage customersTabPage;
        private TabPage employeesTabPage;
        private TabPage reportsTabPage;
        private TabControl tabControl2;
        private TabPage report1TabPage;
        private TabPage report2TabPage;
        private TabPage report3TabPage;
        private TabPage report4TabPage;
        private TabPage report5TabPage;
        private Button launchMovieButton;
        private ExTextBox exTextBox1;
        private ComboBox genderComboBox;
        private ExTextBox lastNameTextBox;
        private ExTextBox firstNameTextBox;
        private Button searchButton;
        private DateTimePicker actorBirthdateDateTimePicker;
        private Button button1;
        private DataGridView dataGridView1;
        private Button launchActorButton;
        private RadioButton allMoviesRadioButton;
        private Button addActorButton;
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
    }
}