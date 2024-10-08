using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class ToambAmbarFiyati
    {
        public ToambAmbarFiyati()
        {
            ToambSevkIrsaliyesiSatiris = new HashSet<ToambSevkIrsaliyesiSatiri>();
        }

        public int AmbarFiyatiId { get; set; }
        public int AmbarId { get; set; }
        public int SatirNo { get; set; }
        public string Aciklama { get; set; }
        public double Muamele { get; set; }
        public double Hammaliye { get; set; }
        public double Navlun { get; set; }
        public int? GeldigiYerId { get; set; }
        public int? YazihaneId { get; set; }
        public int? GonderenId { get; set; }
        public int? MalGrupId { get; set; }
        public int? MalId { get; set; }
        public int? KapId { get; set; }
        public double? Prim { get; set; }
        public double? HammaliyePrimi { get; set; }
        public double? AmbarPrimi { get; set; }
        public int? PrimSahibiId { get; set; }

        public virtual TohalCariKart Ambar { get; set; }
        public virtual TohalTabloMaddesi GeldigiYer { get; set; }
        public virtual TohalCariKart Gonderen { get; set; }
        public virtual TohalKap Kap { get; set; }
        public virtual TohalMal Mal { get; set; }
        public virtual TohalTabloMaddesi MalGrup { get; set; }
        public virtual TohalCariKart Yazihane { get; set; }
        public virtual ICollection<ToambSevkIrsaliyesiSatiri> ToambSevkIrsaliyesiSatiris { get; set; }
    }
}