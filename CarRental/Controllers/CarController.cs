using CarRental.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    public class CarController : Controller
    {
        public IActionResult HomePage()
        {
            return View();
        }
        public IActionResult HomePage(CarModel model)
        {
            if (ModelState.IsValid)
            {
                return View("NewCar");
            }
            return View();
        }
    }
}
