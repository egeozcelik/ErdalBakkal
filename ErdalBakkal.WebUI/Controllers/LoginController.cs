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
    public class LoginController : Controller
    {
        UserRepository repo = new UserRepository();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Logon(User entity)
        {
            User loginUser = repo.Login(entity.UserName, entity.Password);
            if (loginUser != null)
            {
                Session["UserSession"] = loginUser;
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Index");
        }
    }
}