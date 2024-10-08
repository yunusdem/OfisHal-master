namespace OfisHal.Core.Domain
{
    public class TohalKullaniciYetkisi
    {
        public int KullaniciId { get; set; }
        public byte YetkiCinsi { get; set; }
        public byte? CalismaBicimi { get; set; }

        public virtual TohalKullanici Kullanici { get; set; }
    }
}