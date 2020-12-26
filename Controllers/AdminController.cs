using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Güzellik_Merkezi.Data;
using Güzellik_Merkezi.Models;
using Güzellik_Merkezi.Services;
using KuaförRandevu00.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Güzellik_Merkezi.Controllers
{

    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IRandevuService _randevuService;
        private readonly IMüsteriService _müsteriService;

        public AdminController(ApplicationDbContext dbContext,IRandevuService randevuService,IMüsteriService müsteriService)
        {
            _dbContext = dbContext;
            _randevuService = randevuService;
            _müsteriService = müsteriService;
        }

        //public ActionResult GirisYap()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult GirisYap(string Name, string Sifre)
        //{
        //    var admin = _dbContext.Roles.FirstOrDefault(x => x.Name == Name && x.Sifre == Sifre);
        //    if (admin != null)
        //    {   
        //        return View("Index");
        //    }
        //    ViewBag.msg = "Kullanıcı Girişi Başarısız";
        //    return View();
        //}

        
        public ActionResult Index()
        {
            return View();
        }

  
        public ActionResult CikisYap()
        {
            
            return RedirectToAction("Index", "HomeController1");
        }
        
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: AdminController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(string Name ,string Sifre)
        //{
        //    var admin = _dbContext.Roles.FirstOrDefault();
        //    if (admin != null)
        //    {
        //        ViewBag.msj0 = "Bilgiler başarıyla değiştirildi";
        //        admin.Name = Name;
        //        admin.Sifre = Sifre;
        //        _dbContext.SaveChanges();
        //        return View("Index");
        //    }

        //    return NotFound("Bilgileriniz değiştirilemedi");
        //}


        // GET: Randevu/Create
        public IActionResult CreateRandevu()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateRandevu(Randevu randevu)
        {
            _randevuService.Create(randevu);
            _dbContext.SaveChanges();
            return View("Index");
   
        }

        public IActionResult EditRandevu(int? id)
        {
            return View();
        }

        // POST: Randevu/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditRandevu(Randevu randevu)
        {
            _randevuService.Update(randevu);
            _dbContext.SaveChanges();
            return View("Index");
        }


        // GET: Randevu/Delete/5
        public IActionResult  DeleteRandevu(int? id)
        {
            if (id==null)
            {
                return NotFound("Böyle bir randevu sistemde bulunamadı.");
            }

            var randevu = _randevuService.GetAll();
            var randevu1 = randevu.FirstOrDefault(x => x.Id == id);
            if (randevu1==null)
            {
                return NotFound("Böyle bir randevu sistemde bulunamadı.");
            }
            
            return View(randevu1);
        }

        // POST: Randevu/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteRandevu(Randevu randevu)
        {
            _randevuService.Delete(randevu);
            _dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        //---------------------------------------------------------------------


        public IActionResult MüsteriIndex()
        {
            _müsteriService.GetAll();
            return View();
        }

        // GET: Randevu/Create
        public IActionResult CreateMüsteri()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateMüsteri(AppUser appUser)
        {

            _müsteriService.Create(appUser);
            _dbContext.SaveChanges();
            return View("MüsteriIndex");

        }

        public IActionResult DeleteMüsteri(string id)
        {

            var müsteri1 = _dbContext.Users.FirstOrDefault(x => x.Id == id);
            if (id == null)
            {
                return NotFound("Böyle bir müşteri sistemde bulunamadı");
            }
            return View(müsteri1);
            

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteMüsteri(AppUser appUser)
        {
            var müsteri1 = _dbContext.Users.FirstOrDefault(x => x.Id == appUser.Id);

           
            if (müsteri1 != null)
            {
                _dbContext.Remove(müsteri1);

                await _dbContext.SaveChangesAsync();
              
                return View("MüsteriIndex");
            }

            return View();

        }



        public IActionResult EditMüsteri(string? id)
        {
            return View();
        }

        // POST: Randevu/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditMüsteri(string? id,[Bind("Id,Ad,Soyad,Email,PhoneNumber")] AppUser appUser)
        {

            var müsteri1 = _dbContext.Users.FirstOrDefault(x => x.Id == appUser.Id);

            appUser.AccessFailedCount= müsteri1.AccessFailedCount;
            müsteri1.ConcurrencyStamp = appUser.ConcurrencyStamp;
            appUser.LockoutEnabled = müsteri1.LockoutEnabled ;
            appUser.LockoutEnd=müsteri1.LockoutEnd;
            müsteri1.Email = appUser.Email;
            appUser.EmailConfirmed = müsteri1.EmailConfirmed;
            müsteri1.Id = appUser.Id ;
            appUser.NormalizedEmail = müsteri1.NormalizedEmail;
            appUser.NormalizedUserName = müsteri1.NormalizedUserName;
            appUser.PasswordHash = müsteri1.PasswordHash ;
            müsteri1.PhoneNumber = appUser.PhoneNumber;
            müsteri1.PhoneNumberConfirmed = appUser.PhoneNumberConfirmed ;
            müsteri1.SecurityStamp = appUser.SecurityStamp ;
            müsteri1.Soyad = appUser.Soyad;
            müsteri1.TwoFactorEnabled = appUser.TwoFactorEnabled ;
            appUser.UserName = müsteri1.UserName;
            müsteri1.Ad = appUser.Ad;
            if (müsteri1!=null)
            {
                _dbContext.Update(müsteri1);
                _dbContext.SaveChanges();
                ViewBag.mes = "Müşteri bilgileri başarıyla değiştirildi";
                return View("MüsteriIndex");
            }
           
            return View("Index");
        }

    }
}
