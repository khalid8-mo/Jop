using JopWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

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


            return View();
        }
        [HttpPost]
        public ActionResult Contact(Contact contact)
        {
            //Send Message
            var male = new MailMessage();
            var loginInfo = new NetworkCredential("aljokar014@gmail.com","JR@13@jr!"); //Information your Email 
            male.From = new MailAddress(contact.Email); // From Mail To LoginInfo
            male.To.Add(new MailAddress("aljokar014@gmail.com"));
            // Information The Message
            male.Subject = "الموضوع : " + contact.Subject; 
            var body = "اسم المرسل :"+contact.Name +"<br>"
            + "عنوان المرسل : " + contact.Email + "<br>" +  
            "عنوان الرساله : " + contact.Subject + "<br>"+
            "نص الرساله  : " + contact.Massege;

            male.Body = body;
            var SmtpClientPort = new SmtpClient("asmp.gmail.com", 587); // Host And Port
            SmtpClientPort.EnableSsl = true; // الرسايل التلقائيه
            SmtpClientPort.Credentials = loginInfo; 
            SmtpClientPort.Send(male); //Send The Message

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
        public ActionResult Searsh()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Searsh(string Search)
        {
            var reuslt = db.Jops.Where(a => a.JopTitle.Contains(Search) ||
            a.JopContent.Contains(Search) ||
            a.Category.CategoryName.Contains(Search) ||
            a.Category.CategoryDescription.Contains(Search)
            
            );
            return View();
        }
    }
}