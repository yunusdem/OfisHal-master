using System;

namespace OfisHal.Web.Models
{
    public class VohalbFaturaUrunKunyesi
    {
        public int FaturaId { get; set; }
        public DateTime Tarih { get; set; }
        public int FaturaSatiriId { get; set; }
        public string Marka { get; set; }
        public string MalKodu { get; set; }
        public string MalAdi { get; set; }
        public string HksMalAdi { get; set; }
        public string HksMalCinsi { get; set; }
        public int? UretimSekli { get; set; }
        public string KapKodu { get; set; }
        public string KapAdi { get; set; }
        public int KapMiktari { get; set; }
        public double Darali { get; set; }
        public double Dara { get; set; }
        public double MalMiktari { get; set; }
        public double Fiyat { get; set; }
        public double Tutar { get; set; }
        public double KdvOrani { get; set; }
        public string SatirAciklamasi { get; set; }
        public string MustahsilAdi { get; set; }
        public string MustahsilAdresi { get; set; }
        public string MustahsilIl { get; set; }
        public string MustahsilIlce { get; set; }
        public string MustahsilBelde { get; set; }
        public string MustahsilPostaKodu { get; set; }
        public string MustahsilVergiKimlikNo { get; set; }
        public string FaturaAdresi { get; set; }
        public string PlakaNo { get; set; }
        public string FaturaVergiDairesi { get; set; }
        public string VergiKimlikNo { get; set; }
        public string FaturaIl { get; set; }
        public string FaturaIlce { get; set; }
        public string FaturaBelde { get; set; }
        public string FaturaUnvani { get; set; }
        public string FirmamizAdi { get; set; }
        public string FirmamizVergiKimlikNo { get; set; }
        public string FirmamizGsmNo { get; set; }
        public string FirmamizEposta { get; set; }
        public string ToptanciHaliAdi { get; set; }
        public string ToptanciHaliTelNo { get; set; }
    }
}