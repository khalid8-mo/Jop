using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
      private  ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
           
            
            return View(db.Categories.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Statistics()
        {
            Session["UserNum"] = db.Users.ToList().Count;
            Session["Jop"] = db.Jops.ToList().Count;
            Session["Categories"] = db.Categories.ToList().Count;
            Session["StudentNumber"] = db.Students.ToList().Count;
            return View();
        }
        public ActionResult SerchForm()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SerchForm(string Search)
        {

            return View();
        }
    }
}