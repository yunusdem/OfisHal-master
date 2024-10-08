

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrIadesizKapTakibi
    {
        public int FaturaId { get; set; }
        public string FaturaNo { get; set; }
        public DateTime Tarih { get; set; }
        public string Marka { get; set; }
        public string MalAdi { get; set; }
        public int FaturaSatiriId { get; set; }
        public int KapMiktari { get; set; }
        public double KapBedeli { get; set; }
        public double IadesizKapKdv { get; set; }
    }
}