using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bookApp.Models;
using bookApp.ViewModels;
using bookApp.Models;
using LibApp.Models;
using bookApp.Data;
using Microsoft.EntityFrameworkCore;
namespace LibApp.Controllers
{
    
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;
        //DbContext will be polled through Dependency Injection

        public CustomersController(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }
        public ViewResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();

            return View(customers);
        }

        public IActionResult Details(int id)
        {
            var customer = _context.Customers
                .Include(c => c.MembershipType)
                .SingleOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return Content("User not found");
            }

            return View(customer);
        }
        public IActionResult New()
        {
            return View();
        }
     

        
    }
}