using PMEntity;
using PMRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMApp.Controllers
{
    public class PersonController : Controller
    {
        private PersonRepository repo = new PersonRepository();

        
        public ActionResult Index()
        {
            return View(this.repo.GetAll());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Person person)
        {
            if(ModelState.IsValid)
            {
                this.repo.Insert(person);
                return RedirectToAction("Index");
            }
            else
            {
                person.Email = "";
                return View(person);
            }
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            Person p = this.repo.Get(id);
            return View(p);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Person p = this.repo.Get(id);
            return View(p);
        }

        [HttpPost]
        public ActionResult Edit(Person person)
        {
            this.repo.Update(person);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Person p = this.repo.Get(id);
            return View(p);
        }

        [HttpPost][ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            this.repo.Delete(id);
            return RedirectToAction("Index");
        }

        [NonAction]
        public ActionResult Test()
        {
            int[] arr = new int[] { 2,4,5,8,9,6,1 };
            
            var result = from i in arr
                         where i > 5 && i % 2 == 0
                         select i;

            var result2 = arr.OrderBy(i => i);

            ViewBag.Result = result2;
            return View();
        }
    }
}