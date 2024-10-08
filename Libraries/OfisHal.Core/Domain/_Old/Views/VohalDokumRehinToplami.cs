

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalDokumRehinToplami
    {
        public int MakbuzId { get; set; }
        public int? MarkaId { get; set; }
        public string Marka { get; set; }
        public int KapId { get; set; }
        public string KapKodu { get; set; }
        public string KapAdi { get; set; }
        public int? KapMiktari { get; set; }
        public double? KapTutari { get; set; }
        public int? KesilenKapMiktari { get; set; }
        public double? KesilenKapTutari { get; set; }
    }
}