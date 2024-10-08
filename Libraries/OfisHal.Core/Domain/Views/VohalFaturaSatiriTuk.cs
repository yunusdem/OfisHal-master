using System;

namespace OfisHal.Core.Domain
{
    public class VohalFaturaSatiriTuk
    {
        public int FaturaSatiriId { get; set; }
        public string Guid { get; set; }
        public int FaturaId { get; set; }
        public int Tip { get; set; }
        public DateTime FaturaTarihi { get; set; }
        public int SatirNo { get; set; }
        public byte? SatisTipi { get; set; }
        public int MarkaId { get; set; }
        public string Marka { get; set; }
        public int? CariKartId { get; set; }
        public string CariAdi { get; set; }
        public byte KisilikTipi { get; set; }
        public string MustahsilAdiVkn { get; set; }
        public int MalId { get; set; }
        public string MalKodu { get; set; }
        public string MalAdi { get; set; }
        public string DigerMalAdi { get; set; }
        public int? KapId { get; set; }
        public string KapKodu { get; set; }
        public string KapAdi { get; set; }
        public bool? IadeliKap { get; set; }
        public int KapMiktari { get; set; }
        public double? KapFiyati { get; set; }
        public double? BirimDara { get; set; }
        public double Darali { get; set; }
        public double Dara { get; set; }
        public double MalMiktari { get; set; }
        public double MalKapFiyati { get; set; }
        public double MalFiyati { get; set; }
        public bool? TutarHesaplanmasin { get; set; }
        public double Tutar { get; set; }
        public double? MalKdvOrani { get; set; }
        public double KdvOrani { get; set; }
        public string Aciklama { get; set; }
        public int? RehinKabiId { get; set; }
        public string RehinKabiKodu { get; set; }
        public string RehinKabiAdi { get; set; }
        public double? CiroPrimi { get; set; }
        public double RusumOrani { get; set; }
        public double Rusum { get; set; }
        public int? StokKunyeId { get; set; }
        public string StokKunyesi { get; set; }
        public double? StokKunyesiFiyati { get; set; }
        public int? SatisKunyeId { get; set; }
        public string SatisKunyesi { get; set; }
        public bool HalKomisyoncusu { get; set; }
        public bool RusumAlinmasin { get; set; }
        public byte? UretimSekli { get; set; }
        public bool? RusumHesaplanmasin { get; set; }
        public double IskontoOrani { get; set; }
        public double Iskonto { get; set; }
        public bool? IskontoHesaplanmasin { get; set; }
        public double IskontoPayi { get; set; }
        public double Yukleme { get; set; }
        public int? AlisFatSatId { get; set; }
        public string MalBirimi { get; set; }
        public string EFaturaUneceKisaltma { get; set; }
        public int? FisSatiriId { get; set; }
        public int? StokKunyeSayisi { get; set; }
        public int? SatisKunyeSayisi { get; set; }
        public double? KunyeMiktari { get; set; }
        public int? FiyatListesiId { get; set; }
        public double? KapIcindekiMalMiktari { get; set; }
        public string GtipNo { get; set; }
        public string AmbalajTipiKodu { get; set; }
        public string AmbalajMarkasi { get; set; }
        public int? MalHksId { get; set; }
        public int? KdvTevkifatTanimiId { get; set; }
        public string KdvTevkifatTanimiAciklamasi { get; set; }
        public int? KdvTevkifatPayi { get; set; }
        public int? KdvTevkifatPaydasi { get; set; }
        public double? KdvTevkifatUygulamaAltSiniri { get; set; }
        public int? MalKdvTevkifatTanimiId { get; set; }
        public double? MalOrtalamaKilo { get; set; }
    }
}