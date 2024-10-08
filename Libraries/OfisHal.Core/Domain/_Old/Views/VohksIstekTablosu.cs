

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohksIstekTablosu
    {
        public Guid Guid { get; set; }
        public int? SatirId { get; set; }
        public DateTime? IstekTarih { get; set; }
        public int EvrakTuru { get; set; }
        public int EvrakId { get; set; }
        public string EvrakNo { get; set; }
        public int IslemTuru { get; set; }
        public int? HataKodu { get; set; }
        public string HataMesaji { get; set; }
        public int? Durum { get; set; }
    }
}