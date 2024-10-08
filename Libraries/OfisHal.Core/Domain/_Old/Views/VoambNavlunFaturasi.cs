using System;

namespace OfisHal.Web.Models
{
    public class VoambNavlunFaturasi
    {
        public int KayitId { get; set; }
        public int NavlunFaturasiId { get; set; }
        public DateTime FaturaTarihi { get; set; }
        public DateTime Zaman { get; set; }
        public string FaturaNo { get; set; }
        public double NavlunToplam { get; set; }
        public double MuameleToplam { get; set; }
        public double KdvOrani { get; set; }
        public double Toplam { get; set; }
        public bool? Odendi { get; set; }
        public double Kdv { get; set; }
        public double GenelToplam { get; set; }
        public int YazihaneId { get; set; }
        public string YazihaneAdi { get; set; }
        public string YazihaneKodu { get; set; }
        public bool? Kesildi { get; set; }
        public string HalAdi { get; set; }
        public string HalKodu { get; set; }
        public string VergiKimlikNo { get; set; }
        public int? DizaynId { get; set; }
        public string DizaynAdi { get; set; }
        public int? AdetToplami { get; set; }
        public int? EkleyenId { get; set; }
        public string EkleyenKullaniciAdi { get; set; }
        public DateTime? EklemeZamani { get; set; }
        public string GuncelleyenKullaniciAdi { get; set; }
        public DateTime? GuncellemeZamani { get; set; }
        public string GuncellemeZamaniString { get; set; }
        public int? GibFirmamizPostaKutusuId { get; set; }
        public string GibFirmamizPostaKutusu { get; set; }
        public int? GibMuhatapPostaKutusuId { get; set; }
        public string GibMuhatapPostaKutusu { get; set; }
        public string EFaturaEttn { get; set; }
        public string IlAdi { get; set; }
        public string IlceAdi { get; set; }
        public string UlkeAdi { get; set; }
        public string VergiDairesi { get; set; }
        public string Adres { get; set; }
    }
}