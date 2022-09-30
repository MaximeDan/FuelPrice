using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OilPriceAPI.Data;
using OilPriceAPI.Models;

namespace OilPriceAPI.Controllers
{
    public class OilPriceMVCWithViewController : Controller
    {
        private readonly OilPriceContext _context;

        public OilPriceMVCWithViewController(OilPriceContext context)
        {
            _context = context;
        }

        // GET: OilPriceMVCWithView
        public async Task<IActionResult> Index()
        {
              return _context.OilPrices != null ? 
                          View(await _context.OilPrices.ToListAsync()) :
                          Problem("Entity set 'OilPriceContext.OilPrices'  is null.");
        }

        // GET: OilPriceMVCWithView/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.OilPrices == null)
            {
                return NotFound();
            }

            var oilPrice = await _context.OilPrices
                .FirstOrDefaultAsync(m => m.OilPriceId == id);
            if (oilPrice == null)
            {
                return NotFound();
            }

            return View(oilPrice);
        }

        // GET: OilPriceMVCWithView/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OilPriceMVCWithView/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OilPriceId,FuelType,City,PostalCode,Address,UpdateTime,Price")] OilPrice oilPrice)
        {
            if (ModelState.IsValid)
            {
                _context.Add(oilPrice);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(oilPrice);
        }

        // GET: OilPriceMVCWithView/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.OilPrices == null)
            {
                return NotFound();
            }

            var oilPrice = await _context.OilPrices.FindAsync(id);
            if (oilPrice == null)
            {
                return NotFound();
            }
            return View(oilPrice);
        }

        // POST: OilPriceMVCWithView/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OilPriceId,FuelType,City,PostalCode,Address,UpdateTime,Price")] OilPrice oilPrice)
        {
            if (id != oilPrice.OilPriceId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(oilPrice);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OilPriceExists(oilPrice.OilPriceId))
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
            return View(oilPrice);
        }

        // GET: OilPriceMVCWithView/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.OilPrices == null)
            {
                return NotFound();
            }

            var oilPrice = await _context.OilPrices
                .FirstOrDefaultAsync(m => m.OilPriceId == id);
            if (oilPrice == null)
            {
                return NotFound();
            }

            return View(oilPrice);
        }

        // POST: OilPriceMVCWithView/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.OilPrices == null)
            {
                return Problem("Entity set 'OilPriceContext.OilPrices'  is null.");
            }
            var oilPrice = await _context.OilPrices.FindAsync(id);
            if (oilPrice != null)
            {
                _context.OilPrices.Remove(oilPrice);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OilPriceExists(int id)
        {
          return (_context.OilPrices?.Any(e => e.OilPriceId == id)).GetValueOrDefault();
        }
    }
}
