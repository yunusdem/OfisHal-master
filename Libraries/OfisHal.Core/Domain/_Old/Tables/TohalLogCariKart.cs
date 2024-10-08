using System;

namespace OfisHal.Web.Models
{
    public class TohalLogCariKart
    {
        public DateTime Zaman { get; set; }
        public int KullaniciId { get; set; }
        public byte Islem { get; set; }
        public int CariKartId { get; set; }
        public double? ODevir { get; set; }
        public double? SDevir { get; set; }
        public double? OOran { get; set; }
        public double? SOran { get; set; }
        public double? OOrtaklikOrani { get; set; }
        public double? SOrtaklikOrani { get; set; }
    }
}