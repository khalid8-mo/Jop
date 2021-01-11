using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using JopWebsite.Models;
using WebApplication1.Models;
 

namespace JopWebsite.Controllers
{
    [Authorize]
    public class JopsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Jops
        public ActionResult Index()
        {
            return View(db.Jops.ToList());
        }

        // GET: Jops/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jop jop = db.Jops.Find(id);
            if (jop == null)
            {
                return HttpNotFound();
            }
            return View(jop);
        }

        // GET: Jops/Create
        public ActionResult Create()

        {
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "CategoryName");
            return View();
        }

        // POST: Jops/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( Jop jop , HttpPostedFileBase Upload)
        {

           
            if (ModelState.IsValid)
            {
                //Upload File 
                string path = Path.Combine(Server.MapPath("~/Uploads"), Upload.FileName);
                Upload.SaveAs(path);
                jop.JopImage = Upload.FileName; //Save The Database

                db.Jops.Add(jop);
                db.SaveChanges();
                return RedirectToAction("Index");

            }
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "CategoryName", jop.CategoryId);

            return View(jop);
        }

        // GET: Jops/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jop jop = db.Jops.Find(id);
            if (jop == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "CategoryName", jop.CategoryId);
            return View(jop);
        }

        // POST: Jops/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( Jop jop ,HttpPostedFileBase Upload)
        {
            if (ModelState.IsValid)
            {
                string oldPath = Path.Combine(Server.MapPath("~/Uploads"), jop.JopImage); 

                if (Upload != null)
                {
                    System.IO.File.Delete(oldPath);
                    string path = Path.Combine(Server.MapPath("~/Uploads"), Upload.FileName);
                    Upload.SaveAs(path);
                    jop.JopImage = Upload.FileName;
                }
               


                db.Entry(jop).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryId = new SelectList(db.Categories, "Id", "CategoryName", jop.CategoryId);
            return View(jop);
        }

        // GET: Jops/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jop jop = db.Jops.Find(id);
            if (jop == null)
            {
                return HttpNotFound();
            }
            return View(jop);
        }

        // POST: Jops/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Jop jop = db.Jops.Find(id);
            db.Jops.Remove(jop);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        public JsonResult GetDetails(int x)
        {
            var result = from c in db.Categories
                         where c.Id == x
                         select new
                         {
                             getNum = c.Id

                         }; return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}
