using Güzellik_Merkezi.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Güzellik_Merkezi.ViewComponents
{
    public class RandevuListViewComponent:ViewComponent
    {
        private readonly IRandevuService _randevuService;
        public RandevuListViewComponent(IRandevuService randevuService)
        {
            _randevuService = randevuService;
        }

        public IViewComponentResult Invoke()
        {
            var randevu = _randevuService.GetAll();
            return View(randevu);
        }
    }
}
