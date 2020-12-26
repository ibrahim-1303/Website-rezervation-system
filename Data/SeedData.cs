using Güzellik_Merkezi;
using Güzellik_Merkezi.Data;
using Güzellik_Merkezi.Models;
using KuaförRandevu00.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KuaförRandevu00.Data
{
    public static class SeedData
    {
        public  static  void Initialize(IServiceProvider serviceProvider)
        {
            Console.WriteLine("Çekirdek Verileri Tohumlanıyor");

            using (var context = new ApplicationDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                context.Database.Migrate();

                if (context.HomePages.Any())
                {
                    return;
                }
                if (context.Hizmetlers.Any())
                {
                    return;
                }
                if (context.İletisims.Any())
                {
                    return;
                }
                if (context.Servislers.Any())
                {
                    return;
                }

                var roleManager = serviceProvider.GetRequiredService<RoleManager<AppRole>>();
                 roleManager.CreateAsync(new AppRole {Name="Admin",Sifre="admin0000"});

                 roleManager.CreateAsync(new AppRole {Name="Users",Sifre="admin0000"});
                

                var userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
                var admin = new AppUser{Ad="ibrahim",Soyad="Ayfer", UserName = "admin@gmail.com", Email = "admin@gmail.com", EmailConfirmed = true };
                
                userManager.CreateAsync(admin,"admin0000");

                userManager.AddToRoleAsync(admin,"admin");
                

                context.HomePages.AddRange(
                    new HomePage
                    {
                        LogoYazısı = "Barberz",
                        Baslik = "Bir Saç Kesiminden Daha Fazlası",
                        Aciklama = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Soluta veritatis tenetur doloremque, maiores doloribus officia iste. Dolores.",
                        ResimYolu = "img_1.jpg",
                        ResimYolu1 = "img_1.jpg",
                        Baslik1 = "Barberz'a Hoş Geldiniz!",
                        Aciklama1 = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Iure nesciunt nemo vel earum maxime neque!",
                        ResimYolu2 = "img_2.jpg",
                        ServislerBasli = "Hizmetler ve Fiyatlandırma",
                        SrvislerAciklama = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Iure nesciunt nemo vel earum maxime neque!",
                        BaslikDigerSacStilleri = "Daha Fazla Saç Modeli",
                        AciklamaDigerSacStilleri = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Iure nesciunt nemo vel earum maxime neque!",
                        ResimYolu3 = "img_3.jpg",
                        AciklamaKaliteliSacKesimi = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Iure nesciunt nemo vel earum maxime neque!",
                        ResimYolu4 = "img_1.jpg"
                    });
                context.SaveChanges();

                context.Hizmetlers.AddRange(
                    new Hizmetler
                    {
                        ResimYolu = "img_1.jpg",
                        Baslik = "Saç Kesimi",
                        Hizmet = "Şampuan ve Fön",
                        Hizmet1 = "Erkek Kesimi",
                        Hizmet2 = "Kesim",
                        Hizmet3 = "Tarama",
                        Hizmet4 = "Bakım",
                        Fiyat = 10,
                        Fiyat1 = 20,
                        Fiyat2 = 30,
                        Fiyat3 = 50,
                        Fiyat4 = 60
                    });
                context.SaveChanges();
                context.Hizmetlers.AddRange(
                    new Hizmetler
                    {
                        ResimYolu = "img_2.jpg",
                        Baslik = "Saç Sitili",
                        Hizmet = "Şampuan",
                        Hizmet1 = "Kuru Fön",
                        Hizmet2 = "Kesim",
                        Hizmet3 = "Tarama",
                        Hizmet4 = "Bakım",
                        Fiyat = 10,
                        Fiyat1 = 20,
                        Fiyat2 = 30,
                        Fiyat3 = 50,
                        Fiyat4 = 60
                    });
                context.Hizmetlers.AddRange(
                    new Hizmetler
                    {
                        ResimYolu = "img_3.jpg",
                        Baslik = "Saç Sitili",
                        Hizmet = "Şampuan",
                        Hizmet1 = "Kuru Fön",
                        Hizmet2 = "Kesim",
                        Hizmet3 = "Tarama",
                        Hizmet4 = "Bakım",
                        Fiyat = 10,
                        Fiyat1 = 20,
                        Fiyat2 = 30,
                        Fiyat3 = 50,
                        Fiyat4 = 60
                    });
                context.SaveChanges();
                context.İletisims.AddRange(
                  new İletisim
                  {
                      LogoYazısı = "Berberz",
                      Baslik = "Bize Ulaşın",
                      Aciklama = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Soluta veritatis tenetur doloremque, maiores doloribus officia iste. Dolores.",
                      Baslik1 = "Araç Kiralamak İçin Bize Ulaşın Veya Bu Formu Kullanın",
                      Aciklama1 = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Nemo varsayım, dolorum requireditatibus eius earum voluptates sed!",
                      Adres = "34 Sokak Adı, Buradaki Şehir Adı, Amerika Birleşik Devletleri",
                      TelNo = "+1 242 4942 290",
                      EPosta = "info@alaniniz.com",
                  });
                context.SaveChanges();
                context.Servislers.AddRange(
                    new Servis
                    {
                        LogoYazısı = "Berberz",
                        Baslik = "Bize Ulaşın",
                        Aciklama = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Soluta veritatis tenetur doloremque, maiores doloribus officia iste. Dolores.",
                        Baslik1 = "Saç Kesimi",
                        Aciklama1 = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Obcaecati, laboriosam",
                        Baslik2 = "Yüz ve Vücut Bakımı",
                        Aciklama2 = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Obcaecati, laboriosam",
                        Baslik3 = "Masajlar",
                        Aciklama3 = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Obcaecati, laboriosam",
                        Baslik4 = "Saç kesimi",
                        Aciklama4 = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Obcaecati, laboriosam",
                        Baslik5 = "Yüz ve Vücut Bakımı",
                        Aciklama5 = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Obcaecati, laboriosam",
                        Baslik6 = "Masajlar",
                        Aciklama6 = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Obcaecati, laboriosam",
                        ClientSaysbaslik = "En İyi Müşterimiz Söylüyor",
                        ResimYolu = "person_1.jpg",
                        Müsteriisim = "Mike Fisher",
                        MüsteriAciklama = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Obcaecati, laboriosam",
                        ResimYolu2 = "person_2.jpg",
                        Müsteriisim2 = "Jean Stanley",
                        MüsteriAciklama2 = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Obcaecati, laboriosam",
                        ResimYolu3 = "person_3.jpg",
                        Müsteriisim3 = "Katie gü",
                        MüsteriAciklama3 = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Obcaecati, laboriosam",
                        KalitelisacBaslik = "Kaliteli Saç Kesimi",
                        KalitelisacAciklama = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Obcaecati, laboriosam",
                        ResimYolu1 = "img_1.jpg"
                    });


                context.SaveChanges();
                var logger = serviceProvider.GetRequiredService<ILogger<Program>>();
                logger.LogInformation("Çekirdek Veriler Başarıyla Yazıldı.");
            }


        }


    }
}



