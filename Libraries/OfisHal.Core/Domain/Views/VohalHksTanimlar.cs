

using System;
using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class VohalHksTanimlar
    {
        public string DigWebKullanicisi { get; set; }
        public string DigWebSifresi { get; set; }
        public byte? DigHksBildirimSekli { get; set; }
        public string DigHksSifresi { get; set; }
        public byte? DigHksCalismaSekli { get; set; }
        public bool? DigKunyeyiOtomatikGonder { get; set; }
        public int? DigHksAdetSiniri { get; set; }
        public double? DigHksKiloSiniri { get; set; }
        public bool? DigKunyeTakibiVar { get; set; }
        public bool? DigKunyeBarkoduYazdir { get; set; }
        public DateTime? DigKunyeGecerlilikTarihi { get; set; }
        public byte? DigSifati { get; set; }
        public byte? DigSatinAlaninSifati { get; set; }
        public byte? SatBildirimTuru { get; set; }
        public byte? DokBildirimTuru { get; set; }
        public bool? DigMarkaninKunyeTakibiVar { get; set; }
        public byte? DigGidecegiYerTipi { get; set; }
        public int? BeldeId { get; set; }
        public int? BeldeHksId { get; set; }
        public string BeldeAdi { get; set; }
        public int? IlceId { get; set; }
        public int? IlceHksId { get; set; }
        public string IlceAdi { get; set; }
        public int? IlId { get; set; }
        public int? IlHksId { get; set; }
        public string IlAdi { get; set; }
        public byte? HksKunyeBakiyesiDusmeSekli { get; set; }
        public bool? HksVarsayilanDegerAtansin { get; set; }
        public bool? HksSatirCogalabilir { get; set; }
        public string HksVarsayilanPlakaNo { get; set; }
        public byte? HksStokCalismaSekli { get; set; }
        public bool? HksSatirDetayiVar { get; set; }
        public bool? HksKunyeSecAcilsin { get; set; }
        public bool? HksKiloKunyesiOncelikli { get; set; }
        public bool? HksKiloKapKarisik { get; set; }
        public bool? HksDigerKunyeleriKullan { get; set; }
        public string HksBildirimBelediyeAdi { get; set; }
        public string HksServisAdresi { get; set; }
    }
}