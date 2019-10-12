using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Search_Recipes.Models;


namespace Search_Recipes.Controllers
{
    public class RecipesController : Controller
    {
        private RecipeModel db = new RecipeModel();
    
        // GET: Recipes
        public ActionResult Index(string searchString, string exFood, string mealContent, string meatContent, string allergensFree, string cookStyle)
        {
            var title = from t in db.Recipes select t;

            if(!string.IsNullOrEmpty(searchString))
            {
                title = title.Where(t => t.Title.Contains(searchString));
            }
            if (!string.IsNullOrEmpty(exFood))
            {
                title = title.Where(t => !t.Ingredients.Contains(exFood));
            }
            if (!string.IsNullOrEmpty(mealContent))
            {
                title = title.Where(t => t.Categories.Contains(mealContent));
            }
            if (!string.IsNullOrEmpty(meatContent))
            {
                title = title.Where(t => t.Ingredients.Contains(meatContent));
            }
            if (!string.IsNullOrEmpty(allergensFree))
            {
                title = title.Where(t => t.Categories.Contains(allergensFree));
            }
            if (!string.IsNullOrEmpty(cookStyle))
            {
                title = title.Where(t => t.Categories.Contains(cookStyle));
            }



            return View(title);
        }

        // GET: Recipes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recipe recipe = db.Recipes.Find(id);
            if (recipe == null)
            {
                return HttpNotFound();
            }
            return View(recipe);
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
