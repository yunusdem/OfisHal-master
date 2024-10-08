

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalFi
    {
        public int FisId { get; set; }
        public byte Tip { get; set; }
        public int? CariKartId { get; set; }
        public int? KayitsizMusteriId { get; set; }
        public string CariKod { get; set; }
        public string Unvan { get; set; }
        public string FisNo { get; set; }
        public DateTime Tarih { get; set; }
        public DateTime? OdemeTarihi { get; set; }
        public string Aciklama { get; set; }
        public int KullaniciId { get; set; }
        public string KullaniciAdi { get; set; }
        public string GuncellemeZamani { get; set; }
    }
}