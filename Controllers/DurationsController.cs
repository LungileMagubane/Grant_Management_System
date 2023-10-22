using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Grant_Management_System.Data;
using Grant_Management_System.Models.DropdownMenus;

namespace Grant_Management_System.Controllers
{
    public class DurationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DurationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Durations
        public async Task<IActionResult> Index()
        {
            return View(await _context.durations.ToListAsync());
        }

        // GET: Durations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var duration = await _context.durations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (duration == null)
            {
                return NotFound();
            }

            return View(duration);
        }

        // GET: Durations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Durations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Id")] Duration duration)
        {
            try
            {
                if (ModelState.IsValid)
            {
                _context.Add(duration);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
        }
    catch (DbUpdateException /* ex */)
    {
        //Log the error (uncomment ex variable name and write a log.
        ModelState.AddModelError("", "Unable to save changes. " +
            "Try again, and if the problem persists " +
            "see your system administrator.");
    }
            return View(duration);
        }

        // GET: Durations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var duration = await _context.durations.FindAsync(id);
            if (duration == null)
            {
                return NotFound();
            }
            return View(duration);
        }

        // POST: Durations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Id")] Duration duration)
        {
            if (id != duration.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(duration);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateException)
                {
                    ModelState.AddModelError("", "Unable to save changes. " +
               "Try again, and if the problem persists, " +
               "see your system administrator.");
                }
                
            }
            return View(duration);
        }

        // GET: Durations/Delete/5
        public async Task<IActionResult> Delete(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return NotFound();
            }

            var duration = await _context.durations
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (duration == null)
            {
                return NotFound();
            }
            if (saveChangesError.GetValueOrDefault())
            {
                ViewData["ErrorMessage"] =
                    "Delete failed. Try again, and if the problem persists " +
                    "see your system administrator.";
            }

            return View(duration);
        }

        // POST: Durations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var duration = await _context.durations.FindAsync(id);
            if (duration == null)
            {
                return RedirectToAction(nameof(Index));
            }

            try
            {
                _context.durations.Remove(duration);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    catch (DbUpdateException )
    {
        
        return RedirectToAction(nameof(Delete), new { id = id, saveChangesError = true });
    }
        }

        private bool DurationExists(int id)
        {
            return _context.durations.Any(e => e.Id == id);
        }
    }
}
