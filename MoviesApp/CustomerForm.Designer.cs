namespace MoviesApp
{
    partial class CustomerForm
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
            this.viewCustomerTabControl = new System.Windows.Forms.TabControl();
            this.accountInfoTabPage = new System.Windows.Forms.TabPage();
            this.contactTabPage = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.currentRentalsTabPage = new System.Windows.Forms.TabPage();
            this.historyTabPage = new System.Windows.Forms.TabPage();
            this.suggestTabPage = new System.Windows.Forms.TabPage();
            this.viewCustomerTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewCustomerTabControl
            // 
            this.viewCustomerTabControl.Controls.Add(this.accountInfoTabPage);
            this.viewCustomerTabControl.Controls.Add(this.contactTabPage);
            this.viewCustomerTabControl.Controls.Add(this.currentRentalsTabPage);
            this.viewCustomerTabControl.Controls.Add(this.historyTabPage);
            this.viewCustomerTabControl.Controls.Add(this.suggestTabPage);
            this.viewCustomerTabControl.Location = new System.Drawing.Point(0, 0);
            this.viewCustomerTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewCustomerTabControl.Name = "viewCustomerTabControl";
            this.viewCustomerTabControl.SelectedIndex = 0;
            this.viewCustomerTabControl.Size = new System.Drawing.Size(985, 515);
            this.viewCustomerTabControl.TabIndex = 0;
            // 
            // accountInfoTabPage
            // 
            this.accountInfoTabPage.Location = new System.Drawing.Point(4, 24);
            this.accountInfoTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accountInfoTabPage.Name = "accountInfoTabPage";
            this.accountInfoTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accountInfoTabPage.Size = new System.Drawing.Size(977, 487);
            this.accountInfoTabPage.TabIndex = 0;
            this.accountInfoTabPage.Text = "Account Info";
            this.accountInfoTabPage.UseVisualStyleBackColor = true;
            // 
            // contactTabPage
            // 
            this.contactTabPage.Location = new System.Drawing.Point(4, 24);
            this.contactTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contactTabPage.Name = "contactTabPage";
            this.contactTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contactTabPage.Size = new System.Drawing.Size(977, 487);
            this.contactTabPage.TabIndex = 1;
            this.contactTabPage.Text = "Contact";
            this.contactTabPage.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(792, 521);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // currentRentalsTabPage
            // 
            this.currentRentalsTabPage.Location = new System.Drawing.Point(4, 24);
            this.currentRentalsTabPage.Name = "currentRentalsTabPage";
            this.currentRentalsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.currentRentalsTabPage.Size = new System.Drawing.Size(977, 487);
            this.currentRentalsTabPage.TabIndex = 2;
            this.currentRentalsTabPage.Text = "Current Rentals";
            this.currentRentalsTabPage.UseVisualStyleBackColor = true;
            // 
            // historyTabPage
            // 
            this.historyTabPage.Location = new System.Drawing.Point(4, 24);
            this.historyTabPage.Name = "historyTabPage";
            this.historyTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.historyTabPage.Size = new System.Drawing.Size(977, 487);
            this.historyTabPage.TabIndex = 3;
            this.historyTabPage.Text = "History";
            this.historyTabPage.UseVisualStyleBackColor = true;
            // 
            // suggestTabPage
            // 
            this.suggestTabPage.Location = new System.Drawing.Point(4, 24);
            this.suggestTabPage.Name = "suggestTabPage";
            this.suggestTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.suggestTabPage.Size = new System.Drawing.Size(977, 487);
            this.suggestTabPage.TabIndex = 4;
            this.suggestTabPage.Text = "Suggest";
            this.suggestTabPage.UseVisualStyleBackColor = true;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.viewCustomerTabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee View - Customer";
            this.viewCustomerTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl viewCustomerTabControl;
        private TabPage accountInfoTabPage;
        private TabPage contactTabPage;
        private Button button1;
        private TabPage currentRentalsTabPage;
        private TabPage historyTabPage;
        private TabPage suggestTabPage;
    }
}