namespace OfisHal.Web.Models
{
    public class TohalLogDokumDefteri
    {
        public int? MakbuzId { get; set; }
        public int? FaturaSatiriId { get; set; }
        public int? OMalId { get; set; }
        public int? SMalId { get; set; }
        public int? OKapSayisi { get; set; }
        public int? SKapSayisi { get; set; }
        public double? OMiktar { get; set; }
        public double? SMiktar { get; set; }
        public double? OFiyat { get; set; }
        public double? SFiyat { get; set; }
        public double? OTutar { get; set; }
        public double? STutar { get; set; }
        public double? OKdvOrani { get; set; }
        public double? SKdvOrani { get; set; }
        public int? OStokHareketiId { get; set; }
        public int? SStokHareketiId { get; set; }
        public double? OCiroPrimi { get; set; }
        public double? SCiroPrimi { get; set; }
        public string OAciklama { get; set; }
        public string SAciklama { get; set; }
    }
}