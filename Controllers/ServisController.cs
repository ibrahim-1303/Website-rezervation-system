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
    public class ServisController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ServisController(ApplicationDbContext context,IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        // GET: Servis
        public async Task<IActionResult> Index()
        {
            return View(await _context.Servislers.ToListAsync());
        }

        // GET: Servis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servis = await _context.Servislers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (servis == null)
            {
                return NotFound();
            }

            return View(servis);
        }

        // GET: Servis/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Servis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,LogoYazısı,Baslik,Aciklama,Baslik1,Aciklama1,Baslik2,Aciklama2,Baslik3,Aciklama3,Baslik4,Aciklama4,Baslik5,Aciklama5,Baslik6,Aciklama6,ClientSaysbaslik,ClientSaysAciklama,ResimDosyası,Müsteriisim,MüsteriAciklama,ResimDosyası2,Müsteriisim2,MüsteriAciklama2,ResimDosyası3,Müsteriisim3,MüsteriAciklama3,KalitelisacBaslik,KalitelisacAciklama,ResimDosyası1")] Servis servis)
        {

            if (ModelState.IsValid)
            {
                string wwwRootPath = _hostEnvironment.WebRootPath;
                string wwwRootPaht1 = _hostEnvironment.WebRootPath;
                string wwwRootPath2 = _hostEnvironment.WebRootPath;
                string wwwRootPaht3 = _hostEnvironment.WebRootPath;

                string fileName = Path.GetFileNameWithoutExtension(servis.ResimDosyası.FileName);
                string fileName1 = Path.GetFileNameWithoutExtension(servis.ResimDosyası1.FileName);
                string fileName2 = Path.GetFileNameWithoutExtension(servis.ResimDosyası2.FileName);
                string fileName3 = Path.GetFileNameWithoutExtension(servis.ResimDosyası3.FileName);

                string extension = Path.GetExtension(servis.ResimDosyası.FileName);
                string extension1 = Path.GetExtension(servis.ResimDosyası1.FileName);
                string extension2 = Path.GetExtension(servis.ResimDosyası2.FileName);
                string extension3 = Path.GetExtension(servis.ResimDosyası3.FileName);


                servis.ResimYolu= fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                servis.ResimYolu1 = fileName1 = fileName1 + DateTime.Now.ToString("yymmssfff") + extension;
                servis.ResimYolu2 = fileName2 = fileName2 + DateTime.Now.ToString("yymmssfff") + extension;
                servis.ResimYolu3 = fileName3 = fileName3 + DateTime.Now.ToString("yymmssfff") + extension;

                string path = Path.Combine(wwwRootPath + "/ServislerimizResimleri/", fileName);
                string path1 = Path.Combine(wwwRootPaht1 + "/ServislerimizResimleri/", fileName1);
                string path2 = Path.Combine(wwwRootPath2 + "/ServislerimizResimleri/", fileName2);
                string path3 = Path.Combine(wwwRootPaht3 + "/ServislerimizResimleri/", fileName3);

                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    await servis.ResimDosyası.CopyToAsync(fileStream);
                }

                using (var fileStream1 = new FileStream(path1,FileMode.Create))
                {
                    await servis.ResimDosyası1.CopyToAsync(fileStream1);
                }
                using (var fileStream2 = new FileStream(path2, FileMode.Create))
                {
                    await servis.ResimDosyası2.CopyToAsync(fileStream2);
                }
                using (var fileStream3 = new FileStream(path3, FileMode.Create))
                {
                    await servis.ResimDosyası3.CopyToAsync(fileStream3);
                }

                _context.Add(servis);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(servis);
        }

        // GET: Servis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servis = await _context.Servislers.FindAsync(id);
            if (servis == null)
            {
                return NotFound();
            }
            return View(servis);
        }

        // POST: Servis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,LogoYazısı,Baslik,Aciklama,Baslik1,Aciklama1,Baslik2,Aciklama2,Baslik3,Aciklama3,Baslik4,Aciklama4,Baslik5,Aciklama5,Baslik6,Aciklama6,ClientSaysbaslik,ClientSaysAciklama,ResimYolu,Müsteriisim,MüsteriAciklama,ResimYolu2,Müsteriisim2,MüsteriAciklama2,ResimYolu3,Müsteriisim3,MüsteriAciklama3,KalitelisacBaslik,KalitelisacAciklama,ResimYolu1")] Servis servis)
        {
            if (id != servis.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(servis);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServisExists(servis.Id))
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
            return View(servis);
        }

        // GET: Servis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var servis = await _context.Servislers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (servis == null)
            {
                return NotFound();
            }

            return View(servis);
        }

        // POST: Servis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {

            var servis = await _context.Servislers.FindAsync(id);
            var servis1 = await _context.Servislers.FindAsync(id);
            var servis2 = await _context.Servislers.FindAsync(id);
            var servis3 = await _context.Servislers.FindAsync(id);

            var imagePath = Path.Combine(_hostEnvironment.WebRootPath, "ServislerimizResimleri", servis.ResimYolu);
            var imagePath1 = Path.Combine(_hostEnvironment.WebRootPath, "ServislerimizResimleri", servis.ResimYolu1);
            var imagePath2 = Path.Combine(_hostEnvironment.WebRootPath, "ServislerimizResimleri", servis.ResimYolu2);
            var imagePath3 = Path.Combine(_hostEnvironment.WebRootPath, "ServislerimizResimleri", servis.ResimYolu3);

            if (System.IO.File.Exists(imagePath))
            {
                System.IO.File.Delete(imagePath);
                System.IO.File.Delete(imagePath1);
                System.IO.File.Delete(imagePath2);
                System.IO.File.Delete(imagePath3);
            }


            _context.Servislers.Remove(servis);
            _context.Servislers.Remove(servis1);
            _context.Servislers.Remove(servis2);
            _context.Servislers.Remove(servis3);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ServisExists(int id)
        {
            return _context.Servislers.Any(e => e.Id == id);
        }
    }
}
