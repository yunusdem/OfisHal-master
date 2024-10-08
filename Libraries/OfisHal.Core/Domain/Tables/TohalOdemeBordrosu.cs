using System;
using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class TohalOdemeBordrosu
    {
        public TohalOdemeBordrosu()
        {
            TohalObSatiriOdemeBordrosus = new HashSet<TohalObSatiri>();
            TohalObSatiriSonrakiBordroes = new HashSet<TohalObSatiri>();
        }

        public int OdemeBordrosuId { get; set; }
        public int? CariKartId { get; set; }
        public byte IslemTuru { get; set; }
        public string BordroNo { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
        public int EkleyenId { get; set; }
        public bool? Devir { get; set; }
        public DateTime EklemeZamani { get; set; }
        public int GuncelleyenId { get; set; }
        public DateTime GuncellemeZamani { get; set; }
        public int? BankaHesabiId { get; set; }

        public virtual TohalBankaHesabi BankaHesabi { get; set; }
        public virtual TohalCariKart CariKart { get; set; }
        public virtual TohalKullanici Ekleyen { get; set; }
        public virtual TohalKullanici Guncelleyen { get; set; }
        public virtual ICollection<TohalObSatiri> TohalObSatiriOdemeBordrosus { get; set; }
        public virtual ICollection<TohalObSatiri> TohalObSatiriSonrakiBordroes { get; set; }
    }
}