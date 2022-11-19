namespace MoviesApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (accountTextInput.Text.StartsWith("E"))
            {
                this.Close();
                new EmployeeViewForm().Show();
            }
            else 
            {
                this.Close();
                new CustomerViewForm().Show();
            }
        }
    }
}