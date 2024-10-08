

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrSatisFaturasiAktarimi
    {
        public int FaturaId { get; set; }
        public DateTime Tarih { get; set; }
        public string Faturano { get; set; }
        public bool? Veresiye { get; set; }
        public string CariKod { get; set; }
        public string CariAdi { get; set; }
        public string VergiKimlikNo { get; set; }
        public string Marka { get; set; }
        public double MalMiktari { get; set; }
        public int KapMiktari { get; set; }
        public double Fiyat { get; set; }
        public double NetTutar { get; set; }
        public string StokKodu { get; set; }
        public double KdvOrani { get; set; }
        public double? MalKdv { get; set; }
        public double RusumOrani { get; set; }
        public double Rusum { get; set; }
        public double Rusumtoplam { get; set; }
        public double Yukleme { get; set; }
        public double YuklemeKdv { get; set; }
        public double Nakliye { get; set; }
        public double NakliyeKdv { get; set; }
        public double KdvsizIadesizKap { get; set; }
        public double KdvliIadesizKap { get; set; }
        public double IadesizKapKdvOrani { get; set; }
        public double IadesizKapKdv { get; set; }
        public byte RehinIadeliKap { get; set; }
        public int RehinMiktar { get; set; }
        public double? RehinFiyat { get; set; }
        public int RehinToplamMiktar { get; set; }
        public double? RehinToplamTutar { get; set; }
        public double? SonToplam { get; set; }
        public double RusumKdv { get; set; }
        public double IskontoOrani { get; set; }
        public double Iskonto { get; set; }
        public double SIskonto { get; set; }
        public double SIskontoOrani { get; set; }
        public string SatHamaliyeAdlandirma { get; set; }
        public string SatNakliyeAdlandirma { get; set; }
    }
}