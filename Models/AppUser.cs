using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Güzellik_Merkezi.Models
{
    public class AppUser:IdentityUser
    {
    
        
        public string Ad { get; set; }
        public string Soyad { get; set; }

      
    }
}
