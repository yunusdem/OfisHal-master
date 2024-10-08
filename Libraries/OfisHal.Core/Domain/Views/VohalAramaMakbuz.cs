using System;

namespace OfisHal.Core.Domain
{
    public class VohalAramaMakbuz
    {
        public int MakbuzId { get; set; }
        public string DokumNo { get; set; }
        public DateTime StokGirisTarihi { get; set; }
        public string FaturaNo { get; set; }
        public DateTime? FaturaTarihi { get; set; }
        public int CariKartId { get; set; }
        public string CariKodu { get; set; }
        public string CariAdi { get; set; }
        public string IrsaliyeNo { get; set; }
        public bool? Kesildi { get; set; }
        public int BekleyenHareketSayisi { get; set; }
        public string KodTarih { get; set; }
        public string AdTarih { get; set; }
        public string KodStokTarih { get; set; }
        public string AdStokTarih { get; set; }
        public DateTime MalinGelisTarihi { get; set; }
    }
}