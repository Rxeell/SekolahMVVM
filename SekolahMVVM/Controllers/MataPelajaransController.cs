using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SekolahMVVM.Models;

namespace SekolahMVVM.Controllers
{
    public class MataPelajaransController : Controller
    {
        private readonly SiswaDbContext _context;

        public MataPelajaransController(SiswaDbContext context)
        {
            _context = context;
        }

        // GET: MataPelajarans
        public async Task<IActionResult> Index()
        {
              return _context.MataPelajaran != null ? 
                          View(await _context.MataPelajaran.ToListAsync()) :
                          Problem("Entity set 'SiswaDbContext.MataPelajaran'  is null.");
        }

        // GET: MataPelajarans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.MataPelajaran == null)
            {
                return NotFound();
            }

            var mataPelajaran = await _context.MataPelajaran
                .FirstOrDefaultAsync(m => m.IdPelajaran == id);
            if (mataPelajaran == null)
            {
                return NotFound();
            }

            return View(mataPelajaran);
        }

        // GET: MataPelajarans/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MataPelajarans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPelajaran,NamaPelajaran")] MataPelajaran mataPelajaran)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mataPelajaran);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mataPelajaran);
        }

        // GET: MataPelajarans/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.MataPelajaran == null)
            {
                return NotFound();
            }

            var mataPelajaran = await _context.MataPelajaran.FindAsync(id);
            if (mataPelajaran == null)
            {
                return NotFound();
            }
            return View(mataPelajaran);
        }

        // POST: MataPelajarans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPelajaran,NamaPelajaran")] MataPelajaran mataPelajaran)
        {
            if (id != mataPelajaran.IdPelajaran)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mataPelajaran);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MataPelajaranExists(mataPelajaran.IdPelajaran))
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
            return View(mataPelajaran);
        }

        // GET: MataPelajarans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.MataPelajaran == null)
            {
                return NotFound();
            }

            var mataPelajaran = await _context.MataPelajaran
                .FirstOrDefaultAsync(m => m.IdPelajaran == id);
            if (mataPelajaran == null)
            {
                return NotFound();
            }

            return View(mataPelajaran);
        }

        // POST: MataPelajarans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.MataPelajaran == null)
            {
                return Problem("Entity set 'SiswaDbContext.MataPelajaran'  is null.");
            }
            var mataPelajaran = await _context.MataPelajaran.FindAsync(id);
            if (mataPelajaran != null)
            {
                _context.MataPelajaran.Remove(mataPelajaran);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MataPelajaranExists(int id)
        {
          return (_context.MataPelajaran?.Any(e => e.IdPelajaran == id)).GetValueOrDefault();
        }
    }
}
