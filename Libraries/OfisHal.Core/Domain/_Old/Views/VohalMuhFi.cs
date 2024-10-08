

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalMuhFi
    {
        public int MuhFisId { get; set; }
        public byte Tur { get; set; }
        public byte? Konu { get; set; }
        public string FisNo { get; set; }
        public string YevmiyeNo { get; set; }
        public DateTime Tarih { get; set; }
        public string Hakkinda { get; set; }
        public byte? DokumanTipi { get; set; }
        public int? DigerDokumanTipiId { get; set; }
        public DateTime? DokumanTarihi { get; set; }
        public string DokumanNo { get; set; }
        public byte? OdemeSekli { get; set; }
        public byte? SahipTuru { get; set; }
        public int? SahipId { get; set; }
        public string DigerDokumanTipiAdi { get; set; }
    }
}