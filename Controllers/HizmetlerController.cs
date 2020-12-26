using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KuaförRandevu00.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Güzellik_Merkezi.Data;
using Microsoft.AspNetCore.Authorization;

namespace KuaförRandevu00.Controllers
{
    [Authorize(Roles = "Admin")]
    public class HizmetlerController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;
        public HizmetlerController(ApplicationDbContext context,IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        // GET: Hizmetler
        public async Task<IActionResult> Index()
        {
            return View(await _context.Hizmetlers.ToListAsync());
        }



        // GET: Hizmetler/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hizmetler = await _context.Hizmetlers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hizmetler == null)
            {
                return NotFound();
            }

            return View(hizmetler);
        }

        // GET: Hizmetler/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Hizmetler/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BaslikServisler,BaslikAciklama,ResimDosyası,Baslik,Hizmet,Hizmet1,Hizmet2,Hizmet3,Hizmet4,Fiyat,Fiyat1,Fiyat2,Fiyat3,Fiyat4")] Hizmetler hizmetler)
        {
            if (ModelState.IsValid)
            {
                string wwwRoothPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(hizmetler.ResimDosyası.FileName);
                string extension = Path.GetExtension(hizmetler.ResimDosyası.FileName);
                hizmetler.ResimYolu = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                string path = Path.Combine(wwwRoothPath + "/HizmetlerResimleri/", fileName);

                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await hizmetler.ResimDosyası.CopyToAsync(fileStream);
                }


                _context.Add(hizmetler);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hizmetler);
        }

        // GET: Hizmetler/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hizmetler = await _context.Hizmetlers.FindAsync(id);
            if (hizmetler == null)
            {
                return NotFound();
            }
            return View(hizmetler);
        }

        // POST: Hizmetler/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,BaslikServisler,BaslikAciklama,ResimYolu,Baslik,Hizmet,Hizmet1,Hizmet2,Hizmet3,Hizmet4,Fiyat,Fiyat1,Fiyat2,Fiyat3,Fiyat4")] Hizmetler hizmetler)
        {
            if (id != hizmetler.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hizmetler);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HizmetlerExists(hizmetler.Id))
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
            return View(hizmetler);
        }

        // GET: Hizmetler/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hizmetler = await _context.Hizmetlers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hizmetler == null)
            {
                return NotFound();
            }

            return View(hizmetler);
        }

        // POST: Hizmetler/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            var hizmetler = await _context.Hizmetlers.FindAsync(id);
            var imagePath = Path.Combine(_hostEnvironment.WebRootPath, "HizmetlerResimleri", hizmetler.ResimYolu);

            if (System.IO.File.Exists(imagePath))
            {
                System.IO.File.Delete(imagePath);
            }
            _context.Hizmetlers.Remove(hizmetler);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HizmetlerExists(int id)
        {
            return _context.Hizmetlers.Any(e => e.Id == id);
        }
    }
}
