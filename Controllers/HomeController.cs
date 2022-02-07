using EcommerceWebStore.Models.Repository;
using EcommerceWebStore.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EcommerceWebStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            CategoryRepository objCategoryRepository = new CategoryRepository();
            List<Category> li = objCategoryRepository.ViewCategory();
            ViewBag.CategoryList = li;
            return View();
        }

        public ActionResult Product(int? id)
        {
            ProductRepository objProductRepository = new ProductRepository();
            List<Product> li = objProductRepository.ViewProduct().Where(x => x.prod_fk_cat_id == id).ToList();
            ViewBag.ProductList = li;
            return View();
        }

        public ActionResult ProductDetails(int? id)
        {
            ProductRepository objProductRepository = new ProductRepository();
            if (id == null) //if direct in url id is written then error
            {
                ViewData["error-msg"] = "No Product Found";
            }
            else
            {
                ViewData["data"]=objProductRepository.GetProduct((int)id);

            }
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}