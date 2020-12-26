using Güzellik_Merkezi.Data;
using KuaförRandevu00.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Güzellik_Merkezi.Services
{
    public class RandevuManager : IRandevuService
    {
        private readonly ApplicationDbContext _dbContext;
        public RandevuManager(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(Randevu randevu)
        {
            _dbContext.Add(randevu);
        }

        public void Delete(Randevu randevu)
        {
            _dbContext.Remove(randevu);
        }

        public List<Randevu> GetAll()
        {
            var randevu = _dbContext.Randevus;
            return randevu.ToList();
        }

        public void Update(Randevu randevu)
        {
            _dbContext.Update(randevu);
        }

       
    }
}
