using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E_Commerce.Entities;
using E_Commerce.Services;

namespace Ecommerce.web.Controllers
{
    public class CategoryController : Controller
    {
        CategoriesService categoryservice = new CategoriesService();
        [HttpGet]
        public ActionResult Index()
        {
            var categories=categoryservice.GetCategories();
            return View(categories);
        }

        [HttpGet]
        public ActionResult create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult create(Category category)
        {
            categoryservice.SaveCategory(category);
            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var category = categoryservice.GetCategory(ID);
            return View(category);
        }
        [HttpPost]
        public ActionResult Edit(Category category)
        {
            categoryservice.UpdateCategory(category);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int ID)
        {
            var category = categoryservice.GetCategory(ID);
            return View(category);
        }
        [HttpPost]
        public ActionResult Delete(Category category)
        {
            category = categoryservice.GetCategory(category.ID);
            categoryservice.DeleteCategory(category.ID);


            return RedirectToAction("Index");
        }
    }
}