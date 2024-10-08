using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class TohalBankaHesabi
    {
        public TohalBankaHesabi()
        {
            TohalBankaHareketiBankaHesabis = new HashSet<TohalBankaHareketi>();
            TohalBankaHareketiKarsiBankaHesabis = new HashSet<TohalBankaHareketi>();
            TohalOdemeAracis = new HashSet<TohalOdemeAraci>();
            TohalOdemeBordrosus = new HashSet<TohalOdemeBordrosu>();
            TohalPosCihazis = new HashSet<TohalPosCihazi>();
        }

        public int BankaHesabiId { get; set; }
        public string HesapNo { get; set; }
        public string HesapAdi { get; set; }
        public string Iban { get; set; }
        public string SubeAdi { get; set; }
        public int BankaId { get; set; }
        public double Devir { get; set; }
        public int? MuhHesapId { get; set; }
        public bool? EFaturadaGozuksun { get; set; }

        public virtual TohalTabloMaddesi Banka { get; set; }
        public virtual TohalMuhHesap MuhHesap { get; set; }
        public virtual ICollection<TohalBankaHareketi> TohalBankaHareketiBankaHesabis { get; set; }
        public virtual ICollection<TohalBankaHareketi> TohalBankaHareketiKarsiBankaHesabis { get; set; }
        public virtual ICollection<TohalOdemeAraci> TohalOdemeAracis { get; set; }
        public virtual ICollection<TohalOdemeBordrosu> TohalOdemeBordrosus { get; set; }
        public virtual ICollection<TohalPosCihazi> TohalPosCihazis { get; set; }
    }
}