namespace MoviesApp
{
    partial class CustomerMovieForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backButtonOnCustMovForm = new System.Windows.Forms.Button();
            this.rentCustMovie = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.movieName = new System.Windows.Forms.Label();
            this.movieYear = new System.Windows.Forms.Label();
            this.movieGenre = new System.Windows.Forms.Label();
            this.movieFormat = new System.Windows.Forms.ComboBox();
            this.dateToRent = new System.Windows.Forms.DateTimePicker();
            this.dateToReturn = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(100, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name:";
            this.label4.Click += new System.EventHandler(this.movieName_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(95, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Genre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose format:";
            // 
            // backButtonOnCustMovForm
            // 
            this.backButtonOnCustMovForm.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.backButtonOnCustMovForm.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backButtonOnCustMovForm.Location = new System.Drawing.Point(40, 407);
            this.backButtonOnCustMovForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButtonOnCustMovForm.Name = "backButtonOnCustMovForm";
            this.backButtonOnCustMovForm.Size = new System.Drawing.Size(131, 34);
            this.backButtonOnCustMovForm.TabIndex = 4;
            this.backButtonOnCustMovForm.Text = "Back";
            this.backButtonOnCustMovForm.UseVisualStyleBackColor = false;
            this.backButtonOnCustMovForm.Click += new System.EventHandler(this.backButtonCustMovie);
            // 
            // rentCustMovie
            // 
            this.rentCustMovie.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rentCustMovie.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rentCustMovie.Location = new System.Drawing.Point(782, 407);
            this.rentCustMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rentCustMovie.Name = "rentCustMovie";
            this.rentCustMovie.Size = new System.Drawing.Size(139, 34);
            this.rentCustMovie.TabIndex = 5;
            this.rentCustMovie.Text = "Rent";
            this.rentCustMovie.UseVisualStyleBackColor = false;
            this.rentCustMovie.Click += new System.EventHandler(this.rentButtonCustMovie);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(379, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 15);
            this.label5.TabIndex = 6;
            // 
            // movieName
            // 
            this.movieName.AutoSize = true;
            this.movieName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.movieName.Location = new System.Drawing.Point(174, 39);
            this.movieName.Name = "movieName";
            this.movieName.Size = new System.Drawing.Size(126, 18);
            this.movieName.TabIndex = 7;
            this.movieName.Text = "movieNameHere";
            // 
            // movieYear
            // 
            this.movieYear.AutoSize = true;
            this.movieYear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.movieYear.Location = new System.Drawing.Point(108, 74);
            this.movieYear.Name = "movieYear";
            this.movieYear.Size = new System.Drawing.Size(0, 18);
            this.movieYear.TabIndex = 8;
            // 
            // movieGenre
            // 
            this.movieGenre.AutoSize = true;
            this.movieGenre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.movieGenre.Location = new System.Drawing.Point(174, 66);
            this.movieGenre.Name = "movieGenre";
            this.movieGenre.Size = new System.Drawing.Size(127, 18);
            this.movieGenre.TabIndex = 9;
            this.movieGenre.Text = "movieGenreHere";
            this.movieGenre.Click += new System.EventHandler(this.movieGenre_Click);
            // 
            // movieFormat
            // 
            this.movieFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.movieFormat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.movieFormat.FormattingEnabled = true;
            this.movieFormat.Items.AddRange(new object[] {
            "Blue Ray",
            "DVD",
            "USB",
            "VHS",
            "Lazer Disk"});
            this.movieFormat.Location = new System.Drawing.Point(174, 98);
            this.movieFormat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.movieFormat.Name = "movieFormat";
            this.movieFormat.Size = new System.Drawing.Size(160, 26);
            this.movieFormat.TabIndex = 11;
            // 
            // dateToRent
            // 
            this.dateToRent.Location = new System.Drawing.Point(675, 38);
            this.dateToRent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateToRent.Name = "dateToRent";
            this.dateToRent.Size = new System.Drawing.Size(239, 23);
            this.dateToRent.TabIndex = 12;
            // 
            // dateToReturn
            // 
            this.dateToReturn.Location = new System.Drawing.Point(675, 102);
            this.dateToReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateToReturn.Name = "dateToReturn";
            this.dateToReturn.Size = new System.Drawing.Size(239, 23);
            this.dateToReturn.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(507, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Enter rental date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(507, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Enter return date:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(80, 159);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 16;
            // 
            // CustomerMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateToReturn);
            this.Controls.Add(this.dateToRent);
            this.Controls.Add(this.movieFormat);
            this.Controls.Add(this.movieGenre);
            this.Controls.Add(this.movieYear);
            this.Controls.Add(this.movieName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rentCustMovie);
            this.Controls.Add(this.backButtonOnCustMovForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "CustomerMovieForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Movie Search Form";
            this.Load += new System.EventHandler(this.CustomerMovieForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private Label label2;
        private Label label1;
        private Button backButtonOnCustMovForm;
        private Button rentCustMovie;
        private Label label5;
        private Label movieName;
        private Label movieYear;
        private Label movieGenre;
        private ComboBox movieFormat;
        private DateTimePicker dateToRent;
        private DateTimePicker dateToReturn;
        private Label label3;
        private Label label6;
        private MonthCalendar monthCalendar1;
    }
}