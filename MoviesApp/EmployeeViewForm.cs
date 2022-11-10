namespace MoviesApp
{
    public partial class EmployeeViewForm : Form
    {
        public EmployeeViewForm()
        {
            InitializeComponent();
        }

        private void launchMovieButton_Click(object sender, EventArgs e)
        {
                this.Close();
                new MovieForm().Show();
        }
    }
}