using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnderRule.RegistrationService.Models;

namespace UnderRule.RegistrationService.Controllers
{
    [Produces("application/json")]
    [Route("api/Registration")]
    public class RegistrationController : Controller
    {
        // POST api/values
        [HttpPost]
        public bool Post(RegistrationModel model) 
        {
            return true;

        }
    }


}