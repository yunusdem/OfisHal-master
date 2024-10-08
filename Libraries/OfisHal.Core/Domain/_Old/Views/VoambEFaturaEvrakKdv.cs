namespace OfisHal.Web.Models
{
    public class VoambEFaturaEvrakKdv
    {
        public int FaturaId { get; set; }
        public int? MakbuzId { get; set; }
        public double Oran { get; set; }
        public double? Matrah { get; set; }
        public double? Kdv { get; set; }
        public string Kod { get; set; }
    }
}