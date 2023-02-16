using CarRental.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    public class AddCarController : Controller
    {
        private readonly CarDbContext _context;
        public AddCarController(CarDbContext context)
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
        public IActionResult Create([FromForm] CarModel car)
        {
            if (ModelState.IsValid)
            {
                _context.Cars.Add(car);
                _context.SaveChanges();
            }
            return View();
        }
    }
}
