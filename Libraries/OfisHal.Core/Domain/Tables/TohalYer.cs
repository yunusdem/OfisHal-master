using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class TohalYer
    {
        public TohalYer()
        {
            InverseUst = new HashSet<TohalYer>();
            TohalCariKarts = new HashSet<TohalCariKart>();
            TohalFaturas = new HashSet<TohalFatura>();
            TohalKayitsizMusteris = new HashSet<TohalKayitsizMusteri>();
            TohalKunyes = new HashSet<TohalKunye>();
            TohalMagazas = new HashSet<TohalMagaza>();
            TohalMakbuzs = new HashSet<TohalMakbuz>();
        }

        public int YerId { get; set; }
        public int? UstId { get; set; }
        public byte Tur { get; set; }
        public string Ad { get; set; }
        public int? HksId { get; set; }

        public virtual TohalYer Ust { get; set; }
        public virtual ICollection<TohalYer> InverseUst { get; set; }
        public virtual ICollection<TohalCariKart> TohalCariKarts { get; set; }
        public virtual ICollection<TohalFatura> TohalFaturas { get; set; }
        public virtual ICollection<TohalKayitsizMusteri> TohalKayitsizMusteris { get; set; }
        public virtual ICollection<TohalKunye> TohalKunyes { get; set; }
        public virtual ICollection<TohalMagaza> TohalMagazas { get; set; }
        public virtual ICollection<TohalMakbuz> TohalMakbuzs { get; set; }
    }
}