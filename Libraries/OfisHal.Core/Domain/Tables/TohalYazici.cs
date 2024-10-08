namespace OfisHal.Core.Domain
{
    public class TohalYazici
    {
        public int YaziciId { get; set; }
        public int SiraNo { get; set; }
        public string Ad { get; set; }
        public int? SatisFaturasiSiraNo { get; set; }
        public int? MustahsilFaturasiSiraNo { get; set; }
        public int? AmbarNavlunFaturasiSiraNo { get; set; }
        public byte BelgeYaziciModu { get; set; }
        public string BelgeDizini { get; set; }
        public int? KopyaSayisi { get; set; }
        public string CihazAdi { get; set; }
        public string BaglantiNoktasi { get; set; }
        public byte? PaperOrientation { get; set; }
        public byte? PaperSize { get; set; }
        public byte? SatFaturaBelgesi { get; set; }
    }
}