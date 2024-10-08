using System;
using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class TohalSipari
    {
        public TohalSipari()
        {
            TohalFaturas = new HashSet<TohalFatura>();
            TohalSiparisSatiris = new HashSet<TohalSiparisSatiri>();
        }

        public int SiparisId { get; set; }
        public string SiparisNo { get; set; }
        public DateTime? SiparisTarihi { get; set; }
        public string Aciklama { get; set; }
        public int? MusteriCariKartId { get; set; }
        public int? MarkaId { get; set; }
        public bool? Kapandi { get; set; }

        public virtual TohalMarka Marka { get; set; }
        public virtual TohalCariKart MusteriCariKart { get; set; }
        public virtual ICollection<TohalFatura> TohalFaturas { get; set; }
        public virtual ICollection<TohalSiparisSatiri> TohalSiparisSatiris { get; set; }
    }
}