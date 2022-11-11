namespace MoviesApp
{
    partial class MovieForm
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
            this.movieAboutTabPage = new System.Windows.Forms.TabPage();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.distrFeeTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.distrFeeLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.movieActorsTabPage = new System.Windows.Forms.TabPage();
            this.movieCopiesTabPage = new System.Windows.Forms.TabPage();
            this.movieDoneButton = new System.Windows.Forms.Button();
            this.deleteMovieButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.movieAboutTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.movieAboutTabPage);
            this.tabControl1.Controls.Add(this.movieActorsTabPage);
            this.tabControl1.Controls.Add(this.movieCopiesTabPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(985, 515);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // movieAboutTabPage
            // 
            this.movieAboutTabPage.Controls.Add(this.genreComboBox);
            this.movieAboutTabPage.Controls.Add(this.distrFeeTextBox);
            this.movieAboutTabPage.Controls.Add(this.yearTextBox);
            this.movieAboutTabPage.Controls.Add(this.titleTextBox);
            this.movieAboutTabPage.Controls.Add(this.idTextBox);
            this.movieAboutTabPage.Controls.Add(this.distrFeeLabel);
            this.movieAboutTabPage.Controls.Add(this.genreLabel);
            this.movieAboutTabPage.Controls.Add(this.yearLabel);
            this.movieAboutTabPage.Controls.Add(this.titleLabel);
            this.movieAboutTabPage.Controls.Add(this.idLabel);
            this.movieAboutTabPage.Location = new System.Drawing.Point(4, 24);
            this.movieAboutTabPage.Name = "movieAboutTabPage";
            this.movieAboutTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.movieAboutTabPage.Size = new System.Drawing.Size(977, 487);
            this.movieAboutTabPage.TabIndex = 0;
            this.movieAboutTabPage.Text = "About";
            this.movieAboutTabPage.UseVisualStyleBackColor = true;
            // 
            // genreComboBox
            // 
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Items.AddRange(new object[] {
            "Comedy",
            "Drama",
            "Action",
            "Foreign"});
            this.genreComboBox.Location = new System.Drawing.Point(313, 272);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(463, 23);
            this.genreComboBox.TabIndex = 10;
            this.genreComboBox.Text = "Genre";
            // 
            // distrFeeTextBox
            // 
            this.distrFeeTextBox.Location = new System.Drawing.Point(313, 308);
            this.distrFeeTextBox.Name = "distrFeeTextBox";
            this.distrFeeTextBox.Size = new System.Drawing.Size(463, 23);
            this.distrFeeTextBox.TabIndex = 9;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(313, 237);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(463, 23);
            this.yearTextBox.TabIndex = 8;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(313, 200);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(463, 23);
            this.titleTextBox.TabIndex = 7;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(313, 165);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(463, 23);
            this.idTextBox.TabIndex = 6;
            // 
            // distrFeeLabel
            // 
            this.distrFeeLabel.AutoSize = true;
            this.distrFeeLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.distrFeeLabel.Location = new System.Drawing.Point(200, 313);
            this.distrFeeLabel.Name = "distrFeeLabel";
            this.distrFeeLabel.Size = new System.Drawing.Size(76, 18);
            this.distrFeeLabel.TabIndex = 5;
            this.distrFeeLabel.Text = "Distr. Fee";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genreLabel.Location = new System.Drawing.Point(225, 272);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(51, 18);
            this.genreLabel.TabIndex = 4;
            this.genreLabel.Text = "Genre";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yearLabel.Location = new System.Drawing.Point(237, 237);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(39, 18);
            this.yearLabel.TabIndex = 3;
            this.yearLabel.Text = "Year";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(240, 200);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(36, 18);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Title";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idLabel.Location = new System.Drawing.Point(253, 165);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(23, 18);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "ID";
            // 
            // movieActorsTabPage
            // 
            this.movieActorsTabPage.Location = new System.Drawing.Point(4, 24);
            this.movieActorsTabPage.Name = "movieActorsTabPage";
            this.movieActorsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.movieActorsTabPage.Size = new System.Drawing.Size(977, 497);
            this.movieActorsTabPage.TabIndex = 1;
            this.movieActorsTabPage.Text = "Actors";
            this.movieActorsTabPage.UseVisualStyleBackColor = true;
            // 
            // movieCopiesTabPage
            // 
            this.movieCopiesTabPage.Location = new System.Drawing.Point(4, 24);
            this.movieCopiesTabPage.Name = "movieCopiesTabPage";
            this.movieCopiesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.movieCopiesTabPage.Size = new System.Drawing.Size(977, 497);
            this.movieCopiesTabPage.TabIndex = 2;
            this.movieCopiesTabPage.Text = "Copies";
            this.movieCopiesTabPage.UseVisualStyleBackColor = true;
            // 
            // movieDoneButton
            // 
            this.movieDoneButton.Location = new System.Drawing.Point(831, 521);
            this.movieDoneButton.Name = "movieDoneButton";
            this.movieDoneButton.Size = new System.Drawing.Size(150, 30);
            this.movieDoneButton.TabIndex = 0;
            this.movieDoneButton.Text = "Done";
            this.movieDoneButton.UseVisualStyleBackColor = true;
            this.movieDoneButton.Click += new System.EventHandler(this.movieDoneButton_Click);
            // 
            // deleteMovieButton
            // 
            this.deleteMovieButton.Location = new System.Drawing.Point(4, 521);
            this.deleteMovieButton.Name = "deleteMovieButton";
            this.deleteMovieButton.Size = new System.Drawing.Size(150, 30);
            this.deleteMovieButton.TabIndex = 1;
            this.deleteMovieButton.Text = "Delete Movie";
            this.deleteMovieButton.UseVisualStyleBackColor = true;
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.deleteMovieButton);
            this.Controls.Add(this.movieDoneButton);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "MovieForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee View - Movie";
            this.tabControl1.ResumeLayout(false);
            this.movieAboutTabPage.ResumeLayout(false);
            this.movieAboutTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage movieAboutTabPage;
        private TabPage movieActorsTabPage;
        private TabPage movieCopiesTabPage;
        private Button movieDoneButton;
        private ComboBox genreComboBox;
        private TextBox distrFeeTextBox;
        private TextBox yearTextBox;
        private TextBox titleTextBox;
        private TextBox idTextBox;
        private Label distrFeeLabel;
        private Label genreLabel;
        private Label yearLabel;
        private Label titleLabel;
        private Label idLabel;
        private Button deleteMovieButton;
    }
}