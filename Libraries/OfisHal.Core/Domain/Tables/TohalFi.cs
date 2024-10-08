using System;
using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class TohalFi
    {
        public TohalFi()
        {
            TohalFaturas = new HashSet<TohalFatura>();
            TohalFisSatiris = new HashSet<TohalFisSatiri>();
        }

        public int FisId { get; set; }
        public byte Tip { get; set; }
        public int? CariKartId { get; set; }
        public int? KayitsizMusteriId { get; set; }
        public string Unvan { get; set; }
        public string FisNo { get; set; }
        public DateTime Tarih { get; set; }
        public DateTime? OdemeTarihi { get; set; }
        public string Aciklama { get; set; }
        public int KullaniciId { get; set; }
        public DateTime GuncellemeZamani { get; set; }

        public virtual TohalCariKart CariKart { get; set; }
        public virtual TohalKayitsizMusteri KayitsizMusteri { get; set; }
        public virtual TohalKullanici Kullanici { get; set; }
        public virtual ICollection<TohalFatura> TohalFaturas { get; set; }
        public virtual ICollection<TohalFisSatiri> TohalFisSatiris { get; set; }
    }
}