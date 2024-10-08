

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalDevirKalanDokumler
    {
        public int MakbuzId { get; set; }
        public int MarkaId { get; set; }
        public int CariKartId { get; set; }
        public DateTime StokGirisTarihi { get; set; }
        public int? YerId { get; set; }
        public string Plaka { get; set; }
        public byte? Sifati { get; set; }
        public byte? BildirimTuru { get; set; }
        public int? HalId { get; set; }
        public byte StokTipi { get; set; }
        public int MalId { get; set; }
        public int? KapId { get; set; }
        public int? KapSayisi { get; set; }
        public double? Miktar { get; set; }
        public double Fiyat { get; set; }
        public string StokKunye { get; set; }
        public string Aciklama { get; set; }
        public string StokKunyesi { get; set; }
        public byte KunyeTuru { get; set; }
        public DateTime KunyeZamani { get; set; }
        public int? UretimYeriId { get; set; }
        public string UreticiAdi { get; set; }
        public string MalSahibiAdi { get; set; }
        public string BildirimciAdi { get; set; }
        public double KunyeRusum { get; set; }
        public string KunyePlakaNo { get; set; }
        public byte KunyeSifati { get; set; }
        public string KunyeBelgeNo { get; set; }
        public double OrtaklikOrani { get; set; }
    }
}