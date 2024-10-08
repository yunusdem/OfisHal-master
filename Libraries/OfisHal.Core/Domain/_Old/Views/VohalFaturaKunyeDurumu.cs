

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalFaturaKunyeDurumu
    {
        public int FaturaId { get; set; }
        public DateTime Tarih { get; set; }
        public string FaturaNo { get; set; }
        public string MusteriAdi { get; set; }
        public string MagazaAdi { get; set; }
        public int? SatirSayisi { get; set; }
        public int? StokKunyeSayisi { get; set; }
        public int? SatisKunyeSayisi { get; set; }
    }
}