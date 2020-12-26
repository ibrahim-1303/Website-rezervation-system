using Güzellik_Merkezi.Services;
using KuaförRandevu00.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KuaförRandevu00.ViewComponents
{
    public class MüsterilerListViewComponent : ViewComponent
    {
        private readonly IMüsteriService _müsteriService;

        public MüsterilerListViewComponent(IMüsteriService müsteriService)
        {
            _müsteriService = müsteriService;
        }


        public IViewComponentResult Invoke()
        {

            var müsteri=  _müsteriService.GetAll();
            return View(müsteri);
        }
    }
}
