using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class TohalKdvTevkifatTanimi
    {
        public TohalKdvTevkifatTanimi()
        {
            TohalFaturaSatiris = new HashSet<TohalFaturaSatiri>();
            TohalMals = new HashSet<TohalMal>();
            TohalNavlunFaturasis = new HashSet<TohalNavlunFaturasi>();
        }

        public int KdvTevkifatTanimiId { get; set; }
        public string Aciklama { get; set; }
        public int Pay { get; set; }
        public int Payda { get; set; }
        public string Kod { get; set; }
        public double UygulamaAltSiniri { get; set; }

        public virtual ICollection<TohalFaturaSatiri> TohalFaturaSatiris { get; set; }
        public virtual ICollection<TohalMal> TohalMals { get; set; }
        public virtual ICollection<TohalNavlunFaturasi> TohalNavlunFaturasis { get; set; }
    }
}