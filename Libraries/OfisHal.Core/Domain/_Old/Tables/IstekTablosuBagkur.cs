using System;

namespace OfisHal.Web.Models
{
    public class IstekTablosuBagkur
    {
        public Guid Guid { get; set; }
        public DateTime? IstekZamani { get; set; }
        public int? Durum { get; set; }
        public string Istek { get; set; }
        public int? IslemTuru { get; set; }
        public DateTime? IslemeAlinmaZamani { get; set; }
        public string VeriTabani { get; set; }
        public int KullaniciId { get; set; }
    }
}