using ErdalBakkal.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ErdalBakkal.WebUI.Models
{
    public class AuthAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            User loginUser = (User)HttpContext.Current.Session["UserSession"];
            if (loginUser == null)
            {
                filterContext.Result = new RedirectResult("/Login/Index");
            }
        }
    }
}