

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalMakbuzdanCariKartBilgileriniSoyle
    {
        public int MakbuzId { get; set; }
        public byte KisilikTipi { get; set; }
        public string BagkurNo { get; set; }
        public string BorsaSicilNo { get; set; }
        public string MuafiyetBelgeNo { get; set; }
        public string BabaAdi { get; set; }
        public string Dogum { get; set; }
        public string Adres { get; set; }
        public string VergiKimlikNo { get; set; }
        public string VergiDairesi { get; set; }
        public int? BeldeId { get; set; }
        public string BeldeAdi { get; set; }
        public int? IlceId { get; set; }
        public string IlceAdi { get; set; }
        public int? IlId { get; set; }
        public string IlAdi { get; set; }
    }
}