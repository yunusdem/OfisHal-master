

using System;
using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class VohalDigerTanimlar
    {
        public string Surum { get; set; }
        public byte? Tip { get; set; }
        public int? DigFiyatKurusSayisi { get; set; }
        public int? DigKiloOndalikSayisi { get; set; }
        public int? DigBordroSayfaNo { get; set; }
        public int? DigBordroKapDevri { get; set; }
        public double? DigBordroKiloDevri { get; set; }
        public int? DigMalBeyanSayfaNo { get; set; }
        public int? DigDokumDefterSayfaNo { get; set; }
        public bool? DigDokumNoBasinaSifir { get; set; }
        public int? DigMustahsilKodSiraNo { get; set; }
        public int? DigMusteriKodSiraNo { get; set; }
        public bool? DigCariKodBasinaSifir { get; set; }
        public bool? DigFaturaNoBasinaSifir { get; set; }
        public byte? DigRehinIadeCalismaSekli { get; set; }
        public byte? DigRehinTahsilatGosterimi { get; set; }
        public byte? DigKasaVeresiyeSekli { get; set; }
        public double? DigKasaDevri { get; set; }
        public string DigBelgeDizini { get; set; }
        public byte? DigEditDenetimIsleyisi { get; set; }
        public bool? DigKasaDefterindeDevirVar { get; set; }
        public byte? DigKasaDevirSekli { get; set; }
        public bool? DigRehinBakiyeGosterilsin { get; set; }
        public int? DigCariHareketRefNo { get; set; }
        public bool? DigBuyukHarfeCevir { get; set; }
        public int? DigOdemeBordroSiraNo { get; set; }
        public bool? DigOdemeBordroBasinaSifir { get; set; }
        public double? DigVadeFarkiOrani { get; set; }
        public DateTime? DigRehinBaslangicTarihi { get; set; }
        public DateTime? DigDonemBaslangicTarihi { get; set; }
        public DateTime? DigDonemBitisTarihi { get; set; }
        public byte? DigTutarHesaplamaSekli { get; set; }
        public byte? DigKasMustahCalismaSekli { get; set; }
        public byte? DigSatisTipi { get; set; }
        public string DigHalMudurlukFormuKlasoru { get; set; }
        public string DegisiklikTakipSifresi { get; set; }
        public string DigYedekKlasoru { get; set; }
        public bool? DigEBagkurVar { get; set; }
        public string DigVergiSorgulayanTcKNo { get; set; }
        public string DigMudurlukKulAdi { get; set; }
        public string DigMudurlukKulSifresi { get; set; }
        public byte? DigVeresiyeAsimOlayi { get; set; }
        public bool? DigAciklama2Goster { get; set; }
        public int? HesapYili { get; set; }
        public string DevirAlani { get; set; }
        public bool? HalMudurlukXmlAdi { get; set; }
        public string DigIkinciYedekKlasoru { get; set; }
        public int? FisSiraNo { get; set; }
        public int? MalKabulSiraNo { get; set; }
        public bool? DigVeresiyeMizaniAc { get; set; }
        public bool? DigKasaDevrindeYukNakVar { get; set; }
        public bool? DigKasaDefterindeAlisVar { get; set; }
        public bool? DigRehinBazliKapCari { get; set; }
        public bool? KunyeCogalmaLog { get; set; }
        public string DigBagkurDosyaNo { get; set; }
        public bool? DigKasaKrediKartiVar { get; set; }
        public string DigEtaFaturaKlasoru { get; set; }
        public DateTime? SonAlinanGibKullaniciTarih { get; set; }
    }
}