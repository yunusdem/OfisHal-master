using System;
using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class TohalCariKart
    {
        public TohalCariKart()
        {
            InverseOrtak = new HashSet<TohalCariKart>();
            InverseRehinCariKart = new HashSet<TohalCariKart>();
            ToambAmbarFiyatiAmbars = new HashSet<ToambAmbarFiyati>();
            ToambAmbarFiyatiGonderens = new HashSet<ToambAmbarFiyati>();
            ToambAmbarFiyatiYazihanes = new HashSet<ToambAmbarFiyati>();
            ToambNavlunFaturaSatiris = new HashSet<ToambNavlunFaturaSatiri>();
            ToambNavlunFaturasis = new HashSet<ToambNavlunFaturasi>();
            ToambSevkIrsaliyesiSatiriGonderens = new HashSet<ToambSevkIrsaliyesiSatiri>();
            ToambSevkIrsaliyesiSatiriPrimSahibis = new HashSet<ToambSevkIrsaliyesiSatiri>();
            ToambSevkIrsaliyesiSatiriYazihanes = new HashSet<ToambSevkIrsaliyesiSatiri>();
            TohalBankaHareketis = new HashSet<TohalBankaHareketi>();
            TohalCariHareketCariKarts = new HashSet<TohalCariHareket>();
            TohalCariHareketKarsiCariKarts = new HashSet<TohalCariHareket>();
            TohalFaturas = new HashSet<TohalFatura>();
            TohalFis = new HashSet<TohalFi>();
            TohalFisSatiris = new HashSet<TohalFisSatiri>();
            TohalKapHarekets = new HashSet<TohalKapHareket>();
            TohalMagazas = new HashSet<TohalMagaza>();
            TohalMakbuzCariKarts = new HashSet<TohalMakbuz>();
            TohalMakbuzOrtaks = new HashSet<TohalMakbuz>();
            TohalOdemeBordrosus = new HashSet<TohalOdemeBordrosu>();
            TohalSiparis = new HashSet<TohalSipari>();
            TohalCariSifats = new HashSet<TohalCariSifat>();
        }

        public int CariKartId { get; set; }
        public byte Tip { get; set; }
        public string Kod { get; set; }
        public string Ad { get; set; }
        public int? MarkaId { get; set; }
        public int? UlkeId { get; set; }
        public int? PostaKoduId { get; set; }
        public string Adres { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Faks { get; set; }
        public string BankaHesapNo { get; set; }
        public byte KisilikTipi { get; set; }
        public string VergiKimlikNo { get; set; }
        public int? VergiDairesiId { get; set; }
        public string MuafiyetBelgeNo { get; set; }
        public DateTime? MuafiyetBitisTarihi { get; set; }
        public string BagkurNo { get; set; }
        public string BabaAdi { get; set; }
        public string Dogum { get; set; }
        public string BorsaSicilNo { get; set; }
        public string Kefil { get; set; }
        public double? Oran { get; set; }
        public double Devir { get; set; }
        public string Hakkinda { get; set; }
        public int? OrtakId { get; set; }
        public double? OrtaklikOrani { get; set; }
        public int? Vade { get; set; }
        public string Filtre { get; set; }
        public string KendiKodu { get; set; }
        public double? ReeskontOrani { get; set; }
        public bool? RusumAlinmasin { get; set; }
        public int? YerId { get; set; }
        public string PlakaNo { get; set; }
        public string GsmNo { get; set; }
        public string EPosta { get; set; }
        public byte? GidecegiYerTipi { get; set; }
        public int? SehirId { get; set; }
        public byte? SatinAlaninSifati { get; set; }
        public int? HalId { get; set; }
        public bool? HalKomisyoncusu { get; set; }
        public bool? Ihracatci { get; set; }
        public int? GidecegiYerWebSiraNo { get; set; }
        public bool? HksBilgisiAlindi { get; set; }
        public string Mahalle { get; set; }
        public string Cadde { get; set; }
        public string Sokak { get; set; }
        public string KapiNo { get; set; }
        public string DaireNo { get; set; }
        public string WebAdresi { get; set; }
        public DateTime? BakiyeTarihi { get; set; }
        public double? Bakiye { get; set; }
        public double? KesilmemisFaturaTutari { get; set; }
        public double? RehindekiKapTutari { get; set; }
        public double? KesilmeyenDhlRehKapTutari { get; set; }
        public double? VeresiyeSiniri { get; set; }
        public bool? KesintiAlinmasin { get; set; }
        public int? CariHesapId { get; set; }
        public int? DigerHesapId { get; set; }
        public int? GibEFaturaPostaKutusuId { get; set; }
        public string EFaturaBolgeKodu { get; set; }
        public string EFaturaFaturaKodu { get; set; }
        public int? BolgeKoduId { get; set; }
        public string YetkiliKisi { get; set; }
        public int? GeldigiYerId { get; set; }
        public int? GunFarki { get; set; }
        public int? FiyatListesiId { get; set; }
        public int? YazihaneSiraNo { get; set; }
        public string YazihaneNot { get; set; }
        public double? RiskSiniri { get; set; }
        public int? EIrsaliyePostaKutusuId { get; set; }
        public string EFaturaBelgesi { get; set; }
        public string EIrsaliyeBelgesi { get; set; }
        public byte? EFaturaSenaryosu { get; set; }
        public double? KdvOrani { get; set; }
        public bool? EFaturaBakiyeVar { get; set; }
        public bool? VergiNoSorgulandi { get; set; }
        public bool? FatKesilmedenKunyeAlinamaz { get; set; }
        public int? SoforId { get; set; }
        public byte? HamaliyeHesaplamaSekli { get; set; }
        public byte? NakliyeHesaplamaSekli { get; set; }
        public int? RehinCariKartId { get; set; }
        public bool? StopajsizKesebilir { get; set; }

        public virtual TohalTabloMaddesi BolgeKodu { get; set; }
        public virtual TohalMuhHesap CariHesap { get; set; }
        public virtual TohalMuhHesap DigerHesap { get; set; }
        public virtual TohalGibKullanici EIrsaliyePostaKutusu { get; set; }
        public virtual TohalFiyatListesi FiyatListesi { get; set; }
        public virtual TohalTabloMaddesi GeldigiYer { get; set; }
        public virtual TohalGibKullanici GibEFaturaPostaKutusu { get; set; }
        public virtual TohalHal Hal { get; set; }
        public virtual TohalMarka Marka { get; set; }
        public virtual TohalCariKart Ortak { get; set; }
        public virtual TohalTabloMaddesi PostaKodu { get; set; }
        public virtual TohalCariKart RehinCariKart { get; set; }
        public virtual TohalTabloMaddesi Sofor { get; set; }
        public virtual TohalTabloMaddesi Ulke { get; set; }
        public virtual TohalTabloMaddesi VergiDairesi { get; set; }
        public virtual TohalYer Yer { get; set; }
        public virtual ICollection<TohalCariKart> InverseOrtak { get; set; }
        public virtual ICollection<TohalCariKart> InverseRehinCariKart { get; set; }
        public virtual ICollection<ToambAmbarFiyati> ToambAmbarFiyatiAmbars { get; set; }
        public virtual ICollection<ToambAmbarFiyati> ToambAmbarFiyatiGonderens { get; set; }
        public virtual ICollection<ToambAmbarFiyati> ToambAmbarFiyatiYazihanes { get; set; }
        public virtual ICollection<ToambNavlunFaturaSatiri> ToambNavlunFaturaSatiris { get; set; }
        public virtual ICollection<ToambNavlunFaturasi> ToambNavlunFaturasis { get; set; }
        public virtual ICollection<ToambSevkIrsaliyesiSatiri> ToambSevkIrsaliyesiSatiriGonderens { get; set; }
        public virtual ICollection<ToambSevkIrsaliyesiSatiri> ToambSevkIrsaliyesiSatiriPrimSahibis { get; set; }
        public virtual ICollection<ToambSevkIrsaliyesiSatiri> ToambSevkIrsaliyesiSatiriYazihanes { get; set; }
        public virtual ICollection<TohalBankaHareketi> TohalBankaHareketis { get; set; }
        public virtual ICollection<TohalCariHareket> TohalCariHareketCariKarts { get; set; }
        public virtual ICollection<TohalCariHareket> TohalCariHareketKarsiCariKarts { get; set; }
        public virtual ICollection<TohalFatura> TohalFaturas { get; set; }
        public virtual ICollection<TohalFi> TohalFis { get; set; }
        public virtual ICollection<TohalFisSatiri> TohalFisSatiris { get; set; }
        public virtual ICollection<TohalKapHareket> TohalKapHarekets { get; set; }
        public virtual ICollection<TohalMagaza> TohalMagazas { get; set; }
        public virtual ICollection<TohalMakbuz> TohalMakbuzCariKarts { get; set; }
        public virtual ICollection<TohalMakbuz> TohalMakbuzOrtaks { get; set; }
        public virtual ICollection<TohalOdemeBordrosu> TohalOdemeBordrosus { get; set; }
        public virtual ICollection<TohalSipari> TohalSiparis { get; set; }
        public virtual ICollection<TohalCariSifat> TohalCariSifats { get; set; }
    }
}