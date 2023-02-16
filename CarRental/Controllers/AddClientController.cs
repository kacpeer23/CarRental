using CarRental.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    public class AddClientController : Controller
    {
        private readonly CarDbContext _context;
        public AddClientController(CarDbContext context)
        {
            _context = context;
        }
        [Authorize(Roles = "Administrator")]
        public IActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "Administrator")]
        public IActionResult Create()
        {
            return View();
        }
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public IActionResult Create([FromForm] ClientModel client)
        {
            Console.WriteLine(client);
            if (ModelState.IsValid)
            {
                _context.Clients.Add(client);
                _context.SaveChanges();
            }
            return View();
        }
    }
}
