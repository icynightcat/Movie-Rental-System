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
            this.movieAboutLabel = new System.Windows.Forms.Label();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.distrFeeTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.distrFeeLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.movieActorsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.actorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieCopiesDataGridView = new System.Windows.Forms.DataGridView();
            this.selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.movieDoneButton = new System.Windows.Forms.Button();
            this.deleteMovieButton = new System.Windows.Forms.Button();
            this.movieCopiesLabel = new System.Windows.Forms.Label();
            this.movieActorsLabel = new System.Windows.Forms.Label();
            this.empMovieEditButton = new System.Windows.Forms.Button();
            this.removeCopyButton = new System.Windows.Forms.Button();
            this.removeActorButton = new System.Windows.Forms.Button();
            this.addCopyComboBox = new System.Windows.Forms.ComboBox();
            this.addCopyButton = new System.Windows.Forms.Button();
            this.addCopyResComboBox = new System.Windows.Forms.ComboBox();
            this.actorSearchTextBox = new MoviesApp.ExTextBox();
            this.actorSearchListBox = new System.Windows.Forms.ListBox();
            this.clearActorSearchButton = new System.Windows.Forms.Button();
            this.addActorButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.movieActorsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieCopiesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // movieAboutLabel
            // 
            this.movieAboutLabel.AutoSize = true;
            this.movieAboutLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.movieAboutLabel.Location = new System.Drawing.Point(60, 15);
            this.movieAboutLabel.Name = "movieAboutLabel";
            this.movieAboutLabel.Size = new System.Drawing.Size(44, 18);
            this.movieAboutLabel.TabIndex = 11;
            this.movieAboutLabel.Text = "####";
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
            this.genreComboBox.Location = new System.Drawing.Point(186, 46);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(554, 26);
            this.genreComboBox.TabIndex = 10;
            this.genreComboBox.Text = "Genre";
            // 
            // distrFeeTextBox
            // 
            this.distrFeeTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.distrFeeTextBox.Location = new System.Drawing.Point(186, 82);
            this.distrFeeTextBox.Name = "distrFeeTextBox";
            this.distrFeeTextBox.ReadOnly = true;
            this.distrFeeTextBox.Size = new System.Drawing.Size(554, 26);
            this.distrFeeTextBox.TabIndex = 9;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleTextBox.Location = new System.Drawing.Point(186, 12);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.ReadOnly = true;
            this.titleTextBox.Size = new System.Drawing.Size(554, 26);
            this.titleTextBox.TabIndex = 7;
            // 
            // distrFeeLabel
            // 
            this.distrFeeLabel.AutoSize = true;
            this.distrFeeLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.distrFeeLabel.Location = new System.Drawing.Point(104, 85);
            this.distrFeeLabel.Name = "distrFeeLabel";
            this.distrFeeLabel.Size = new System.Drawing.Size(76, 18);
            this.distrFeeLabel.TabIndex = 5;
            this.distrFeeLabel.Text = "Distr. Fee";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genreLabel.Location = new System.Drawing.Point(129, 49);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(51, 18);
            this.genreLabel.TabIndex = 4;
            this.genreLabel.Text = "Genre";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(144, 15);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(36, 18);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Title";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idLabel.Location = new System.Drawing.Point(22, 15);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(23, 18);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "ID";
            // 
            // movieActorsDataGridView
            // 
            this.movieActorsDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.movieActorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movieActorsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.actorId,
            this.first_name,
            this.last_name,
            this.gender,
            this.age});
            this.movieActorsDataGridView.Location = new System.Drawing.Point(28, 356);
            this.movieActorsDataGridView.Name = "movieActorsDataGridView";
            this.movieActorsDataGridView.RowTemplate.Height = 25;
            this.movieActorsDataGridView.Size = new System.Drawing.Size(928, 150);
            this.movieActorsDataGridView.TabIndex = 1;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Selected";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Visible = false;
            // 
            // actorId
            // 
            this.actorId.HeaderText = "Actor Id";
            this.actorId.Name = "actorId";
            this.actorId.Visible = false;
            // 
            // first_name
            // 
            this.first_name.HeaderText = "First Name";
            this.first_name.MinimumWidth = 250;
            this.first_name.Name = "first_name";
            this.first_name.Width = 250;
            // 
            // last_name
            // 
            this.last_name.HeaderText = "Last Name";
            this.last_name.MinimumWidth = 250;
            this.last_name.Name = "last_name";
            this.last_name.Width = 250;
            // 
            // gender
            // 
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            // 
            // age
            // 
            this.age.HeaderText = "Age";
            this.age.Name = "age";
            // 
            // movieCopiesDataGridView
            // 
            this.movieCopiesDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.movieCopiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movieCopiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selected});
            this.movieCopiesDataGridView.Location = new System.Drawing.Point(28, 156);
            this.movieCopiesDataGridView.Name = "movieCopiesDataGridView";
            this.movieCopiesDataGridView.RowTemplate.Height = 25;
            this.movieCopiesDataGridView.Size = new System.Drawing.Size(928, 138);
            this.movieCopiesDataGridView.TabIndex = 2;
            // 
            // selected
            // 
            this.selected.HeaderText = "Selected";
            this.selected.Name = "selected";
            this.selected.Visible = false;
            // 
            // movieDoneButton
            // 
            this.movieDoneButton.Location = new System.Drawing.Point(806, 518);
            this.movieDoneButton.Name = "movieDoneButton";
            this.movieDoneButton.Size = new System.Drawing.Size(150, 28);
            this.movieDoneButton.TabIndex = 0;
            this.movieDoneButton.Text = "Done";
            this.movieDoneButton.UseVisualStyleBackColor = true;
            this.movieDoneButton.Click += new System.EventHandler(this.movieDoneButton_Click);
            // 
            // deleteMovieButton
            // 
            this.deleteMovieButton.Location = new System.Drawing.Point(28, 518);
            this.deleteMovieButton.Name = "deleteMovieButton";
            this.deleteMovieButton.Size = new System.Drawing.Size(150, 28);
            this.deleteMovieButton.TabIndex = 1;
            this.deleteMovieButton.Text = "Delete Movie";
            this.deleteMovieButton.UseVisualStyleBackColor = true;
            // 
            // movieCopiesLabel
            // 
            this.movieCopiesLabel.AutoSize = true;
            this.movieCopiesLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.movieCopiesLabel.Location = new System.Drawing.Point(28, 135);
            this.movieCopiesLabel.Name = "movieCopiesLabel";
            this.movieCopiesLabel.Size = new System.Drawing.Size(59, 18);
            this.movieCopiesLabel.TabIndex = 12;
            this.movieCopiesLabel.Text = "Copies";
            // 
            // movieActorsLabel
            // 
            this.movieActorsLabel.AutoSize = true;
            this.movieActorsLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.movieActorsLabel.Location = new System.Drawing.Point(28, 335);
            this.movieActorsLabel.Name = "movieActorsLabel";
            this.movieActorsLabel.Size = new System.Drawing.Size(53, 18);
            this.movieActorsLabel.TabIndex = 13;
            this.movieActorsLabel.Text = "Actors";
            // 
            // empMovieEditButton
            // 
            this.empMovieEditButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.empMovieEditButton.Location = new System.Drawing.Point(650, 517);
            this.empMovieEditButton.Name = "empMovieEditButton";
            this.empMovieEditButton.Size = new System.Drawing.Size(150, 28);
            this.empMovieEditButton.TabIndex = 14;
            this.empMovieEditButton.Text = "Edit";
            this.empMovieEditButton.UseVisualStyleBackColor = true;
            this.empMovieEditButton.Click += new System.EventHandler(this.empMovieEditButton_click);
            // 
            // removeCopyButton
            // 
            this.removeCopyButton.Location = new System.Drawing.Point(103, 130);
            this.removeCopyButton.Name = "removeCopyButton";
            this.removeCopyButton.Size = new System.Drawing.Size(150, 23);
            this.removeCopyButton.TabIndex = 15;
            this.removeCopyButton.Text = "Remove Selected";
            this.removeCopyButton.UseVisualStyleBackColor = true;
            this.removeCopyButton.Visible = false;
            this.removeCopyButton.Click += new System.EventHandler(this.removeCopyButton_click);
            // 
            // removeActorButton
            // 
            this.removeActorButton.Location = new System.Drawing.Point(104, 327);
            this.removeActorButton.Name = "removeActorButton";
            this.removeActorButton.Size = new System.Drawing.Size(150, 23);
            this.removeActorButton.TabIndex = 16;
            this.removeActorButton.Text = "Remove Selected";
            this.removeActorButton.UseVisualStyleBackColor = true;
            this.removeActorButton.Visible = false;
            this.removeActorButton.Click += new System.EventHandler(this.removeActorButton_click);
            // 
            // addCopyComboBox
            // 
            this.addCopyComboBox.FormattingEnabled = true;
            this.addCopyComboBox.Items.AddRange(new object[] {
            "Movie Type",
            "DVD",
            "Blue Ray",
            "Lazer Disk",
            "USB",
            "VHS"});
            this.addCopyComboBox.Location = new System.Drawing.Point(344, 128);
            this.addCopyComboBox.Name = "addCopyComboBox";
            this.addCopyComboBox.Size = new System.Drawing.Size(225, 23);
            this.addCopyComboBox.TabIndex = 17;
            this.addCopyComboBox.Text = "Movie Type";
            this.addCopyComboBox.Visible = false;
            // 
            // addCopyButton
            // 
            this.addCopyButton.Location = new System.Drawing.Point(806, 127);
            this.addCopyButton.Name = "addCopyButton";
            this.addCopyButton.Size = new System.Drawing.Size(150, 23);
            this.addCopyButton.TabIndex = 18;
            this.addCopyButton.Text = "Add";
            this.addCopyButton.UseVisualStyleBackColor = true;
            this.addCopyButton.Visible = false;
            // 
            // addCopyResComboBox
            // 
            this.addCopyResComboBox.FormattingEnabled = true;
            this.addCopyResComboBox.Items.AddRange(new object[] {
            "Resolution",
            "800x500",
            "1600x900",
            "19020x1080",
            "2560x1440"});
            this.addCopyResComboBox.Location = new System.Drawing.Point(575, 128);
            this.addCopyResComboBox.Name = "addCopyResComboBox";
            this.addCopyResComboBox.Size = new System.Drawing.Size(225, 23);
            this.addCopyResComboBox.TabIndex = 19;
            this.addCopyResComboBox.Text = "Resolution";
            this.addCopyResComboBox.Visible = false;
            // 
            // actorSearchTextBox
            // 
            this.actorSearchTextBox.Hint = "Type Actor Name";
            this.actorSearchTextBox.Location = new System.Drawing.Point(398, 330);
            this.actorSearchTextBox.Name = "actorSearchTextBox";
            this.actorSearchTextBox.Size = new System.Drawing.Size(342, 23);
            this.actorSearchTextBox.TabIndex = 20;
            this.actorSearchTextBox.Visible = false;
            this.actorSearchTextBox.TextChanged += new System.EventHandler(this.actorSearchTextBox_TextChanged);
            this.actorSearchTextBox.Leave += new System.EventHandler(this.actorSearchTextBox_Leave);
            this.actorSearchTextBox.MouseCaptureChanged += new System.EventHandler(this.actorSearchTextBox_Leave);
            // 
            // actorSearchListBox
            // 
            this.actorSearchListBox.FormattingEnabled = true;
            this.actorSearchListBox.ItemHeight = 15;
            this.actorSearchListBox.Location = new System.Drawing.Point(398, 352);
            this.actorSearchListBox.Name = "actorSearchListBox";
            this.actorSearchListBox.Size = new System.Drawing.Size(342, 94);
            this.actorSearchListBox.TabIndex = 21;
            this.actorSearchListBox.Visible = false;
            this.actorSearchListBox.Click += new System.EventHandler(this.actorSearchListBox_SelectedIndexChanged);
            // 
            // clearActorSearchButton
            // 
            this.clearActorSearchButton.Location = new System.Drawing.Point(744, 330);
            this.clearActorSearchButton.Name = "clearActorSearchButton";
            this.clearActorSearchButton.Size = new System.Drawing.Size(105, 23);
            this.clearActorSearchButton.TabIndex = 22;
            this.clearActorSearchButton.Text = "Clear";
            this.clearActorSearchButton.UseVisualStyleBackColor = true;
            this.clearActorSearchButton.Visible = false;
            this.clearActorSearchButton.Click += new System.EventHandler(this.clearActorSearchButton_Click);
            // 
            // addActorButton
            // 
            this.addActorButton.Location = new System.Drawing.Point(852, 330);
            this.addActorButton.Name = "addActorButton";
            this.addActorButton.Size = new System.Drawing.Size(105, 23);
            this.addActorButton.TabIndex = 23;
            this.addActorButton.Text = "Add";
            this.addActorButton.UseVisualStyleBackColor = true;
            this.addActorButton.Visible = false;
            this.addActorButton.Click += new System.EventHandler(this.addActorButton_Click);
            // 
            // MovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.addActorButton);
            this.Controls.Add(this.clearActorSearchButton);
            this.Controls.Add(this.actorSearchListBox);
            this.Controls.Add(this.actorSearchTextBox);
            this.Controls.Add(this.addCopyResComboBox);
            this.Controls.Add(this.addCopyButton);
            this.Controls.Add(this.addCopyComboBox);
            this.Controls.Add(this.removeActorButton);
            this.Controls.Add(this.removeCopyButton);
            this.Controls.Add(this.empMovieEditButton);
            this.Controls.Add(this.movieActorsLabel);
            this.Controls.Add(this.movieCopiesLabel);
            this.Controls.Add(this.movieCopiesDataGridView);
            this.Controls.Add(this.movieActorsDataGridView);
            this.Controls.Add(this.movieAboutLabel);
            this.Controls.Add(this.deleteMovieButton);
            this.Controls.Add(this.genreComboBox);
            this.Controls.Add(this.movieDoneButton);
            this.Controls.Add(this.distrFeeTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.distrFeeLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.titleLabel);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "MovieForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee View - Movie";
            this.Load += new System.EventHandler(this.MovieForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movieActorsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieCopiesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button movieDoneButton;
        private ComboBox genreComboBox;
        private TextBox distrFeeTextBox;
        private TextBox titleTextBox;
        private Label distrFeeLabel;
        private Label genreLabel;
        private Label titleLabel;
        private Label idLabel;
        private Button deleteMovieButton;
        private Label movieAboutLabel;
        private DataGridView movieActorsDataGridView;
        private DataGridView movieCopiesDataGridView;
        private Label movieCopiesLabel;
        private Label movieActorsLabel;
        private Button empMovieEditButton;
        private DataGridViewCheckBoxColumn selected;
        private Button removeCopyButton;
        private Button removeActorButton;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private DataGridViewTextBoxColumn actorId;
        private DataGridViewTextBoxColumn first_name;
        private DataGridViewTextBoxColumn last_name;
        private DataGridViewTextBoxColumn gender;
        private DataGridViewTextBoxColumn age;
        private ComboBox addCopyComboBox;
        private Button addCopyButton;
        private ComboBox addCopyResComboBox;
        private ExTextBox actorSearchTextBox;
        private ListBox actorSearchListBox;
        private Button clearActorSearchButton;
        private Button addActorButton;
    }
}