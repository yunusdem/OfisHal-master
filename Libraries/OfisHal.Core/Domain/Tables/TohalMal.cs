using System;
using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class TohalMal
    {
        public TohalMal()
        {
            ToambAmbarFiyatis = new HashSet<ToambAmbarFiyati>();
            ToambNavlunFaturaSatiris = new HashSet<ToambNavlunFaturaSatiri>();
            ToambSevkIrsaliyesiSatiris = new HashSet<ToambSevkIrsaliyesiSatiri>();
            TohalFaturaSatiris = new HashSet<TohalFaturaSatiri>();
            TohalFisSatiris = new HashSet<TohalFisSatiri>();
            TohalFiyatListesiSatiris = new HashSet<TohalFiyatListesiSatiri>();
            TohalMakbuzSatiris = new HashSet<TohalMakbuzSatiri>();
            TohalMalHksBagis = new HashSet<TohalMalHksBagi>();
            TohalSiparisSatiris = new HashSet<TohalSiparisSatiri>();
            TohalStokHareketis = new HashSet<TohalStokHareketi>();
        }

        public int MalId { get; set; }
        public string Kod { get; set; }
        public string Ad { get; set; }
        public byte Tur { get; set; }
        public byte? GrupNo { get; set; }
        public int? DigerAdId { get; set; }
        public byte? Birim { get; set; }
        public double? SatisFiyati { get; set; }
        public double? AlisFiyati { get; set; }
        public int? AlisHesapId { get; set; }
        public int? SatisHesapId { get; set; }
        public double? KdvOrani { get; set; }
        public DateTime? SonKullanmaTarihi { get; set; }
        public byte? FaturaBirimi { get; set; }
        public string GtipNo { get; set; }
        public int? KdvTevkifatTanimiId { get; set; }
        public int? KapIcindekiMiktari { get; set; }
        public double? OrtalamaKilo { get; set; }

        public virtual TohalMuhHesap AlisHesap { get; set; }
        public virtual TohalDigerAd DigerAd { get; set; }
        public virtual TohalKdvTevkifatTanimi KdvTevkifatTanimi { get; set; }
        public virtual TohalMuhHesap SatisHesap { get; set; }
        public virtual ICollection<ToambAmbarFiyati> ToambAmbarFiyatis { get; set; }
        public virtual ICollection<ToambNavlunFaturaSatiri> ToambNavlunFaturaSatiris { get; set; }
        public virtual ICollection<ToambSevkIrsaliyesiSatiri> ToambSevkIrsaliyesiSatiris { get; set; }
        public virtual ICollection<TohalFaturaSatiri> TohalFaturaSatiris { get; set; }
        public virtual ICollection<TohalFisSatiri> TohalFisSatiris { get; set; }
        public virtual ICollection<TohalFiyatListesiSatiri> TohalFiyatListesiSatiris { get; set; }
        public virtual ICollection<TohalMakbuzSatiri> TohalMakbuzSatiris { get; set; }
        public virtual ICollection<TohalMalHksBagi> TohalMalHksBagis { get; set; }
        public virtual ICollection<TohalSiparisSatiri> TohalSiparisSatiris { get; set; }
        public virtual ICollection<TohalStokHareketi> TohalStokHareketis { get; set; }
    }
}