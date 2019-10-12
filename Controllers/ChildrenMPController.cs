using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Search_Recipes.Models;

namespace Search_Recipes.Controllers
{
    public class ChildrenMPController : Controller
    {
        private RecipeModel db = new RecipeModel();

        // GET: ChildrenMP
        public ActionResult Index()
        {
            return View();
        }

        // GET: ChildrenMP/Details/5
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

        public ActionResult Dairyfree()
        {
            return View();
        }

        public ActionResult Glutenfree()
        {
            return View();
        }

        public ActionResult Peanutfree()
        {
            return View();
        }

        public ActionResult Soyfree()
        {
            return View();
        }

        public ActionResult TreeNutfree()
        {
            return View();
        }

        public FileResult Download(string keyword)
        {
            if (keyword == "Peanut")
            {
                String root = Server.MapPath("~/AppFiles/Children");
                string filename = "Children cakes（peanut free）.pdf";
                string filePath = Path.Combine(root, filename);
                String s = MimeMapping.GetMimeMapping(filename);
                return File(filePath, s, Path.GetFileName(filePath));
            }
            if (keyword == "Dairy")
            {
                String root = Server.MapPath("~/AppFiles/Children");
                string filename = "Children cakes（Dairy free）.pdf";
                string filePath = Path.Combine(root, filename);
                String s = MimeMapping.GetMimeMapping(filename);
                return File(filePath, s, Path.GetFileName(filePath));
            }
            if (keyword == "Soy")
            {
                String root = Server.MapPath("~/AppFiles/Children");
                string filename = "Children cakes（peanut free）.pdf";
                string filePath = Path.Combine(root, filename);
                String s = MimeMapping.GetMimeMapping(filename);
                return File(filePath, s, Path.GetFileName(filePath));
            }
            if (keyword == "Gluten")
            {
                String root = Server.MapPath("~/AppFiles/Children");
                string filename = "Children cakes（gluten free）.pdf";
                string filePath = Path.Combine(root, filename);
                String s = MimeMapping.GetMimeMapping(filename);
                return File(filePath, s, Path.GetFileName(filePath));
            }
            if (keyword == "TreeNut")
            {
                String root = Server.MapPath("~/AppFiles/Children");
                string filename = "Children cakes（tree-nut free）.pdf";
                string filePath = Path.Combine(root, filename);
                String s = MimeMapping.GetMimeMapping(filename);
                return File(filePath, s, Path.GetFileName(filePath));
            }

            return null;

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
