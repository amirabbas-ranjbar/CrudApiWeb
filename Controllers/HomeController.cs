using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudApi.Controllers
{
    public class HomeController : Controller
    {
        public CrudApi.Models.CrudAPIEntities DBEntities { get; set; }
        public HomeController()
        {
            DBEntities = new Models.CrudAPIEntities();
        }
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public JsonResult SelectAll()
        {
            var model = DBEntities.USERS.Select(a => a).ToList();
            return Json(model, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public JsonResult Select(int id)
        {
            var model = DBEntities.USERS.Select(a => a.ID==id).SingleOrDefault();
            return Json(model, JsonRequestBehavior.AllowGet);
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}