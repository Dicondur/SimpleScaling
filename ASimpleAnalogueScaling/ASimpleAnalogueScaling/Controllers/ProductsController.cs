using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ScalingApp;
using System.Linq.Dynamic;

namespace ScalingApp.Controllers
{
    public class ProductsController : Controller
    {
        private mssql7Entities db = new mssql7Entities();

        // GET: Products
        public ActionResult Index(int page = 1, string sort = "Name", string sortdir = "asc", string search = "")
        {
            var products = db.Products.Include(p => p.UnitOfMeasure);
            return View(products.ToList());


            //int pageSize = 10;
            //int totalRecords = 0;

            //if (page < 1) page = 1;
            //int skip = (page * pageSize) - pageSize;
            //var data = GetProducts(search, sort, sortdir, skip, pageSize, out totalRecords);
            //ViewBag.TotalRows = totalRecords;
            //ViewBag.search = search;

            //return View(data);
        }



        //get Products from DB

        public List<Product> GetProducts(string search, string sort, string sortdir, int skip, int pageSize, out int totalRecords)
        {
            using (mssql7Entities dc = new mssql7Entities())
            {
                var v = (from each in dc.Products
                         where
                            each.Name.Contains(search) ||
                            each.ProductDescription.Contains(search)
                         select each);

                totalRecords = v.Count();
                //v = db.Products.Include(p => p.UnitOfMeasure);
                
                v = v.OrderBy(sort + " " + sortdir);
                if (pageSize > 0)
                {
                    v = v.Skip(skip).Take(pageSize);

                }

                return v.ToList();
            }
        }



        // GET: Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            ViewBag.UnitMeasureCode = new SelectList(db.UnitOfMeasures, "UnitMeasureCode", "UnitOfMeasure1");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProductID,Name,ProductDescription,UnitMeasureCode")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.UnitMeasureCode = new SelectList(db.UnitOfMeasures, "UnitMeasureCode", "UnitOfMeasure1", product.UnitMeasureCode);
            return View(product);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            ViewBag.UnitMeasureCode = new SelectList(db.UnitOfMeasures, "UnitMeasureCode", "UnitOfMeasure1", product.UnitMeasureCode);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProductID,Name,ProductDescription,UnitMeasureCode")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.UnitMeasureCode = new SelectList(db.UnitOfMeasures, "UnitMeasureCode", "UnitOfMeasure1", product.UnitMeasureCode);
            return View(product);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = db.Products.Find(id);
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
