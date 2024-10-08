

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrMakbuz
    {
        public int MakbuzId { get; set; }
        public int MarkaId { get; set; }
        public string Marka { get; set; }
        public int CariKartId { get; set; }
        public string CariKodu { get; set; }
        public string CariAdi { get; set; }
        public string DokumNo { get; set; }
        public string Adres { get; set; }
        public DateTime StokGirisTarihi { get; set; }
        public DateTime? FaturaTarihi { get; set; }
        public string FaturaNo { get; set; }
        public string IrsaliyeNo { get; set; }
        public string GeldigiYer { get; set; }
        public string Plaka { get; set; }
        public string Aciklama { get; set; }
        public bool? Kesildi { get; set; }
        public double RusumOrani { get; set; }
        public double Rusum { get; set; }
        public double StopajOrani { get; set; }
        public double Stopaj { get; set; }
        public double BagkurOrani { get; set; }
        public double Bagkur { get; set; }
        public double BorsaOrani { get; set; }
        public double Borsa { get; set; }
        public double Navlun { get; set; }
        public double NavlunKdvOrani { get; set; }
        public double NavlunKdv { get; set; }
        public double KomisyonOrani { get; set; }
        public double Komisyon { get; set; }
        public double KomisyonKdvOrani { get; set; }
        public double KomisyonKdv { get; set; }
        public double IadesizKapTutari { get; set; }
        public double IadesizKapKdvOrani { get; set; }
        public double IadesizKapKdv { get; set; }
        public bool? IadesizKapKomisyonaDahil { get; set; }
        public double? GelenMiktar { get; set; }
        public int? GelenKap { get; set; }
        public double? SatilanMiktar { get; set; }
        public int? SatilanKap { get; set; }
        public int? BekleyenHareketSayisi { get; set; }
        public double? MakbuzdakiMiktar { get; set; }
        public int? MakbuzdakiKap { get; set; }
        public double? Masraf { get; set; }
        public double? MasrafKdv { get; set; }
        public double? MalTutari { get; set; }
        public double? MalKdv { get; set; }
        public int? OrtakId { get; set; }
        public double OrtaklikOrani { get; set; }
        public string OrtakAdi { get; set; }
        public int? Vade { get; set; }
        public string EkleyenKullaniciAdi { get; set; }
        public DateTime EklemeZamani { get; set; }
        public string GuncelleyenKullaniciAdi { get; set; }
        public DateTime GuncellemeZamani { get; set; }
        public string MakbuzGuncelleyenKullaniciAdi { get; set; }
        public DateTime MakbuzGuncellemeZamani { get; set; }
        public double IadeliKapTutari { get; set; }
        public int? VergiDairesiId { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiKimlikNo { get; set; }
        public int? SehirId { get; set; }
        public string Sehir { get; set; }
        public string KodTarih { get; set; }
        public string AdTarih { get; set; }
        public string DigAdres { get; set; }
        public string FirMahalle { get; set; }
        public string FirCadde { get; set; }
        public string FirSokak { get; set; }
        public string FirmaVergiDairesiAdi { get; set; }
        public string DigVergiKimlikNo { get; set; }
        public string FirMersisNo { get; set; }
        public string EFaturaEttn { get; set; }
        public string DuzelnlemeZamani { get; set; }
        public string FirmaAdresi { get; set; }
        public byte[] Logo { get; set; }
        public byte[] Imza { get; set; }
    }
}