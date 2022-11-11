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
                //this.Close();
                new MovieForm().ShowDialog();
        }
        private void launchActorButton_Click(object sender, EventArgs e)
        {
            //this.Close();
            new ActorForm().ShowDialog();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}