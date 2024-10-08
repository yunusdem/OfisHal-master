using System;

namespace OfisHal.Web.Models
{
    public class TohalKunyeDetay
    {
        public int? KunyeId { get; set; }
        public int? UretimYeriId { get; set; }
        public string UreticiAdi { get; set; }
        public string MalSahibiAdi { get; set; }
        public string BildirimciAdi { get; set; }
        public double? Rusum { get; set; }
        public string PlakaNo { get; set; }
        public byte? Sifat { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public DateTime? UretimTarihi { get; set; }
        public DateTime? BildirimTarihi { get; set; }
        public string MalinAdi { get; set; }
        public string MalinCinsi { get; set; }
        public string MalinTuru { get; set; }
        public string MalinUretildigiYer { get; set; }
        public string MalinGidecegiYer { get; set; }
        public double? MalinMiktari { get; set; }
        public string MiktarBirimAdi { get; set; }
        public double? BirimFiyati { get; set; }
        public string Nereden { get; set; }
        public string Nereye { get; set; }
        public string BelgeNo { get; set; }
        public string Guid { get; set; }
        public double? KalanMiktar { get; set; }
        public string IsletmeAdi { get; set; }
        public string BildirimciVergiNo { get; set; }
        public string UreticiVergiNo { get; set; }

        public virtual TohalKunye Kunye { get; set; }
    }
}