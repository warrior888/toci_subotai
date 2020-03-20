using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Toci.Subotai.Dal.Gatekeeper.Interfaces;

namespace Toci.MillShop.Ui.Naturals.Web.Areas.Registration.Controllers
{
    public class UsersController : Controller
    {
        private subotaiEntities db = new subotaiEntities();

        // GET: Registration/Users
        public ActionResult Index()
        {
            var users = db.Users.Include(u => u.Language);
            return View(users.ToList());
        }

        // GET: Registration/Users/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // GET: Registration/Users/Create
        public ActionResult Create()
        {
            ViewBag.IdLanguages = new SelectList(db.Languages, "Id", "Name");
            return View();
        }

        // POST: Registration/Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,ComesFrom,Gender,Surname,Email,Phone,Password,EmailVerified,City,PostCode,Street,IdLanguages")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdLanguages = new SelectList(db.Languages, "Id", "Name", user.IdLanguages);
            return View(user);
        }

        // GET: Registration/Users/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdLanguages = new SelectList(db.Languages, "Id", "Name", user.IdLanguages);
            return View(user);
        }

        // POST: Registration/Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,ComesFrom,Gender,Surname,Email,Phone,Password,EmailVerified,City,PostCode,Street,IdLanguages")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdLanguages = new SelectList(db.Languages, "Id", "Name", user.IdLanguages);
            return View(user);
        }

        // GET: Registration/Users/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: Registration/Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            User user = db.Users.Find(id);
            db.Users.Remove(user);
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
