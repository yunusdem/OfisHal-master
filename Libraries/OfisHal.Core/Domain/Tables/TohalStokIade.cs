using System;

namespace OfisHal.Core.Domain
{
    public class TohalStokIade
    {
        public int StokIadeId { get; set; }
        public int StokHareketiId { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
        public int KapSayisi { get; set; }
        public double Miktar { get; set; }

        public virtual TohalStokHareketi StokHareketi { get; set; }
    }
}