using System;

namespace OfisHal.Core.Domain
{
    public class TohalBankaHareketi
    {
        public int BankaHareketiId { get; set; }
        public int? BankaHesabiId { get; set; }
        public DateTime Tarih { get; set; }
        public byte IslemTipi { get; set; }
        public string Aciklama { get; set; }
        public double Meblag { get; set; }
        public int? CariKartId { get; set; }
        public int EkleyenId { get; set; }
        public DateTime EklemeZamani { get; set; }
        public int? GuncelleyenId { get; set; }
        public DateTime GuncellemeZamani { get; set; }
        public int? HesapId { get; set; }
        public int? KarsiBankaHesabiId { get; set; }
        public int? PosCihaziId { get; set; }

        public virtual TohalBankaHesabi BankaHesabi { get; set; }
        public virtual TohalCariKart CariKart { get; set; }
        public virtual TohalKullanici Ekleyen { get; set; }
        public virtual TohalKullanici Guncelleyen { get; set; }
        public virtual TohalHesap Hesap { get; set; }
        public virtual TohalBankaHesabi KarsiBankaHesabi { get; set; }
        public virtual TohalPosCihazi PosCihazi { get; set; }
    }
}