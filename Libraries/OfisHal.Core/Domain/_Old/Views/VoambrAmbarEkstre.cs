using System;

namespace OfisHal.Web.Models
{
    public class VoambrAmbarEkstre
    {
        public DateTime? Tarih { get; set; }
        public string Kod { get; set; }
        public string Unvan { get; set; }
        public string Tip { get; set; }
        public string EvrakNo { get; set; }
        public string Aciklama { get; set; }
        public double Borc { get; set; }
        public double? Alacak { get; set; }
    }
}