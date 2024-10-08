

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrEntegreEdilmeyenStokHareketi
    {
        public int CariKartId { get; set; }
        public string MustahsilAdi { get; set; }
        public int MakbuzId { get; set; }
        public string DokumNo { get; set; }
        public string IrsaliyeNo { get; set; }
        public string GeldigiYer { get; set; }
        public string Plaka { get; set; }
        public DateTime StokGirisTarihi { get; set; }
        public int MarkaId { get; set; }
        public string Marka { get; set; }
        public int MalId { get; set; }
        public string MalAdi { get; set; }
        public double? Bakiye { get; set; }
        public byte StokTipi { get; set; }
        public double? Miktar { get; set; }
    }
}