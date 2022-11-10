namespace MoviesApp
{
    partial class EmployeeViewForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.moviesTabPage = new System.Windows.Forms.TabPage();
            this.launchMovieButton = new System.Windows.Forms.Button();
            this.actorsTabPage = new System.Windows.Forms.TabPage();
            this.customersTabPage = new System.Windows.Forms.TabPage();
            this.employeesTabPage = new System.Windows.Forms.TabPage();
            this.transactionsTabPage = new System.Windows.Forms.TabPage();
            this.reportsTabPage = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.report1TabPage = new System.Windows.Forms.TabPage();
            this.report2TabPage = new System.Windows.Forms.TabPage();
            this.report3TabPage = new System.Windows.Forms.TabPage();
            this.report4TabPage = new System.Windows.Forms.TabPage();
            this.report5TabPage = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.moviesTabPage.SuspendLayout();
            this.reportsTabPage.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.moviesTabPage);
            this.tabControl1.Controls.Add(this.actorsTabPage);
            this.tabControl1.Controls.Add(this.customersTabPage);
            this.tabControl1.Controls.Add(this.employeesTabPage);
            this.tabControl1.Controls.Add(this.transactionsTabPage);
            this.tabControl1.Controls.Add(this.reportsTabPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(986, 562);
            this.tabControl1.TabIndex = 0;
            // 
            // moviesTabPage
            // 
            this.moviesTabPage.Controls.Add(this.launchMovieButton);
            this.moviesTabPage.Location = new System.Drawing.Point(4, 24);
            this.moviesTabPage.Name = "moviesTabPage";
            this.moviesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.moviesTabPage.Size = new System.Drawing.Size(978, 534);
            this.moviesTabPage.TabIndex = 0;
            this.moviesTabPage.Text = "Movies";
            this.moviesTabPage.UseVisualStyleBackColor = true;
            // 
            // launchMovieButton
            // 
            this.launchMovieButton.Location = new System.Drawing.Point(232, 215);
            this.launchMovieButton.Name = "launchMovieButton";
            this.launchMovieButton.Size = new System.Drawing.Size(232, 23);
            this.launchMovieButton.TabIndex = 0;
            this.launchMovieButton.Text = "Temporary Launch Movie";
            this.launchMovieButton.UseVisualStyleBackColor = true;
            this.launchMovieButton.Click += new System.EventHandler(this.launchMovieButton_Click);
            // 
            // actorsTabPage
            // 
            this.actorsTabPage.Location = new System.Drawing.Point(4, 24);
            this.actorsTabPage.Name = "actorsTabPage";
            this.actorsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.actorsTabPage.Size = new System.Drawing.Size(978, 534);
            this.actorsTabPage.TabIndex = 1;
            this.actorsTabPage.Text = "Actors";
            this.actorsTabPage.UseVisualStyleBackColor = true;
            // 
            // customersTabPage
            // 
            this.customersTabPage.Location = new System.Drawing.Point(4, 24);
            this.customersTabPage.Name = "customersTabPage";
            this.customersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.customersTabPage.Size = new System.Drawing.Size(978, 534);
            this.customersTabPage.TabIndex = 2;
            this.customersTabPage.Text = "Customers";
            this.customersTabPage.UseVisualStyleBackColor = true;
            // 
            // employeesTabPage
            // 
            this.employeesTabPage.Location = new System.Drawing.Point(4, 24);
            this.employeesTabPage.Name = "employeesTabPage";
            this.employeesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.employeesTabPage.Size = new System.Drawing.Size(978, 534);
            this.employeesTabPage.TabIndex = 3;
            this.employeesTabPage.Text = "Employees";
            this.employeesTabPage.UseVisualStyleBackColor = true;
            // 
            // transactionsTabPage
            // 
            this.transactionsTabPage.Location = new System.Drawing.Point(4, 24);
            this.transactionsTabPage.Name = "transactionsTabPage";
            this.transactionsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.transactionsTabPage.Size = new System.Drawing.Size(978, 534);
            this.transactionsTabPage.TabIndex = 4;
            this.transactionsTabPage.Text = "Transactions";
            this.transactionsTabPage.UseVisualStyleBackColor = true;
            // 
            // reportsTabPage
            // 
            this.reportsTabPage.Controls.Add(this.tabControl2);
            this.reportsTabPage.Location = new System.Drawing.Point(4, 24);
            this.reportsTabPage.Name = "reportsTabPage";
            this.reportsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.reportsTabPage.Size = new System.Drawing.Size(978, 534);
            this.reportsTabPage.TabIndex = 5;
            this.reportsTabPage.Text = "Reports";
            this.reportsTabPage.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl2.Controls.Add(this.report1TabPage);
            this.tabControl2.Controls.Add(this.report2TabPage);
            this.tabControl2.Controls.Add(this.report3TabPage);
            this.tabControl2.Controls.Add(this.report4TabPage);
            this.tabControl2.Controls.Add(this.report5TabPage);
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(982, 538);
            this.tabControl2.TabIndex = 0;
            // 
            // report1TabPage
            // 
            this.report1TabPage.Location = new System.Drawing.Point(4, 4);
            this.report1TabPage.Name = "report1TabPage";
            this.report1TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.report1TabPage.Size = new System.Drawing.Size(974, 510);
            this.report1TabPage.TabIndex = 0;
            this.report1TabPage.Text = "Report 1";
            this.report1TabPage.UseVisualStyleBackColor = true;
            // 
            // report2TabPage
            // 
            this.report2TabPage.Location = new System.Drawing.Point(4, 4);
            this.report2TabPage.Name = "report2TabPage";
            this.report2TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.report2TabPage.Size = new System.Drawing.Size(974, 510);
            this.report2TabPage.TabIndex = 1;
            this.report2TabPage.Text = "Report 2";
            this.report2TabPage.UseVisualStyleBackColor = true;
            // 
            // report3TabPage
            // 
            this.report3TabPage.Location = new System.Drawing.Point(4, 4);
            this.report3TabPage.Name = "report3TabPage";
            this.report3TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.report3TabPage.Size = new System.Drawing.Size(974, 510);
            this.report3TabPage.TabIndex = 2;
            this.report3TabPage.Text = "Report 3";
            this.report3TabPage.UseVisualStyleBackColor = true;
            // 
            // report4TabPage
            // 
            this.report4TabPage.Location = new System.Drawing.Point(4, 4);
            this.report4TabPage.Name = "report4TabPage";
            this.report4TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.report4TabPage.Size = new System.Drawing.Size(974, 510);
            this.report4TabPage.TabIndex = 3;
            this.report4TabPage.Text = "Report4";
            this.report4TabPage.UseVisualStyleBackColor = true;
            // 
            // report5TabPage
            // 
            this.report5TabPage.Location = new System.Drawing.Point(4, 4);
            this.report5TabPage.Name = "report5TabPage";
            this.report5TabPage.Padding = new System.Windows.Forms.Padding(3);
            this.report5TabPage.Size = new System.Drawing.Size(974, 510);
            this.report5TabPage.TabIndex = 4;
            this.report5TabPage.Text = "Report 5";
            this.report5TabPage.UseVisualStyleBackColor = true;
            // 
            // EmployeeViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "EmployeeViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee View";
            this.tabControl1.ResumeLayout(false);
            this.moviesTabPage.ResumeLayout(false);
            this.reportsTabPage.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage moviesTabPage;
        private TabPage actorsTabPage;
        private TabPage customersTabPage;
        private TabPage employeesTabPage;
        private TabPage transactionsTabPage;
        private TabPage reportsTabPage;
        private TabControl tabControl2;
        private TabPage report1TabPage;
        private TabPage report2TabPage;
        private TabPage report3TabPage;
        private TabPage report4TabPage;
        private TabPage report5TabPage;
        private Button launchMovieButton;
    }
}