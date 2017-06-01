using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult Create(Models.Book cBook)
        {
            new ValuesController().Create(cBook);
            return View();
        }
        public ActionResult Delete(int id)
        {
            Models.Book b = new ValuesController().Get(id);
            new ValuesController().Delete(id);
            return View(b);
        }
    }
}
