

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalFisSatiri
    {
        public int FisSatiriId { get; set; }
        public int FisId { get; set; }
        public int SatirNo { get; set; }
        public int? MarkaId { get; set; }
        public int? CariKartId { get; set; }
        public int MalId { get; set; }
        public int? KapId { get; set; }
        public int KapMiktari { get; set; }
        public double Darali { get; set; }
        public double Dara { get; set; }
        public double MalMiktari { get; set; }
        public double? PiyasaFiyati { get; set; }
        public double? FiyatFarki { get; set; }
        public double Fiyat { get; set; }
        public double Tutar { get; set; }
        public string MalKodu { get; set; }
        public string MalAdi { get; set; }
        public string Marka { get; set; }
        public string CariKod { get; set; }
        public string CariAdi { get; set; }
        public string KapAdi { get; set; }
        public double? BirimDara { get; set; }
        public int? KapIcindekiMalMiktari { get; set; }
        public int? FaturaSatiriId { get; set; }
        public byte FisTipi { get; set; }
        public DateTime FisTarihi { get; set; }
    }
}