using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class TohalMuhHesap
    {
        public TohalMuhHesap()
        {
            TohalBankaHesabis = new HashSet<TohalBankaHesabi>();
            TohalCariKartCariHesaps = new HashSet<TohalCariKart>();
            TohalCariKartDigerHesaps = new HashSet<TohalCariKart>();
            TohalHesaps = new HashSet<TohalHesap>();
            TohalKapAlisHesaps = new HashSet<TohalKap>();
            TohalKapSatisHesaps = new HashSet<TohalKap>();
            TohalMalAlisHesaps = new HashSet<TohalMal>();
            TohalMalSatisHesaps = new HashSet<TohalMal>();
            TohalMuhFisSatiris = new HashSet<TohalMuhFisSatiri>();
        }

        public int MuhHesapId { get; set; }
        public string Kod { get; set; }
        public string Ad { get; set; }
        public byte? Tur { get; set; }
        public byte Tip { get; set; }
        public string Hakkinda { get; set; }

        public virtual ICollection<TohalBankaHesabi> TohalBankaHesabis { get; set; }
        public virtual ICollection<TohalCariKart> TohalCariKartCariHesaps { get; set; }
        public virtual ICollection<TohalCariKart> TohalCariKartDigerHesaps { get; set; }
        public virtual ICollection<TohalHesap> TohalHesaps { get; set; }
        public virtual ICollection<TohalKap> TohalKapAlisHesaps { get; set; }
        public virtual ICollection<TohalKap> TohalKapSatisHesaps { get; set; }
        public virtual ICollection<TohalMal> TohalMalAlisHesaps { get; set; }
        public virtual ICollection<TohalMal> TohalMalSatisHesaps { get; set; }
        public virtual ICollection<TohalMuhFisSatiri> TohalMuhFisSatiris { get; set; }
    }
}