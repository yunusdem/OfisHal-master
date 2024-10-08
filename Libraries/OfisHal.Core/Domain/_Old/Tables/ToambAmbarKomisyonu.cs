namespace OfisHal.Web.Models
{
    public class ToambAmbarKomisyonu
    {
        public int? SatirNo { get; set; }
        public int IrsaliyeId { get; set; }
        public int AmbarId { get; set; }
        public int? Adet { get; set; }
        public double? Komisyon { get; set; }

        public virtual TohalCariKart Ambar { get; set; }
        public virtual ToambSevkIrsaliyesi Irsaliye { get; set; }
    }
}