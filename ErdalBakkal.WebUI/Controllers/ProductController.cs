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
    public class ProductController : Controller
    {
        ProductRepository repo = new ProductRepository();
        CategoryRepository repoCate = new CategoryRepository();
        // GET: Product
        public ActionResult Index()
        {
            List<Product> product = repo.GetAll();

            return View(product);
        }

        public ActionResult Add()
        {
            ProductViewModel viewModel = new ProductViewModel();
            viewModel.Product = new Product();
            viewModel.Categories = repoCate.GetAll();
            return View(viewModel);
        }
        [HttpPost]
        public ActionResult Add(ProductViewModel p)
        {
            repo.Add(p.Product);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            ProductViewModel viewModel = new ProductViewModel();
            viewModel.Product = repo.GetById(id);
            viewModel.Categories = repoCate.GetAll();
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Edit(ProductViewModel p)
        {
            repo.Update(p.Product);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            Product p = repo.GetById(id);
            repo.Delete(p);
            return RedirectToAction("Index");
        }
    }
}