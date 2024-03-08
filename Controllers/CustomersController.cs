using System.Runtime.InteropServices.JavaScript;
using FirstProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FirstProject.Controllers
{
    public class CustomersController : Controller
    {

        private StoreContext _context;

        public CustomersController()
        {
            _context = new StoreContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            List<Customer> customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            Customer? customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return View("Error");
            return View(customer);
        }

        public ActionResult New()
        {
            return View();
        }
    }
}