

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class Vohalr00EntegreEdilmeyenStokHareketi
    {
        public int MakbuzId { get; set; }
        public DateTime GirisTarihi { get; set; }
        public string DokumNo { get; set; }
        public int MarkaId { get; set; }
        public int? KapId { get; set; }
        public int MalId { get; set; }
        public byte StokTipi { get; set; }
        public int SatirNo { get; set; }
        public int StokHareketiId { get; set; }
        public double? Bakiye { get; set; }
        public double? Miktar { get; set; }
    }
}