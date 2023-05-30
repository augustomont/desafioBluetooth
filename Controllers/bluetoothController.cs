using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using desafioBluetooth.Models;

namespace desafioBluetooth.Controllers
{
    public class bluetoothController : Controller
    {
        private readonly Contexto _context;

        public bluetoothController(Contexto context)
        {
            _context = context;
        }

        // GET: bluetooth
        public async Task<IActionResult> Index()
        {
              return _context.Bluetooth != null ? 
                          View(await _context.Bluetooth.ToListAsync()) :
                          Problem("Entity set 'Contexto.Bluetooth'  is null.");
        }

        // GET: bluetooth/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Bluetooth == null)
            {
                return NotFound();
            }

            var bluetoothModel = await _context.Bluetooth
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bluetoothModel == null)
            {
                return NotFound();
            }

            return View(bluetoothModel);
        }

        // GET: bluetooth/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: bluetooth/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Periodo,MAC,MACScan,MACPaired,DataHoraEvento,FlagProcess,ApplicationUserId")] bluetoothModel bluetoothModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bluetoothModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bluetoothModel);
        }

        // GET: bluetooth/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Bluetooth == null)
            {
                return NotFound();
            }

            var bluetoothModel = await _context.Bluetooth.FindAsync(id);
            if (bluetoothModel == null)
            {
                return NotFound();
            }
            return View(bluetoothModel);
        }

        // POST: bluetooth/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Periodo,MAC,MACScan,MACPaired,DataHoraEvento,FlagProcess,ApplicationUserId")] bluetoothModel bluetoothModel)
        {
            if (id != bluetoothModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bluetoothModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!bluetoothModelExists(bluetoothModel.Id))
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
            return View(bluetoothModel);
        }

        // GET: bluetooth/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Bluetooth == null)
            {
                return NotFound();
            }

            var bluetoothModel = await _context.Bluetooth
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bluetoothModel == null)
            {
                return NotFound();
            }

            return View(bluetoothModel);
        }

        // POST: bluetooth/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Bluetooth == null)
            {
                return Problem("Entity set 'Contexto.Bluetooth'  is null.");
            }
            var bluetoothModel = await _context.Bluetooth.FindAsync(id);
            if (bluetoothModel != null)
            {
                _context.Bluetooth.Remove(bluetoothModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool bluetoothModelExists(int id)
        {
          return (_context.Bluetooth?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
