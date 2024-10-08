using System;

namespace OfisHal.Web.Models
{
    public class VoambrYazihaneGelenMalRaporu
    {
        public int IrsaliyeId { get; set; }
        public string IrsaliyeNo { get; set; }
        public int RefNo { get; set; }
        public DateTime Tarih { get; set; }
        public int? SatirNo { get; set; }
        public int? GonderenId { get; set; }
        public string GonderenKodu { get; set; }
        public string Gonderen { get; set; }
        public int? MalId { get; set; }
        public string MalCinsi { get; set; }
        public string Kap { get; set; }
        public int Adet { get; set; }
        public double MuameleTutar { get; set; }
        public double Tutar { get; set; }
        public string FaturaNo { get; set; }
        public string PlakaNo { get; set; }
        public string GeldigiYer { get; set; }
        public string AmbarAdi { get; set; }
        public string AmbarKodu { get; set; }
        public int? YazihaneId { get; set; }
        public string YazihaneAdi { get; set; }
        public string YazihaneKodu { get; set; }
        public double KdvToplami { get; set; }
        public string DizaynAdi { get; set; }
        public string DizaynDosyaAdi { get; set; }
    }
}