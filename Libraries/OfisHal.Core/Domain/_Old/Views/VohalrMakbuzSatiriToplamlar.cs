

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrMakbuzSatiriToplamlar
    {
        public int MakbuzId { get; set; }
        public double? MalTutari { get; set; }
        public double KdvOrani { get; set; }
        public string KdvAciklamasi { get; set; }
        public double? Kdv { get; set; }
        public double? VergilerDahilToplam { get; set; }
        public double ToplamMasraflar { get; set; }
        public double? FaturaToplami { get; set; }
        public double IadeliKapTutari { get; set; }
        public double? NetYekun { get; set; }
    }
}