using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KuaförRandevu00.Models
{
    public class HomePage
    {
       


        public int Id { get; set; }
        public string LogoYazısı { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }


        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Image Name")]
        public string ResimYolu { get; set; }


        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ResimDosyası { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Image Name")]
        public string ResimYolu1 { get; set; }


        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ResimDosyası1 { get; set; }

        public string Baslik1 { get; set; }
        public string Aciklama1 { get; set; }


        public string BaslikServisler { get; set; }
        public string BaslikAciklama { get; set; }


        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Image Name")]
        public string ResimYolu2 { get; set; }


        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ResimDosyası2 { get; set; }

        public string ServislerBasli { get; set; }
        public string SrvislerAciklama { get; set; }

        //[Display(Name = "Fiyatı")]
        //[Column(TypeName = "decimal(18,2)")]
        //public decimal? Fiyat { get; set; }

        public string BaslikDigerSacStilleri { get; set; }
        public string AciklamaDigerSacStilleri { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Image Name")]
        public string ResimYolu3 { get; set; }


        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ResimDosyası3 { get; set; }

        public string BaslikKaliteliSacKesimi { get; set; }
        public string AciklamaKaliteliSacKesimi { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Image Name")]
        public string ResimYolu4 { get; set; }


        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ResimDosyası4 { get; set; }



    }
}
