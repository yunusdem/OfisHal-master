using System;

namespace OfisHal.Core.Domain
{
    public class TohalKapHareket
    {
        public int KapHareketId { get; set; }
        public int? CariKartId { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
        public int KapId { get; set; }
        public byte Tip { get; set; }
        public int Miktar { get; set; }
        public double Fiyat { get; set; }
        public double Tutar { get; set; }
        public int? RehinFisiId { get; set; }
        public byte? IslenecegiHesap { get; set; }
        public int EkleyenId { get; set; }
        public DateTime EklemeZamani { get; set; }
        public int GuncelleyenId { get; set; }
        public DateTime GuncellemeZamani { get; set; }

        public virtual TohalCariKart CariKart { get; set; }
        public virtual TohalKullanici Ekleyen { get; set; }
        public virtual TohalKullanici Guncelleyen { get; set; }
        public virtual TohalKap Kap { get; set; }
        public virtual TohalRehinFisi RehinFisi { get; set; }
    }
}