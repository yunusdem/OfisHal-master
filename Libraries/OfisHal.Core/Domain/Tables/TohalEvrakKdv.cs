using OfisHal.Core.Domain;

namespace OfisHal.Core.Domain
{
    public class TohalEvrakKdv
    {
        public int? FaturaId { get; set; }
        public int? MakbuzId { get; set; }
        public double Oran { get; set; }
        public int? SevkIrsaliyesiId { get; set; }
        public int? NavlunFaturasiId { get; set; }
        public double Matrah { get; set; }
        public double Kdv { get; set; }
        public int? KdvTevkifatTanimiId { get; set; }
        public int KdvTevkifatPayi { get; set; }
        public int KdvTevkifatPaydasi { get; set; }
        public double KdvTahakkuku { get; set; }
        public double KdvTevkifati { get; set; }

        public virtual TohalFatura Fatura { get; set; }
        public virtual TohalMakbuz Makbuz { get; set; }
        public virtual ToambNavlunFaturasi NavlunFaturasi { get; set; }
        public virtual ToambSevkIrsaliyesi SevkIrsaliyesi { get; set; }
    }
}