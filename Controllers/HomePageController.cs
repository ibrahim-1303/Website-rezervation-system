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
    public class HomePageController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public HomePageController(ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }

        // GET: HomePage
        public async Task<IActionResult> Index()
        {
          
            return View(await _context.HomePages.ToListAsync());
        }

        // GET: HomePage/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homePage = await _context.HomePages
                .FirstOrDefaultAsync(m => m.Id == id);
            if (homePage == null)
            {
                return NotFound();
            }

            return View(homePage);
        }

        // GET: HomePage/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HomePage/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,LogoYazısı,Baslik,Aciklama,ResimDosyası,ResimDosyası1,Baslik1,Aciklama1,ResimDosyası2,ServislerBasli,SrvislerAciklama,BaslikDigerSacStilleri,AciklamaDigerSacStilleri,ResimDosyası3,BaslikKaliteliSacKesimi,AciklamaKaliteliSacKesimi,ResimDosyası4")] HomePage homePage)
        {

            if (ModelState.IsValid)
            {

                string wwwRoothPath = _hostEnvironment.WebRootPath;
                string wwwRoothPath1 = _hostEnvironment.WebRootPath;
                string wwwRoothPath2 = _hostEnvironment.WebRootPath;
                string wwwRoothPath3 = _hostEnvironment.WebRootPath;
                string wwwRoothPath4 = _hostEnvironment.WebRootPath;


                string fileName = Path.GetFileNameWithoutExtension(homePage.ResimDosyası.FileName);
                string fileName1 = Path.GetFileNameWithoutExtension(homePage.ResimDosyası1.FileName);
                string fileName2 = Path.GetFileNameWithoutExtension(homePage.ResimDosyası2.FileName);
                string fileName3 = Path.GetFileNameWithoutExtension(homePage.ResimDosyası3.FileName);
                string fileName4 = Path.GetFileNameWithoutExtension(homePage.ResimDosyası4.FileName);

                string extension = Path.GetExtension(homePage.ResimDosyası.FileName);
                string extension1 = Path.GetExtension(homePage.ResimDosyası1.FileName);
                string extension2 = Path.GetExtension(homePage.ResimDosyası2.FileName);
                string extension3 = Path.GetExtension(homePage.ResimDosyası3.FileName);
                string extension4 = Path.GetExtension(homePage.ResimDosyası4.FileName);

                homePage.ResimYolu = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                homePage.ResimYolu1 = fileName1 = fileName1 + DateTime.Now.ToString("yymmssfff") + extension;
                homePage.ResimYolu2 = fileName2 = fileName2 + DateTime.Now.ToString("yymmssfff") + extension;
                homePage.ResimYolu3 = fileName3 = fileName3 + DateTime.Now.ToString("yymmssfff") + extension;
                homePage.ResimYolu4 = fileName4 = fileName4 + DateTime.Now.ToString("yymmssfff") + extension;

                string path = Path.Combine(wwwRoothPath + "/HomePageResimleri/", fileName);
                string path1 = Path.Combine(wwwRoothPath + "/HomePageResimleri/", fileName1);
                string path2 = Path.Combine(wwwRoothPath + "/HomePageResimleri/", fileName2);
                string path3 = Path.Combine(wwwRoothPath + "/HomePageResimleri/", fileName3);
                string path4 = Path.Combine(wwwRoothPath + "/HomePageResimleri/", fileName4);

                using (var fileStream = new FileStream(path, FileMode.Create))
                {

                    await homePage.ResimDosyası.CopyToAsync(fileStream);
                }
                using (var fileStream1 = new FileStream(path1, FileMode.Create))
                {

                    await homePage.ResimDosyası1.CopyToAsync(fileStream1);
                }
                using (var fileStream2 = new FileStream(path2, FileMode.Create))
                {
                    await homePage.ResimDosyası2.CopyToAsync(fileStream2);
                }

                using (var fileStream3 = new FileStream(path3, FileMode.Create))
                {
                    await homePage.ResimDosyası3.CopyToAsync(fileStream3);
                }

                using (var fileStream4 = new FileStream(path4, FileMode.Create))
                {
                    await homePage.ResimDosyası4.CopyToAsync(fileStream4);
                }
                _context.Add(homePage);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(homePage);
        }

        // GET: HomePage/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homePage = await _context.HomePages.FindAsync(id);
            if (homePage == null)
            {
                return NotFound();
            }
            return View(homePage);
        }

        // POST: HomePage/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,LogoYazısı,Baslik,Aciklama,ResimYolu,ResimYolu1,Baslik1,Aciklama1,ResimYolu2,ServislerBasli,SrvislerAciklama,BaslikDigerSacStilleri,AciklamaDigerSacStilleri,ResimYolu3,BaslikKaliteliSacKesimi,AciklamaKaliteliSacKesimi,ResimYolu4")] HomePage homePage)
        {
            if (id != homePage.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(homePage);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HomePageExists(homePage.Id))
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
            return View(homePage);
        }

        // GET: HomePage/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homePage = await _context.HomePages
                .FirstOrDefaultAsync(m => m.Id == id);
            if (homePage == null)
            {
                return NotFound();
            }

            return View(homePage);
        }

        // POST: HomePage/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var homePage = await _context.HomePages.FindAsync(id);
            var homePage1 = await _context.HomePages.FindAsync(id);
            var homePage2 = await _context.HomePages.FindAsync(id);
            var homePage3 = await _context.HomePages.FindAsync(id);
            var homePage4 = await _context.HomePages.FindAsync(id);
            var imagePath = Path.Combine(_hostEnvironment.WebRootPath, "HomePageResimleri", homePage.ResimYolu);
            var imagePath1 = Path.Combine(_hostEnvironment.WebRootPath, "HomePageResimleri", homePage1.ResimYolu1);
            var imagePath2 = Path.Combine(_hostEnvironment.WebRootPath, "HomePageResimleri", homePage2.ResimYolu2);
            var imagePath3 = Path.Combine(_hostEnvironment.WebRootPath, "HomePageResimleri", homePage3.ResimYolu3);
            var imagePath4 = Path.Combine(_hostEnvironment.WebRootPath, "HomePageResimleri", homePage4.ResimYolu4);
            if (System.IO.File.Exists(imagePath))
            {
                System.IO.File.Delete(imagePath);
                System.IO.File.Delete(imagePath1);
                System.IO.File.Delete(imagePath2);
                System.IO.File.Delete(imagePath3);
                System.IO.File.Delete(imagePath4);

            }
            _context.HomePages.Remove(homePage);
            _context.HomePages.Remove(homePage1);
            _context.HomePages.Remove(homePage2);
            _context.HomePages.Remove(homePage3);
            _context.HomePages.Remove(homePage4);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HomePageExists(int id)
        {
            return _context.HomePages.Any(e => e.Id == id);
        }
    }
}
