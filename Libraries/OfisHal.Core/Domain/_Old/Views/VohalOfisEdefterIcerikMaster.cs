

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalOfisEdefterIcerikMaster
    {
        public string YevmiyeNo { get; set; }
        public DateTime KayitTarihi { get; set; }
        public string MuhFisNo { get; set; }
        public string Hakkinda { get; set; }
        public double? BorcToplami { get; set; }
        public double? AlacakToplami { get; set; }
        public DateTime MuhFisTarih { get; set; }
        public string FirmaVkn { get; set; }
    }
}