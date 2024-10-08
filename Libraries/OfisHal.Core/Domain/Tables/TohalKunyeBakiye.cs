using System;
using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class TohalKunyeBakiye
    {
        public TohalKunyeBakiye()
        {
  
        }
        public int MARKA_ID { get; set; }
        public string MARKA { get; set; }
        public int? URETICI_ID { get; set; }
        public string URETICI_ADI { get; set; }
        public int MAL_ID { get; set; }
        public string MAL_KODU { get; set; }
        public string MAL_ADI { get; set; }
        public DateTime? KUNYE_ZAMANI { get; set; }
        public int? KUNYE_ID { get; set; }
        public string KUNYE { get; set; }
        public double KAP_BAKIYE { get; set; }
        public double MIKTAR_BAKIYE { get; set; }
        public double MALIN_MIKTARI { get; set; }
        public double FIYAT { get; set; }
        public int SATIS_TIPI { get; set; }
        public int? ALIS_FATURA_SATIRI_I { get; set; }
        public string PLAKA_NO { get; set; }
        public string TESLIMAT_YERI { get; set; }
        public int? SIFAT { get; set; }
        public string HKS_MAL_ADI { get; set; }
        public int? SECILDI { get; set; }
    }
}