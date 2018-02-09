using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommonObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UnderRule.WorldService.Controllers
{
    [Produces("application/json")]
    [Route("api/World")]
    public class WorldController : Controller
    {
        [HttpGet]
        public World Get(int id)
        {
            var world = new World();
            world.Player = new Player()
            {
                Army = 0,
                Castle = 1,
                Farm = 1,
                UserName = "Ryan"


            };
            world.OtherPlayers = new List<Player>();
            world.OtherPlayers.Add(new Player()
            {
                Army = 100,
                Castle = 10,
                Farm = 1,
                UserName = "Shane"
            });

            return world;
        }
    }
}