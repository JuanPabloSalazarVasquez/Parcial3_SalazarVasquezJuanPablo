using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Parcial3_SalazarVasquezJuanPablo.DAL;
using Parcial3_SalazarVasquezJuanPablo.DAL.Entities;

namespace Parcial3_SalazarVasquezJuanPablo.Controllers
{
    public class VehicleDetailsController : Controller
    {
        private readonly DatabaseContext _context;

        public VehicleDetailsController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: VehicleDetails
        public async Task<IActionResult> Index()
        {
              return _context.VehicleDetails != null ? 
                          View(await _context.VehicleDetails.ToListAsync()) :
                          Problem("Entity set 'DatabaseContext.VehicleDetails'  is null.");
        }

        // GET: VehicleDetails/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.VehicleDetails == null)
            {
                return NotFound();
            }

            var vehicleDetail = await _context.VehicleDetails
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vehicleDetail == null)
            {
                return NotFound();
            }

            return View(vehicleDetail);
        }

        // GET: VehicleDetails/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VehicleDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(VehicleDetail vehicleDetail)
        {
            if (ModelState.IsValid)
            {
                vehicleDetail.Id = Guid.NewGuid();
                _context.Add(vehicleDetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vehicleDetail);
        }

        // GET: VehicleDetails/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.VehicleDetails == null)
            {
                return NotFound();
            }

            var vehicleDetail = await _context.VehicleDetails.FindAsync(id);
            if (vehicleDetail == null)
            {
                return NotFound();
            }
            return View(vehicleDetail);
        }

        // POST: VehicleDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, VehicleDetail vehicleDetail)
        {
            if (id != vehicleDetail.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vehicleDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VehicleDetailExists(vehicleDetail.Id))
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
            return View(vehicleDetail);
        }

        // GET: VehicleDetails/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.VehicleDetails == null)
            {
                return NotFound();
            }

            var vehicleDetail = await _context.VehicleDetails
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vehicleDetail == null)
            {
                return NotFound();
            }

            return View(vehicleDetail);
        }

        // POST: VehicleDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.VehicleDetails == null)
            {
                return Problem("Entity set 'DatabaseContext.VehicleDetails'  is null.");
            }
            var vehicleDetail = await _context.VehicleDetails.FindAsync(id);
            if (vehicleDetail != null)
            {
                _context.VehicleDetails.Remove(vehicleDetail);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VehicleDetailExists(Guid id)
        {
          return (_context.VehicleDetails?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
