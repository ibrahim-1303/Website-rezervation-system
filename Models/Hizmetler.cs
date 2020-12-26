using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KuaförRandevu00.Models
{
    public class Hizmetler
    {

        public int Id { get; set; }

      

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Image Name")]
        public string ResimYolu { get; set; }


        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ResimDosyası { get; set; }

        public string Baslik { get; set; }

        public string Hizmet { get; set; }
        public string Hizmet1 { get; set; }
        public string Hizmet2 { get; set; }
        public string Hizmet3 { get; set; }
        public string Hizmet4 { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? Fiyat { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? Fiyat1 { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? Fiyat2 { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? Fiyat3 { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? Fiyat4 { get; set; }


    }
}
