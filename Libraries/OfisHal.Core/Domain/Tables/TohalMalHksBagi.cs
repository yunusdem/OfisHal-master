namespace OfisHal.Core.Domain
{
    public class TohalMalHksBagi
    {
        public int MalId { get; set; }
        public int HksMalId { get; set; }
        public int SiraNo { get; set; }

        public virtual TohalHksMal HksMal { get; set; }
        public virtual TohalMal Mal { get; set; }
    }
}