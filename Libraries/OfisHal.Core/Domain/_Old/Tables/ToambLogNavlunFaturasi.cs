using System;

namespace OfisHal.Web.Models
{
    public class ToambLogNavlunFaturasi
    {
        public DateTime Zaman { get; set; }
        public int KullaniciId { get; set; }
        public byte Islem { get; set; }
        public int NavlunFaturasiId { get; set; }
        public int? OYazihaneId { get; set; }
        public int? SYazihaneId { get; set; }
        public int? ODizaynId { get; set; }
        public int? SDizaynId { get; set; }
        public string OFaturaNo { get; set; }
        public string SFaturaNo { get; set; }
        public DateTime? OTarih { get; set; }
        public DateTime? STarih { get; set; }
        public double? ONavlunToplam { get; set; }
        public double? SNavlunToplam { get; set; }
        public double? OMuameleToplam { get; set; }
        public double? SMuameleToplam { get; set; }
        public double? OToplam { get; set; }
        public double? SToplam { get; set; }
        public double? OKdvOrani { get; set; }
        public double? SKdvOrani { get; set; }
        public double? OKdv { get; set; }
        public double? SKdv { get; set; }
        public double? OGenelToplam { get; set; }
        public double? SGenelToplam { get; set; }
        public bool? OOdendi { get; set; }
        public bool? SOdendi { get; set; }
        public bool? OKesildi { get; set; }
        public bool? SKesildi { get; set; }
    }
}