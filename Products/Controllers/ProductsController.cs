using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Products.Data;
using Products.Models;

namespace Products.Controllers
{
    [Authorize]
    public class ProductsController : Controller
    {
        ProductsContext db = new ProductsContext();

        public IActionResult Index()
        {
            var products = db.Products.Include(p => p.categories).ToList();
            return View(products);
        }
        public IActionResult Details(int? id)
        {
            if (id == null)
                return BadRequest();
            var product = db.Products.Include(p => p.categories).SingleOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
        public IActionResult Create()
        {
            var Cate = db.Categories.ToList();
            ViewBag.Cate = Cate;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Models.Products product)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            var Cate = db.Categories.ToList();
            ViewBag.Cate = Cate;
            return View("Create", product);
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
                return BadRequest();
            var product = db.Products.SingleOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            var Cate = db.Categories.ToList();
            ViewBag.Cate = Cate;
            return View(product);
        }
        [HttpPost]
        public IActionResult Edit(Models.Products product)
        {
            if (ModelState.IsValid)
            {
                db.Products.Update(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            var Cate = db.Categories.ToList();
            ViewBag.Cate = Cate;
            return View("Edit", product);
        }
        public IActionResult Delete(int id)
        {
            var product = db.Products.SingleOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            db.Products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View(new LoginViewModel()); // Pass an empty LoginViewModel to the view
        }

        [HttpPost]
        [AllowAnonymous] // Allow anonymous access for the POST login action
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Here you would typically perform your authentication logic:
                // - Validate email and password against your user store (e.g., Identity, custom database)
                // - If successful, sign the user in (e.g., using SignInManager<ApplicationUser>)
                // - Redirect to a secured area (e.g., RedirectToAction("Index", "Products"))
                // If unsuccessful, add a model error:
                // ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            }

            // If ModelState is not valid or login fails, return the view with the model
            return View(model);
        }
    }
}
