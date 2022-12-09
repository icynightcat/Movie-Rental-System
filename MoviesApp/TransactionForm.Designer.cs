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
            this.transactionCustomerIDTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.transactionNewCancelButton = new System.Windows.Forms.Button();
            this.txCustNameTextbox = new System.Windows.Forms.TextBox();
            this.txCustName = new System.Windows.Forms.Label();
            this.txOrderIdTextBox = new System.Windows.Forms.TextBox();
            this.txOrderId = new System.Windows.Forms.Label();
            this.txStartTextBox = new System.Windows.Forms.TextBox();
            this.txStart = new System.Windows.Forms.Label();
            this.txEndTextBox = new System.Windows.Forms.TextBox();
            this.txEndDate = new System.Windows.Forms.Label();
            this.txMovieNameTextBox = new System.Windows.Forms.TextBox();
            this.txMovieName = new System.Windows.Forms.Label();
            this.txCIDTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txEmpIdTextBox = new System.Windows.Forms.TextBox();
            this.txEmployeeId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // transactionNewCheckoutButton
            // 
            this.transactionNewCheckoutButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.transactionNewCheckoutButton.Location = new System.Drawing.Point(1224, 875);
            this.transactionNewCheckoutButton.Margin = new System.Windows.Forms.Padding(6);
            this.transactionNewCheckoutButton.Name = "transactionNewCheckoutButton";
            this.transactionNewCheckoutButton.Size = new System.Drawing.Size(223, 60);
            this.transactionNewCheckoutButton.TabIndex = 14;
            this.transactionNewCheckoutButton.Text = "Confirm";
            this.transactionNewCheckoutButton.UseVisualStyleBackColor = true;
            this.transactionNewCheckoutButton.Click += new System.EventHandler(this.transactionNewCheckoutButton_Click);
            // 
            // transactionCustomerIDTextBox
            // 
            this.transactionCustomerIDTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.transactionCustomerIDTextBox.Location = new System.Drawing.Point(414, 60);
            this.transactionCustomerIDTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.transactionCustomerIDTextBox.Name = "transactionCustomerIDTextBox";
            this.transactionCustomerIDTextBox.ReadOnly = true;
            this.transactionCustomerIDTextBox.Size = new System.Drawing.Size(752, 44);
            this.transactionCustomerIDTextBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(199, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 36);
            this.label2.TabIndex = 9;
            this.label2.Text = "Customer ID";
            // 
            // transactionNewCancelButton
            // 
            this.transactionNewCancelButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.transactionNewCancelButton.Location = new System.Drawing.Point(990, 875);
            this.transactionNewCancelButton.Margin = new System.Windows.Forms.Padding(6);
            this.transactionNewCancelButton.Name = "transactionNewCancelButton";
            this.transactionNewCancelButton.Size = new System.Drawing.Size(223, 60);
            this.transactionNewCancelButton.TabIndex = 17;
            this.transactionNewCancelButton.Text = "Cancel";
            this.transactionNewCancelButton.UseVisualStyleBackColor = true;
            this.transactionNewCancelButton.Click += new System.EventHandler(this.transactionNewCancelButton_Click);
            // 
            // txCustNameTextbox
            // 
            this.txCustNameTextbox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txCustNameTextbox.Location = new System.Drawing.Point(414, 119);
            this.txCustNameTextbox.Margin = new System.Windows.Forms.Padding(6);
            this.txCustNameTextbox.Name = "txCustNameTextbox";
            this.txCustNameTextbox.ReadOnly = true;
            this.txCustNameTextbox.Size = new System.Drawing.Size(752, 44);
            this.txCustNameTextbox.TabIndex = 19;
            // 
            // txCustName
            // 
            this.txCustName.AutoSize = true;
            this.txCustName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txCustName.Location = new System.Drawing.Point(147, 127);
            this.txCustName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txCustName.Name = "txCustName";
            this.txCustName.Size = new System.Drawing.Size(246, 36);
            this.txCustName.TabIndex = 18;
            this.txCustName.Text = "Customer Name";
            // 
            // txOrderIdTextBox
            // 
            this.txOrderIdTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txOrderIdTextBox.Location = new System.Drawing.Point(414, 175);
            this.txOrderIdTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.txOrderIdTextBox.Name = "txOrderIdTextBox";
            this.txOrderIdTextBox.ReadOnly = true;
            this.txOrderIdTextBox.Size = new System.Drawing.Size(752, 44);
            this.txOrderIdTextBox.TabIndex = 21;
            // 
            // txOrderId
            // 
            this.txOrderId.AutoSize = true;
            this.txOrderId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txOrderId.Location = new System.Drawing.Point(262, 183);
            this.txOrderId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txOrderId.Name = "txOrderId";
            this.txOrderId.Size = new System.Drawing.Size(131, 36);
            this.txOrderId.TabIndex = 20;
            this.txOrderId.Text = "Order Id";
            // 
            // txStartTextBox
            // 
            this.txStartTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txStartTextBox.Location = new System.Drawing.Point(414, 231);
            this.txStartTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.txStartTextBox.Name = "txStartTextBox";
            this.txStartTextBox.ReadOnly = true;
            this.txStartTextBox.Size = new System.Drawing.Size(752, 44);
            this.txStartTextBox.TabIndex = 23;
            // 
            // txStart
            // 
            this.txStart.AutoSize = true;
            this.txStart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txStart.Location = new System.Drawing.Point(236, 239);
            this.txStart.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txStart.Name = "txStart";
            this.txStart.Size = new System.Drawing.Size(157, 36);
            this.txStart.TabIndex = 22;
            this.txStart.Text = "Start Date";
            // 
            // txEndTextBox
            // 
            this.txEndTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txEndTextBox.Location = new System.Drawing.Point(414, 287);
            this.txEndTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.txEndTextBox.Name = "txEndTextBox";
            this.txEndTextBox.ReadOnly = true;
            this.txEndTextBox.Size = new System.Drawing.Size(752, 44);
            this.txEndTextBox.TabIndex = 25;
            // 
            // txEndDate
            // 
            this.txEndDate.AutoSize = true;
            this.txEndDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txEndDate.Location = new System.Drawing.Point(247, 295);
            this.txEndDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txEndDate.Name = "txEndDate";
            this.txEndDate.Size = new System.Drawing.Size(146, 36);
            this.txEndDate.TabIndex = 24;
            this.txEndDate.Text = "End Date";
            // 
            // txMovieNameTextBox
            // 
            this.txMovieNameTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txMovieNameTextBox.Location = new System.Drawing.Point(414, 353);
            this.txMovieNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.txMovieNameTextBox.Name = "txMovieNameTextBox";
            this.txMovieNameTextBox.ReadOnly = true;
            this.txMovieNameTextBox.Size = new System.Drawing.Size(752, 44);
            this.txMovieNameTextBox.TabIndex = 27;
            // 
            // txMovieName
            // 
            this.txMovieName.AutoSize = true;
            this.txMovieName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txMovieName.Location = new System.Drawing.Point(199, 359);
            this.txMovieName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txMovieName.Name = "txMovieName";
            this.txMovieName.Size = new System.Drawing.Size(191, 36);
            this.txMovieName.TabIndex = 26;
            this.txMovieName.Text = "Movie Name";
            // 
            // txCIDTextBox
            // 
            this.txCIDTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txCIDTextBox.Location = new System.Drawing.Point(414, 479);
            this.txCIDTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.txCIDTextBox.Name = "txCIDTextBox";
            this.txCIDTextBox.ReadOnly = true;
            this.txCIDTextBox.Size = new System.Drawing.Size(752, 44);
            this.txCIDTextBox.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(259, 487);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 36);
            this.label7.TabIndex = 28;
            this.label7.Text = "Copy ID";
            // 
            // txEmpIdTextBox
            // 
            this.txEmpIdTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txEmpIdTextBox.Location = new System.Drawing.Point(414, 414);
            this.txEmpIdTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.txEmpIdTextBox.Name = "txEmpIdTextBox";
            this.txEmpIdTextBox.ReadOnly = true;
            this.txEmpIdTextBox.Size = new System.Drawing.Size(752, 44);
            this.txEmpIdTextBox.TabIndex = 31;
            // 
            // txEmployeeId
            // 
            this.txEmployeeId.AutoSize = true;
            this.txEmployeeId.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txEmployeeId.Location = new System.Drawing.Point(199, 420);
            this.txEmployeeId.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txEmployeeId.Name = "txEmployeeId";
            this.txEmployeeId.Size = new System.Drawing.Size(188, 36);
            this.txEmployeeId.TabIndex = 30;
            this.txEmployeeId.Text = "Employee Id";
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 960);
            this.Controls.Add(this.txEmpIdTextBox);
            this.Controls.Add(this.txEmployeeId);
            this.Controls.Add(this.txCIDTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txMovieNameTextBox);
            this.Controls.Add(this.txMovieName);
            this.Controls.Add(this.txEndTextBox);
            this.Controls.Add(this.txEndDate);
            this.Controls.Add(this.txStartTextBox);
            this.Controls.Add(this.txStart);
            this.Controls.Add(this.txOrderIdTextBox);
            this.Controls.Add(this.txOrderId);
            this.Controls.Add(this.txCustNameTextbox);
            this.Controls.Add(this.txCustName);
            this.Controls.Add(this.transactionNewCancelButton);
            this.Controls.Add(this.transactionNewCheckoutButton);
            this.Controls.Add(this.transactionCustomerIDTextBox);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TransactionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee View - Transaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button transactionNewCheckoutButton;
        private ExTextBox transactionMovieCodeTextBox;
        private TextBox transactionCustomerIDTextBox;
        private Label txOrderId;
        private Label label2;
        private Button transactionNewCancelButton;
        private TextBox txCustNameTextbox;
        private Label txCustName;
        private TextBox txOrderIdTextBox;
        private TextBox txStartTextBox;
        private Label txStart;
        private TextBox txEndTextBox;
        private Label txEndDate;
        private TextBox txMovieNameTextBox;
        private Label txMovieName;
        private TextBox txCIDTextBox;
        private Label label7;
        private TextBox txEmpIdTextBox;
        private Label txEmployeeId;
    }
}