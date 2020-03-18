using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Toci.Subotai.Dal.Gatekeeper.Interfaces;

namespace Toci.MillShop.Ui.Naturals.Web.Areas.Product.Controllers
{
    public class ProductsController : Controller
    {
        private subotaiEntities db = new subotaiEntities();

        // GET: Product/Products
        public ActionResult Index()
        {
            var products = db.Products.Include(p => p.Category);
            return View(products.ToList());
        }

        // GET: Product/Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subotai.Dal.Gatekeeper.Interfaces.Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Product/Products/Create
        public ActionResult Create()
        {
            ViewBag.IdCategories = new SelectList(db.Categories, "Id", "Name");
            return View();
        }

        // POST: Product/Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IdCategories,Name,ProductVat,IsPriceGross,HowMuchCount,Description,Price")] Subotai.Dal.Gatekeeper.Interfaces.Product product)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdCategories = new SelectList(db.Categories, "Id", "Name", product.IdCategories);
            return View(product);
        }

        // GET: Product/Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subotai.Dal.Gatekeeper.Interfaces.Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdCategories = new SelectList(db.Categories, "Id", "Name", product.IdCategories);
            return View(product);
        }

        // POST: Product/Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IdCategories,Name,ProductVat,IsPriceGross,HowMuchCount,Description,Price")] Subotai.Dal.Gatekeeper.Interfaces.Product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdCategories = new SelectList(db.Categories, "Id", "Name", product.IdCategories);
            return View(product);
        }

        // GET: Product/Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subotai.Dal.Gatekeeper.Interfaces.Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Product/Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Subotai.Dal.Gatekeeper.Interfaces.Product product = db.Products.Find(id);
            db.Products.Remove(product);
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
