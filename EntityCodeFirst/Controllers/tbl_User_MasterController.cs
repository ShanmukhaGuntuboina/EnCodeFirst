using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EntityCodeFirst;

namespace EntityCodeFirst.Controllers
{
    public class tbl_User_MasterController : Controller
    {
        private Model1 db = new Model1();
        public ActionResult Index()
        {
            return View(db.tbl_User_Master.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_User_Master tbl_User_Master = db.tbl_User_Master.Find(id);
            if (tbl_User_Master == null)
            {
                return HttpNotFound();
            }
            return View(tbl_User_Master);
        }

        public ActionResult Create()
        {
            ViewBag.Employee_Id = new SelectList(db.tbl_Educational_Details, "Educational_Details_Id", "Education");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "User_Id,Username,Password,Full_Name,Last_Login_Datetime,Active_Status")] tbl_User_Master tbl_User_Master)
        {
            if (ModelState.IsValid)
            {
                db.tbl_User_Master.Add(tbl_User_Master);
                db.SaveChanges();
                return RedirectToAction("Home");
            }

            return View(tbl_User_Master);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_User_Master tbl_User_Master = db.tbl_User_Master.Find(id);
            if (tbl_User_Master == null)
            {
                return HttpNotFound();
            }
            return View(tbl_User_Master);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "User_Id,Username,Password,Full_Name,Last_Login_Datetime,Active_Status")] tbl_User_Master tbl_User_Master)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_User_Master).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_User_Master);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_User_Master tbl_User_Master = db.tbl_User_Master.Find(id);
            if (tbl_User_Master == null)
            {
                return HttpNotFound();
            }
            return View(tbl_User_Master);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_User_Master tbl_User_Master = db.tbl_User_Master.Find(id);
            db.tbl_User_Master.Remove(tbl_User_Master);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)w
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
