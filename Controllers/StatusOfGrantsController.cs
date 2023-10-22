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
    public class StatusOfGrantsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StatusOfGrantsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: StatusOfGrants
        public async Task<IActionResult> Index()
        {
            return View(await _context.statusOfGrants.ToListAsync());
        }

        // GET: StatusOfGrants/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var statusOfGrant = await _context.statusOfGrants
                .FirstOrDefaultAsync(m => m.Id == id);
            if (statusOfGrant == null)
            {
                return NotFound();
            }

            return View(statusOfGrant);
        }

        // GET: StatusOfGrants/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StatusOfGrants/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Id")] StatusOfGrant statusOfGrant)
        {
            if (ModelState.IsValid)
            {
                _context.Add(statusOfGrant);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(statusOfGrant);
        }

        // GET: StatusOfGrants/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var statusOfGrant = await _context.statusOfGrants.FindAsync(id);
            if (statusOfGrant == null)
            {
                return NotFound();
            }
            return View(statusOfGrant);
        }

        // POST: StatusOfGrants/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("Name,Id")] StatusOfGrant statusOfGrant)
        {
            if (id != statusOfGrant.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(statusOfGrant);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StatusOfGrantExists(statusOfGrant.Id))
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
            return View(statusOfGrant);
        }

        // GET: StatusOfGrants/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var statusOfGrant = await _context.statusOfGrants
                .FirstOrDefaultAsync(m => m.Id == id);
            if (statusOfGrant == null)
            {
                return NotFound();
            }

            return View(statusOfGrant);
        }

        // POST: StatusOfGrants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var statusOfGrant = await _context.statusOfGrants.FindAsync(id);
            _context.statusOfGrants.Remove(statusOfGrant);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StatusOfGrantExists(int? id)
        {
            return _context.statusOfGrants.Any(e => e.Id == id);
        }
    }
}
