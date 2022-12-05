namespace MoviesApp
{
    partial class ActorForm
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
            this.actorMoviesDataGridView = new System.Windows.Forms.DataGridView();
            this.actorSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.actorMovieId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieActsIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.actorFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.actorLastNameTextBox = new System.Windows.Forms.TextBox();
            this.actorAgeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.actorGenderComboBox = new System.Windows.Forms.ComboBox();
            this.actorIdLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.actorDoneButton = new System.Windows.Forms.Button();
            this.actorCancelButton = new System.Windows.Forms.Button();
            this.actorEditButton = new System.Windows.Forms.Button();
            this.deleteActorButton = new System.Windows.Forms.Button();
            this.removeActorMovieButton = new System.Windows.Forms.Button();
            this.actorMovieSearchTextBox = new MoviesApp.ExTextBox();
            this.clearActorMovieSearchButton = new System.Windows.Forms.Button();
            this.addActorMovieButton = new System.Windows.Forms.Button();
            this.actorMovieSearchListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.actorMoviesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // actorMoviesDataGridView
            // 
            this.actorMoviesDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.actorMoviesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.actorMoviesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.actorSelected,
            this.actorMovieId,
            this.movieActsIn});
            this.actorMoviesDataGridView.Location = new System.Drawing.Point(28, 186);
            this.actorMoviesDataGridView.Name = "actorMoviesDataGridView";
            this.actorMoviesDataGridView.RowTemplate.Height = 25;
            this.actorMoviesDataGridView.Size = new System.Drawing.Size(928, 332);
            this.actorMoviesDataGridView.TabIndex = 1;
            // 
            // actorSelected
            // 
            this.actorSelected.HeaderText = "Selected";
            this.actorSelected.Name = "actorSelected";
            this.actorSelected.Visible = false;
            this.actorSelected.Width = 80;
            // 
            // actorMovieId
            // 
            this.actorMovieId.HeaderText = "Id";
            this.actorMovieId.Name = "actorMovieId";
            this.actorMovieId.Visible = false;
            // 
            // movieActsIn
            // 
            this.movieActsIn.HeaderText = "Movie Title";
            this.movieActsIn.MinimumWidth = 800;
            this.movieActsIn.Name = "movieActsIn";
            this.movieActsIn.Width = 800;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Movies";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // actorFirstNameTextBox
            // 
            this.actorFirstNameTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.actorFirstNameTextBox.Location = new System.Drawing.Point(227, 32);
            this.actorFirstNameTextBox.Name = "actorFirstNameTextBox";
            this.actorFirstNameTextBox.ReadOnly = true;
            this.actorFirstNameTextBox.Size = new System.Drawing.Size(571, 26);
            this.actorFirstNameTextBox.TabIndex = 4;
            // 
            // actorLastNameTextBox
            // 
            this.actorLastNameTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.actorLastNameTextBox.Location = new System.Drawing.Point(227, 64);
            this.actorLastNameTextBox.Name = "actorLastNameTextBox";
            this.actorLastNameTextBox.ReadOnly = true;
            this.actorLastNameTextBox.Size = new System.Drawing.Size(571, 26);
            this.actorLastNameTextBox.TabIndex = 5;
            // 
            // actorAgeTextBox
            // 
            this.actorAgeTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.actorAgeTextBox.Location = new System.Drawing.Point(558, 96);
            this.actorAgeTextBox.Name = "actorAgeTextBox";
            this.actorAgeTextBox.ReadOnly = true;
            this.actorAgeTextBox.Size = new System.Drawing.Size(240, 26);
            this.actorAgeTextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(116, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(116, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(500, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(140, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gender";
            // 
            // actorGenderComboBox
            // 
            this.actorGenderComboBox.Enabled = false;
            this.actorGenderComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.actorGenderComboBox.FormattingEnabled = true;
            this.actorGenderComboBox.Items.AddRange(new object[] {
            "Gender",
            "Female",
            "Male"});
            this.actorGenderComboBox.Location = new System.Drawing.Point(227, 96);
            this.actorGenderComboBox.Name = "actorGenderComboBox";
            this.actorGenderComboBox.Size = new System.Drawing.Size(234, 26);
            this.actorGenderComboBox.TabIndex = 11;
            this.actorGenderComboBox.Text = "Gender";
            // 
            // actorIdLabel
            // 
            this.actorIdLabel.AutoSize = true;
            this.actorIdLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.actorIdLabel.Location = new System.Drawing.Point(87, 9);
            this.actorIdLabel.Name = "actorIdLabel";
            this.actorIdLabel.Size = new System.Drawing.Size(44, 18);
            this.actorIdLabel.TabIndex = 12;
            this.actorIdLabel.Text = "####";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Actor ID:";
            // 
            // actorDoneButton
            // 
            this.actorDoneButton.Location = new System.Drawing.Point(807, 521);
            this.actorDoneButton.Name = "actorDoneButton";
            this.actorDoneButton.Size = new System.Drawing.Size(150, 28);
            this.actorDoneButton.TabIndex = 14;
            this.actorDoneButton.Text = "Save";
            this.actorDoneButton.UseVisualStyleBackColor = true;
            this.actorDoneButton.Click += new System.EventHandler(this.actorDoneButton_Click);
            // 
            // actorCancelButton
            // 
            this.actorCancelButton.Location = new System.Drawing.Point(651, 521);
            this.actorCancelButton.Name = "actorCancelButton";
            this.actorCancelButton.Size = new System.Drawing.Size(150, 28);
            this.actorCancelButton.TabIndex = 29;
            this.actorCancelButton.Text = "Cancel";
            this.actorCancelButton.UseVisualStyleBackColor = true;
            this.actorCancelButton.Click += new System.EventHandler(this.actorCancelButton_Click);
            // 
            // actorEditButton
            // 
            this.actorEditButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.actorEditButton.Location = new System.Drawing.Point(495, 521);
            this.actorEditButton.Name = "actorEditButton";
            this.actorEditButton.Size = new System.Drawing.Size(150, 28);
            this.actorEditButton.TabIndex = 30;
            this.actorEditButton.Text = "Edit";
            this.actorEditButton.UseVisualStyleBackColor = true;
            this.actorEditButton.Click += new System.EventHandler(this.empActorEditButton_click);
            // 
            // deleteActorButton
            // 
            this.deleteActorButton.Location = new System.Drawing.Point(28, 521);
            this.deleteActorButton.Name = "deleteActorButton";
            this.deleteActorButton.Size = new System.Drawing.Size(150, 28);
            this.deleteActorButton.TabIndex = 31;
            this.deleteActorButton.Text = "Delete Actor";
            this.deleteActorButton.UseVisualStyleBackColor = true;
            this.deleteActorButton.Click += new System.EventHandler(this.actorDeleteButton_Click);
            // 
            // removeActorMovieButton
            // 
            this.removeActorMovieButton.Location = new System.Drawing.Point(140, 160);
            this.removeActorMovieButton.Name = "removeActorMovieButton";
            this.removeActorMovieButton.Size = new System.Drawing.Size(150, 23);
            this.removeActorMovieButton.TabIndex = 32;
            this.removeActorMovieButton.Text = "Remove Selected";
            this.removeActorMovieButton.UseVisualStyleBackColor = true;
            this.removeActorMovieButton.Visible = false;
            this.removeActorMovieButton.Click += new System.EventHandler(this.removeActorMovieButton_click);
            // 
            // actorMovieSearchTextBox
            // 
            this.actorMovieSearchTextBox.Hint = "Type Movie Name";
            this.actorMovieSearchTextBox.Location = new System.Drawing.Point(400, 157);
            this.actorMovieSearchTextBox.Name = "actorMovieSearchTextBox";
            this.actorMovieSearchTextBox.Size = new System.Drawing.Size(342, 23);
            this.actorMovieSearchTextBox.TabIndex = 33;
            this.actorMovieSearchTextBox.Visible = false;
            this.actorMovieSearchTextBox.TextChanged += new System.EventHandler(this.actorMovieSearchTextBox_TextChanged);
            this.actorMovieSearchTextBox.Leave += new System.EventHandler(this.movieSearchTextBox_Leave);
            this.actorMovieSearchTextBox.MouseCaptureChanged += new System.EventHandler(this.movieSearchTextBox_Leave);
            // 
            // clearActorMovieSearchButton
            // 
            this.clearActorMovieSearchButton.Location = new System.Drawing.Point(745, 157);
            this.clearActorMovieSearchButton.Name = "clearActorMovieSearchButton";
            this.clearActorMovieSearchButton.Size = new System.Drawing.Size(105, 23);
            this.clearActorMovieSearchButton.TabIndex = 34;
            this.clearActorMovieSearchButton.Text = "Clear";
            this.clearActorMovieSearchButton.UseVisualStyleBackColor = true;
            this.clearActorMovieSearchButton.Visible = false;
            this.clearActorMovieSearchButton.Click += new System.EventHandler(this.clearActorMovieSearchButton_Click);
            // 
            // addActorMovieButton
            // 
            this.addActorMovieButton.Location = new System.Drawing.Point(852, 157);
            this.addActorMovieButton.Name = "addActorMovieButton";
            this.addActorMovieButton.Size = new System.Drawing.Size(105, 23);
            this.addActorMovieButton.TabIndex = 35;
            this.addActorMovieButton.Text = "Add";
            this.addActorMovieButton.UseVisualStyleBackColor = true;
            this.addActorMovieButton.Visible = false;
            this.addActorMovieButton.Click += new System.EventHandler(this.addActorMovieButton_Click);
            // 
            // actorMovieSearchListBox
            // 
            this.actorMovieSearchListBox.FormattingEnabled = true;
            this.actorMovieSearchListBox.ItemHeight = 15;
            this.actorMovieSearchListBox.Location = new System.Drawing.Point(400, 180);
            this.actorMovieSearchListBox.Name = "actorMovieSearchListBox";
            this.actorMovieSearchListBox.Size = new System.Drawing.Size(342, 94);
            this.actorMovieSearchListBox.TabIndex = 36;
            this.actorMovieSearchListBox.Visible = false;
            this.actorMovieSearchListBox.Click += new System.EventHandler(this.actorMovieSearchListBox_SelectedIndexChanged);
            // 
            // ActorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.actorMovieSearchListBox);
            this.Controls.Add(this.addActorMovieButton);
            this.Controls.Add(this.clearActorMovieSearchButton);
            this.Controls.Add(this.actorMovieSearchTextBox);
            this.Controls.Add(this.removeActorMovieButton);
            this.Controls.Add(this.deleteActorButton);
            this.Controls.Add(this.actorEditButton);
            this.Controls.Add(this.actorCancelButton);
            this.Controls.Add(this.actorDoneButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.actorIdLabel);
            this.Controls.Add(this.actorGenderComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.actorAgeTextBox);
            this.Controls.Add(this.actorLastNameTextBox);
            this.Controls.Add(this.actorFirstNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.actorMoviesDataGridView);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "ActorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee View - Actor";
            this.Load += new System.EventHandler(this.ActorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.actorMoviesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView actorMoviesDataGridView;
        private Label label1;
        private TextBox actorFirstNameTextBox;
        private TextBox actorLastNameTextBox;
        private TextBox actorAgeTextBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox actorGenderComboBox;
        private Label actorIdLabel;
        private Label label6;
        private Button actorDoneButton;
        private Button actorCancelButton;
        private Button actorEditButton;
        private Button deleteActorButton;
        private Button removeActorMovieButton;
        private ExTextBox actorMovieSearchTextBox;
        private Button clearActorMovieSearchButton;
        private Button addActorMovieButton;
        private ListBox actorMovieSearchListBox;
        private DataGridViewCheckBoxColumn actorSelected;
        private DataGridViewTextBoxColumn actorMovieId;
        private DataGridViewTextBoxColumn movieActsIn;
    }
}