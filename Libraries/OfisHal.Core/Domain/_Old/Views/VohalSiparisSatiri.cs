

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalSiparisSatiri
    {
        public int SiparisId { get; set; }
        public string SiparisNo { get; set; }
        public string Aciklama { get; set; }
        public int SiparisSatiriId { get; set; }
        public int MalId { get; set; }
        public string MalKodu { get; set; }
        public string MalAdi { get; set; }
        public double Miktar { get; set; }
        public byte MalBirimi { get; set; }
    }
}