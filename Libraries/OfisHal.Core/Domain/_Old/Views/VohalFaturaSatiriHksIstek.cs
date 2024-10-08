

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalFaturaSatiriHksIstek
    {
        public int FaturaId { get; set; }
        public int FaturaSatiriId { get; set; }
        public int? StokKunyeId { get; set; }
        public string StokKunye { get; set; }
        public int? SatisKunyeId { get; set; }
        public string SatisKunye { get; set; }
        public int TeslimatYeriId { get; set; }
        public string TeslimatYeri { get; set; }
        public byte TeslimatYeriTipi { get; set; }
        public int? TeslimatYeriHksId { get; set; }
        public string MustahsilPlakaNo { get; set; }
        public string MustahsilVergiKimlikNo { get; set; }
        public string MustahsilAdi { get; set; }
        public string MustahsilEposta { get; set; }
        public string MustahsilTel1 { get; set; }
        public int? IlHksId { get; set; }
        public int? IlceHksId { get; set; }
        public int? BeldeHksId { get; set; }
        public int? HksId { get; set; }
        public int? UrunHksId { get; set; }
        public int? HksUrunKodu { get; set; }
        public byte? HksUretimSekli { get; set; }
        public byte? Birim { get; set; }
        public double MalMiktari { get; set; }
        public double Fiyat { get; set; }
        public int? MusteriCariKartId { get; set; }
        public byte? CariKartGidecegiYerTipi { get; set; }
        public byte? FaturaGidecegiYerTipi { get; set; }
        public int? MagazaHksId { get; set; }
        public int? CariIlkMagazaHksId { get; set; }
        public byte? BildirimTuru { get; set; }
        public int? FaturaIlHksId { get; set; }
        public int? FaturaIlceHksId { get; set; }
        public int? FaturaBeldeHksId { get; set; }
        public string PlakaNo { get; set; }
        public byte? CariSifati { get; set; }
        public string VergiKimlikNo { get; set; }
        public string Unvan { get; set; }
        public string EPosta { get; set; }
        public string GsmNo { get; set; }
        public int? CariKartYerHksId { get; set; }
        public int? FaturaYerHksId { get; set; }
    }
}