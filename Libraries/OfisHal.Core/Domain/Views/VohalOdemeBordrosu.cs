

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalOdemeBordrosu
    {
        public int OdemeBordrosuId { get; set; }
        public int? KartTipi { get; set; }
        public int? CariKartId { get; set; }
        public string Kod { get; set; }
        public string Ad { get; set; }
        public byte IslemTuru { get; set; }
        public string BordroNo { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
        public bool? Devir { get; set; }
        public int? BankaHesabiId { get; set; }
        public string HesapNo { get; set; }
        public string HesapAdi { get; set; }
        public string SubeAdi { get; set; }
        public int? BankaId { get; set; }
        public string BankaAdi { get; set; }
        public string EkleyenKullaniciAdi { get; set; }
        public DateTime EklemeZamani { get; set; }
        public string GuncelleyenKullaniciAdi { get; set; }
        public DateTime GuncellemeZamani { get; set; }
    }
}