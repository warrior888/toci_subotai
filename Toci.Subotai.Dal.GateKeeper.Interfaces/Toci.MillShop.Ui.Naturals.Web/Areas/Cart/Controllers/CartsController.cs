using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Toci.MillShop.Ui.Naturals.Web.BusinessLogic;
using Toci.Subotai.Dal.Gatekeeper.Interfaces;

namespace Toci.MillShop.Ui.Naturals.Web.Areas.Cart.Controllers
{
    public class CartsController : WebController
    {
        private subotaiEntities db;

        public CartsController(subotaiEntities subotaiEntities) : base(subotaiEntities)
        {
            db = subotaiEntities;
        }
        // GET: Cart/Carts
        public ActionResult Index()
        {
            var carts = db.Carts.Include(c => c.ProductItem).Include(c => c.User);
            return View(carts.ToList());
        }

        // GET: Cart/Carts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subotai.Dal.Gatekeeper.Interfaces.Cart cart = db.Carts.Find(id);
            if (cart == null)
            {
                return HttpNotFound();
            }
            return View(cart);
        }

        // GET: Cart/Carts/Create
        public ActionResult Create()
        {
            ViewBag.IdProductItems = new SelectList(db.ProductItems, "Id", "Name");
            ViewBag.IdUser = new SelectList(db.Users, "Id", "Name");
            return View();
        }

        // POST: Cart/Carts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IdProductItems,IdUser")] Subotai.Dal.Gatekeeper.Interfaces.Cart cart)
        {
            if (ModelState.IsValid)
            {
                db.Carts.Add(cart);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdProductItems = new SelectList(db.ProductItems, "Id", "Name", cart.IdProductItems);
            ViewBag.IdUser = new SelectList(db.Users, "Id", "Name", cart.IdUser);
            return View(cart);
        }

        // GET: Cart/Carts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subotai.Dal.Gatekeeper.Interfaces.Cart cart = db.Carts.Find(id);
            if (cart == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdProductItems = new SelectList(db.ProductItems, "Id", "Name", cart.IdProductItems);
            ViewBag.IdUser = new SelectList(db.Users, "Id", "Name", cart.IdUser);
            return View(cart);
        }

        // POST: Cart/Carts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IdProductItems,IdUser")] Subotai.Dal.Gatekeeper.Interfaces.Cart cart)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cart).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdProductItems = new SelectList(db.ProductItems, "Id", "Name", cart.IdProductItems);
            ViewBag.IdUser = new SelectList(db.Users, "Id", "Name", cart.IdUser);
            return View(cart);
        }

        // GET: Cart/Carts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subotai.Dal.Gatekeeper.Interfaces.Cart cart = db.Carts.Find(id);
            if (cart == null)
            {
                return HttpNotFound();
            }
            return View(cart);
        }

        // POST: Cart/Carts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Subotai.Dal.Gatekeeper.Interfaces.Cart cart = db.Carts.Find(id);
            db.Carts.Remove(cart);
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
