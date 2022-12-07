namespace MoviesApp
{
    partial class TransactionForm
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
            this.transactionNewCheckoutButton = new System.Windows.Forms.Button();
            this.transactionNewSearchButton = new System.Windows.Forms.Button();
            this.transactionMovieCodeTextBox = new MoviesApp.ExTextBox();
            this.transactionCustomerIDTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TransactionsNewDataGridView = new System.Windows.Forms.DataGridView();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.transactionNewCancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsNewDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // transactionNewCheckoutButton
            // 
            this.transactionNewCheckoutButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.transactionNewCheckoutButton.Location = new System.Drawing.Point(659, 410);
            this.transactionNewCheckoutButton.Name = "transactionNewCheckoutButton";
            this.transactionNewCheckoutButton.Size = new System.Drawing.Size(120, 28);
            this.transactionNewCheckoutButton.TabIndex = 14;
            this.transactionNewCheckoutButton.Text = "Checkout";
            this.transactionNewCheckoutButton.UseVisualStyleBackColor = true;
            this.transactionNewCheckoutButton.Click += new System.EventHandler(this.transactionNewCheckoutButton_Click);
            // 
            // transactionNewSearchButton
            // 
            this.transactionNewSearchButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.transactionNewSearchButton.Location = new System.Drawing.Point(652, 65);
            this.transactionNewSearchButton.Name = "transactionNewSearchButton";
            this.transactionNewSearchButton.Size = new System.Drawing.Size(120, 28);
            this.transactionNewSearchButton.TabIndex = 13;
            this.transactionNewSearchButton.Text = "Search";
            this.transactionNewSearchButton.UseVisualStyleBackColor = true;
            this.transactionNewSearchButton.Click += new System.EventHandler(this.transactionNewSearchButton_Click);
            // 
            // transactionMovieCodeTextBox
            // 
            this.transactionMovieCodeTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.transactionMovieCodeTextBox.Hint = "ex. 1234567-001";
            this.transactionMovieCodeTextBox.Location = new System.Drawing.Point(223, 65);
            this.transactionMovieCodeTextBox.Name = "transactionMovieCodeTextBox";
            this.transactionMovieCodeTextBox.Size = new System.Drawing.Size(407, 26);
            this.transactionMovieCodeTextBox.TabIndex = 12;
            // 
            // transactionCustomerIDTextBox
            // 
            this.transactionCustomerIDTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.transactionCustomerIDTextBox.Location = new System.Drawing.Point(223, 28);
            this.transactionCustomerIDTextBox.Name = "transactionCustomerIDTextBox";
            this.transactionCustomerIDTextBox.Size = new System.Drawing.Size(407, 26);
            this.transactionCustomerIDTextBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(109, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Movie Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(107, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Customer ID";
            // 
            // TransactionsNewDataGridView
            // 
            this.TransactionsNewDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.TransactionsNewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionsNewDataGridView.Location = new System.Drawing.Point(12, 112);
            this.TransactionsNewDataGridView.Name = "TransactionsNewDataGridView";
            this.TransactionsNewDataGridView.RowHeadersWidth = 51;
            this.TransactionsNewDataGridView.RowTemplate.Height = 25;
            this.TransactionsNewDataGridView.Size = new System.Drawing.Size(502, 272);
            this.TransactionsNewDataGridView.TabIndex = 15;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(545, 112);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 16;
            // 
            // transactionNewCancelButton
            // 
            this.transactionNewCancelButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.transactionNewCancelButton.Location = new System.Drawing.Point(533, 410);
            this.transactionNewCancelButton.Name = "transactionNewCancelButton";
            this.transactionNewCancelButton.Size = new System.Drawing.Size(120, 28);
            this.transactionNewCancelButton.TabIndex = 17;
            this.transactionNewCancelButton.Text = "Cancel";
            this.transactionNewCancelButton.UseVisualStyleBackColor = true;
            this.transactionNewCancelButton.Click += new System.EventHandler(this.transactionNewCancelButton_Click);
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.transactionNewCancelButton);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.TransactionsNewDataGridView);
            this.Controls.Add(this.transactionNewCheckoutButton);
            this.Controls.Add(this.transactionNewSearchButton);
            this.Controls.Add(this.transactionMovieCodeTextBox);
            this.Controls.Add(this.transactionCustomerIDTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "TransactionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee View - Transaction";
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsNewDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button transactionNewCheckoutButton;
        private Button transactionNewSearchButton;
        private ExTextBox transactionMovieCodeTextBox;
        private TextBox transactionCustomerIDTextBox;
        private Label label3;
        private Label label2;
        private DataGridView TransactionsNewDataGridView;
        private MonthCalendar monthCalendar1;
        private Button transactionNewCancelButton;
    }
}