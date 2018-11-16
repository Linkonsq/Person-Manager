using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMApp.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (Session["USERNAME"] == null)
            {
                Response.Redirect("http://localhost:51440/");
            }
            base.OnActionExecuting(filterContext);
        }
    }
}