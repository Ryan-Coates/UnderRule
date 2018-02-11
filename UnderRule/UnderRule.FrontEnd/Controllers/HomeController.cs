using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UnderRule.FrontEnd.Models;
using Microsoft.AspNetCore.Authorization;
using CommonObjects;
using UnderRule.ApiGateway.Interface;
using UnderRule.ApiGateway.Interface.APIEntities;
using System.Security.Claims;

namespace UnderRule.FrontEnd.Controllers
{
    
    public class HomeController : Controller
    {
        RegistrationAPI registrationAPI;
        PlayerAPI playerAPI;
        WorldAPI worldAPI;
        public HomeController()
        {
            HTTPRequester requester = new HTTPRequester("http://underrule.apigateway");
            registrationAPI = new RegistrationAPI(requester);
            playerAPI = new PlayerAPI(requester);
            worldAPI = new WorldAPI(requester);
        }

        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> Game()
        {
            //todo: get auth token
           
            int userId = 0;
            var claims = ((ClaimsIdentity)User.Identity).Claims;
            foreach (var claim in claims)
            {
                if (claim.Type == "sub")
                {
                    userId = int.Parse(claim.Value);
                }
            }

            var world = await worldAPI.GetAsync(userId, "xx");
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
            RegistrationModel model = new RegistrationModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(RegistrationModel model)
        {
            await registrationAPI.PostAsync(model);
            //register player
            return RedirectToAction("Index");
        }

    }
}
