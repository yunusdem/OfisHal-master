

using System;
using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class VohalStokHareketi
    {
        public int StokHareketiId { get; set; }
        public int MakbuzId { get; set; }
        public string Marka { get; set; }
        public int SatirNo { get; set; }
        public DateTime GirisTarihi { get; set; }
        public byte StokTipi { get; set; }
        public int MalId { get; set; }
        public string MalKodu { get; set; }
        public string MalAdi { get; set; }
        public double Miktar { get; set; }
        public int? KapId { get; set; }
        public string KapKodu { get; set; }
        public string KapAdi { get; set; }
        public bool? Iadeli { get; set; }
        public int KapSayisi { get; set; }
        public double SatilanMiktar { get; set; }
        public int SatilanKap { get; set; }
        public int? StokKunyeId { get; set; }
        public string StokKunyesi { get; set; }
        public double? StokKunyesiFiyati { get; set; }
        public double? KalanMiktar { get; set; }
        public double? Fiyat { get; set; }
        public string Aciklama { get; set; }
    }
}