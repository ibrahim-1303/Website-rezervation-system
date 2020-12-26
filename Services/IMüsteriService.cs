using Güzellik_Merkezi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Güzellik_Merkezi.Services
{
    public interface IMüsteriService
    {
        List<AppUser> GetAll();
        void Create(AppUser appUser);
        void Delete(AppUser appUser);
        void Update(AppUser appUser);
    }
}
