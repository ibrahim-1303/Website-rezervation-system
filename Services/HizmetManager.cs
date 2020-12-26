using Güzellik_Merkezi.Data;
using KuaförRandevu00.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KuaförRandevu00.Services
{
    public class HizmetManager : IHizmetService
    {

        private readonly ApplicationDbContext _dbContext;
        public HizmetManager(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(Hizmetler hizmetler)
        {
            _dbContext.Add(hizmetler);
        }

        public void Delete(Hizmetler hizmetler)
        {
            _dbContext.Remove(hizmetler);
        }


        public List<Hizmetler> GetAll()
        {
            var hizmet = _dbContext.Hizmetlers;

            return hizmet.ToList();

        }

        public void Update(Hizmetler hizmetler)
        {
            _dbContext.Hizmetlers.Update(hizmetler);
        }
    }
}
