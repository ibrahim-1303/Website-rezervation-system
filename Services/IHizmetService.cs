using KuaförRandevu00.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KuaförRandevu00.Services
{
    public interface IHizmetService
    {
        List<Hizmetler> GetAll();
        void Create(Hizmetler hizmetler);
        void Delete(Hizmetler hizmetler);
        void Update(Hizmetler hizmetler);


    }
}
