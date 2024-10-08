using System;

namespace OfisHal.Web.Models
{
    public class TohalDevirAyarlari
    {
        public bool? MustahsilCari { get; set; }
        public bool? MusteriCari { get; set; }
        public bool? MustahsilKapCari { get; set; }
        public bool? MusteriKapCari { get; set; }
        public bool? CekSenet { get; set; }
        public bool? Banka { get; set; }
        public bool? KayitsizMusteri { get; set; }
        public bool? KalanDokum { get; set; }
        public bool? Magaza { get; set; }
        public byte? MusteriRehinIadeSekli { get; set; }
        public DateTime? DevirHareketTarihi { get; set; }
        public string HedefVeritabaniAdi { get; set; }
        public bool? FiyatListesi { get; set; }
    }
}