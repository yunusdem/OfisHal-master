using System;
using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class TohalFiyatListesi
    {
        public TohalFiyatListesi()
        {
            TohalCariKarts = new HashSet<TohalCariKart>();
            TohalFiyatListesiSatiris = new HashSet<TohalFiyatListesiSatiri>();
        }

        public int FiyatListesiId { get; set; }
        public string Aciklama { get; set; }
        public DateTime? Tarih { get; set; }
        public byte Tip { get; set; }

        public virtual ICollection<TohalCariKart> TohalCariKarts { get; set; }
        public virtual ICollection<TohalFiyatListesiSatiri> TohalFiyatListesiSatiris { get; set; }
    }
}