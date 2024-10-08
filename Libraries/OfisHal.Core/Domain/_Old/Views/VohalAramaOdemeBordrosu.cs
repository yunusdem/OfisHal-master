using System;

namespace OfisHal.Web.Models
{
    public class VohalAramaOdemeBordrosu
    {
        public int OdemeBordrosuId { get; set; }
        public int? CariKartId { get; set; }
        public byte IslemTuru { get; set; }
        public string BordroNo { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
        public string Ad { get; set; }
    }
}