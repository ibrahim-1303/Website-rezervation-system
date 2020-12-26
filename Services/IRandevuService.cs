using KuaförRandevu00.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Güzellik_Merkezi.Services
{
  public  interface IRandevuService
    {
        List<Randevu> GetAll();
        void Create(Randevu randevu);
        void Delete(Randevu randevu);
        void Update(Randevu randevu);
    }
}
