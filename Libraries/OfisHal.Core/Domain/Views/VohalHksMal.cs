namespace OfisHal.Core.Domain
{
    public class VohalHksMal
    {
        public int MalAdiId { get; set; }
        public string MalAdi { get; set; }
        public int? MalAdiHksId { get; set; }
        public int? MalCinsiHksId { get; set; }
        public int? MalCinsiId { get; set; }
        public string MalCinsi { get; set; }
        public byte? UretimSekli { get; set; }
        public string UretimSekliAciklamasi { get; set; }
    }
}