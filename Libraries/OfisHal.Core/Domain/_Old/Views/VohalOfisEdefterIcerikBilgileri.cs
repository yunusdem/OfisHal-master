

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalOfisEdefterIcerikBilgileri
    {
        public string YevmiyeNo { get; set; }
        public DateTime KayitTarihi { get; set; }
        public string MuhFisNo { get; set; }
        public string Hakkinda { get; set; }
        public int? SubeId { get; set; }
        public int? SubeAdi { get; set; }
        public double? BorcToplami { get; set; }
        public double? AlacakToplami { get; set; }
        public string AnaHesapKodu { get; set; }
        public string AnaHesapAdi { get; set; }
        public string AltHesapAdi { get; set; }
        public double Meblag { get; set; }
        public string DebitCreditCode { get; set; }
        public DateTime MuhFisTarih { get; set; }
        public string Aciklama { get; set; }
        public int MuhFisId { get; set; }
        public int AnaHesapId { get; set; }
        public string AltHesapKodu { get; set; }
        public int? YevmiyeSatirNo { get; set; }
        public string DokumanTipi { get; set; }
        public string DokumanNo { get; set; }
        public string OdemeSekli { get; set; }
        public DateTime? DokumanTarihi { get; set; }
        public string DokumanAdi { get; set; }
        public string FirmaVkn { get; set; }
    }
}