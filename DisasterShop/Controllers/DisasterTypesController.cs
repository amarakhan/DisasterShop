using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DisasterShop.Data;

namespace DisasterShop.Controllers
{
    public class DisasterTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DisasterTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DisasterTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.DisasterTypes.ToListAsync());
        }

        // GET: DisasterTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var disasterType = await _context.DisasterTypes
                .FirstOrDefaultAsync(m => m.ID == id);
            if (disasterType == null)
            {
                return NotFound();
            }

            return View(disasterType);
        }

        // GET: DisasterTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DisasterTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Description,BannerImageUrl")] DisasterType disasterType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(disasterType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(disasterType);
        }

        // GET: DisasterTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var disasterType = await _context.DisasterTypes.FindAsync(id);
            if (disasterType == null)
            {
                return NotFound();
            }
            return View(disasterType);
        }

        // POST: DisasterTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Description,BannerImageUrl")] DisasterType disasterType)
        {
            if (id != disasterType.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(disasterType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DisasterTypeExists(disasterType.ID))
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
            return View(disasterType);
        }

        // GET: DisasterTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var disasterType = await _context.DisasterTypes
                .FirstOrDefaultAsync(m => m.ID == id);
            if (disasterType == null)
            {
                return NotFound();
            }

            return View(disasterType);
        }

        // POST: DisasterTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var disasterType = await _context.DisasterTypes.FindAsync(id);
            _context.DisasterTypes.Remove(disasterType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DisasterTypeExists(int id)
        {
            return _context.DisasterTypes.Any(e => e.ID == id);
        }
    }
}
