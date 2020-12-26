using Güzellik_Merkezi.Data;
using Güzellik_Merkezi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Güzellik_Merkezi.Services
{
    public class MüsteiManager : IMüsteriService
    {
        private readonly ApplicationDbContext _dbContext;

        public MüsteiManager(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Create(AppUser appUser)
        {
            _dbContext.Add(appUser);
        }

        public void Delete(AppUser appUser)
        {
            _dbContext.Remove(appUser );
        }

        public List<AppUser> GetAll()
        {
            var müsteri = _dbContext.Users;
            return müsteri.ToList();
        }

        public void Update(AppUser appUser)
        {
            _dbContext.Update(appUser);
        }
    }
}
