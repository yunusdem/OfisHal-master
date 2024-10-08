

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalFiyatListesiSatiri
    {
        public DateTime? Tarih { get; set; }
        public byte Tip { get; set; }
        public int FiyatListesiId { get; set; }
        public int SatirNo { get; set; }
        public int MalId { get; set; }
        public string MalAdi { get; set; }
        public double Fiyat { get; set; }
        public double IskontoOrani { get; set; }
    }
}