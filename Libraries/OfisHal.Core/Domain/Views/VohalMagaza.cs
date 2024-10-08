namespace OfisHal.Core.Domain
{
    public class VohalMagaza
    {
        public int MagazaId { get; set; }
        public int CariKartId { get; set; }
        public string Kod { get; set; }
        public string Ad { get; set; }
        public string Adres { get; set; }
        public int? PostaKoduId { get; set; }
        public string PostaKodu { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Faks { get; set; }
        public byte? GidecegiYer { get; set; }
        public byte? CariSifati { get; set; }
        public bool? EnCokKullanilan { get; set; }
        public string PlakaNo { get; set; }
        public int? GidecegiYerWebSiraNo { get; set; }
        public int? BeldeId { get; set; }
        public int? BeldeHksId { get; set; }
        public string BeldeAdi { get; set; }
        public int? IlceId { get; set; }
        public int? IlceHksId { get; set; }
        public string IlceAdi { get; set; }
        public int? IlId { get; set; }
        public string IlAdi { get; set; }
        public int? IlHksId { get; set; }
        public int? HksId { get; set; }
        public int? EIrsaliyePostaKutusuId { get; set; }
        public string EIrsaliyePostaKutusu { get; set; }
        public string EFaturaBolgeKodu { get; set; }
    }
}