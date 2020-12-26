using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Güzellik_Merkezi.Models
{
    public class AppRole:IdentityRole
    {
        public string Sifre { get; set; }

    }
}
