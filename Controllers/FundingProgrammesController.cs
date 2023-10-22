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
    public class FundingProgrammesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FundingProgrammesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: FundingProgrammes
        public async Task<IActionResult> Index()
        {
            return View(await _context.fundingProgrammes.ToListAsync());
        }

        // GET: FundingProgrammes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fundingProgramme = await _context.fundingProgrammes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fundingProgramme == null)
            {
                return NotFound();
            }

            return View(fundingProgramme);
        }

        // GET: FundingProgrammes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FundingProgrammes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Id")] FundingProgramme fundingProgramme)
        {
            try { 
            if (ModelState.IsValid)
            {
                _context.Add(fundingProgramme);
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
            return View(fundingProgramme);
        }

        // GET: FundingProgrammes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fundingProgramme = await _context.fundingProgrammes.FindAsync(id);
            if (fundingProgramme == null)
            {
                return NotFound();
            }
            return View(fundingProgramme);
        }

        // POST: FundingProgrammes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Id")] FundingProgramme fundingProgramme)
        {
            if (id != fundingProgramme.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fundingProgramme);
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
            return View(fundingProgramme);
        }

        // GET: FundingProgrammes/Delete/5
        public async Task<IActionResult> Delete(int? id, bool? saveChangesError = false)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fundingProgramme = await _context.fundingProgrammes
                 .AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fundingProgramme == null)
            {
                return NotFound();
            }
            if (saveChangesError.GetValueOrDefault())
            {
                ViewData["ErrorMessage"] =
                    "Delete failed. Try again, and if the problem persists " +
                    "see your system administrator.";
            }

            return View(fundingProgramme);
        }

        // POST: FundingProgrammes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fundingProgramme = await _context.fundingProgrammes.FindAsync(id);
            if (fundingProgramme == null)
            {
                return RedirectToAction(nameof(Index));
            }

            try
            {
                _context.fundingProgrammes.Remove(fundingProgramme);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    catch (DbUpdateException )
    {
        
        return RedirectToAction(nameof(Delete), new { id = id, saveChangesError = true });
    }
        }

        private bool FundingProgrammeExists(int id)
        {
            return _context.fundingProgrammes.Any(e => e.Id == id);
        }
    }
}
