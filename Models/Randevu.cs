using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KuaförRandevu00.Models
{
    public class Randevu
    {

        public int Id { get; set; }
        public DateTime Start { get; set; }
        public string Text { get; set; }

        
        
        public string Ad { get; set; }
        
        public string Soyad { get; set; }
     
        public string Telno { get; set; }


    }
}
