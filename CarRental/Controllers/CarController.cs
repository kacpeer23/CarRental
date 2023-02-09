using CarRental.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        private readonly CarDbContext _context;
        public CarController(CarDbContext context)
        {
            _context = context;
        }

        /*public IActionResult Index(CarModel model)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            return View();
        }*/
    }
}
