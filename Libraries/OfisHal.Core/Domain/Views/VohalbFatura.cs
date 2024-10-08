using System;

namespace OfisHal.Core.Domain
{
    public class VohalbFatura
    {
        public int FaturaId { get; set; }
        public string Guid { get; set; }
        public int? CariKartId { get; set; }
        public string CariKod { get; set; }
        public string CariUnvan { get; set; }
        public string ReferansNo { get; set; }
        public string FaturaNo { get; set; }
        public int Tip { get; set; }
        public DateTime Tarih { get; set; }
        public int? Vade { get; set; }
        public string Unvan { get; set; }
        public int? MagazaId { get; set; }
        public string MagazaKodu { get; set; }
        public int? SehirId { get; set; }
        public string SehirAdi { get; set; }
        public string Adres { get; set; }
        public byte KisilikTipi { get; set; }
        public int? VergiDairesiId { get; set; }
        public string VergiDairesi { get; set; }
        public string VergiKimlikNo { get; set; }
        public string IrsaliyeNo { get; set; }
        public DateTime IrsaliyeZamani { get; set; }
        public int? SiparisId { get; set; }
        public string SiparisNo { get; set; }
        public int OdemeSekli { get; set; }
        public double Rusum { get; set; }
        public double RusumKdvOrani { get; set; }
        public double RusumKdv { get; set; }
        public double IskontoOrani { get; set; }
        public double? Iskonto { get; set; }
        public double KdvsizIadesizKap { get; set; }
        public double KdvliIadesizKap { get; set; }
        public double IadesizKapKdvOrani { get; set; }
        public double IadesizKapKdv { get; set; }
        public byte RehinIadeliKap { get; set; }
        public double Yukleme { get; set; }
        public double YuklemeKdvOrani { get; set; }
        public double YuklemeKdv { get; set; }
        public double Nakliye { get; set; }
        public double NakliyeKdvOrani { get; set; }
        public double NakliyeKdv { get; set; }
        public bool? Kesildi { get; set; }
        public bool? Veresiye { get; set; }
        public double VeresiyeTahsilEdilen { get; set; }
        public bool? Degistirildi { get; set; }
        public int? IadeEdilenKapSayisi { get; set; }
        public bool? RehinDevri { get; set; }
        public int EkleyenId { get; set; }
        public string EkleyenKullaniciAdi { get; set; }
        public DateTime EklemeZamani { get; set; }
        public string GuncelleyenKullaniciAdi { get; set; }
        public DateTime GuncellemeZamani { get; set; }
        public string GuncellemeZamaniString { get; set; }
    }
}