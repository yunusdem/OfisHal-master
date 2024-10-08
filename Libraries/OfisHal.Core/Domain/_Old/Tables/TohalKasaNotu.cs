using System;

namespace OfisHal.Web.Models
{
    public class TohalKasaNotu
    {
        public int KasaNotuId { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
    }
}