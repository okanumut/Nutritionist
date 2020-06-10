using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using Nutritionist.Client;
using Nutritionist.Entity.Concrete;
using Nutritionist.Repository.UnitOfWork;

namespace Nutritionist.UI.Controllers
{
    public class 
        
        
        Controller : Controller
    {
        UnitOfWork _unitOfWork = new UnitOfWork();

        public IActionResult Index()
        {
            return View();
        }


        //Register
        public IActionResult Login(string UserName, string Password, string Email, string UserType)
        {
            try
            {
                tbl_LoginUsers _user = new tbl_LoginUsers
                {
                    UserName = UserName,
                    Email = Email,
                    Password = Password,
                    UserType = UserType,
                };

                _unitOfWork.LoginUsers.Insert(_user);
                _unitOfWork.Save();
            }
            catch (Exception)
            {

                throw;
            }

            return View();
        }


        //Login
        public IActionResult ReallyLogin(string UserNameLog, string PasswordLog)
        {


            try
            {
                var UserSuccess = _unitOfWork.LoginUsers.Find(x => x.UserName == UserNameLog && x.Password == PasswordLog);


                if (UserSuccess != null)
                {
                    Settings.cache.Set("UserName", UserSuccess.UserName);
                    Settings.cache.Set("UserType", UserSuccess.UserType);

                    var status = new { operation = "Success" };

                    return Content(JsonConvert.SerializeObject(status), "application/json");
                }
                else
                {
                    var status = new { operation = "Wrong" };

                    return Content(JsonConvert.SerializeObject(status), "application/json");
                }


            }
            catch (Exception e)
            {
                var asd = e;
                var status = new { operation = "Catch" };

                return Content(JsonConvert.SerializeObject(status), "application/json");
            }



        }
    }
}