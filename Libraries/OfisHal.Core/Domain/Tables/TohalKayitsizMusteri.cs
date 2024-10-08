using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class TohalKayitsizMusteri
    {
        public TohalKayitsizMusteri()
        {
            TohalFis = new HashSet<TohalFi>();
        }

        public int KayitsizMusteriId { get; set; }
        public string Unvan { get; set; }
        public string VergiKimlikNo { get; set; }
        public int? VergiDairesiId { get; set; }
        public int? SehirId { get; set; }
        public string Adres { get; set; }
        public byte KisilikTipi { get; set; }
        public bool? Ihracatci { get; set; }
        public string PlakaNo { get; set; }
        public string GsmNo { get; set; }
        public string EPosta { get; set; }
        public byte? GidecegiYerTipi { get; set; }
        public int? YerId { get; set; }
        public int? GidecegiYerWebSiraNo { get; set; }
        public byte? Sifati { get; set; }
        public byte? BildirimTuru { get; set; }
        public byte? CariSifati { get; set; }
        public int? HalId { get; set; }
        public bool? Komisyoncu { get; set; }
        public int? HksId { get; set; }
        public bool? HksBilgisiAlindi { get; set; }

        public virtual TohalHal Hal { get; set; }
        public virtual TohalTabloMaddesi Sehir { get; set; }
        public virtual TohalTabloMaddesi VergiDairesi { get; set; }
        public virtual TohalYer Yer { get; set; }
        public virtual ICollection<TohalFi> TohalFis { get; set; }
    }
}