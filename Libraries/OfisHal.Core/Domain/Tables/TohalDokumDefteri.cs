namespace OfisHal.Core.Domain
{
    public class TohalDokumDefteri
    {
        public int Id { get; set; }
        public int MakbuzId { get; set; }
        public int? FaturaSatiriId { get; set; }
        public int MalId { get; set; }
        public int KapSayisi { get; set; }
        public double Miktar { get; set; }
        public double Fiyat { get; set; }
        public double Tutar { get; set; }
        public double KdvOrani { get; set; }
        public int? StokHareketiId { get; set; }
        public double CiroPrimi { get; set; }
        public string Aciklama { get; set; }

        public virtual TohalFaturaSatiri FaturaSatiri { get; set; }
        public virtual TohalMakbuz Makbuz { get; set; }
        public virtual TohalMal Mal { get; set; }
    }
}