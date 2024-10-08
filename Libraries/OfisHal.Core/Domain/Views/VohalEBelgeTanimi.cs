

using System;
using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class VohalEBelgeTanimi
    {
        public int? EntegratorYanitVermeSuresi { get; set; }
        public string EBelgeServerIp { get; set; }
        public int? EBelgeServerPortu { get; set; }
        public byte? EFaturaSenaryosu { get; set; }
        public string KdvMuafiyetNedeni { get; set; }
        public string EntegratorCsvDizini { get; set; }
        public bool? XsltDosyalariKopyalansin { get; set; }
        public bool? RptDosyalariKopyalansin { get; set; }
        public DateTime? EFaturaBaslangicTarihi { get; set; }
        public string EFaturaOnEki { get; set; }
        public int? EFaturaSiraNo { get; set; }
        public bool? EFaturaBasilsin { get; set; }
        public bool? EFaturaNotAdetOlsun { get; set; }
        public byte? EFaturaYaziIleSekli { get; set; }
        public bool? EFaturaMustahsilVar { get; set; }
        public bool? EFaturaMustahsilVknVar { get; set; }
        public DateTime? EArsivBaslangicTarihi { get; set; }
        public string EArsivFaturasiOnEki { get; set; }
        public int? EArsivFaturasiSiraNo { get; set; }
        public bool? EArsivFaturasiBasilsin { get; set; }
        public DateTime? EMustahsilMakbuzuBaslangicTarihi { get; set; }
        public string EMustahsilMakbuzuOnEki { get; set; }
        public int? EMustahsilMakbuzuSiraNo { get; set; }
        public bool? EMustahsilMakbuzuBasilsin { get; set; }
        public bool? FirmalaraMakbuzKesilsin { get; set; }
        public byte? MusFatDuzenlemeSekli { get; set; }
        public string EMustahsilFaturasiOnEki { get; set; }
        public int? EMustahsilFaturasiSiraNo { get; set; }
        public string EMusFatArsivOnEki { get; set; }
        public int? EMusFatArsivSiraNo { get; set; }
        public DateTime? EIrsaliyeBaslangicTarihi { get; set; }
        public string EIrsaliyeOnEki { get; set; }
        public int? EIrsaliyeSiraNo { get; set; }
        public bool? EIrsaliyeBasilsin { get; set; }
        public bool? EIrsaliyedeFiyatVar { get; set; }
        public string EFaturaExeYolu { get; set; }
        public string EFaturaPortalAdresi { get; set; }
    }
}