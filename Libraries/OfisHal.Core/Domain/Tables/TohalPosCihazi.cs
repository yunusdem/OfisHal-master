using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class TohalPosCihazi
    {
        public TohalPosCihazi()
        {
            TohalBankaHareketis = new HashSet<TohalBankaHareketi>();
            TohalCariHarekets = new HashSet<TohalCariHareket>();
            TohalFaturas = new HashSet<TohalFatura>();
        }

        public int PosCihaziId { get; set; }
        public int BankaHesabiId { get; set; }
        public string Kod { get; set; }
        public string Ad { get; set; }
        public double Devir { get; set; }

        public virtual TohalBankaHesabi BankaHesabi { get; set; }
        public virtual ICollection<TohalBankaHareketi> TohalBankaHareketis { get; set; }
        public virtual ICollection<TohalCariHareket> TohalCariHarekets { get; set; }
        public virtual ICollection<TohalFatura> TohalFaturas { get; set; }
    }
}