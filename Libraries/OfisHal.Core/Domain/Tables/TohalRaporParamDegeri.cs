using System;

namespace OfisHal.Core.Domain
{
    public class TohalRaporParamDegeri
    {
        public int KullaniciId { get; set; }
        public int RaporId { get; set; }
        public int ParametreId { get; set; }
        public int SiraNo { get; set; }
        public byte Tip { get; set; }
        public string IlkString { get; set; }
        public string SonString { get; set; }
        public DateTime? IlkTarih { get; set; }
        public DateTime? SonTarih { get; set; }
        public double? IlkSayi { get; set; }
        public double? SonSayi { get; set; }

        public virtual TohalKullanici Kullanici { get; set; }
    }
}