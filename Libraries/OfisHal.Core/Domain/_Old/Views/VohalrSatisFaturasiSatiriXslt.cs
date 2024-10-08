

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrSatisFaturasiSatiriXslt
    {
        public int? FaturaSatiriId { get; set; }
        public int FaturaId { get; set; }
        public int? SatirNo { get; set; }
        public int MarkaId { get; set; }
        public string Marka { get; set; }
        public int MalId { get; set; }
        public string MalKodu { get; set; }
        public string MalAdi { get; set; }
        public string SatisKunyesi { get; set; }
        public string StokKunyesi { get; set; }
        public int? KapId { get; set; }
        public string KapKodu { get; set; }
        public string KapAdi { get; set; }
        public double? KapFiyati { get; set; }
        public int? KapMiktari { get; set; }
        public double? Darali { get; set; }
        public DateTime Tarih { get; set; }
        public double? Dara { get; set; }
        public double? MalMiktari { get; set; }
        public double? Fiyat { get; set; }
        public double? Tutar { get; set; }
        public double KdvOrani { get; set; }
        public string Aciklama { get; set; }
        public double IskontoOrani { get; set; }
        public double? Iskonto { get; set; }
        public double? IskontoPayi { get; set; }
        public double RusumOrani { get; set; }
        public double? Rusum { get; set; }
        public string MalBirimi { get; set; }
        public int? KiloOndalikSayisi { get; set; }
    }
}