using CarRental.Models;
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
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
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
