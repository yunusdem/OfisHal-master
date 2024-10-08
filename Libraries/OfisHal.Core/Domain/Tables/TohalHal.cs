using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class TohalHal
    {
        public TohalHal()
        {
            TohalCariKarts = new HashSet<TohalCariKart>();
            TohalFaturas = new HashSet<TohalFatura>();
            TohalKayitsizMusteris = new HashSet<TohalKayitsizMusteri>();
            TohalMakbuzs = new HashSet<TohalMakbuz>();
        }

        public int HalId { get; set; }
        public string Ad { get; set; }

        public virtual ICollection<TohalCariKart> TohalCariKarts { get; set; }
        public virtual ICollection<TohalFatura> TohalFaturas { get; set; }
        public virtual ICollection<TohalKayitsizMusteri> TohalKayitsizMusteris { get; set; }
        public virtual ICollection<TohalMakbuz> TohalMakbuzs { get; set; }
    }
}