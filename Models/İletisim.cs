using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KuaförRandevu00.Models
{
    public class İletisim
    {
        [Key]
        public int Id { get; set; }
        public string LogoYazısı { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string Baslik1{ get; set; }
        public string Aciklama1 { get; set; }
        public string Adres { get; set; }
        public string TelNo { get; set; }
        public string EPosta { get; set; }
    }
}
