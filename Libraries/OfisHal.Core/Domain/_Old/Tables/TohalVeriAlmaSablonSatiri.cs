namespace OfisHal.Web.Models
{
    public class TohalVeriAlmaSablonSatiri
    {
        public int SablonId { get; set; }
        public int KaynakKolonNo { get; set; }
        public byte HedefAlanTipi { get; set; }

        public virtual TohalTabloMaddesi Sablon { get; set; }
    }
}