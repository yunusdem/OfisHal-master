using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class TohalMagaza
    {
        public TohalMagaza()
        {
            TohalFaturas = new HashSet<TohalFatura>();
        }

        public int MagazaId { get; set; }
        public int CariKartId { get; set; }
        public string Kod { get; set; }
        public int? YerId { get; set; }
        public string Ad { get; set; }
        public string Adres { get; set; }
        public int? SehirId { get; set; }
        public int? PostaKoduId { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Faks { get; set; }
        public byte? GidecegiYer { get; set; }
        public int? GidecegiYerWebSiraNo { get; set; }
        public int? HksId { get; set; }
        public byte? CariSifati { get; set; }
        public bool? EnCokKullanilan { get; set; }
        public string PlakaNo { get; set; }
        public int? EIrsaliyePostaKutusuId { get; set; }
        public string EFaturaBolgeKodu { get; set; }

        public virtual TohalCariKart CariKart { get; set; }
        public virtual TohalGibKullanici EIrsaliyePostaKutusu { get; set; }
        public virtual TohalTabloMaddesi PostaKodu { get; set; }
        public virtual TohalTabloMaddesi Sehir { get; set; }
        public virtual TohalYer Yer { get; set; }
        public virtual ICollection<TohalFatura> TohalFaturas { get; set; }
    }
}