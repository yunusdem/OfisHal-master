

using System;
using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class VohalSatisTanimlari
    {
        public double? SatIadesizKapKdvOrani { get; set; }
        public double? SatVerMukMalKdvOrani { get; set; }
        public double? SatDigerMalKdvOrani { get; set; }
        public double? SatYuklemeKdvOrani { get; set; }
        public double? SatNakliyeKdvOrani { get; set; }
        public double? SatRusumOrani { get; set; }
        public byte? SatKiloOkumaSekli { get; set; }
        public bool? SatCiftciTuccarKdv { get; set; }
        public bool? SatKdvAtlama { get; set; }
        public bool? SatRusumAtlama { get; set; }
        public bool? SatDaraDaraliAtlama { get; set; }
        public bool? SatDaraRehinIliski { get; set; }
        public bool? SatAyniMallariTopla { get; set; }
        public bool? SatMalariSirala { get; set; }
        public bool? SatSatirdaFiatKontrol { get; set; }
        public bool? SatVeresiyeUyarisi { get; set; }
        public bool? SatRehinOtomatikHesaplansin { get; set; }
        public bool? SatIadesizKapHesaplansin { get; set; }
        public int? SatSatFaturaSiraNo { get; set; }
        public bool? SatRehindeMarkaVar { get; set; }
        public byte? SatRehinIadeIslenecegiHsp { get; set; }
        public bool? SatIskontoVar { get; set; }
        public byte? SatFaturaMalGorunumSekli { get; set; }
        public byte? SatRusumKdvIliskisi { get; set; }
        public byte? SatRusumKdvGosterimi { get; set; }
        public double? SatRusumKdvOrani { get; set; }
        public bool? SatStokKunyesiDegistir { get; set; }
        public bool? SatDokumdenKunyeVar { get; set; }
        public int? SatFaturaSatirSayisi { get; set; }
        public bool? SatStokMiktariGoster { get; set; }
        public bool? SatSubeAdresiniKullan { get; set; }
        public bool? SatKunyesizSatirlardaUyar { get; set; }
        public bool? SatRusumuHksdenAl { get; set; }
        public bool? SatDokumRusumuAsilabilir { get; set; }
        public bool? SatKesilirkenKunyeAl { get; set; }
        public bool? SatFaturaDefaultVeresiye { get; set; }
        public bool? SatBarkoduDirekYazdir { get; set; }
        public byte? SatFaturaBelgesi { get; set; }
        public byte? SatBarkodBelgesi { get; set; }
        public int? SatIrsaliyeSiraNo { get; set; }
        public bool? SatIrsaliyeNoBasinaSifir { get; set; }
        public string SatHamaliyeAdlandirma { get; set; }
        public bool? SatOtomatikHamaliye { get; set; }
        public byte? SatHamaliyeHesaplamaSekli { get; set; }
        public string SatNakliyeAdlandirma { get; set; }
        public bool? SatOtomatikNakliye { get; set; }
        public byte? SatNakliyeHesaplamaSekli { get; set; }
        public double? SatBirimKiloNakliye { get; set; }
        public double? SatBirimKapNakliye { get; set; }
        public byte? SatBildirimServisi { get; set; }
        public bool? SatPesinKayitYapilmasin { get; set; }
        public bool? SatTeslimatYeriKopyalansin { get; set; }
        public byte? SatFaturaUyarmaSekli { get; set; }
        public double? SatKunyeFiyatiSinirOrani { get; set; }
        public byte? SatKunyeFiyatiSinirDenetim { get; set; }
        public bool? SatKunyedeListeFiyatiVar { get; set; }
        public byte? SatKunyePlakaNoKontrolu { get; set; }
    }
}