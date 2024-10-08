﻿

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalGonderimeHazirEMustahsilFaturasi
    {
        public int MakbuzId { get; set; }
        public string FaturaNo { get; set; }
        public string DokumNo { get; set; }
        public DateTime? Tarih { get; set; }
        public int CariKartId { get; set; }
        public string Unvan { get; set; }
        public double? ToplamTutar { get; set; }
        public byte EFaturaDurumu { get; set; }
        public int EBelgeTuru { get; set; }
        public byte? MusFatDuzenlemeSekli { get; set; }
        public DateTime? EMustahsilMakbuzuBaslangici { get; set; }
        public DateTime? FaturaTarihi { get; set; }
        public int? GibFirmamizPostaKutusuId { get; set; }
        public int? GibMuhatapPostaKutusuId { get; set; }
    }
}