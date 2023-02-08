using CarRental.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index(ClientModel model)
        {
            if (ModelState.IsValid)
            {
                return View("NewClient");
            }
            return View();
        }
    }
}
