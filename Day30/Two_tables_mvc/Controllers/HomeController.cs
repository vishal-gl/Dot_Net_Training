using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Two_tables_mvc.Models;

namespace Two_tables_mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Product_CategoryEntities db = new Product_CategoryEntities();
            List<Product> p =db.Products.ToList();

            return View(p);
            
        }

        public ActionResult Category()
        {
            Product_CategoryEntities db = new Product_CategoryEntities();
            List<Category> c = db.Categories.ToList();

            return View(c);

        }
        public ActionResult EditCategories(string id)
        {
            Product_CategoryEntities dbcontext = new Product_CategoryEntities();
            var category = dbcontext.Categories.FirstOrDefault(x => x.CategoryId == id);


            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editcategories(Category c)
        {

            Product_CategoryEntities dbcontext = new Product_CategoryEntities();
            if (ModelState.IsValid)
            {
                try
                {


                    dbcontext.Entry(c).State = System.Data.Entity.EntityState.Modified;

                    dbcontext.SaveChanges();
                    return RedirectToAction("Category");



                }
                catch (Exception ex)
                {
                    Response.Write("<h1>"+ex.Message+"<h1>");
                }




            }
            return View(c);
        }
        public ActionResult Edit(string id)
        {
            Product_CategoryEntities dbcontext = new Product_CategoryEntities();
            var product = dbcontext.Products.FirstOrDefault(x => x.PId== id);


            return View(product);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product p)
        {

            Product_CategoryEntities dbcontext = new Product_CategoryEntities();
            if (ModelState.IsValid)
            {
                try
                {
                    
                    
                        dbcontext.Entry(p).State = System.Data.Entity.EntityState.Modified;

                        dbcontext.SaveChanges();
                        return RedirectToAction("Index");

                    

                }
                catch(Exception ex)
                {
                    Response.Write("<h1>Please Enter The Valid Category Id<h1>");
                }
                

                
                
            }
            return View(p);
        }



        public ActionResult Details(string id)
        {
            Product_CategoryEntities db = new Product_CategoryEntities();
            Product single = db.Products.Find(id);
            
            return View(single);
        }

        public ActionResult DetailsCategory(string id)
        {
            Product_CategoryEntities db = new Product_CategoryEntities();
            Category single = db.Categories.Find(id);

            return View(single);

        }
        public ActionResult Delete(string id)
        {
            Product_CategoryEntities db = new Product_CategoryEntities();
            Product product = db.Products.Find(id);
            
            return View(product);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Product_CategoryEntities db = new Product_CategoryEntities();
            Product p= db.Products.Find(id);
            db.Products.Remove(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteCategory(string id)
        {
            Product_CategoryEntities db = new Product_CategoryEntities();
            Category c = db.Categories.Find(id);

            return View(c);
        }
        [HttpPost, ActionName("DeleteCategory")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteCategoryConfirmed(string id)
        {
            Product_CategoryEntities db = new Product_CategoryEntities();
            Category c= db.Categories.Find(id);
            db.Categories.Remove(c);
            db.SaveChanges();
            return RedirectToAction("Category");
        }

        public ActionResult Create()
        {
            return View();
        }

        //  
        // POST: /Product/Create  

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product p)
        {
            Product_CategoryEntities db = new Product_CategoryEntities();
            if (ModelState.IsValid)
            {
                db.Products.Add(p);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(p);
        }

        public ActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateCategory(Category c)
        {
            Product_CategoryEntities db = new Product_CategoryEntities();
            if (ModelState.IsValid)
            {
                db.Categories.Add(c);
                db.SaveChanges();
                return RedirectToAction("Category");
            }

            return View(c);
        }


    }
}