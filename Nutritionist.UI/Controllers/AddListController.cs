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
    public class AddListController : Controller
    {
        public static UnitOfWork _unitOfWork = new UnitOfWork();
        public List<tbl_List> ListProduct = _unitOfWork.List.GetList().ToList();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddProduct(string Name, string Author, string Meal, string Detail)
        {
            try
            {
                tbl_List _book = new tbl_List
                {
                    Name = Name,
                    Author = Author,
                    Meal = Meal,
                    Detail = Detail,
                };

                _unitOfWork.List.Insert(_book);
                _unitOfWork.Save();

                var status = new { operation = "Success" };

                return Content(JsonConvert.SerializeObject(status), "application/json");
            }
            catch (Exception)
            {
                var status = new { operation = "Wrong" };

                return Content(JsonConvert.SerializeObject(status), "application/json");
            }


            return View();
        }

        public IActionResult DeleteProduct(string ID)
        {
            try
            {
                var t = _unitOfWork.List.Find(x => x._id == ID);

                tbl_List del = new tbl_List
                {
                    _id = t._id,
                    Author = t.Author,
                    Meal = t.Meal,
                    Name = t.Name,
                    Detail = t.Detail,
                };

                //tbl_Basket dell = new tbl_Basket
                //{
                //    _id = t._id,
                //    BookAuthor = t.BookAuthor,
                //    BookCategory = t.BookCategory,
                //    BookName = t.BookName,
                //    BookPrice = t.BookPrice,
                //};

                _unitOfWork.List.Delete(del);
                //_unitOfWork.Baskets.Delete(dell);
                _unitOfWork.Save();

                var status = new { operation = "Success" };

                return Content(JsonConvert.SerializeObject(status), "application/json");
            }
            catch (Exception)
            {
                var status = new { operation = "Wrong" };

                return Content(JsonConvert.SerializeObject(status), "application/json");
            }




            return View();
        }
    }
}