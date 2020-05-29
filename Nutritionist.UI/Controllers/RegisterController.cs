using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Nutritionist.Entity.Concrete;
using Nutritionist.Repository.UnitOfWork;

namespace Nutritionist.UI.Controllers
{
    public class RegisterController : Controller
    {
        UnitOfWork _unitOfWork = new UnitOfWork();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        { 
            return View();
        }

        public IActionResult RegisterPage(string Name, string Email, string Password)
        {
            try
            {
                tbl_LoginUsers _userSetting = new tbl_LoginUsers
                {
                    UserName = Name,
                    Email = Email,
                    Password = Password,
                };

                _unitOfWork.LoginUsers.Insert(_userSetting);
                _unitOfWork.Save();

                var status = new { operation = "Success" };

                return Content(JsonConvert.SerializeObject(status), "application/json");
            }
            catch (Exception)
            {
                var status = new { operation = "Error" };

                return Content(JsonConvert.SerializeObject(status), "application/json");
            }

        }
    }
}