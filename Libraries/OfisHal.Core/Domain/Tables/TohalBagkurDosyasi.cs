using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class TohalBagkurDosyasi
    {
        public TohalBagkurDosyasi()
        {
            TohalFaturas = new HashSet<TohalFatura>();
            TohalMakbuzs = new HashSet<TohalMakbuz>();
        }

        public int DosyaId { get; set; }
        public string DosyaNo { get; set; }
        public bool? Muhasebelesti { get; set; }

        public virtual ICollection<TohalFatura> TohalFaturas { get; set; }
        public virtual ICollection<TohalMakbuz> TohalMakbuzs { get; set; }
    }
}