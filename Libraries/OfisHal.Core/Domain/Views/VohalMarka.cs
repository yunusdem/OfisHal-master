namespace OfisHal.Core.Domain
{
    public class VohalMarka
    {
        public int MarkaId { get; set; }
        public string Marka { get; set; }
        public int? CariKartId { get; set; }
        public string Kod { get; set; }
        public string Ad { get; set; }
        public string VergiKimlikNo { get; set; }
        public byte? KisilikTipi { get; set; }
        public bool? RusumAlinmasin { get; set; }
        public bool? HalKomisyoncusu { get; set; }
        public bool Kapandi { get; set; }
    }
}