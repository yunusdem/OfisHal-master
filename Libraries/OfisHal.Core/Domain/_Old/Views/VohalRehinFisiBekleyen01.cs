

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalRehinFisiBekleyen01
    {
        public int CariKartId { get; set; }
        public int FaturaId { get; set; }
        public int FaturaTipi { get; set; }
        public string FaturaNo { get; set; }
        public string RefNo { get; set; }
        public DateTime Tarih { get; set; }
        public int? KalanMiktar { get; set; }
        public string Marka { get; set; }
        public string KapKodu { get; set; }
        public string KapMiktari { get; set; }
        public string Fiyat { get; set; }
    }
}