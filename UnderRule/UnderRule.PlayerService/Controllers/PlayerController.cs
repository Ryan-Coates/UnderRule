using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    }
}