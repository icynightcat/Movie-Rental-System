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
            this.movieActorsTabPage = new System.Windows.Forms.TabPage();
            this.movieCopiesTabPage = new System.Windows.Forms.TabPage();
            this.movieDoneButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(985, 525);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // movieAboutTabPage
            // 
            this.movieAboutTabPage.Location = new System.Drawing.Point(4, 24);
            this.movieAboutTabPage.Name = "movieAboutTabPage";
            this.movieAboutTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.movieAboutTabPage.Size = new System.Drawing.Size(977, 497);
            this.movieAboutTabPage.TabIndex = 0;
            this.movieAboutTabPage.Text = "About";
            this.movieAboutTabPage.UseVisualStyleBackColor = true;
            // 
            // movieActorsTabPage
            // 
            this.movieActorsTabPage.Location = new System.Drawing.Point(4, 24);
            this.movieActorsTabPage.Name = "movieActorsTabPage";
            this.movieActorsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.movieActorsTabPage.Size = new System.Drawing.Size(977, 533);
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
            this.movieDoneButton.Location = new System.Drawing.Point(831, 527);
            this.movieDoneButton.Name = "movieDoneButton";
            this.movieDoneButton.Size = new System.Drawing.Size(150, 30);
            this.movieDoneButton.TabIndex = 0;
            this.movieDoneButton.Text = "Done";
            this.movieDoneButton.UseVisualStyleBackColor = true;
            // 
            // movieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.movieDoneButton);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "movieForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee View - Movie";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage movieAboutTabPage;
        private TabPage movieActorsTabPage;
        private TabPage movieCopiesTabPage;
        private Button movieDoneButton;
    }
}