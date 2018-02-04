using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UnderRule.FrontEnd.Models;
using Microsoft.AspNetCore.Authorization;

namespace UnderRule.FrontEnd.Controllers
{
    
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult Game()
        {
            Players players = new Players();
            players._Players = new List<Player>();
            players._Players.Add(new Player()
                {
                    Name = "Shane",
                    Castle = 1,
                    Farm = 1
                }
            );
            players._Players.Add(new Player()
                {
                    Name = "Ryan",
                    Castle = 1,
                    Farm = 1
                }
            );
            return View(players);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
