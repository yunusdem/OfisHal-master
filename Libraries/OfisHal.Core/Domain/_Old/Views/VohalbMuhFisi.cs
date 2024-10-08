using System;

namespace OfisHal.Web.Models
{
    public class VohalbMuhFisi
    {
        public int MuhFisId { get; set; }
        public byte Tur { get; set; }
        public string FisNo { get; set; }
        public string YevmiyeNo { get; set; }
        public DateTime MuhFisiTarihi { get; set; }
        public string Hakkinda { get; set; }
        public byte? Konu { get; set; }
        public int MuhHesapId { get; set; }
        public string Ad { get; set; }
        public string UstKod { get; set; }
        public string Kod { get; set; }
        public byte MuhFisiSatiriTipi { get; set; }
        public double Meblag { get; set; }
        public string MuhFisSatiriAciklma { get; set; }
        public byte? MuhHesapTur { get; set; }
        public byte MuhHesapTipi { get; set; }
        public string UstHesapKodu { get; set; }
        public string UstHesapAdi { get; set; }
        public string FirmaAdi { get; set; }
        public string Adres { get; set; }
    }
}