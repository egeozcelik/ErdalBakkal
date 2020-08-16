using ErdalBakkal.BLL;
using ErdalBakkal.Entity;
using ErdalBakkal.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ErdalBakkal.WebUI.Controllers
{
    [Auth]
    public class CategoryController : Controller
    {
        CategoryRepository catRepo = new CategoryRepository();
        // GET: Category
        public ActionResult Index()
        {
            List<Category> catList = catRepo.GetAll();
            return View(catList);
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Category c)
        {
            catRepo.Add(c);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            Category c = catRepo.GetById(id);
            catRepo.Delete(c);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            Category category = catRepo.GetById(id);
            return View(category);
        }

        [HttpPost]
        public ActionResult Edit(Category entity)
        {
            catRepo.Update(entity);
            return RedirectToAction("Index");
        }


    }
}