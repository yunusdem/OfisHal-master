using System;

namespace OfisHal.Core.Domain
{
    public class VohalAramaDokum
    {
        public int MakbuzId { get; set; }
        public int? MarkaId { get; set; }
        public string Marka { get; set; }
        public int CariKartId { get; set; }
        public string CariKodu { get; set; }
        public string CariAdi { get; set; }
        public string DokumNo { get; set; }
        public DateTime StokGirisTarihi { get; set; }
        public string IrsaliyeNo { get; set; }
        public bool? Kesildi { get; set; }
        public double Navlun { get; set; }
    }
}