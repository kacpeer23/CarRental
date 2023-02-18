using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarRental.Models;

namespace CarRental.Controllers
{
    public class AccidentModelsController : Controller
    {
        private readonly CarDbContext _context;

        public AccidentModelsController(CarDbContext context)
        {
            _context = context;
        }

        // GET: AccidentModels
        public async Task<IActionResult> Index()
        {
              return View(await _context.Accidents.ToListAsync());
        }

        // GET: AccidentModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Accidents == null)
            {
                return NotFound();
            }

            var accidentModel = await _context.Accidents
                .FirstOrDefaultAsync(m => m.Id == id);
            if (accidentModel == null)
            {
                return NotFound();
            }

            return View(accidentModel);
        }

        // GET: AccidentModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AccidentModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Car,Client,Description,DateOfAccident")] AccidentModel accidentModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(accidentModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(accidentModel);
        }

        // GET: AccidentModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Accidents == null)
            {
                return NotFound();
            }

            var accidentModel = await _context.Accidents.FindAsync(id);
            if (accidentModel == null)
            {
                return NotFound();
            }
            return View(accidentModel);
        }

        // POST: AccidentModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Car,Client,Description,DateOfAccident")] AccidentModel accidentModel)
        {
            if (id != accidentModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(accidentModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccidentModelExists(accidentModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(accidentModel);
        }

        // GET: AccidentModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Accidents == null)
            {
                return NotFound();
            }

            var accidentModel = await _context.Accidents
                .FirstOrDefaultAsync(m => m.Id == id);
            if (accidentModel == null)
            {
                return NotFound();
            }

            return View(accidentModel);
        }

        // POST: AccidentModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Accidents == null)
            {
                return Problem("Entity set 'CarDbContext.Accidents'  is null.");
            }
            var accidentModel = await _context.Accidents.FindAsync(id);
            if (accidentModel != null)
            {
                _context.Accidents.Remove(accidentModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AccidentModelExists(int id)
        {
          return _context.Accidents.Any(e => e.Id == id);
        }
    }
}
