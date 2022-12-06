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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.movieFormat = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(36, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name:";
            this.label4.Click += new System.EventHandler(this.movieName_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(32, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Genre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Format:";
            // 
            // backButtonOnCustMovForm
            // 
            this.backButtonOnCustMovForm.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.backButtonOnCustMovForm.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.backButtonOnCustMovForm.Location = new System.Drawing.Point(46, 543);
            this.backButtonOnCustMovForm.Name = "backButtonOnCustMovForm";
            this.backButtonOnCustMovForm.Size = new System.Drawing.Size(150, 45);
            this.backButtonOnCustMovForm.TabIndex = 4;
            this.backButtonOnCustMovForm.Text = "Back";
            this.backButtonOnCustMovForm.UseVisualStyleBackColor = false;
            this.backButtonOnCustMovForm.Click += new System.EventHandler(this.backButtonCustMovie);
            // 
            // rentCustMovie
            // 
            this.rentCustMovie.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.rentCustMovie.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rentCustMovie.Location = new System.Drawing.Point(894, 543);
            this.rentCustMovie.Name = "rentCustMovie";
            this.rentCustMovie.Size = new System.Drawing.Size(159, 45);
            this.rentCustMovie.TabIndex = 5;
            this.rentCustMovie.Text = "Rent";
            this.rentCustMovie.UseVisualStyleBackColor = false;
            this.rentCustMovie.Click += new System.EventHandler(this.rentButtonCustMovie);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(433, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 6;
            // 
            // movieName
            // 
            this.movieName.AutoSize = true;
            this.movieName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.movieName.Location = new System.Drawing.Point(124, 52);
            this.movieName.Name = "movieName";
            this.movieName.Size = new System.Drawing.Size(154, 23);
            this.movieName.TabIndex = 7;
            this.movieName.Text = "movieNameHere";
            // 
            // movieYear
            // 
            this.movieYear.AutoSize = true;
            this.movieYear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.movieYear.Location = new System.Drawing.Point(124, 98);
            this.movieYear.Name = "movieYear";
            this.movieYear.Size = new System.Drawing.Size(0, 23);
            this.movieYear.TabIndex = 8;
            // 
            // movieGenre
            // 
            this.movieGenre.AutoSize = true;
            this.movieGenre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.movieGenre.Location = new System.Drawing.Point(124, 88);
            this.movieGenre.Name = "movieGenre";
            this.movieGenre.Size = new System.Drawing.Size(158, 23);
            this.movieGenre.TabIndex = 9;
            this.movieGenre.Text = "movieGenreHere";
            this.movieGenre.Click += new System.EventHandler(this.movieGenre_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.monthCalendar1.Location = new System.Drawing.Point(807, 40);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 10;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // movieFormat
            // 
            this.movieFormat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.movieFormat.FormattingEnabled = true;
            this.movieFormat.Items.AddRange(new object[] {
            "Blu-Ray",
            "DVD"});
            this.movieFormat.Location = new System.Drawing.Point(124, 131);
            this.movieFormat.Name = "movieFormat";
            this.movieFormat.Size = new System.Drawing.Size(182, 31);
            this.movieFormat.TabIndex = 11;
            // 
            // CustomerMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 659);
            this.Controls.Add(this.movieFormat);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.movieGenre);
            this.Controls.Add(this.movieYear);
            this.Controls.Add(this.movieName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rentCustMovie);
            this.Controls.Add(this.backButtonOnCustMovForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.MaximumSize = new System.Drawing.Size(1137, 775);
            this.MinimumSize = new System.Drawing.Size(1137, 660);
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
        private MonthCalendar monthCalendar1;
        private ComboBox movieFormat;
    }
}