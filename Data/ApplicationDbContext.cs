using System;
using System.Collections.Generic;
using System.Text;
using Güzellik_Merkezi.Models;
using KuaförRandevu00.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Güzellik_Merkezi.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser,AppRole,string >
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<HomePage> HomePages { get; set; }
        public DbSet<Hizmetler> Hizmetlers { get; set; }
        public DbSet<Servis> Servislers { get; set; }
        public DbSet<İletisim> İletisims { get; set; }
        public DbSet<Randevu> Randevus { get; set; }
    }
}
