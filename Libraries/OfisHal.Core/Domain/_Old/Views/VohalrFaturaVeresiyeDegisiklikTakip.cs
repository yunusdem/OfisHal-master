

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrFaturaVeresiyeDegisiklikTakip
    {
        public int ReferansNo { get; set; }
        public DateTime Tarih { get; set; }
        public double PesinAlinan { get; set; }
        public double VeresiyeHareketTutari { get; set; }
        public string RefNo { get; set; }
        public DateTime? CariHareketTarihi { get; set; }
        public int KullaniciId { get; set; }
        public double? FaturaToplami { get; set; }
    }
}