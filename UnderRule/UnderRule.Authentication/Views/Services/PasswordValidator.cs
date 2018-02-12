using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace UnderRule.Authentication.Services
{
    public static class PasswordValidator
    {
        public static int IsValid(string username, string password)
        {
            //todo: shane do this!
            //check username and password match
            //get the users userid

            string connectionString = "datasource=sarls.duckdns.org;port=3306;username=root;password=root_password";

            string Query = "Select id, username, password FROM UnderRule.Users where username ='" + username + "';";

            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand myCommand = new MySqlCommand(Query, connection);

            using (myCommand)
            {
                using (connection)
                {
                    connection.Open();
                    using (MySqlDataReader rdr = myCommand.ExecuteReader())
                    {
                        int id = int.Parse(rdr[0].ToString());
                        string dbUsername = rdr[1].ToString();
                        string dbPassword = rdr[2].ToString();

                        rdr.Close();

                        if (password == dbPassword)
                        {
                            return id;

                        }
                        else
                        {
                            return -1;
                        }
                    }
                }
            }
        }

            
        
    }

}