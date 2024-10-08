using System;

namespace OfisHal.Web.Models
{
    public class TohalLogOdemeBordrosu
    {
        public DateTime Zaman { get; set; }
        public int KullaniciId { get; set; }
        public byte Islem { get; set; }
        public int OdemeBordrosuId { get; set; }
        public int? OCariKartId { get; set; }
        public int? SCariKartId { get; set; }
        public byte? OIslemTuru { get; set; }
        public byte? SIslemTuru { get; set; }
        public string OBordroNo { get; set; }
        public string SBordroNo { get; set; }
        public DateTime? OTarih { get; set; }
        public DateTime? STarih { get; set; }
        public string OAciklama { get; set; }
        public string SAciklama { get; set; }
        public int? OBankaHesabiId { get; set; }
        public int? SBankaHesabiId { get; set; }
    }
}