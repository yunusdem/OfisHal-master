

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrSermayeKarlilik
    {
        public double? MalMaliyeti { get; set; }
        public string DokumNo { get; set; }
        public string Marka { get; set; }
        public DateTime Tarih { get; set; }
        public string IrsaliyeNo { get; set; }
        public string MustahsilAdi { get; set; }
        public int CariKartId { get; set; }
        public double Masraf { get; set; }
        public double Satis { get; set; }
        public double GirenMiktar { get; set; }
        public double SatisMasrafi { get; set; }
        public double NetTutar { get; set; }
        public double Miktar { get; set; }
        public string MustahsilKodu { get; set; }
        public int MakbuzId { get; set; }
    }
}