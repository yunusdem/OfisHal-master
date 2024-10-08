using System;

namespace OfisHal.Web.Models
{
    public class VohalAntalyaHalSatisBildirimi
    {
        public int FaturaId { get; set; }
        public string CariAdi { get; set; }
        public string VergiKimlikNo { get; set; }
        public string FaturaNo { get; set; }
        public DateTime Tarih { get; set; }
        public string FaturaTipi { get; set; }
        public string BelgeNo { get; set; }
        public string IrsaliyeNo { get; set; }
        public string StokKunyeNo { get; set; }
        public int SatirNo { get; set; }
        public double IskontoOrani { get; set; }
        public double IskontoToplami { get; set; }
        public double Tutar { get; set; }
        public int? UrunHksId { get; set; }
        public string HksUrunKodu { get; set; }
        public string HksUrunAdi { get; set; }
        public int? UrunCinsiHksId { get; set; }
        public string UrunCinsiKodu { get; set; }
        public string UrunCinsiAdi { get; set; }
        public string UretimSekliKodu { get; set; }
        public string UretimSekliAdi { get; set; }
        public double Fiyat { get; set; }
        public double? MalMiktari { get; set; }
        public double RusumOrani { get; set; }
        public double Rusum { get; set; }
        public string SatisKunyeNo { get; set; }
        public double AraToplam { get; set; }
        public double KdvOrani { get; set; }
        public double KdvTutari { get; set; }
        public string BirimAdi { get; set; }
        public double Agirlik { get; set; }
        public string PlakaNo { get; set; }
        public string DonenAlanDegeri { get; set; }
        public byte BildirimDurumu { get; set; }
        public byte OnBildirimDurumu { get; set; }
        public string DigMudurlukKulAdi { get; set; }
        public string DigMudurlukKulSifresi { get; set; }
        public string DigYazihaneNo { get; set; }
        public string DigFirmaAdi { get; set; }
        public string DigVergiKimlikNo { get; set; }
    }
}