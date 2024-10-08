using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class TohalKap
    {
        public TohalKap()
        {
            InverseRehinKabi = new HashSet<TohalKap>();
            ToambAmbarFiyatis = new HashSet<ToambAmbarFiyati>();
            ToambNavlunFaturaSatiris = new HashSet<ToambNavlunFaturaSatiri>();
            ToambSevkIrsaliyesiSatiris = new HashSet<ToambSevkIrsaliyesiSatiri>();
            TohalFaturaSatiris = new HashSet<TohalFaturaSatiri>();
            TohalFisSatiris = new HashSet<TohalFisSatiri>();
            TohalKapHarekets = new HashSet<TohalKapHareket>();
            TohalRehinFisis = new HashSet<TohalRehinFisi>();
            TohalStokHareketis = new HashSet<TohalStokHareketi>();
        }

        public int KapId { get; set; }
        public string Kod { get; set; }
        public string Ad { get; set; }
        public double Dara { get; set; }
        public bool? Iadeli { get; set; }
        public double? BirimFiyati { get; set; }
        public int? RehinKabiId { get; set; }
        public int? DigerAdId { get; set; }
        public int? AlisHesapId { get; set; }
        public int? SatisHesapId { get; set; }
        public string AmbalajTipiKodu { get; set; }
        public string AmbalajMarkasi { get; set; }
        public double? Kapasite { get; set; }

        public virtual TohalMuhHesap AlisHesap { get; set; }
        public virtual TohalDigerAd DigerAd { get; set; }
        public virtual TohalKap RehinKabi { get; set; }
        public virtual TohalMuhHesap SatisHesap { get; set; }
        public virtual ICollection<TohalKap> InverseRehinKabi { get; set; }
        public virtual ICollection<ToambAmbarFiyati> ToambAmbarFiyatis { get; set; }
        public virtual ICollection<ToambNavlunFaturaSatiri> ToambNavlunFaturaSatiris { get; set; }
        public virtual ICollection<ToambSevkIrsaliyesiSatiri> ToambSevkIrsaliyesiSatiris { get; set; }
        public virtual ICollection<TohalFaturaSatiri> TohalFaturaSatiris { get; set; }
        public virtual ICollection<TohalFisSatiri> TohalFisSatiris { get; set; }
        public virtual ICollection<TohalKapHareket> TohalKapHarekets { get; set; }
        public virtual ICollection<TohalRehinFisi> TohalRehinFisis { get; set; }
        public virtual ICollection<TohalStokHareketi> TohalStokHareketis { get; set; }
    }
}