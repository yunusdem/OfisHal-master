

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalFaturaSatiriSatisKunyeDetayListesi
    {
        public int FaturaId { get; set; }
        public int FaturaSatiriId { get; set; }
        public int KunyeId { get; set; }
        public string Kod { get; set; }
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
    }
}