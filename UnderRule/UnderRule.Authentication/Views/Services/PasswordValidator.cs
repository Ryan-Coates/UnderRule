using System;
using System.Collections.Generic;
using System.Data;
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
            //okay thanks!

            if (username == "shane")
            {
                return 1;
            }
            else if (username == "ryan")
            {
                return 2;
            }
            else
            {
                return 0;
            }
                
                
                
                /*
            string connectionString = "datasource=sarls.duckdns.org;port=3306;username=root;password=root_password";

            string Query = "Select id, username, password FROM UnderRule.Users where username ='" + username + "';";
            
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand myCommand = new MySqlCommand(Query, connection))
                {
                    connection.Open();
                   
                    MySqlDataAdapter adapter = new MySqlDataAdapter(Query, connection);
                    DataSet DS = new DataSet();
                    //get query results in dataset
                    adapter.Fill(DS);
                    if (DS.Tables[0].Rows.Count > 0)
                    {
                        var row = DS.Tables[0].Rows[0];
                        int id = int.Parse(row[0].ToString());
                        string dbUsername = row[1].ToString();
                        string dbPassword = row[2].ToString();
                        if (password == dbPassword)
                        {
                            return id;

                        }
                        else
                        {
                            return -1;
                        }
                    }
                    else
                    {
                        return -1;
                    }
                    */
                }
            }

            
        }

            
        
    }

}