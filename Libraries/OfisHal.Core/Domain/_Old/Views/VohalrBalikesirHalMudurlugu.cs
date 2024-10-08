

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrBalikesirHalMudurlugu
    {
        public int FaturaId { get; set; }
        public string AdiSoyadi { get; set; }
        public string VergiDairesi { get; set; }
        public string SicilNo { get; set; }
        public DateTime Tarihi { get; set; }
        public string SeriNo { get; set; }
        public string FaturaNo { get; set; }
        public string Cinsi { get; set; }
        public double Kg { get; set; }
        public int MiktarBasamakSayisi { get; set; }
        public int Kasa { get; set; }
        public double Fiyati { get; set; }
        public int? FiyatKurusBasamakSayisi { get; set; }
        public double Tutari { get; set; }
        public double KdvOrani { get; set; }
    }
}