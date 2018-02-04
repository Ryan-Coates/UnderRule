using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UnderRule.FrontEnd.Models;
using Microsoft.AspNetCore.Authorization;
using CommonObjects;

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

            return View(world);
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

        public IActionResult SignUp()
        {
            SignupModel model = new SignupModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult SignUp(SignupModel model)
        {
            return RedirectToAction("Index");
        }

    }
}
