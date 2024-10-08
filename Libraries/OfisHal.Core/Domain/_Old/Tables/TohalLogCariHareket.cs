using System;

namespace OfisHal.Web.Models
{
    public class TohalLogCariHareket
    {
        public DateTime Zaman { get; set; }
        public int KullaniciId { get; set; }
        public byte Islem { get; set; }
        public int CariHareketId { get; set; }
        public int? OCariKartId { get; set; }
        public int? SCariKartId { get; set; }
        public DateTime? OTarih { get; set; }
        public DateTime? STarih { get; set; }
        public byte? OIslemTipi { get; set; }
        public byte? SIslemTipi { get; set; }
        public string OAciklama { get; set; }
        public string SAciklama { get; set; }
        public double? OMeblag { get; set; }
        public double? SMeblag { get; set; }
        public string ORefNo { get; set; }
        public string SRefNo { get; set; }
        public byte? OTip { get; set; }
        public byte? STip { get; set; }
    }
}