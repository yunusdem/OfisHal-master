namespace OfisHal.Core.Domain
{
    public class TohalSiparisSatiri
    {
        public int SiparisSatiriId { get; set; }
        public int SiparisId { get; set; }
        public int MalId { get; set; }
        public double Miktar { get; set; }
        public byte MalBirimi { get; set; }

        public virtual TohalMal Mal { get; set; }
        public virtual TohalSipari Siparis { get; set; }
    }
}