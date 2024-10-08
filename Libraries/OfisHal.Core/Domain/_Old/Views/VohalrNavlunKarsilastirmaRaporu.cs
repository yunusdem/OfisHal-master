

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrNavlunKarsilastirmaRaporu
    {
        public string Marka { get; set; }
        public string CariKodu { get; set; }
        public string CariAdi { get; set; }
        public string DokumNo { get; set; }
        public DateTime? StokGirisTarihi { get; set; }
        public string IrsaliyeNo { get; set; }
        public double? Navlun { get; set; }
        public double? OdenenNavlun { get; set; }
        public DateTime? OdemeTarihi { get; set; }
        public int? KurusSayisi { get; set; }
    }
}