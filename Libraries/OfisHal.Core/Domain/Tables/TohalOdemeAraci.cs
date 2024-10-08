using System;
using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class TohalOdemeAraci
    {
        public TohalOdemeAraci()
        {
            TohalObSatiris = new HashSet<TohalObSatiri>();
        }

        public int OdemeAraciId { get; set; }
        public byte Tur { get; set; }
        public int? BankaId { get; set; }
        public string OdemeAraciNo { get; set; }
        public DateTime VadeTarihi { get; set; }
        public double Meblag { get; set; }
        public bool? BaskasinaAit { get; set; }
        public int? BankaHesabiId { get; set; }

        public virtual TohalTabloMaddesi Banka { get; set; }
        public virtual TohalBankaHesabi BankaHesabi { get; set; }
        public virtual ICollection<TohalObSatiri> TohalObSatiris { get; set; }
    }
}