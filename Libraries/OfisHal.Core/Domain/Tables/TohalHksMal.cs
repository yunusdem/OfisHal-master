using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class TohalHksMal
    {
        public TohalHksMal()
        {
            InverseUst = new HashSet<TohalHksMal>();
            TohalMalHksBagis = new HashSet<TohalMalHksBagi>();
        }

        public int HksMalId { get; set; }
        public int? UstId { get; set; }
        public byte Tur { get; set; }
        public string Ad { get; set; }
        public byte? UretimSekli { get; set; }
        public byte? Birim { get; set; }
        public int? HksId { get; set; }
        public string HksUrunKodu { get; set; }

        public virtual TohalHksMal Ust { get; set; }
        public virtual ICollection<TohalHksMal> InverseUst { get; set; }
        public virtual ICollection<TohalMalHksBagi> TohalMalHksBagis { get; set; }
    }
}