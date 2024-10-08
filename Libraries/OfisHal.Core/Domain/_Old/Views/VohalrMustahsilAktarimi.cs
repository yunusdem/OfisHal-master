

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrMustahsilAktarimi
    {
        public DateTime? Tarih { get; set; }
        public string Faturano { get; set; }
        public double Navlun { get; set; }
        public double NavlunKdvOrani { get; set; }
        public double NavlunKdv { get; set; }
        public double KomisyonOrani { get; set; }
        public double Komisyon { get; set; }
        public double KomisyonKdvOrani { get; set; }
        public double KomisyonKdv { get; set; }
        public double IadesizKapTutari { get; set; }
        public double IadesizKapKdvOrani { get; set; }
        public double IadesizKapKdv { get; set; }
        public double Miktar { get; set; }
        public double Fiyat { get; set; }
        public double Tutar { get; set; }
        public double KdvOrani { get; set; }
        public string Stokkodu { get; set; }
        public string Carikod { get; set; }
    }
}