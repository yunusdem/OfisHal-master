using OfisHal.Core.Domain;

namespace OfisHal.Core.Domain
{
    public class TohalEvrakMasrafi
    {
        public int? MakbuzId { get; set; }
        public int? FaturaId { get; set; }
        public int HesapId { get; set; }
        public int? SiparisId { get; set; }
        public int? IrsaliyeId { get; set; }
        public int SatirNo { get; set; }
        public double Masraf { get; set; }
        public double KdvOrani { get; set; }
        public double Kdv { get; set; }
        public byte Muhatap { get; set; }
        public int? KapId { get; set; }
        public int? KapSayisi { get; set; }
        public double? KapFiyati { get; set; }
        public double? KesintiOrani { get; set; }

        public virtual TohalFatura Fatura { get; set; }
        public virtual TohalHesap Hesap { get; set; }
        public virtual ToambSevkIrsaliyesi Irsaliye { get; set; }
        public virtual TohalKap Kap { get; set; }
        public virtual TohalMakbuz Makbuz { get; set; }
        public virtual TohalSipari Siparis { get; set; }
    }
}