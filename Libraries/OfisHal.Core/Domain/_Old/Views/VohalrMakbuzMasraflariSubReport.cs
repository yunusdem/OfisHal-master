

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrMakbuzMasraflariSubReport
    {
        public int? MakbuzId { get; set; }
        public long? SiraNo { get; set; }
        public string Aciklama { get; set; }
        public double Tutar { get; set; }
        public double Oran { get; set; }
        public int MakbuzMasrafi { get; set; }
    }
}