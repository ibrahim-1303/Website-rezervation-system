using KuaförRandevu00.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KuaförRandevu00.ViewComponents
{
    public class HizmetlerListViewComponent : ViewComponent
    {
        private readonly IHizmetService _hizmetService;

        public HizmetlerListViewComponent(IHizmetService hizmetService)
        {
            _hizmetService = hizmetService;
        }


        public IViewComponentResult Invoke()
        {

            var hizmet=  _hizmetService.GetAll();
            return View(hizmet);
        }
    }
}
