using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommonObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UnderRule.PlayerService.Controllers
{
    [Produces("application/json")]
    [Route("api/Player")]
    public class PlayerController : Controller
    {
        PlayerService service = new PlayerService();
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return service.GetPlayer(id);
        }

        [HttpPost]
        public bool Post([FromBody]RegistrationModel model)
        {
            //shane this needs to go to the database and insert into the player table
            /*
            //This is my connection string i have assigned the database file address path  
            string connectionString = "datasource=sarls.duckdns.org;port=3306;username=root;password=root_password";
            //This is my insert query in which i am taking input from the user through windows forms  
            string Query = "insert into UnderRule.Users (username,password) values ('" + model.UserName + "','" + model.Password + "');";
            //This is  MySqlConnection here i have created the object and pass my connection string.  
            MySqlConnection connection = new MySqlConnection(connectionString);
            //This is command class which will handle the query and connection object.  
            MySqlCommand myCommand = new MySqlCommand(Query, connection);

            connection.Open();
            myCommand.ExecuteNonQuery();
            */
            return true;


        }
    }
}