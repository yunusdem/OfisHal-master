using System;

namespace OfisHal.Web.Models
{
    public class VohalAramaKunyesiAlinamayanlar
    {
        public string EvrakTuru { get; set; }
        public int EvrakId { get; set; }
        public string EvrakNo { get; set; }
        public string IslemTuru { get; set; }
        public DateTime IstekZamani { get; set; }
    }
}