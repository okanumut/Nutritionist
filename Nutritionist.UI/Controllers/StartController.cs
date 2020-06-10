using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nutritionist.Entity.Concrete;
using Nutritionist.Repository.UnitOfWork;
using Nutritionist.UI.Models;

namespace Nutritionist.UI.Controllers
{
    public class StartController : Controller
    {
        public static UnitOfWork _unitOfWork = new UnitOfWork();

        public List<tbl_List> ListProduct = _unitOfWork.List.GetList().ToList();
        public List<ProductModel> ProductModelList = new List<ProductModel>();

        public StartController()
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
        }
        public IActionResult Index()
        {
            return View(ProductModelList);
        }
    }
}