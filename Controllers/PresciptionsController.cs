using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlineDentalClinic.Data;
using OnlineDentalClinic.Models;

namespace OnlineDentalClinic.Controllers
{
    [Authorize]
    public class PresciptionsController : Controller
    {
        private readonly AppDbContext _context;

        public PresciptionsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Presciptions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Prescriptions.ToListAsync());
        }

        // GET: Presciptions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var presciption = await _context.Prescriptions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (presciption == null)
            {
                return NotFound();
            }

            return View(presciption);
        }

        // GET: Presciptions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Presciptions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Patient,Treatment,Tratment_Cost,Medicines,Quetities,Id")] Presciption presciption)
        {
            if (ModelState.IsValid)
            {
                _context.Add(presciption);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(presciption);
        }

        // GET: Presciptions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var presciption = await _context.Prescriptions.FindAsync(id);
            if (presciption == null)
            {
                return NotFound();
            }
            return View(presciption);
        }

        // POST: Presciptions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, [Bind("Patient,Treatment,Tratment_Cost,Medicines,Quetities,Id")] Presciption presciption)
        {
            if (id != presciption.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(presciption);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PresciptionExists(presciption.Id))
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
            return View(presciption);
        }

        // GET: Presciptions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var presciption = await _context.Prescriptions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (presciption == null)
            {
                return NotFound();
            }

            return View(presciption);
        }

        // POST: Presciptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var presciption = await _context.Prescriptions.FindAsync(id);
            if (presciption != null)
            {
                _context.Prescriptions.Remove(presciption);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PresciptionExists(int? id)
        {
            return _context.Prescriptions.Any(e => e.Id == id);
        }
    }
}
