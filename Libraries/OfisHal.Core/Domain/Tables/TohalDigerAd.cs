using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class TohalDigerAd
    {
        public TohalDigerAd()
        {
            TohalKaps = new HashSet<TohalKap>();
            TohalMals = new HashSet<TohalMal>();
        }

        public int DigerAdId { get; set; }
        public byte Tur { get; set; }
        public int? UzakSistemId { get; set; }
        public string Ad { get; set; }

        public virtual ICollection<TohalKap> TohalKaps { get; set; }
        public virtual ICollection<TohalMal> TohalMals { get; set; }
    }
}