using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Toci.Subotai.Dal.Gatekeeper.Interfaces;

namespace Toci.MillShop.Ui.Naturals.Web.Areas.Order.Controllers
{
    public class OrdersController : Controller
    {
        private subotaiEntities db = new subotaiEntities();

        // GET: Order/Orders
        public ActionResult Index()
        {
            var orders = db.Orders.Include(o => o.Cart).Include(o => o.User);
            return View(orders.ToList());
        }

        // GET: Order/Orders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subotai.Dal.Gatekeeper.Interfaces.Order order = db.Orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // GET: Order/Orders/Create
        public ActionResult Create()
        {
            ViewBag.IdCarts = new SelectList(db.Carts, "Id", "Id");
            ViewBag.IdUser = new SelectList(db.Users, "Id", "Name");
            return View();
        }

        // POST: Order/Orders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IdCarts,IdUser")] Subotai.Dal.Gatekeeper.Interfaces.Order order)
        {
            if (ModelState.IsValid)
            {
                db.Orders.Add(order);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdCarts = new SelectList(db.Carts, "Id", "Id", order.IdCarts);
            ViewBag.IdUser = new SelectList(db.Users, "Id", "Name", order.IdUser);
            return View(order);
        }

        // GET: Order/Orders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subotai.Dal.Gatekeeper.Interfaces.Order order = db.Orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdCarts = new SelectList(db.Carts, "Id", "Id", order.IdCarts);
            ViewBag.IdUser = new SelectList(db.Users, "Id", "Name", order.IdUser);
            return View(order);
        }

        // POST: Order/Orders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IdCarts,IdUser")] Subotai.Dal.Gatekeeper.Interfaces.Order order)
        {
            if (ModelState.IsValid)
            {
                db.Entry(order).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdCarts = new SelectList(db.Carts, "Id", "Id", order.IdCarts);
            ViewBag.IdUser = new SelectList(db.Users, "Id", "Name", order.IdUser);
            return View(order);
        }

        // GET: Order/Orders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subotai.Dal.Gatekeeper.Interfaces.Order order = db.Orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // POST: Order/Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Subotai.Dal.Gatekeeper.Interfaces.Order order = db.Orders.Find(id);
            db.Orders.Remove(order);
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
