using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjeSube1
{
    internal class OgrenciDers
    {
        public int DersId { get; set; }
        public int OgrenciId { get; set; }

        public virtual Ogrenci Ogrenci { get; set; }  
        public virtual Ders Ders { get; set; } 
    }
}
