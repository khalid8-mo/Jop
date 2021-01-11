using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using JopWebsite.Models;
using WebApplication1.Models;
using System.IO;
namespace JopWebsite.Controllers
{
    public class MyInfoesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: MyInfoes
        public ActionResult Index()
        {
            return View(db.MyInfoes.ToList());
        }

        // GET: MyInfoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MyInfo myInfo = db.MyInfoes.Find(id);
            if (myInfo == null)
            {
                return HttpNotFound();
            }
            return View(myInfo);
        }

        // GET: MyInfoes/Create
        public ActionResult Create()
        {
           
            return View();
        }

        // POST: MyInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( MyInfo myInfo ,HttpPostedFileBase myImageUploud)
        {
  
            if (ModelState.IsValid)
            {
                string path = Path.Combine(Server.MapPath("~/Uploud"), myImageUploud.FileName);
                myImageUploud.SaveAs(path);
                myInfo.Image = myImageUploud.FileName;
                db.MyInfoes.Add(myInfo);
                db.SaveChanges();
                ViewBag.Name = myInfo.Name;
                Session["Mastar"] = myInfo.Mastar;
                return RedirectToAction("Index");
            }
            return View(myInfo);
        }

        // GET: MyInfoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MyInfo myInfo = db.MyInfoes.Find(id);
            if (myInfo == null)
            {
                return HttpNotFound();
            }
            return View(myInfo);
        }

        // POST: MyInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Mastar,Phone,Email,Skills,Discraption,Image")] MyInfo myInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(myInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(myInfo);
        }

        // GET: MyInfoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MyInfo myInfo = db.MyInfoes.Find(id);
            if (myInfo == null)
            {
                return HttpNotFound();
            }
            return View(myInfo);
        }

        // POST: MyInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MyInfo myInfo = db.MyInfoes.Find(id);
            db.MyInfoes.Remove(myInfo);
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
    }
}
