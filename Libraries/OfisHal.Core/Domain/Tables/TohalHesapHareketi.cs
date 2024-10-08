using System;
using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class TohalHesapHareketi
    {
        public TohalHesapHareketi()
        {
            TohalNavlunFaturasis = new HashSet<TohalNavlunFaturasi>();
        }

        public int HesapHareketiId { get; set; }
        public int HesapId { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
        public byte Tip { get; set; }
        public double Meblag { get; set; }
        public double KdvOrani { get; set; }
        public double Kdv { get; set; }
        public int EkleyenId { get; set; }
        public DateTime EklemeZamani { get; set; }
        public int GuncelleyenId { get; set; }
        public DateTime GuncellemeZamani { get; set; }
        public byte HareketTipi { get; set; }

        public virtual TohalKullanici Ekleyen { get; set; }
        public virtual TohalKullanici Guncelleyen { get; set; }
        public virtual TohalHesap Hesap { get; set; }
        public virtual ICollection<TohalNavlunFaturasi> TohalNavlunFaturasis { get; set; }
    }
}