using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Nutritionist.Client;

namespace Nutritionist.UI.Controllers
{
    public class LogOutController : Controller
    {
        public IActionResult LogOut(bool SignOut)
        {
            if (SignOut == true)
            {
                Settings.cache.Remove("UserName");
                Settings.cache.Remove("UserType");

                var status = new { operation = "Success" };

                return Content(JsonConvert.SerializeObject(status), "application/json");
            }



            return View();
        }
    }
}