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
    public class SiswaPelajaransController : Controller
    {
        private readonly SiswaDbContext _context;

        public SiswaPelajaransController(SiswaDbContext context)
        {
            _context = context;
        }

        // GET: SiswaPelajarans
        public async Task<IActionResult> Index()
        {
            //return _context.SiswaPelajarans != null ? 
            //            View(await _context.SiswaPelajarans.ToListAsync()) :
            //            Problem("Entity set 'SiswaDbContext.SiswaPelajarans'  is null.");

            var siswapel = _context.SiswaPelajarans.ToList();

            //var test = siswapel.Select(x => x.Siswa.Name).ToList();

            var coba = _context.SiswaPelajarans.Where(x => x.MataPelajaran.IdPelajaran == 1);

            if (siswapel == null)
            {
                Problem("Entity set 'SiswaDbContext.SiswaPelajarans'  is null.");
            }

            return View(siswapel);
        }

        // GET: SiswaPelajarans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.SiswaPelajarans == null)
            {
                return NotFound();
            }

            var siswaPelajaran = await _context.SiswaPelajarans
                .FirstOrDefaultAsync(m => m.IdSiswaPelajaran == id);
            if (siswaPelajaran == null)
            {
                return NotFound();
            }

            return View(siswaPelajaran);
        }

        // GET: SiswaPelajarans/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SiswaPelajarans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdSiswaPelajaran,IdSiswa,IdPelajaran")] SiswaPelajaran siswaPelajaran)
        {
            if (ModelState.IsValid)
            {
                _context.Add(siswaPelajaran);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(siswaPelajaran);
        }

        // GET: SiswaPelajarans/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.SiswaPelajarans == null)
            {
                return NotFound();
            }

            var siswaPelajaran = await _context.SiswaPelajarans.FindAsync(id);
            if (siswaPelajaran == null)
            {
                return NotFound();
            }
            return View(siswaPelajaran);
        }

        // POST: SiswaPelajarans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdSiswaPelajaran,IdSiswa,IdPelajaran")] SiswaPelajaran siswaPelajaran)
        {
            if (id != siswaPelajaran.IdSiswaPelajaran)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(siswaPelajaran);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SiswaPelajaranExists(siswaPelajaran.IdSiswaPelajaran))
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
            return View(siswaPelajaran);
        }

        // GET: SiswaPelajarans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.SiswaPelajarans == null)
            {
                return NotFound();
            }

            var siswaPelajaran = await _context.SiswaPelajarans
                .FirstOrDefaultAsync(m => m.IdSiswaPelajaran == id);
            if (siswaPelajaran == null)
            {
                return NotFound();
            }

            return View(siswaPelajaran);
        }

        // POST: SiswaPelajarans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.SiswaPelajarans == null)
            {
                return Problem("Entity set 'SiswaDbContext.SiswaPelajarans'  is null.");
            }
            var siswaPelajaran = await _context.SiswaPelajarans.FindAsync(id);
            if (siswaPelajaran != null)
            {
                _context.SiswaPelajarans.Remove(siswaPelajaran);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SiswaPelajaranExists(int id)
        {
          return (_context.SiswaPelajarans?.Any(e => e.IdSiswaPelajaran == id)).GetValueOrDefault();
        }
    }
}
