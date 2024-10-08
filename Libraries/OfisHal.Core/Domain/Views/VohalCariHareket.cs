using System;

namespace OfisHal.Core.Domain
{
    public class VohalCariHareket
    {
        public int CariHareketId { get; set; }
        public int CariKartId { get; set; }
        public byte KartTipi { get; set; }
        public string Kod { get; set; }
        public string Ad { get; set; }
        public string RefNo { get; set; }
        public DateTime Tarih { get; set; }
        public byte IslemTipi { get; set; }
        public string Aciklama { get; set; }
        public string Aciklama2 { get; set; }
        public double Meblag { get; set; }
        public byte Tip { get; set; }
        public int? PosCihaziId { get; set; }
        public string PosCihaziAdi { get; set; }
        public int? KarsiCariKartId { get; set; }
        public string KarsiCariKartAdi { get; set; }
        public string EkleyenKullaniciAdi { get; set; }
        public DateTime EklemeZamani { get; set; }
        public string GuncelleyenKullaniciAdi { get; set; }
        public DateTime GuncellemeZamani { get; set; }
        public string KodTarih { get; set; }
        public string AdTarih { get; set; }
        public double? VeresiyeSiniri { get; set; }
        public double? RiskSiniri { get; set; }
    }
}