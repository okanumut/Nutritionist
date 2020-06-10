using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Nutritionist.Entity.Concrete;
using Nutritionist.Repository.UnitOfWork;
using Nutritionist.UI.Models;

namespace Nutritionist.UI.Controllers
{
    public class BasketController : Controller
    {
        public static UnitOfWork _unitOfWork = new UnitOfWork();

        public List<tbl_List> ListProduct = _unitOfWork.List.GetList().ToList();


        public List<tbl_Basket> ListBasket = _unitOfWork.Baskets.GetList().ToList();
        public List<BasketModel> BasketModelList = new List<BasketModel>();


        public BasketController()
        {

            if (BasketModelList.Count() == 0)
            {
                for (int i = 0; i < ListBasket.Count(); i++)
                {
                    BasketModelList.AddRange(new BasketModel[]
                    {
                        new BasketModel()
                        {
                            _id = ListBasket[i]._id,
                            Author = ListBasket[i].Author,
                            Meal = ListBasket[i].Meal,
                            Name = ListBasket[i].Name,
                            Detail = ListBasket[i].Detail,
                        }
                    });

                }
            }
        }


        public IActionResult Index()
        {
            return View(BasketModelList);
        }

        public IActionResult AddBasket(string ID)
        {

            try
            {
                var tempProduct = ListProduct.Find(x => x._id == ID);

                tbl_Basket _basket = new tbl_Basket
                {
                    _id = tempProduct._id,
                    Author = tempProduct.Author,
                    Meal = tempProduct.Meal,
                    Name = tempProduct.Name,
                    Detail = tempProduct.Detail

                };


                _unitOfWork.Baskets.Insert(_basket);
                _unitOfWork.Save();

                var status = new { operation = "Success" };

                return Content(JsonConvert.SerializeObject(status), "application/json");
            }
            catch (Exception e)
            {

                throw;
            }





            return View();
        }
    }
}