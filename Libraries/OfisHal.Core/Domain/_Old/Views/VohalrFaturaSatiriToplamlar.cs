

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrFaturaSatiriToplamlar
    {
        public int? FaturaId { get; set; }
        public double SiraNo { get; set; }
        public string Aciklama { get; set; }
        public double? Tutar { get; set; }
    }
}