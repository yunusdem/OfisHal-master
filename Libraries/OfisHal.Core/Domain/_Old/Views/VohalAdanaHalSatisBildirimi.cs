using System;

namespace OfisHal.Web.Models
{
    public class VohalAdanaHalSatisBildirimi
    {
        public string FirmaKodu { get; set; }
        public string FaturaNo { get; set; }
        public DateTime FaturaTarihi { get; set; }
        public string UrunKodu { get; set; }
        public int Parca { get; set; }
        public double Safi { get; set; }
        public double Fiyat { get; set; }
        public double Tutar { get; set; }
        public string MustahsilKimlikNo { get; set; }
        public string MustahsilAdi { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriVergiNo { get; set; }
        public string MusteriSehir { get; set; }
        public int? HksUrunId { get; set; }
        public int? HksCinsId { get; set; }
        public byte? HksTurId { get; set; }
        public string UreticiIl { get; set; }
        public string UreticiIlce { get; set; }
        public string UreticiBelde { get; set; }
        public string TukIl { get; set; }
        public string TukIlce { get; set; }
        public string MT { get; set; }
        public string TukYeri { get; set; }
        public string MalAlisKunyesi { get; set; }
        public string MalSatisKunyesi { get; set; }
        public string Sifreniz { get; set; }
        public string Sifre { get; set; }
        public string Plaka { get; set; }
    }
}