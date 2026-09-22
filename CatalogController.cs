using System.Linq;
using System.Web.Mvc;
using ProductCatalogApp.Models;

namespace ProductCatalogApp.Controllers
{
    public class CatalogController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Catalog
        public ActionResult Index(string category, string searchQuery)
        {
            var products = db.Products.AsQueryable();

            if (!string.IsNullOrEmpty(category))
            {
                products = products.Where(p => p.Category == category);
            }

            if (!string.IsNullOrEmpty(searchQuery))
            {
                products = products.Where(p => p.Name.Contains(searchQuery) || p.Description.Contains(searchQuery));
            }

            ViewBag.Categories = db.Products.Select(p => p.Category).Distinct().ToList();
            ViewBag.CurrentCategory = category;
            ViewBag.SearchQuery = searchQuery;

            return View(products.ToList());
        }

        // GET: Catalog/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null) return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);

            Product product = db.Products.Find(id);
            if (product == null) return HttpNotFound();

            return View(product);
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