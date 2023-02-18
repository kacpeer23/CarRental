using CarRental.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    public class CarController : Controller
    {
        private readonly CarDbContext _context;
        public CarController(CarDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var cars = _context.Cars.ToList();
            return View(cars);
        }
        
    }
}
