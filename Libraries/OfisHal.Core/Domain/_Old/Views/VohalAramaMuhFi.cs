using System;

namespace OfisHal.Web.Models
{
    public class VohalAramaMuhFi
    {
        public int MuhFisId { get; set; }
        public DateTime Tarih { get; set; }
        public string YevmiyeNo { get; set; }
        public string FisNo { get; set; }
        public string FisTuru { get; set; }
        public byte? Konu { get; set; }
        public string Hakkinda { get; set; }
        public double? Tutar { get; set; }
    }
}