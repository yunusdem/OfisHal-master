

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrMustahsilFaturaDokumu
    {
        public int MakbuzId { get; set; }
        public string FaturaNo { get; set; }
        public DateTime FaturaTarihi { get; set; }
        public int CariKartId { get; set; }
        public string MustahsilKodu { get; set; }
        public string MustahsilAdi { get; set; }
        public string VergiKimlikNo { get; set; }
        public int MarkaId { get; set; }
        public string Marka { get; set; }
        public double DigerIadeler { get; set; }
        public double RusumOrani { get; set; }
        public string Durum { get; set; }
        public double? Rusum { get; set; }
        public double StopajOrani { get; set; }
        public double? Stopaj { get; set; }
        public double BagkurOrani { get; set; }
        public double? Bagkur { get; set; }
        public double BorsaOrani { get; set; }
        public double? Borsa { get; set; }
        public double Navlun { get; set; }
        public double NavlunKdvOrani { get; set; }
        public double? NavlunKdv { get; set; }
        public double KomisyonOrani { get; set; }
        public double? Komisyon { get; set; }
        public double KomisyonKdvOrani { get; set; }
        public double? KomisyonKdv { get; set; }
        public double IadesizKapTutari { get; set; }
        public double IadesizKapKdvOrani { get; set; }
        public double? IadesizKapKdv { get; set; }
        public bool? IadesizKapKomisyonaDahil { get; set; }
        public string Aciklama { get; set; }
        public bool? Kesildi { get; set; }
        public double? Masraf { get; set; }
        public double? Miktar { get; set; }
        public double? Tutar { get; set; }
        public double? Kdv { get; set; }
        public string Sehir { get; set; }
        public string Plaka { get; set; }
        public DateTime StokGirisTarihi { get; set; }
        public string SatNakliyeAdlandirma { get; set; }
        public string SatHamaliyeAdlandirma { get; set; }
    }
}