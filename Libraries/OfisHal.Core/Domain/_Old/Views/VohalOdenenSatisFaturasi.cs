

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalOdenenSatisFaturasi
    {
        public int CariHareketId { get; set; }
        public int FaturaId { get; set; }
        public string FaturaNo { get; set; }
        public DateTime Tarih { get; set; }
        public double? Tutar { get; set; }
    }
}