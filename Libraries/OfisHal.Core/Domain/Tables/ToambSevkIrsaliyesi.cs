using System;
using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class ToambSevkIrsaliyesi
    {
        public ToambSevkIrsaliyesi()
        {
            ToambSevkIrsaliyesiSatiris = new HashSet<ToambSevkIrsaliyesiSatiri>();
        }

        public int IrsaliyeId { get; set; }
        public int AmbarId { get; set; }
        public int? GeldigiYerId { get; set; }
        public string IrsaliyeNo { get; set; }
        public DateTime IrsaliyeTarihi { get; set; }
        public int? PlakaId { get; set; }
        public string Sofor { get; set; }
        public double? Havale { get; set; }
        public double Kesinti { get; set; }
        public string SoforNot { get; set; }
        public double ToplamTutar { get; set; }
        public double KdvOrani { get; set; }
        public double Kdv { get; set; }
        public double GenelToplam { get; set; }
        public bool? Odendi { get; set; }
        public bool? TutariDegistir { get; set; }
        public int? EkleyenId { get; set; }
        public int? GuncelleyenId { get; set; }
        public DateTime? EklemeZamani { get; set; }
        public DateTime? GuncellemeZamani { get; set; }

        public virtual TohalKullanici Ekleyen { get; set; }
        public virtual TohalTabloMaddesi GeldigiYer { get; set; }
        public virtual TohalKullanici Guncelleyen { get; set; }
        public virtual TohalTabloMaddesi Plaka { get; set; }
        public virtual ICollection<ToambSevkIrsaliyesiSatiri> ToambSevkIrsaliyesiSatiris { get; set; }
    }
}