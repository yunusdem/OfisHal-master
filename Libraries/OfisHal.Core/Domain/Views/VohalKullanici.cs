using System;

namespace OfisHal.Core.Domain
{
    public class VohalKullanici
    {
        public int KullaniciId { get; set; }
        public Guid? Guid { get; set; }
        public string Ad { get; set; }
        public bool? SistemYoneticisi { get; set; }
        public string Sifre { get; set; }
        public int? YaziciId { get; set; }
        public string YaziciNo { get; set; }
        public int? KaldigiSatFaturaId { get; set; }
        public int? KaldigiAlsFaturaId { get; set; }
        public int? SatisFaturasiSiraNo { get; set; }
        public int? AlisFaturasiSiraNo { get; set; }
        public int? MustahsilFaturasiSiraNo { get; set; }
        public int? ProgramZeminRengi { get; set; }
        public int? ProgramYaziRengi { get; set; }
        public int? GridBaslikRengi { get; set; }
        public int? GridZeminRengi { get; set; }
        public int? PencereZeminRengi { get; set; }
        public int? PencereYaziRengi { get; set; }
        public int? PencereFokusRengi { get; set; }
        public string MenuFontu { get; set; }
        public string MenuBaslikFontu { get; set; }
        public int? MenuArkaPlanRengi { get; set; }
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
        public int? YatayZoom { get; set; }
        public int? DikeyZoom { get; set; }
        public string BankaIslemleriYetkisi { get; set; }
        public string ServisIslemleriYetkisi { get; set; }
        public string AlisIslemleriYetkisi { get; set; }
        public string MuhasebeYetkisi { get; set; }
        public string MobilYetkisi { get; set; }
        public string DegisiklikTakipSifresi { get; set; }
        public int? NavlunFaturaSiraNo { get; set; }
        public string NavlunEFaturaOnEki { get; set; }
        public string AmbarCariYetkisi { get; set; }
        public string HalCariYetkisi { get; set; }
        public string AmbarFaturaMenusuYetkisi { get; set; }
        public int? MustahsilYaziciId { get; set; }
        public string MustahsilYaziciNo { get; set; }
        public int? IrsaliyeYaziciId { get; set; }
        public string IrsaliyeYaziciNo { get; set; }
        public int? BarkodYaziciId { get; set; }
        public string BarkodYaziciNo { get; set; }
        public int? VadeUyariGunSayisi { get; set; }
        public int? FisSiraNo { get; set; }
        public int? MalKabulSiraNo { get; set; }
        public int? EFaturaGondericiBirimiId { get; set; }
        public string EFaturaGondericiBirimi { get; set; }
        public int? EIrsaliyeGondericiBirimiId { get; set; }
        public string EIrsaliyeGondericiBirimi { get; set; }
        public string EntegratorKullaniciAdi { get; set; }
        public string EntegratorKullaniciSifresi { get; set; }
        public bool? EBelgeKullaniliyor { get; set; }
        public string EFaturaOnEki { get; set; }
        public int? EFaturaSiraNo { get; set; }
        public string EArsivFaturasiOnEki { get; set; }
        public int? EArsivFaturasiSiraNo { get; set; }
        public string EMustahsilFaturasiOnEki { get; set; }
        public int? EMustahsilFaturasiSiraNo { get; set; }
        public string EMusFatArsivOnEki { get; set; }
        public int? EMusFatArsivSiraNo { get; set; }
        public string EMustahsilMakbuzuOnEki { get; set; }
        public int? EMustahsilMakbuzuSiraNo { get; set; }
        public string EIrsaliyeOnEki { get; set; }
        public int? EIrsaliyeSiraNo { get; set; }
    }
}