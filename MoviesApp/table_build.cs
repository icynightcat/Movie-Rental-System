using System.Data.SqlClient;
using Microsoft.SqlServer.Server;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesApp
{
    public partial class table_build
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public static void build_tables()
        {
            String SqlConnectionString = "Server = localhost; Database = Movies; Trusted_Connection = yes;";

            SqlConnection myConnection = new SqlConnection(SqlConnectionString);
            

            try
            {
                myConnection.Open();
                //myCommand = new SqlCommand(); //lets you send commands
                //myCommand.Connection = myConnection; //lets you send commands
                string fileName = "TableCreation.sql";
                string path = Path.Join(Environment.CurrentDirectory, @"SQL\", fileName); //TODO giving error back
                Console.Write(path);
                string script = File.ReadAllText(path);
                SqlCommand command = new SqlCommand(script, myConnection);
                //use myConnection, all ready called and opened
                command.ExecuteNonQuery();

                

                myConnection.Close();
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
            }

        }
    }

    internal class ServerConnction
    {
        private SqlConnection myConnection;

        public ServerConnction(SqlConnection myConnection)
        {
            this.myConnection = myConnection;
        }
    }
}
