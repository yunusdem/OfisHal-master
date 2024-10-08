

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalrFaturaDegisiklikTakip
    {
        public DateTime Zaman { get; set; }
        public int KullaniciId { get; set; }
        public string KullaniciAdi { get; set; }
        public byte Islem { get; set; }
        public byte? OTip { get; set; }
        public byte? STip { get; set; }
        public int ReferansNo { get; set; }
        public string OCariKodu { get; set; }
        public string SCariKodu { get; set; }
        public string OCariAd { get; set; }
        public string SCariAd { get; set; }
        public DateTime? OTarih { get; set; }
        public DateTime? STarih { get; set; }
        public string OFaturaNo { get; set; }
        public string SFaturaNo { get; set; }
        public string OIrsaliyeNo { get; set; }
        public string SIrsaliyeNo { get; set; }
        public string OUnvan { get; set; }
        public string SUnvan { get; set; }
        public double? ORusum { get; set; }
        public double? SRusum { get; set; }
        public double? OIskontoOrani { get; set; }
        public double? SIskontoOrani { get; set; }
        public double? ORusumKdvOrani { get; set; }
        public double? SRusumKdvOrani { get; set; }
        public double? OIskonto { get; set; }
        public double? SIskonto { get; set; }
        public double? ORusumKdv { get; set; }
        public double? SRusumKdv { get; set; }
        public double? OKdvsizIadesizKap { get; set; }
        public double? SKdvsizIadesizKap { get; set; }
        public double? OKdvliIadesizKap { get; set; }
        public double? SKdvliIadesizKap { get; set; }
        public double? OIadesizKapKdvOrani { get; set; }
        public double? SIadesizKapKdvOrani { get; set; }
        public double? OIadesizKapKdv { get; set; }
        public double? SIadesizKapKdv { get; set; }
        public double? OYukleme { get; set; }
        public double? SYukleme { get; set; }
        public byte? ORehinIadeliKap { get; set; }
        public byte? SRehinIadeliKap { get; set; }
        public double? OYuklemeKdvOrani { get; set; }
        public double? SYuklemeKdvOrani { get; set; }
        public double? OYuklemeKdv { get; set; }
        public double? SYuklemeKdv { get; set; }
        public double? ONakliye { get; set; }
        public double? SNakliye { get; set; }
        public double? ONakliyeKdvOrani { get; set; }
        public double? SNakliyeKdvOrani { get; set; }
        public double? ONakliyeKdv { get; set; }
        public double? SNakliyeKdv { get; set; }
        public bool? OKesildi { get; set; }
        public bool? SKesildi { get; set; }
        public int? OVade { get; set; }
        public int? SVade { get; set; }
        public bool? ODegistirildi { get; set; }
        public bool? SDegistirildi { get; set; }
        public int? OMagazaId { get; set; }
        public int? SMagazaId { get; set; }
        public DateTime? OIrsaliyeZamani { get; set; }
        public DateTime? SIrsaliyeZamani { get; set; }
        public int? OSiparisId { get; set; }
        public int? SSiparisId { get; set; }
        public string OSiparisNo { get; set; }
        public string SSiparisNo { get; set; }
        public bool? OIhracatci { get; set; }
        public bool? SIhracatci { get; set; }
        public string OPlakaNo { get; set; }
        public string SPlakaNo { get; set; }
        public byte? ORusumKdvIliskisi { get; set; }
        public byte? SRusumKdvIliskisi { get; set; }
        public int? DegisenSatirSayisi { get; set; }
        public int? TlKurusSayisi { get; set; }
        public bool? OVeresiye { get; set; }
        public bool? SVeresiye { get; set; }
        public double? ONakitTahsilat { get; set; }
        public double? SNakitTahsilat { get; set; }
        public double? OKrediKartiTahsilati { get; set; }
        public double? SKrediKartiTahsilati { get; set; }
        public string OPosCihazi { get; set; }
        public string SPosCihazi { get; set; }
        public int? DegisnRehinSayisi { get; set; }
        public int? DegisnMasrafSayisi { get; set; }
        public string SatHamaliyeAdlandirma { get; set; }
        public string SatNakliyeAdlandirma { get; set; }
    }
}