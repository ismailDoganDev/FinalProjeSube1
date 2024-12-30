using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjeSube1
{
    internal class Ogrenci
    {
        public int OgrenciId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Numara { get; set; }
        public string SinifAd { get; set; }

        public int SinifId { get; set; }  
        public virtual Sinif Sinif { get; set; } 

        public virtual ICollection<OgrenciDers> OgrenciDersler { get; set; } 
    }
}
