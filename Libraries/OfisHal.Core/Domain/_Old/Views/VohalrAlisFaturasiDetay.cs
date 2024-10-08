

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrAlisFaturasiDetay
    {
        public int CariHareketId { get; set; }
        public int FaturaId { get; set; }
        public string MalAdi { get; set; }
        public int KapSayisi { get; set; }
        public double Miktar { get; set; }
        public double Fiyat { get; set; }
        public double Tutar { get; set; }
        public double KdvOrani { get; set; }
        public int? DigKiloOndalikSayisi { get; set; }
        public int? DigFiyatKurusSayisi { get; set; }
        public double Darali { get; set; }
        public string Aciklama { get; set; }
    }
}