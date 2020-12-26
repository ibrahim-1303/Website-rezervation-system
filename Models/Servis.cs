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
    public class Servis
    {
        [Key]
        public int Id { get; set; }
        public string LogoYazısı { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string Baslik1 { get; set; }
        public string Aciklama1 { get; set; }
        public string Baslik2 { get; set; }
        public string Aciklama2 { get; set; }
        public string Baslik3 { get; set; }
        public string Aciklama3 { get; set; }
        public string Baslik4 { get; set; }
        public string Aciklama4 { get; set; }
        public string Baslik5 { get; set; }
        public string Aciklama5 { get; set; }
        public string Baslik6 { get; set; }
        public string Aciklama6 { get; set; }

        public string ClientSaysbaslik { get; set; }
        public string ClientSaysAciklama { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Image Name")]
        public string ResimYolu { get; set; }


        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ResimDosyası { get; set; }

        public string Müsteriisim { get; set; }
        public string MüsteriAciklama { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Image Name")]
        public string ResimYolu2 { get; set; }


        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ResimDosyası2 { get; set; }

        public string Müsteriisim2 { get; set; }
        public string MüsteriAciklama2 { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Image Name")]
        public string ResimYolu3 { get; set; }


        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ResimDosyası3 { get; set; }

        public string Müsteriisim3 { get; set; }
        public string MüsteriAciklama3 { get; set; }


        public string KalitelisacBaslik { get; set; }
        public string KalitelisacAciklama { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Image Name")]
        public string ResimYolu1 { get; set; }


        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ResimDosyası1 { get; set; }



    }

}
