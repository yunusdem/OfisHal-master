using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Reflection;

namespace OfisHal.Web
{
    public enum Sifat
    {
        [Display(Name = "Depo/Tasnif ve Ambalaj")]
        DepoTasnifVeAmbalaj = 9,

        [Display(Name = "E-Market")]
        EMarket = 24,

        [Display(Name = "Hastane")]
        Hastane = 19,

        [Display(Name = "Ýhracat")]
        Ihracat = 2,

        [Display(Name = "Ýmalatçý")]
        Imalatci = 23,

        [Display(Name = "Ýthalat")]
        Ithalat = 3,

        [Display(Name = "Komisyoncu")]
        Komisyoncu = 5,

        [Display(Name = "Lokanta")]
        Lokanta = 13,

        [Display(Name = "Manav")]
        Manav = 8,

        [Display(Name = "Market")]
        Market = 7,

        [Display(Name = "Otel")]
        Otel = 12,

        [Display(Name = "Pazarcý")]
        Pazarcý = 11,

        [Display(Name = "Sanayici")]
        Sanayici = 1,

        [Display(Name = "Tüccar (Hal Dýþý)")]
        TuccarHalDisi = 20,

        [Display(Name = "Tüccar (Hal Ýçi)")]
        TuccarHalIci = 6,

        [Display(Name = "Üretici")]
        Uretici = 4,

        [Display(Name = "Üretici Örgütü")]
        UreticiOrgutu = 10,

        [Display(Name = "Yemek Fabrikasý")]
        YemekFabrikasi = 15,

        [Display(Name = "Yurt")]
        Yurt = 14
    }

    public enum IsletmeTuru
    {
       
        [Display(Name = "Þube")]
        Sube = 1,

        [Display(Name = "Tasnifleme ve Ambalajlama")]
        TasniflemeVeAmbalajlama = 4,

        [Display(Name = "Hal Ýçi Deposu")]
        HalIciDeposu = 5,

        [Display(Name = "Hal Dýþý Deposu")]
        HalDisiDeposu = 6,

        [Display(Name = "Hal Ýçi Ýþyeri")]
        HalIciIsyeri = 7,

        [Display(Name = "Hal Dýþý Ýþyeri")]
        HalDisiIsyeri = 8,

        [Display(Name = "Sýnai Ýþletme")]
        SýnaiIsletme = 9,

        [Display(Name = "Daðýtým Merkezi")]
        DagýtýmMerkezi = 12,

        [Display(Name = "Yurt Dýþý")]
        YurtDisi = 16,

        [Display(Name = "Bireysel Tüketim")]
        BireyselTüketim = 18,

        [Display(Name = "Perakende Satýþ Yeri")]
        PerakendeSatisYeri = 19
    }

    public static class EnumHelperFunc
    {
        public static string GetDisplayName(Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());

            if (field != null)
            {
                DisplayAttribute attribute = (DisplayAttribute)Attribute.GetCustomAttribute(field, typeof(DisplayAttribute));

                if (attribute != null)
                {
                    return attribute.GetName();
                }
            }

            return value.ToString();
        }

        public static string GetEnumValuesAsJson()
        {
            var enumValues = Enum.GetValues(typeof(IsletmeTuru))
                                .Cast<IsletmeTuru>()
                                .ToDictionary(e => e.ToString(), e => (int)e);

            return Newtonsoft.Json.JsonConvert.SerializeObject(enumValues);
        }

        public static string GetEnumDisplayNamesAndValuesAsJson()
        {
            var enumDisplayNamesAndValues = Enum.GetValues(typeof(IsletmeTuru))
                                                .Cast<IsletmeTuru>()
                                                .ToDictionary(e => GetDisplayName(e), e => (int)e);

            return Newtonsoft.Json.JsonConvert.SerializeObject(enumDisplayNamesAndValues);
        }
    }


}