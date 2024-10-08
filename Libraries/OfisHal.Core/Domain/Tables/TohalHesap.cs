using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class TohalHesap
    {
        public TohalHesap()
        {
            TohalBankaHareketis = new HashSet<TohalBankaHareketi>();
            TohalHesapHareketis = new HashSet<TohalHesapHareketi>();
        }

        public int HesapId { get; set; }
        public string Kod { get; set; }
        public string Ad { get; set; }
        public double? KdvOrani { get; set; }
        public bool? YilsonuDevri { get; set; }
        public byte? Tip { get; set; }
        public double? IscilikKiloKatsayisi { get; set; }
        public double? IscilikAdetKatsayisi { get; set; }
        public double? KesintiOrani { get; set; }
        public int? MuhHesapId { get; set; }
        public bool? RehinDevri { get; set; }

        public virtual TohalMuhHesap MuhHesap { get; set; }
        public virtual ICollection<TohalBankaHareketi> TohalBankaHareketis { get; set; }
        public virtual ICollection<TohalHesapHareketi> TohalHesapHareketis { get; set; }
    }
}