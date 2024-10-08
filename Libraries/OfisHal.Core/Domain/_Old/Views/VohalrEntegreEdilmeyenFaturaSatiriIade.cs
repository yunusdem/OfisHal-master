

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrEntegreEdilmeyenFaturaSatiriIade
    {
        public string MalAdi { get; set; }
        public string MarkaAdi { get; set; }
        public int MarkaId { get; set; }
        public int MalId { get; set; }
        public byte StokTipi { get; set; }
        public int MakbuzId { get; set; }
        public double Miktar { get; set; }
        public int KapSayisi { get; set; }
        public int? DigKiloOndalikSayisi { get; set; }
        public int? DigFiyatKurusSayisi { get; set; }
        public bool? Kesildi { get; set; }
        public DateTime Tarih { get; set; }
    }
}