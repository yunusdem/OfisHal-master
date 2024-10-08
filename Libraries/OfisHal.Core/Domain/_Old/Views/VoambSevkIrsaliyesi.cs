using System;

namespace OfisHal.Web.Models
{
    public class VoambSevkIrsaliyesi
    {
        public int KayitId { get; set; }
        public int IrsaliyeId { get; set; }
        public DateTime IrsaliyeTarihi { get; set; }
        public string IrsaliyeNo { get; set; }
        public int? GeldigiYerId { get; set; }
        public string GeldigiYer { get; set; }
        public int? PlakaId { get; set; }
        public string PlakaNo { get; set; }
        public string Sofor { get; set; }
        public double? Kesinti { get; set; }
        public double KdvOrani { get; set; }
        public bool? Odendi { get; set; }
        public double ToplamTutar { get; set; }
        public double GenelToplam { get; set; }
        public int AmbarId { get; set; }
        public string AmbarAdi { get; set; }
        public string AmbarKodu { get; set; }
        public string SoforNot { get; set; }
        public string ReferansNo { get; set; }
        public bool? TutariDegistir { get; set; }
        public double KesintiTutari { get; set; }
        public int? EkleyenId { get; set; }
        public string EkleyenKullaniciAdi { get; set; }
        public DateTime? EklemeZamani { get; set; }
        public string GuncelleyenKullaniciAdi { get; set; }
        public DateTime? GuncellemeZamani { get; set; }
        public string GuncellemeZamaniString { get; set; }
    }
}