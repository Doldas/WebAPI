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
 
            return View(new ValuesController().Get());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Models.Book cBook)
        {
            new ValuesController().Create(cBook);
            return RedirectToAction("Index");
        }
        // GET: ShopLogic/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            if (new ValuesController().Get(id) as Models.Book != null)
            {
                return View(new ValuesController().Get(id));
            }
            return RedirectToAction("Index");
        }
        // POST: ShopLogic/Edit/5
        [HttpPost]
        public ActionResult Edit(Models.Book book)
        {
            new ValuesController().Edit(book);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Models.Book b = new ValuesController().Get(id);
            return View(b);
        }
        [HttpPost]
        public ActionResult Delete(int id, string Remove="")
        {
            if (Remove == "Delete")
            {
                new ValuesController().Delete(id);
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            return View(new ValuesController().Get(id));
        }
    }
}
