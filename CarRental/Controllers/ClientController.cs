using CarRental.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    public class ClientController : Controller
    {
        private readonly CarDbContext _context;
        public ClientController(CarDbContext context)
        {
            _context = context;
        }
        [Authorize(Roles = "Administrator")]
        [HttpGet]
        public IActionResult Index()
        {
            var cars = _context.Clients.ToList();
            return View(cars);
        }
    }
}
