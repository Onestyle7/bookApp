using bookApp.Data;
using bookApp.Models;
using bookApp.ViewModels;
using LibApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bookApp.Controllers
{
    public class BooksController : Controller
    {

        public BooksController(ApplicationDbContext context) {
            _context = context;
        }
        // GET: BooksController
        public ActionResult Index()
        {
            return View();
        }

        // GET: BooksController/Details/5

        // GET: BooksControler/Random

        public IActionResult Random()
        {
            var firstBook = new Book() { Autor = "Random author", Title = "random Title" };
            // return RedirectToAction("Random", "Books");
            // Use for alternative ways of passing data to views
           // ViewData["Book"] = firstBook;
           //ViewBag.Book = firstBook;

            var customers = new List<Customer>
            {
                new Customer  { Name = "Customer 1" },
                new Customer  { Name = "Customer 2" }
            };
            var ViewModel = new RandomBookViewModel
            {
                Book = firstBook,
                Customers = customers
            };
            return View(ViewModel);
        }
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BooksController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BooksController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BooksController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BooksController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BooksController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BooksController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        private ApplicationDbContext _context;
    }
    
}
