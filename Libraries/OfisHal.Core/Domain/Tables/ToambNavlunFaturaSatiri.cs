namespace OfisHal.Core.Domain
{
    public class ToambNavlunFaturaSatiri
    {
        public int NavlunFaturaSatiriId { get; set; }
        public int NavlunFaturasiId { get; set; }
        public int SatirNo { get; set; }
        public int? GeldigiYerId { get; set; }
        public int? GonderenId { get; set; }
        public int MalId { get; set; }
        public int? KapId { get; set; }
        public int Adet { get; set; }
        public double MuameleFiyati { get; set; }
        public double MuameleKdvOrani { get; set; }
        public double MuameleKdv { get; set; }
        public double MuameleTutar { get; set; }
        public double NavlunFiyati { get; set; }
        public double NavlunKdvOrani { get; set; }
        public double NavlunKdv { get; set; }
        public double NavlunTutar { get; set; }
        public int? IrsaliyeSatiriId { get; set; }

        public virtual TohalTabloMaddesi GeldigiYer { get; set; }
        public virtual TohalCariKart Gonderen { get; set; }
        public virtual ToambSevkIrsaliyesiSatiri IrsaliyeSatiri { get; set; }
        public virtual TohalKap Kap { get; set; }
        public virtual TohalMal Mal { get; set; }
        public virtual ToambNavlunFaturasi NavlunFaturasi { get; set; }
    }
}