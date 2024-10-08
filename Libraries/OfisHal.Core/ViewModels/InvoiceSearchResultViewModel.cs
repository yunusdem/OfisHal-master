using System;

namespace OfisHal.Core.ViewModels
{
    public class InvoiceSearchResultViewModel
    {
        public int Id { get; set; }

        public int? CariKartId {  get; set; }

        public string No { get; set; }

        public string Url {  get; set; }

        public DateTime Tarih { get; set; }

        public string Unvan {  get; set; }

        public double? ToplamTutar { get; set; }

        public int? BelgeTuru { get; set; }

        public string BelgeTuruS => TurBul(BelgeTuru);
         
        public byte Durum {  get; set; }

        public string HataAciklamasi {  get; set; }

        private string TurBul(int? belgeTuru)
        {
            if (belgeTuru == 1)
                return "e-Arşiv";
            else if (belgeTuru == 0)
                return "e-Fatura";
            else if (!belgeTuru.HasValue)
                return string.Empty;
            else
                return "tanımsız";
        }
    }
}
