

using System;
using System.Collections.Generic;

namespace OfisHal.Core.Domain

{
    public class VohksHksKayitliKunyeBilgileri
    {
        public int? KunyeId { get; set; }
        public DateTime? IslemeAlinmaZamani { get; set; }
        public byte? Tip { get; set; }
        public string BildirimciVergiNo { get; set; }
        public int? BildirimciId { get; set; }
        public string BildirimciAdi { get; set; }
        public int? BildirimTuru { get; set; }
        public DateTime? BildirimTarihi { get; set; }
        public string MalinSahibiVergiNo { get; set; }
        public int? MalinSahibiId { get; set; }
        public string MalinSahibiAdi { get; set; }
        public string UreticiVergiNo { get; set; }
        public int? UreticiId { get; set; }
        public string UreticiAdi { get; set; }
        public double? KalanMiktar { get; set; }
        public string KunyeNo { get; set; }
        public int? MalId { get; set; }
        public string MalKodu { get; set; }
        public string MalAdi { get; set; }
        public int? HksMalId { get; set; }
        public string HksMalinAdi { get; set; }
        public int? MalinCinsKodNo { get; set; }
        public string MalinCinsi { get; set; }
        public double? MalinMiktari { get; set; }
        public double? MalinSatisFiyati { get; set; }
        public int? MalinTuruKodNo { get; set; }
        public string MalinTuru { get; set; }
        public int? MiktarBirimId { get; set; }
        public string MiktarBirimiAd { get; set; }
        public double? RusumMiktari { get; set; }
        public int KunyeKayitli { get; set; }
        public int StokHareketiVar { get; set; }
        public double? KapKalanMiktar { get; set; }
        public double? KiloKalanMiktar { get; set; }
        public int? TeslimatYeriId { get; set; }
        public string TeslimatYeri { get; set; }
        public string PlakaNo { get; set; }
        public string BelgeNo { get; set; }
        public byte? Sifat { get; set; }
        public int? GidecekIsyeriId { get; set; }
    }
}