

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalKonyaHalSatisBildirimi
    {
        public string DigMudurlukKulAdi { get; set; }
        public string DigMudurlukKulSifresi { get; set; }
        public string HalId { get; set; }
        public string MalSahibi { get; set; }
        public string MalSahibiVergiNo { get; set; }
        public int FaturaId { get; set; }
        public string FaturaNo { get; set; }
        public DateTime GirisTarihi { get; set; }
        public string PlakaNo { get; set; }
        public string VergiKimlikNo { get; set; }
        public DateTime? SatisSaati { get; set; }
        public string UrunAdi { get; set; }
        public string KunyeNo { get; set; }
        public int SatirNo { get; set; }
        public int? HksMalId { get; set; }
        public string HksMalAdi { get; set; }
        public int? HksMalCinsiId { get; set; }
        public string HksMalCinsiAdi { get; set; }
        public byte? UretimSekli { get; set; }
        public int UretimSekliId { get; set; }
        public string UretimSekliAciklamasi { get; set; }
        public double MalMiktari { get; set; }
        public int? BirimId { get; set; }
        public byte? Birim { get; set; }
        public double Fiyat { get; set; }
        public double ToplamStokMiktari { get; set; }
        public int BildirimDurumu { get; set; }
        public double GunGirisMiktari { get; set; }
        public double GunCikisMiktari { get; set; }
        public string DonenAlanDegeri { get; set; }
    }
}