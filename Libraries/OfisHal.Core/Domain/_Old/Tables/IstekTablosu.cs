using System;

namespace OfisHal.Web.Models
{
    public class IstekTablosu
    {
        public Guid Guid { get; set; }
        public DateTime IstekZamani { get; set; }
        public string XmlVersiyon { get; set; }
        public int ProgramId { get; set; }
        public int EvrakTuru { get; set; }
        public int EvrakId { get; set; }
        public int? Durum { get; set; }
        public string Istek { get; set; }
        public int IslemTuru { get; set; }
        public string VeriTabaniAdi { get; set; }
        public int SiraNo { get; set; }
        public DateTime? IslemeAlinmaZamani { get; set; }
        public string HksKullaniciAdi { get; set; }
        public string HksSifre { get; set; }
        public string HksServisSifresi { get; set; }
        public string HataMesaji { get; set; }
        public string BelediyeAdi { get; set; }
    }
}