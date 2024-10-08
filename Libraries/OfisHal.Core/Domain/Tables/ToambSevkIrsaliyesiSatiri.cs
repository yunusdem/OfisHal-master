using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class ToambSevkIrsaliyesiSatiri
    {
        public ToambSevkIrsaliyesiSatiri()
        {
            ToambNavlunFaturaSatiris = new HashSet<ToambNavlunFaturaSatiri>();
        }

        public int IrsaliyeSatiriId { get; set; }
        public int IrsaliyeId { get; set; }
        public int SatirNo { get; set; }
        public int YazihaneId { get; set; }
        public int? GonderenId { get; set; }
        public int MalId { get; set; }
        public int? KapId { get; set; }
        public int Adet { get; set; }
        public int? AmbarFiyatiId { get; set; }
        public double MuameleBirimFiyat { get; set; }
        public double HammaliyeFiyati { get; set; }
        public double MuameleKdvOrani { get; set; }
        public double MuameleKdv { get; set; }
        public int? MuameleDizaynId { get; set; }
        public double Fiyat { get; set; }
        public double NavlunKdvOrani { get; set; }
        public double NavlunKdv { get; set; }
        public double Tutar { get; set; }
        public int? DizaynId { get; set; }
        public int? PrimSahibiId { get; set; }
        public double? AmbarPrimi { get; set; }
        public bool? MuameleDahil { get; set; }

        public virtual ToambAmbarFiyati AmbarFiyati { get; set; }
        public virtual ToambNavlunDizayni Dizayn { get; set; }
        public virtual TohalCariKart Gonderen { get; set; }
        public virtual ToambSevkIrsaliyesi Irsaliye { get; set; }
        public virtual TohalKap Kap { get; set; }
        public virtual TohalMal Mal { get; set; }
        public virtual ToambNavlunDizayni MuameleDizayn { get; set; }
        public virtual TohalCariKart PrimSahibi { get; set; }
        public virtual TohalCariKart Yazihane { get; set; }
        public virtual ICollection<ToambNavlunFaturaSatiri> ToambNavlunFaturaSatiris { get; set; }
    }
}