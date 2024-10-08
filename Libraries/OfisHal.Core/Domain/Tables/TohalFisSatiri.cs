using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class TohalFisSatiri
    {
        public TohalFisSatiri()
        {
            TohalFaturaSatiris = new HashSet<TohalFaturaSatiri>();
        }

        public int FisSatiriId { get; set; }
        public int FisId { get; set; }
        public int SatirNo { get; set; }
        public int? MarkaId { get; set; }
        public int? CariKartId { get; set; }
        public int MalId { get; set; }
        public int? KapId { get; set; }
        public int KapMiktari { get; set; }
        public double Darali { get; set; }
        public double Dara { get; set; }
        public double MalMiktari { get; set; }
        public double? PiyasaFiyati { get; set; }
        public double? FiyatFarki { get; set; }
        public double Fiyat { get; set; }
        public double Tutar { get; set; }

        public virtual TohalCariKart CariKart { get; set; }
        public virtual TohalFi Fis { get; set; }
        public virtual TohalKap Kap { get; set; }
        public virtual TohalMal Mal { get; set; }
        public virtual TohalMarka Marka { get; set; }
        public virtual ICollection<TohalFaturaSatiri> TohalFaturaSatiris { get; set; }
    }
}