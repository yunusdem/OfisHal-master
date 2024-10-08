using System;

namespace OfisHal.Web.Models
{
    public class ToambIskeleAmbarKomisyonu
    {
        public int SatirNo { get; set; }
        public int IrsaliyeId { get; set; }
        public int AmbarId { get; set; }
        public int? Adet { get; set; }
        public double? Komisyon { get; set; }
        public Guid? Guid { get; set; }
    }
}