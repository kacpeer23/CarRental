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
        public IActionResult Create()
        {
            return View();
        }
        /*public IActionResult Index(ClientModel model)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            return View();
        }*/
    }
}
