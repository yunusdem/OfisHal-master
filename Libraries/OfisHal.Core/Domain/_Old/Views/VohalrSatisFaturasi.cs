

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrSatisFaturasi
    {
        public int FaturaId { get; set; }
        public DateTime Tarih { get; set; }
        public string FaturaNo { get; set; }
        public string IrsaliyeNo { get; set; }
        public int? CariKartId { get; set; }
        public string CariKod { get; set; }
        public string Unvan { get; set; }
        public int? SehirId { get; set; }
        public string Sehir { get; set; }
        public string Adres { get; set; }
        public byte KisilikTipi { get; set; }
        public int Tip { get; set; }
        public int? VergiDairesiId { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiKimlikNo { get; set; }
        public int OdemeSekli { get; set; }
        public double Rusum { get; set; }
        public double RusumKdvOrani { get; set; }
        public double RusumKdv { get; set; }
        public double IskontoOrani { get; set; }
        public double? Iskonto { get; set; }
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
        public double VeresiyeTahsilEdilen { get; set; }
        public int? Vade { get; set; }
        public double MalKdv { get; set; }
        public double RehinToplami { get; set; }
        public double MasrafKdv { get; set; }
        public double Masraf { get; set; }
        public int? FiyatKurusSayisi { get; set; }
        public byte? SatRusumKdvIliskisi { get; set; }
        public double RusumOrani { get; set; }
        public string MagazaAdi { get; set; }
        public string MagazaKodu { get; set; }
        public double? MasrafToplami { get; set; }
        public string EFaturaNot { get; set; }
        public string SatHamaliyeAdlandirma { get; set; }
        public string SatNakliyeAdlandirma { get; set; }
    }
}