using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class TohalRehinFisi
    {
        public TohalRehinFisi()
        {
            TohalKapHarekets = new HashSet<TohalKapHareket>();
        }

        public int RehinFisiId { get; set; }
        public int FaturaId { get; set; }
        public int SatirNo { get; set; }
        public int? MarkaId { get; set; }
        public int KapId { get; set; }
        public int KapMiktari { get; set; }
        public double Fiyat { get; set; }
        public double Tutar { get; set; }
        public bool? ElleDegistirildi { get; set; }
        public string Guid { get; set; }

        public virtual TohalFatura Fatura { get; set; }
        public virtual TohalKap Kap { get; set; }
        public virtual TohalMarka Marka { get; set; }
        public virtual ICollection<TohalKapHareket> TohalKapHarekets { get; set; }
    }
}