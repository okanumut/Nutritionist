using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using Nutritionist.Client;
using Nutritionist.Repository.UnitOfWork;

namespace Nutritionist.UI.Controllers
{
    public class LogInController : Controller
    { 
        UnitOfWork _unitOfWork = new UnitOfWork();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(string Email, string Password)
        {
            try
            {
                var UserCheck = _unitOfWork.LoginUsers.Find(x => x.Email == Email && x.Password == Password);
                  

                if (UserCheck != null)
                {
                    Settings.cache.Set("UserName", UserCheck.UserName);
                }

                var status = new { operation = "Success" };
                return Content(JsonConvert.SerializeObject(status), "application/json");
            }
            catch (Exception)
            {

                throw;
            }

           



            return View();
        }
    }
}