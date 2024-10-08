namespace OfisHal.Web.Models
{
    public class VohalbFaturaDetay
    {
        public int FaturaId { get; set; }
        public int SiraNo { get; set; }
        public double VeresiyeTahsilEdilen { get; set; }
        public bool? Veresiye { get; set; }
        public string EFaturaNot { get; set; }
        public string Aciklama { get; set; }
        public double? Tutar { get; set; }
    }
}