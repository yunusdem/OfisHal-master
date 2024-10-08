using System;

namespace OfisHal.Core.Domain
{
    public class TohksKayitliKunyeListesi
    {
        public int Id { get; set; }
        public DateTime? IslemeAlinmaZamani { get; set; }
        public byte? Tip { get; set; }
        public string BildirimciVergiNo { get; set; }
        public int? BildirimTuru { get; set; }
        public DateTime? BildirimTarihi { get; set; }
        public string MalinSahibiVergiNo { get; set; }
        public string UreticiVergiNo { get; set; }
        public double? KalanMiktar { get; set; }
        public string KunyeNo { get; set; }
        public int? MalinKodNo { get; set; }
        public string MalinAdi { get; set; }
        public int? MalinCinsKodNo { get; set; }
        public string MalinCinsi { get; set; }
        public double? MalinMiktari { get; set; }
        public double? MalinSatisFiyati { get; set; }
        public int? MalinTuruKodNo { get; set; }
        public string MalinTuru { get; set; }
        public int? MiktarBirimId { get; set; }
        public string MiktarBirimiAd { get; set; }
        public double? RusumMiktari { get; set; }
        public int? MalId { get; set; }
        public int? GidecekIsyeriId { get; set; }
        public int? KunyeId { get; set; }
        public string PlakaNo { get; set; }
        public byte? Sifat { get; set; }
        public string BelgeNo { get; set; }
    }
}