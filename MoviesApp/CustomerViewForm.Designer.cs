namespace MoviesApp
{
    partial class CustomerViewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label39 = new System.Windows.Forms.Label();
            this.custMovieSearch = new System.Windows.Forms.Button();
            this.label36 = new System.Windows.Forms.Label();
            this.movieGenre = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.saveChanges = new System.Windows.Forms.Button();
            this.label31 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.planType = new System.Windows.Forms.Label();
            this.accountNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.movieTitleSearch = new MoviesApp.ExTextBox();
            this.actorSearch = new MoviesApp.ExTextBox();
            this.yearToSearch = new MoviesApp.ExTextBox();
            this.yearFromSearch = new MoviesApp.ExTextBox();
            this.custFirstName = new MoviesApp.ExTextBox();
            this.custLastName = new MoviesApp.ExTextBox();
            this.custAddress = new MoviesApp.ExTextBox();
            this.custCity = new MoviesApp.ExTextBox();
            this.custState = new MoviesApp.ExTextBox();
            this.custZipCode = new MoviesApp.ExTextBox();
            this.custPhoneNumber = new MoviesApp.ExTextBox();
            this.custCreditCardNumber = new MoviesApp.ExTextBox();
            this.custExpiryDate = new MoviesApp.ExTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(1, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1120, 742);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label46);
            this.tabPage1.Controls.Add(this.label45);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1112, 709);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label46.Location = new System.Drawing.Point(7, 362);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(193, 24);
            this.label46.TabIndex = 2;
            this.label46.Text = "Top 15 Best Sellers";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label45.Location = new System.Drawing.Point(7, 14);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(223, 24);
            this.label45.TabIndex = 0;
            this.label45.Text = "Recommended Movies";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.yearFromSearch);
            this.tabPage2.Controls.Add(this.yearToSearch);
            this.tabPage2.Controls.Add(this.actorSearch);
            this.tabPage2.Controls.Add(this.movieTitleSearch);
            this.tabPage2.Controls.Add(this.label39);
            this.tabPage2.Controls.Add(this.custMovieSearch);
            this.tabPage2.Controls.Add(this.label36);
            this.tabPage2.Controls.Add(this.movieGenre);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1112, 709);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label39.Location = new System.Drawing.Point(20, 232);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(153, 24);
            this.label39.TabIndex = 12;
            this.label39.Text = "Search Results";
            this.label39.Visible = false;
            // 
            // custMovieSearch
            // 
            this.custMovieSearch.BackColor = System.Drawing.Color.LightGray;
            this.custMovieSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.custMovieSearch.Location = new System.Drawing.Point(852, 77);
            this.custMovieSearch.Name = "custMovieSearch";
            this.custMovieSearch.Size = new System.Drawing.Size(176, 57);
            this.custMovieSearch.TabIndex = 10;
            this.custMovieSearch.Text = "Search";
            this.custMovieSearch.UseVisualStyleBackColor = false;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label36.Location = new System.Drawing.Point(20, 125);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(75, 24);
            this.label36.TabIndex = 5;
            this.label36.Text = "Genre:";
            // 
            // movieGenre
            // 
            this.movieGenre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.movieGenre.FormattingEnabled = true;
            this.movieGenre.Items.AddRange(new object[] {
            "Comedy",
            "Drama",
            "Action",
            "Foreign"});
            this.movieGenre.Location = new System.Drawing.Point(101, 125);
            this.movieGenre.Name = "movieGenre";
            this.movieGenre.Size = new System.Drawing.Size(182, 31);
            this.movieGenre.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.custExpiryDate);
            this.tabPage3.Controls.Add(this.custCreditCardNumber);
            this.tabPage3.Controls.Add(this.custPhoneNumber);
            this.tabPage3.Controls.Add(this.custZipCode);
            this.tabPage3.Controls.Add(this.custState);
            this.tabPage3.Controls.Add(this.custCity);
            this.tabPage3.Controls.Add(this.custAddress);
            this.tabPage3.Controls.Add(this.custLastName);
            this.tabPage3.Controls.Add(this.custFirstName);
            this.tabPage3.Controls.Add(this.saveChanges);
            this.tabPage3.Controls.Add(this.label31);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.tableLayoutPanel1);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.planType);
            this.tabPage3.Controls.Add(this.accountNumber);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1112, 709);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "My Account";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click_1);
            // 
            // saveChanges
            // 
            this.saveChanges.BackColor = System.Drawing.Color.LightGray;
            this.saveChanges.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveChanges.Location = new System.Drawing.Point(776, 635);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(251, 45);
            this.saveChanges.TabIndex = 27;
            this.saveChanges.Text = "Save Changes";
            this.saveChanges.UseVisualStyleBackColor = false;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label31.Location = new System.Drawing.Point(10, 513);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(239, 27);
            this.label31.TabIndex = 22;
            this.label31.Text = "Payment Information";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(7, 322);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(233, 27);
            this.label19.TabIndex = 11;
            this.label19.Text = "Contact Information";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.68226F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.31774F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 266F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 245F));
            this.tableLayoutPanel1.Controls.Add(this.label15, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label16, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label14, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label13, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label12, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label11, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(28, 133);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.23809F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.76191F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1025, 121);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(782, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 23);
            this.label15.TabIndex = 10;
            this.label15.Text = "No limit";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(516, 74);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 23);
            this.label16.TabIndex = 11;
            this.label16.Text = "No limit";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(263, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 23);
            this.label14.TabIndex = 9;
            this.label14.Text = "No limit";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(782, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(171, 23);
            this.label13.TabIndex = 8;
            this.label13.Text = "3 movies at a time";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(516, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(171, 23);
            this.label12.TabIndex = 8;
            this.label12.Text = "2 movies at a time";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(263, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 23);
            this.label11.TabIndex = 8;
            this.label11.Text = "1 movie at a time";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(3, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(229, 23);
            this.label10.TabIndex = 8;
            this.label10.Text = "Limit 2 movies per month";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(3, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 23);
            this.label9.TabIndex = 7;
            this.label9.Text = "1 movie at a time";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(782, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Plan 4";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(516, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "Plan 3";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(263, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 24);
            this.label8.TabIndex = 10;
            this.label8.Text = "Plan 2";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Plan 1";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(476, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Available Plans";
            // 
            // planType
            // 
            this.planType.AutoSize = true;
            this.planType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.planType.Location = new System.Drawing.Point(602, 58);
            this.planType.Name = "planType";
            this.planType.Size = new System.Drawing.Size(62, 24);
            this.planType.TabIndex = 5;
            this.planType.Text = "Plan#";
            this.planType.Visible = false;
            // 
            // accountNumber
            // 
            this.accountNumber.AutoSize = true;
            this.accountNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.accountNumber.Location = new System.Drawing.Point(204, 57);
            this.accountNumber.Name = "accountNumber";
            this.accountNumber.Size = new System.Drawing.Size(99, 24);
            this.accountNumber.TabIndex = 4;
            this.accountNumber.Text = "Account#";
            this.accountNumber.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(473, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Plan Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(7, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Information";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1112, 709);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Order";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1112, 709);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Wishlist";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(105, 357);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(839, 30);
            this.textBox2.TabIndex = 13;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(10, 360);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(89, 23);
            this.label21.TabIndex = 12;
            this.label21.Text = "Address:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label22.Location = new System.Drawing.Point(7, 322);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(233, 27);
            this.label22.TabIndex = 11;
            this.label22.Text = "Contact Information";
            this.label22.Click += new System.EventHandler(this.label19_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(627, 274);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(317, 30);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(135, 274);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(317, 30);
            this.textBox4.TabIndex = 9;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(489, 277);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(111, 23);
            this.label23.TabIndex = 8;
            this.label23.Text = "Last Name:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label24.Location = new System.Drawing.Point(7, 277);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(112, 23);
            this.label24.TabIndex = 7;
            this.label24.Text = "First Name:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.68226F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.31774F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 266F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 245F));
            this.tableLayoutPanel2.Controls.Add(this.label25, 3, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label25.Location = new System.Drawing.Point(-41, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(74, 23);
            this.label25.TabIndex = 10;
            this.label25.Text = "No limit";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label26.Location = new System.Drawing.Point(-307, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(74, 23);
            this.label26.TabIndex = 11;
            this.label26.Text = "No limit";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.textBox2);
            this.tabPage6.Controls.Add(this.label21);
            this.tabPage6.Controls.Add(this.label22);
            this.tabPage6.Controls.Add(this.textBox3);
            this.tabPage6.Controls.Add(this.textBox4);
            this.tabPage6.Controls.Add(this.label23);
            this.tabPage6.Controls.Add(this.label24);
            this.tabPage6.Location = new System.Drawing.Point(0, 0);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(200, 100);
            this.tabPage6.TabIndex = 0;
            // 
            // movieTitleSearch
            // 
            this.movieTitleSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.movieTitleSearch.Hint = "Title";
            this.movieTitleSearch.Location = new System.Drawing.Point(20, 29);
            this.movieTitleSearch.Name = "movieTitleSearch";
            this.movieTitleSearch.Size = new System.Drawing.Size(777, 30);
            this.movieTitleSearch.TabIndex = 13;
            // 
            // actorSearch
            // 
            this.actorSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.actorSearch.Hint = "Actor#1, Actor#2, etc.";
            this.actorSearch.Location = new System.Drawing.Point(20, 80);
            this.actorSearch.Name = "actorSearch";
            this.actorSearch.Size = new System.Drawing.Size(777, 30);
            this.actorSearch.TabIndex = 14;
            // 
            // yearToSearch
            // 
            this.yearToSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yearToSearch.Hint = "Year To";
            this.yearToSearch.Location = new System.Drawing.Point(20, 177);
            this.yearToSearch.Name = "yearToSearch";
            this.yearToSearch.Size = new System.Drawing.Size(377, 30);
            this.yearToSearch.TabIndex = 15;
            // 
            // yearFromSearch
            // 
            this.yearFromSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yearFromSearch.Hint = "Year From";
            this.yearFromSearch.Location = new System.Drawing.Point(420, 177);
            this.yearFromSearch.Name = "yearFromSearch";
            this.yearFromSearch.Size = new System.Drawing.Size(377, 30);
            this.yearFromSearch.TabIndex = 16;
            // 
            // custFirstName
            // 
            this.custFirstName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.custFirstName.Hint = "First Name";
            this.custFirstName.Location = new System.Drawing.Point(10, 277);
            this.custFirstName.Name = "custFirstName";
            this.custFirstName.Size = new System.Drawing.Size(455, 30);
            this.custFirstName.TabIndex = 28;
            // 
            // custLastName
            // 
            this.custLastName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.custLastName.Hint = "Last Name";
            this.custLastName.Location = new System.Drawing.Point(489, 277);
            this.custLastName.Name = "custLastName";
            this.custLastName.Size = new System.Drawing.Size(455, 30);
            this.custLastName.TabIndex = 29;
            // 
            // custAddress
            // 
            this.custAddress.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.custAddress.Hint = "Address";
            this.custAddress.Location = new System.Drawing.Point(10, 365);
            this.custAddress.Name = "custAddress";
            this.custAddress.Size = new System.Drawing.Size(934, 30);
            this.custAddress.TabIndex = 30;
            // 
            // custCity
            // 
            this.custCity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.custCity.Hint = "City";
            this.custCity.Location = new System.Drawing.Point(10, 413);
            this.custCity.Name = "custCity";
            this.custCity.Size = new System.Drawing.Size(455, 30);
            this.custCity.TabIndex = 31;
            // 
            // custState
            // 
            this.custState.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.custState.Hint = "State";
            this.custState.Location = new System.Drawing.Point(489, 413);
            this.custState.Name = "custState";
            this.custState.Size = new System.Drawing.Size(455, 30);
            this.custState.TabIndex = 32;
            // 
            // custZipCode
            // 
            this.custZipCode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.custZipCode.Hint = "Zip Code";
            this.custZipCode.Location = new System.Drawing.Point(10, 462);
            this.custZipCode.Name = "custZipCode";
            this.custZipCode.Size = new System.Drawing.Size(455, 30);
            this.custZipCode.TabIndex = 33;
            // 
            // custPhoneNumber
            // 
            this.custPhoneNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.custPhoneNumber.Hint = "Phone Number";
            this.custPhoneNumber.Location = new System.Drawing.Point(489, 462);
            this.custPhoneNumber.Name = "custPhoneNumber";
            this.custPhoneNumber.Size = new System.Drawing.Size(455, 30);
            this.custPhoneNumber.TabIndex = 34;
            // 
            // custCreditCardNumber
            // 
            this.custCreditCardNumber.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.custCreditCardNumber.Hint = "Credit Card Number";
            this.custCreditCardNumber.Location = new System.Drawing.Point(10, 555);
            this.custCreditCardNumber.Name = "custCreditCardNumber";
            this.custCreditCardNumber.Size = new System.Drawing.Size(934, 30);
            this.custCreditCardNumber.TabIndex = 35;
            // 
            // custExpiryDate
            // 
            this.custExpiryDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.custExpiryDate.Hint = "Expiry Date";
            this.custExpiryDate.Location = new System.Drawing.Point(10, 600);
            this.custExpiryDate.Name = "custExpiryDate";
            this.custExpiryDate.Size = new System.Drawing.Size(455, 30);
            this.custExpiryDate.TabIndex = 36;
            // 
            // CustomerViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 737);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1140, 784);
            this.MinimumSize = new System.Drawing.Size(1140, 784);
            this.Name = "CustomerViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer View";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Label label1;
        private Label planType;
        private Label accountNumber;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label8;
        private Label label7;
        private Label label6;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label5;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label15;
        private Label label16;
        private Label label19;
        private Button saveChanges;
        private Label label31;
        private TextBox textBox2;
        private Label label21;
        private Label label22;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label23;
        private Label label24;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label25;
        private Label label26;
        private TabPage tabPage6;
        private Label label36;
        private ComboBox movieGenre;
        private Label label39;
        private Button custMovieSearch;
        private Label label46;
        private Label label45;
        private ExTextBox yearFromSearch;
        private ExTextBox yearToSearch;
        private ExTextBox actorSearch;
        private ExTextBox movieTitleSearch;
        private ExTextBox custExpiryDate;
        private ExTextBox custCreditCardNumber;
        private ExTextBox custPhoneNumber;
        private ExTextBox custZipCode;
        private ExTextBox custState;
        private ExTextBox custCity;
        private ExTextBox custAddress;
        private ExTextBox custLastName;
        private ExTextBox custFirstName;
    }
}