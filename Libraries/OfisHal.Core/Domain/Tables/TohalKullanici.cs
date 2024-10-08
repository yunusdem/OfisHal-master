using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class TohalKullanici
    {
        public TohalKullanici()
        {
            ToambNavlunFaturasiEkleyens = new HashSet<ToambNavlunFaturasi>();
            ToambNavlunFaturasiGuncelleyens = new HashSet<ToambNavlunFaturasi>();
            ToambSevkIrsaliyesiEkleyens = new HashSet<ToambSevkIrsaliyesi>();
            ToambSevkIrsaliyesiGuncelleyens = new HashSet<ToambSevkIrsaliyesi>();
            TohalBankaHareketiEkleyens = new HashSet<TohalBankaHareketi>();
            TohalBankaHareketiGuncelleyens = new HashSet<TohalBankaHareketi>();
            TohalCariHareketEkleyens = new HashSet<TohalCariHareket>();
            TohalCariHareketGuncelleyens = new HashSet<TohalCariHareket>();
            TohalFaturaEkleyens = new HashSet<TohalFatura>();
            TohalFaturaGuncelleyens = new HashSet<TohalFatura>();
            TohalFis = new HashSet<TohalFi>();
            TohalHesapHareketiEkleyens = new HashSet<TohalHesapHareketi>();
            TohalHesapHareketiGuncelleyens = new HashSet<TohalHesapHareketi>();
            TohalKapHareketEkleyens = new HashSet<TohalKapHareket>();
            TohalKapHareketGuncelleyens = new HashSet<TohalKapHareket>();
            TohalKullaniciYetkisis = new HashSet<TohalKullaniciYetkisi>();
            TohalMakbuzEkleyens = new HashSet<TohalMakbuz>();
            TohalMakbuzGuncelleyens = new HashSet<TohalMakbuz>();
            TohalMakbuzMakbuzGuncelleyens = new HashSet<TohalMakbuz>();
            TohalOdemeBordrosuEkleyens = new HashSet<TohalOdemeBordrosu>();
            TohalOdemeBordrosuGuncelleyens = new HashSet<TohalOdemeBordrosu>();
            TohalRaporParamDegeris = new HashSet<TohalRaporParamDegeri>();
        }

        public int KullaniciId { get; set; }
        public string Ad { get; set; }
        public string Sifre { get; set; }
        public bool? SistemYoneticisi { get; set; }
        public int? KaldigiSatFaturaId { get; set; }
        public int? KaldigiAlsFaturaId { get; set; }
        public int? YaziciId { get; set; }
        public int? SatisFaturasiSiraNo { get; set; }
        public int? ProgramZeminRengi { get; set; }
        public int? AlisFaturasiSiraNo { get; set; }
        public int? ProgramYaziRengi { get; set; }
        public int? MustahsilFaturasiSiraNo { get; set; }
        public string MenuFontu { get; set; }
        public string MenuBaslikFontu { get; set; }
        public int? GridBaslikRengi { get; set; }
        public int? MenuArkaPlanRengi { get; set; }
        public int? PencereZeminRengi { get; set; }
        public int? PencereYaziRengi { get; set; }
        public int? PencereFokusRengi { get; set; }
        public int? GridZeminRengi { get; set; }
        public string DialogFontu { get; set; }
        public string GridFontu { get; set; }
        public int? KayitGostermeGunSayisi { get; set; }
        public string AnaMenuYetkisi { get; set; }
        public string MustahsilCariYetkisi { get; set; }
        public string DokumIslemleriYetkisi { get; set; }
        public string MusteriCariYetkisi { get; set; }
        public string SatisIslemleriYetkisi { get; set; }
        public string KasaIslemleriYetkisi { get; set; }
        public string CekSenetIslemleriYetkisi { get; set; }
        public string ResmiFormlarYetkisi { get; set; }
        public string TeknikIslemlerYetkisi { get; set; }
        public int? DikeyZoom { get; set; }
        public int? YatayZoom { get; set; }
        public int? BaktigiSatFaturaId { get; set; }
        public string BankaIslemleriYetkisi { get; set; }
        public int? BaktigiAlsFaturaId { get; set; }
        public string ServisIslemleriYetkisi { get; set; }
        public string AlisIslemleriYetkisi { get; set; }
        public int? EFaturaGondericiBirimiId { get; set; }
        public string EntegratorKullaniciAdi { get; set; }
        public string EntegratorKullaniciSifresi { get; set; }
        public string EFaturaOnEki { get; set; }
        public int? EFaturaSiraNo { get; set; }
        public string MuhasebeYetkisi { get; set; }
        public string EMustahsilFaturasiOnEki { get; set; }
        public int? EMustahsilFaturasiSiraNo { get; set; }
        public int? NavlunFaturaSiraNo { get; set; }
        public string NavlunEFaturaOnEki { get; set; }
        public string AmbarCariYetkisi { get; set; }
        public string HalCariYetkisi { get; set; }
        public string AmbarFaturaMenusuYetkisi { get; set; }
        public int? MustahsilYaziciId { get; set; }
        public int? IrsaliyeYaziciId { get; set; }
        public int? VadeUyariGunSayisi { get; set; }
        public int? FisSiraNo { get; set; }
        public int? MalKabulSiraNo { get; set; }
        public string EArsivFaturasiOnEki { get; set; }
        public int? EArsivFaturasiSiraNo { get; set; }
        public string EMustahsilMakbuzuOnEki { get; set; }
        public int? EMustahsilMakbuzuSiraNo { get; set; }
        public string EIrsaliyeOnEki { get; set; }
        public int? EIrsaliyeSiraNo { get; set; }
        public string EMusFatArsivOnEki { get; set; }
        public int? EMusFatArsivSiraNo { get; set; }
        public int? EIrsaliyeGondericiBirimiId { get; set; }
        public bool? EBelgeKullaniliyor { get; set; }
        public string MobilYetkisi { get; set; }
        public int? BarkodYaziciId { get; set; }

        public virtual TohalGibKullanici EFaturaGondericiBirimi { get; set; }
        public virtual TohalGibKullanici EIrsaliyeGondericiBirimi { get; set; }
        public virtual TohalFatura KaldigiAlsFatura { get; set; }
        public virtual TohalFatura KaldigiSatFatura { get; set; }
        public virtual ICollection<ToambNavlunFaturasi> ToambNavlunFaturasiEkleyens { get; set; }
        public virtual ICollection<ToambNavlunFaturasi> ToambNavlunFaturasiGuncelleyens { get; set; }
        public virtual ICollection<ToambSevkIrsaliyesi> ToambSevkIrsaliyesiEkleyens { get; set; }
        public virtual ICollection<ToambSevkIrsaliyesi> ToambSevkIrsaliyesiGuncelleyens { get; set; }
        public virtual ICollection<TohalBankaHareketi> TohalBankaHareketiEkleyens { get; set; }
        public virtual ICollection<TohalBankaHareketi> TohalBankaHareketiGuncelleyens { get; set; }
        public virtual ICollection<TohalCariHareket> TohalCariHareketEkleyens { get; set; }
        public virtual ICollection<TohalCariHareket> TohalCariHareketGuncelleyens { get; set; }
        public virtual ICollection<TohalFatura> TohalFaturaEkleyens { get; set; }
        public virtual ICollection<TohalFatura> TohalFaturaGuncelleyens { get; set; }
        public virtual ICollection<TohalFi> TohalFis { get; set; }
        public virtual ICollection<TohalHesapHareketi> TohalHesapHareketiEkleyens { get; set; }
        public virtual ICollection<TohalHesapHareketi> TohalHesapHareketiGuncelleyens { get; set; }
        public virtual ICollection<TohalKapHareket> TohalKapHareketEkleyens { get; set; }
        public virtual ICollection<TohalKapHareket> TohalKapHareketGuncelleyens { get; set; }
        public virtual ICollection<TohalKullaniciYetkisi> TohalKullaniciYetkisis { get; set; }
        public virtual ICollection<TohalMakbuz> TohalMakbuzEkleyens { get; set; }
        public virtual ICollection<TohalMakbuz> TohalMakbuzGuncelleyens { get; set; }
        public virtual ICollection<TohalMakbuz> TohalMakbuzMakbuzGuncelleyens { get; set; }
        public virtual ICollection<TohalOdemeBordrosu> TohalOdemeBordrosuEkleyens { get; set; }
        public virtual ICollection<TohalOdemeBordrosu> TohalOdemeBordrosuGuncelleyens { get; set; }
        public virtual ICollection<TohalRaporParamDegeri> TohalRaporParamDegeris { get; set; }
    }
}