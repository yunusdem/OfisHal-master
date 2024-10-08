namespace OfisHal.Web.Models
{
    public class VoambAmbarTanimlari
    {
        public string Surum { get; set; }
        public int? DigFiyatKurusSayisi { get; set; }
        public bool? DigDokumNoBasinaSifir { get; set; }
        public int? DigMustahsilKodSiraNo { get; set; }
        public int? DigMusteriKodSiraNo { get; set; }
        public bool? DigCariKodBasinaSifir { get; set; }
        public bool? DigFaturaNoBasinaSifir { get; set; }
        public double? DigKasaDevri { get; set; }
        public string DigBelgeDizini { get; set; }
        public bool? DigBuyukHarfeCevir { get; set; }
        public double? SatDigerMalKdvOrani { get; set; }
        public double? SatYuklemeKdvOrani { get; set; }
        public bool? DigKasaDefterindeDevirVar { get; set; }
        public byte? DigKasaDevirSekli { get; set; }
        public int? DigTuccarKodSiraNo { get; set; }
        public string DigYedekKlasoru { get; set; }
    }
}