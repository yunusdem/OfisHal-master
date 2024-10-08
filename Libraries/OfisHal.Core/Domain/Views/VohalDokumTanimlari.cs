

using System;
using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class VohalDokumTanimlari
    {
        public double? DokRusumOrani { get; set; }
        public double? DokBagkurOrani { get; set; }
        public double? DokBorsaOrani { get; set; }
        public double? DokStopajOrani { get; set; }
        public double? DokBorsaStopajOrani { get; set; }
        public double? DokKomisyonOrani { get; set; }
        public double? DokKomisyonKdvOrani { get; set; }
        public double? DokTuccarKapKdvOrani { get; set; }
        public double? DokNavlunKdvOrani { get; set; }
        public bool? DokDokumDefteriVar { get; set; }
        public byte? DokDokumAmbar { get; set; }
        public byte? DokDokumDefterTipi { get; set; }
        public byte? DokDokumDefterGosterimi { get; set; }
        public int? DokFaturaSiraNo { get; set; }
        public double? DokMustahsilCiroSiniri { get; set; }
        public bool? DokOtomatikHamaliye { get; set; }
        public byte? DokHamaliyeHesaplamaSekli { get; set; }
        public double? DokBirimHamaliye { get; set; }
        public double? DokBirimNakliye { get; set; }
        public bool? DokKapKomisyonaDahil { get; set; }
        public byte? DokAyniMallariToplamaSekli { get; set; }
        public bool? IadeliKapTutarRehindenAl { get; set; }
        public bool? DokFiyatGirilsin { get; set; }
        public byte? DokCariyeIslemeSekli { get; set; }
        public bool? DokCariIslemeDegissin { get; set; }
        public bool? DokToplamaMalCalisir { get; set; }
        public int? DokHizmetBedeliHesabiId { get; set; }
        public string DokHizmetBedeliHesabiKodu { get; set; }
        public bool? DokKapliEntegrasyonYap { get; set; }
        public bool? DokSatirdaStokGirisTarihi { get; set; }
    }
}