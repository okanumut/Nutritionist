using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using Nutritionist.Client;
using Nutritionist.Entity.Concrete;
using Nutritionist.Repository.UnitOfWork;
using Nutritionist.UI.Models;

namespace Nutritionist.UI.Controllers
{
    public class HomeController : Controller
    {
        public static UnitOfWork _unitOfWork = new UnitOfWork();
        private readonly ILogger<HomeController> _logger;

        public List<tbl_List> ListProduct = _unitOfWork.List.GetList().ToList();
        public List<ProductModel> ProductModelList = new List<ProductModel>();

        public HomeController()
        {
            if (ProductModelList.Count() == 0)
            {
                for (int i = 0; i < ListProduct.Count(); i++)
                {
                    ProductModelList.AddRange(new ProductModel[]
                    {
                        new ProductModel()
                        {
                            _id = ListProduct[i]._id,
                            Author = ListProduct[i].Author,
                            Meal = ListProduct[i].Meal,
                            Name = ListProduct[i].Name,
                            Detail = ListProduct[i].Detail,
                        }
                    });

                }
            }

            ViewBag.User = Settings.cache.Get("UserName");
        }

        public IActionResult Index()
        {
            return View(ProductModelList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
