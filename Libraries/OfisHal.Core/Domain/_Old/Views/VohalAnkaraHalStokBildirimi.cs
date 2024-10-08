using System;

namespace OfisHal.Web.Models
{
    public class VohalAnkaraHalStokBildirimi
    {
        public int MakbuzId { get; set; }
        public string DokumNo { get; set; }
        public DateTime StokGirisTarihi { get; set; }
        public string Belde { get; set; }
        public string Ilce { get; set; }
        public string Il { get; set; }
        public int CariKartId { get; set; }
        public string CariKodu { get; set; }
        public string CariAdi { get; set; }
        public byte? Sifati { get; set; }
        public string VergiKimlikNo { get; set; }
        public string Plaka { get; set; }
        public string UrunAdi { get; set; }
        public string UrunCinsi { get; set; }
        public string UretimSekli { get; set; }
        public string KunyeNo { get; set; }
        public double Miktar { get; set; }
        public byte? Birim { get; set; }
        public byte BildirimDurumu { get; set; }
        public string DonenAlanDegeri { get; set; }
        public int SatirNo { get; set; }
        public int Siralama { get; set; }
    }
}