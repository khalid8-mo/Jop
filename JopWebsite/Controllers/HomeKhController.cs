using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace JopWebsite.Controllers
{
    
    public class HomeKhController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: HomeKh
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MyInfo()
        {
           
            
            return View();
        }
        public ActionResult Projact()
        {
            return View();
        }
        public ActionResult Portfolio()
        {


            return View();
        }
    }
    
}