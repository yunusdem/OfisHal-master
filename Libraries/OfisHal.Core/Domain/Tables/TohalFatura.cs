using System;
using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class TohalFatura
    {
        public TohalFatura()
        {
            InverseFiyatReferansFatura = new HashSet<TohalFatura>();
            TohalCariHarekets = new HashSet<TohalCariHareket>();
            TohalFaturaSatiris = new HashSet<TohalFaturaSatiri>();
            TohalKullaniciKaldigiAlsFaturas = new HashSet<TohalKullanici>();
            TohalKullaniciKaldigiSatFaturas = new HashSet<TohalKullanici>();
            TohalRehinFisis = new HashSet<TohalRehinFisi>();
            CariHarekets = new HashSet<TohalCariHareket>();
        }

        public int FaturaId { get; set; }
        public int? CariKartId { get; set; }
        public DateTime Tarih { get; set; }
        public int Tip { get; set; }
        public string FaturaNo { get; set; }
        public string IrsaliyeNo { get; set; }
        public string Unvan { get; set; }
        public int? SehirId { get; set; }
        public string Adres { get; set; }
        public byte KisilikTipi { get; set; }
        public int? VergiDairesiId { get; set; }
        public string VergiKimlikNo { get; set; }
        public double Rusum { get; set; }
        public double IskontoOrani { get; set; }
        public double RusumKdvOrani { get; set; }
        public double Iskonto { get; set; }
        public double RusumKdv { get; set; }
        public double KdvsizIadesizKap { get; set; }
        public double KdvliIadesizKap { get; set; }
        public double IadesizKapKdvOrani { get; set; }
        public double IadesizKapKdv { get; set; }
        public double Yukleme { get; set; }
        public byte RehinIadeliKap { get; set; }
        public double YuklemeKdvOrani { get; set; }
        public double YuklemeKdv { get; set; }
        public double Nakliye { get; set; }
        public double NakliyeKdvOrani { get; set; }
        public double NakliyeKdv { get; set; }
        public bool? Kesildi { get; set; }
        public bool? Veresiye { get; set; }
        public int? Vade { get; set; }
        public int EkleyenId { get; set; }
        public DateTime EklemeZamani { get; set; }
        public int GuncelleyenId { get; set; }
        public DateTime GuncellemeZamani { get; set; }
        public bool? Degistirildi { get; set; }
        public int? MagazaId { get; set; }
        public DateTime IrsaliyeZamani { get; set; }
        public string Guid { get; set; }
        public bool? RehinDevri { get; set; }
        public bool? Ihracatci { get; set; }
        public string PlakaNo { get; set; }
        public byte? RusumKdvIliskisi { get; set; }
        public int? YerId { get; set; }
        public string GsmNo { get; set; }
        public string EPosta { get; set; }
        public byte? GidecegiYerTipi { get; set; }
        public byte? Sifati { get; set; }
        public byte? BildirimTuru { get; set; }
        public byte? CariSifati { get; set; }
        public int? HalId { get; set; }
        public int? TeslimatYeriId { get; set; }
        public int? HksWebSiraNo { get; set; }
        public int? GibFirmamizPostaKutusuId { get; set; }
        public int? GibMuhatapPostaKutusuId { get; set; }
        public DateTime Zaman { get; set; }
        public string EFaturaEttn { get; set; }
        public byte? EFaturaDurumu { get; set; }
        public string EFaturaHataAciklamasi { get; set; }
        public bool? Onaylandi { get; set; }
        public int? SiparisId { get; set; }
        public bool? IskontoHesaplanmasin { get; set; }
        public byte? HksMalinNiteligi { get; set; }
        public bool? Aktarildi { get; set; }
        public string EFaturaNot { get; set; }
        public string EFaturaSiparisNo { get; set; }
        public DateTime? EFaturaSiparisTarihi { get; set; }
        public string EFaturaBolgeKodu { get; set; }
        public bool? VeresiyeDurumuDegisti { get; set; }
        public double MalIskontoToplami { get; set; }
        public byte? EFaturaGibDurumu { get; set; }
        public string KunyeIstekGuid { get; set; }
        public int? FisId { get; set; }
        public int? BagkurDosyaId { get; set; }
        public string EIrsaliyeEttn { get; set; }
        public byte? EIrsaliyeDurumu { get; set; }
        public string EIrsaliyeHataAciklamasi { get; set; }
        public byte? EIrsaliyeGibDurumu { get; set; }
        public int? GibFrmIrsaliyeKutusuId { get; set; }
        public int? GibMuhatapIrsaliyeKutusuId { get; set; }
        public int? IhracatParaBirimiId { get; set; }
        public double? IhracatKuru { get; set; }
        public double? NavlunMaliyeti { get; set; }
        public double? SigortaMaliyeti { get; set; }
        public int? TeslimatSekliId { get; set; }
        public int? UlasimSekliId { get; set; }
        public int? OdemeSekliId { get; set; }
        public int? FiyatReferansFaturaId { get; set; }
        public string OdeyenKurumunVergiNosu { get; set; }
        public int? OdeyenKurumunVergiDaireId { get; set; }
        public double NakitTahsilat { get; set; }
        public double KrediKartiTahsilati { get; set; }
        public int? PosCihaziId { get; set; }
        public int? SoforId { get; set; }
        public bool? IadeFaturasi { get; set; }
        public byte? EFaturaSenaryosu { get; set; }

        public virtual TohalBagkurDosyasi BagkurDosya { get; set; }
        public virtual TohalCariKart CariKart { get; set; }
        public virtual TohalKullanici Ekleyen { get; set; }
        public virtual TohalFi Fis { get; set; }
        public virtual TohalFatura FiyatReferansFatura { get; set; }
        public virtual TohalGibKullanici GibFirmamizPostaKutusu { get; set; }
        public virtual TohalGibKullanici GibFrmIrsaliyeKutusu { get; set; }
        public virtual TohalGibKullanici GibMuhatapIrsaliyeKutusu { get; set; }
        public virtual TohalGibKullanici GibMuhatapPostaKutusu { get; set; }
        public virtual TohalKullanici Guncelleyen { get; set; }
        public virtual TohalHal Hal { get; set; }
        public virtual TohalTabloMaddesi IhracatParaBirimi { get; set; }
        public virtual TohalMagaza Magaza { get; set; }
        public virtual TohalTabloMaddesi OdemeSekli { get; set; }
        public virtual TohalPosCihazi PosCihazi { get; set; }
        public virtual TohalTabloMaddesi Sehir { get; set; }
        public virtual TohalSipari Siparis { get; set; }
        public virtual TohalTabloMaddesi Sofor { get; set; }
        public virtual TohalTabloMaddesi TeslimatSekli { get; set; }
        public virtual TohalTeslimatYeri TeslimatYeri { get; set; }
        public virtual TohalTabloMaddesi UlasimSekli { get; set; }
        public virtual TohalTabloMaddesi VergiDairesi { get; set; }
        public virtual TohalYer Yer { get; set; }
        public virtual ICollection<TohalFatura> InverseFiyatReferansFatura { get; set; }
        public virtual ICollection<TohalCariHareket> TohalCariHarekets { get; set; }
        public virtual ICollection<TohalFaturaSatiri> TohalFaturaSatiris { get; set; }
        public virtual ICollection<TohalKullanici> TohalKullaniciKaldigiAlsFaturas { get; set; }
        public virtual ICollection<TohalKullanici> TohalKullaniciKaldigiSatFaturas { get; set; }
        public virtual ICollection<TohalRehinFisi> TohalRehinFisis { get; set; }

        public virtual ICollection<TohalCariHareket> CariHarekets { get; set; }
    }
}