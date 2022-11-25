using MoviesApp.SQL;
using System.Transactions;

namespace MoviesApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        //allows us to call dbconnections to make sql calls faster
        
        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            DBConnection connection = new DBConnection();
            connection.OpenConnection();
            new Login(connection).Show();
            Application.Run();          
        }
    }
}