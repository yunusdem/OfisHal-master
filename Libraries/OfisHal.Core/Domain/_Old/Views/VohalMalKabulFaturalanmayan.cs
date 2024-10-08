

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalMalKabulFaturalanmayan
    {
        public int FisId { get; set; }
        public int FisSatiriId { get; set; }
        public int SatirNo { get; set; }
        public int MusteriId { get; set; }
        public string MusteriAdi { get; set; }
        public DateTime Tarih { get; set; }
        public string FisNo { get; set; }
        public int? MarkaId { get; set; }
        public string Marka { get; set; }
        public int MustahsilId { get; set; }
        public string MustahsilAdi { get; set; }
        public bool? HalKomisyoncusu { get; set; }
        public bool? RusumAlinmasin { get; set; }
        public int MalId { get; set; }
        public string MalKodu { get; set; }
        public string MalAdi { get; set; }
        public string MalBirimi { get; set; }
        public string DigerMalAdi { get; set; }
        public int? KapId { get; set; }
        public string KapKodu { get; set; }
        public string KapAdi { get; set; }
        public bool? IadeliKap { get; set; }
        public int KapMiktari { get; set; }
        public double? KapFiyati { get; set; }
        public double? BirimDara { get; set; }
        public int? KapIcindekiMalMiktari { get; set; }
        public double Darali { get; set; }
        public double Dara { get; set; }
        public double MalMiktari { get; set; }
        public double MalFiyati { get; set; }
        public double Tutar { get; set; }
        public double? RusumOrani { get; set; }
        public double? Rusum { get; set; }
        public double? KdvOrani { get; set; }
        public int? RehinKabiId { get; set; }
        public string RehinKabiKodu { get; set; }
        public string RehinKabiAdi { get; set; }
        public byte? UretimSekli { get; set; }
        public string EFaturaUneceKisaltma { get; set; }
        public string MustahsilAdiVkn { get; set; }
    }
}