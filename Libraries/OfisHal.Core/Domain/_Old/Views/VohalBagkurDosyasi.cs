namespace OfisHal.Web.Models
{
    public class VohalBagkurDosyasi
    {
        public int DosyaId { get; set; }
        public string DosyaNo { get; set; }
        public bool? Muhasebelesti { get; set; }
        public double? ToplamMalTutari { get; set; }
        public double? ToplamBagkur { get; set; }
    }
}