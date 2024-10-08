using System;

namespace OfisHal.Web.Models
{
    public class TohalIskeleObSatiri
    {
        public int Id { get; set; }
        public Guid? Guid { get; set; }
        public byte? OdemeAraciTuru { get; set; }
        public int? SatirNo { get; set; }
        public int? OdemeAraciId { get; set; }
        public bool? OdemeAraciSahibi { get; set; }
        public string OdemeAraciNo { get; set; }
        public DateTime? VadeTarihi { get; set; }
        public double? Meblag { get; set; }
        public int? BankaId { get; set; }
        public int? BankaHesabiId { get; set; }
        public string Aciklama { get; set; }
    }
}