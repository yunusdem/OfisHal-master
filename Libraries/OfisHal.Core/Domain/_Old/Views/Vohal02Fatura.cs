using System;

namespace OfisHal.Web.Models
{
    public class Vohal02Fatura
    {
        public int FaturaId { get; set; }
        public int Tip { get; set; }
        public bool? Kesildi { get; set; }
        public bool? Veresiye { get; set; }
        public DateTime Tarih { get; set; }
        public string FaturaNo { get; set; }
        public string Unvan { get; set; }
        public int EkleyenId { get; set; }
        public double NetMalTutari { get; set; }
        public int KapToplami { get; set; }
        public double KdvTutari { get; set; }
        public double IadesizKap { get; set; }
        public double Nakliye { get; set; }
        public double Yukleme { get; set; }
        public double FaturaToplami { get; set; }
        public double MasrafTutari { get; set; }
        public double KesintiTutari { get; set; }
        public double RehinTutari { get; set; }
        public double NakitTahsilat { get; set; }
        public double KrediKartiTahsilati { get; set; }
        public double Tahsilat { get; set; }
        public double MasrafKesintiDahilFaturaToplami { get; set; }
        public double? RehinDahilFaturaToplami { get; set; }
        public double? VeresiyeTutari { get; set; }
    }
}