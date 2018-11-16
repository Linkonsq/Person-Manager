using PMEntity;
using PMRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMApp.Controllers
{
    public class LoginController : Controller
    {
        private UserRepository repo = new UserRepository();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(User user)
        {
            bool valid = repo.Validate(user);
            if(valid)
            {
                Session["USERNAME"] = user.Username;
                return RedirectToAction("Index", "Person");
            }
            else
            {
                return Content("Invalid username or password");
            }
        }
    }
}