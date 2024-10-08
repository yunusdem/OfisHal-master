using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class TohalMarka
    {
        public TohalMarka()
        {
            TohalCariKarts = new HashSet<TohalCariKart>();
            TohalFaturaSatiris = new HashSet<TohalFaturaSatiri>();
            TohalFisSatiris = new HashSet<TohalFisSatiri>();
            TohalMakbuzs = new HashSet<TohalMakbuz>();
            TohalRehinFisis = new HashSet<TohalRehinFisi>();
            TohalSiparis = new HashSet<TohalSipari>();
        }

        public int MarkaId { get; set; }
        public string Ad { get; set; }
        public bool? Kapandi { get; set; }

        public virtual ICollection<TohalCariKart> TohalCariKarts { get; set; }
        public virtual ICollection<TohalFaturaSatiri> TohalFaturaSatiris { get; set; }
        public virtual ICollection<TohalFisSatiri> TohalFisSatiris { get; set; }
        public virtual ICollection<TohalMakbuz> TohalMakbuzs { get; set; }
        public virtual ICollection<TohalRehinFisi> TohalRehinFisis { get; set; }
        public virtual ICollection<TohalSipari> TohalSiparis { get; set; }
    }
}