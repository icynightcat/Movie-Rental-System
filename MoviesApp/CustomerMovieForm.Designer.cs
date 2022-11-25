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
            this.back = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
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
            this.label4.Location = new System.Drawing.Point(58, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name:";
            this.label4.Click += new System.EventHandler(this.movieName_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(52, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Genre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, 209);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Format:";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.back.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.back.Location = new System.Drawing.Point(75, 869);
            this.back.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(244, 72);
            this.back.TabIndex = 4;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.search.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.search.Location = new System.Drawing.Point(1453, 869);
            this.search.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(258, 72);
            this.search.TabIndex = 5;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(704, 339);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 32);
            this.label5.TabIndex = 6;
            // 
            // movieName
            // 
            this.movieName.AutoSize = true;
            this.movieName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.movieName.Location = new System.Drawing.Point(202, 83);
            this.movieName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.movieName.Name = "movieName";
            this.movieName.Size = new System.Drawing.Size(250, 36);
            this.movieName.TabIndex = 7;
            this.movieName.Text = "movieNameHere";
            // 
            // movieYear
            // 
            this.movieYear.AutoSize = true;
            this.movieYear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.movieYear.Location = new System.Drawing.Point(202, 157);
            this.movieYear.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.movieYear.Name = "movieYear";
            this.movieYear.Size = new System.Drawing.Size(0, 36);
            this.movieYear.TabIndex = 8;
            // 
            // movieGenre
            // 
            this.movieGenre.AutoSize = true;
            this.movieGenre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.movieGenre.Location = new System.Drawing.Point(202, 141);
            this.movieGenre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.movieGenre.Name = "movieGenre";
            this.movieGenre.Size = new System.Drawing.Size(254, 36);
            this.movieGenre.TabIndex = 9;
            this.movieGenre.Text = "movieGenreHere";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.monthCalendar1.Location = new System.Drawing.Point(1311, 64);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(15, 14, 15, 14);
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
            this.movieFormat.Location = new System.Drawing.Point(202, 209);
            this.movieFormat.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.movieFormat.Name = "movieFormat";
            this.movieFormat.Size = new System.Drawing.Size(293, 44);
            this.movieFormat.TabIndex = 11;
            // 
            // CustomerMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1810, 1141);
            this.Controls.Add(this.movieFormat);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.movieGenre);
            this.Controls.Add(this.movieYear);
            this.Controls.Add(this.movieName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.search);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximumSize = new System.Drawing.Size(1836, 1212);
            this.MinimumSize = new System.Drawing.Size(1836, 1212);
            this.Name = "CustomerMovieForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Movie Search Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button back;
        private Button search;
        private Label label5;
        private Label movieName;
        private Label movieYear;
        private Label movieGenre;
        private MonthCalendar monthCalendar1;
        private ComboBox movieFormat;
    }
}