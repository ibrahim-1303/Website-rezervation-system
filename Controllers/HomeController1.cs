using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Güzellik_Merkezi.Data;

namespace KuaförRandevu00.Controllers
{
    public class HomeController1 : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;
        private readonly ILogger<HomeController1> _logger;
        public HomeController1(ApplicationDbContext context, IWebHostEnvironment hostEnvironment, ILogger<HomeController1> logger)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;

            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.HomePages.ToListAsync());
        }
        public async Task<IActionResult> Hizmetler()
        {
            return View(await _context.Servislers.ToListAsync());
        }

        public async Task<IActionResult> İletisim()
        {
            return View(await _context.İletisims.ToListAsync());
        }
        public IActionResult Privacy()
        {
            return View();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
