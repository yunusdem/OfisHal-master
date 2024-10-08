﻿

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohksAlisFaturaSatiriIstek
    {
        public int FaturaId { get; set; }
        public int FaturaSatiriId { get; set; }
        public int? KunyeSatirId { get; set; }
        public int? StokKunyeId { get; set; }
        public string StokKunye { get; set; }
        public string PlakaNo { get; set; }
        public byte? Sifati { get; set; }
        public byte? BildirimTuru { get; set; }
        public int? TeslimatYeriId { get; set; }
        public string TeslimatYeri { get; set; }
        public byte? TeslimatYeriTipi { get; set; }
        public int? TeslimatYeriHksId { get; set; }
        public int? IlHksId { get; set; }
        public int? IlceHksId { get; set; }
        public int? BeldeHksId { get; set; }
        public string MustahsilPlakaNo { get; set; }
        public string MustahsilVergiKimlikNo { get; set; }
        public string MustahsilAdi { get; set; }
        public string MustahsilEposta { get; set; }
        public string MustahsilTel1 { get; set; }
        public string MustahsilGsmNo { get; set; }
        public string GsmNo { get; set; }
        public int? HksId { get; set; }
        public int? HksMalinNiteligi { get; set; }
        public int? UrunHksId { get; set; }
        public int? UrunHksKodu { get; set; }
        public byte? HksUretimSekli { get; set; }
        public byte? Birim { get; set; }
        public double MalMiktari { get; set; }
        public double Fiyat { get; set; }
        public string VergiKimlikNo { get; set; }
        public string EPosta { get; set; }
        public string Unvan { get; set; }
        public string IrsaliyeNo { get; set; }
        public string FaturaNo { get; set; }
    }
}