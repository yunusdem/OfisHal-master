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

        [Display(Name = "�hracat")]
        Ihracat = 2,

        [Display(Name = "�malat��")]
        Imalatci = 23,

        [Display(Name = "�thalat")]
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

        [Display(Name = "Pazarc�")]
        Pazarc� = 11,

        [Display(Name = "Sanayici")]
        Sanayici = 1,

        [Display(Name = "T�ccar (Hal D���)")]
        TuccarHalDisi = 20,

        [Display(Name = "T�ccar (Hal ��i)")]
        TuccarHalIci = 6,

        [Display(Name = "�retici")]
        Uretici = 4,

        [Display(Name = "�retici �rg�t�")]
        UreticiOrgutu = 10,

        [Display(Name = "Yemek Fabrikas�")]
        YemekFabrikasi = 15,

        [Display(Name = "Yurt")]
        Yurt = 14
    }

    public enum IsletmeTuru
    {
       
        [Display(Name = "�ube")]
        Sube = 1,

        [Display(Name = "Tasnifleme ve Ambalajlama")]
        TasniflemeVeAmbalajlama = 4,

        [Display(Name = "Hal ��i Deposu")]
        HalIciDeposu = 5,

        [Display(Name = "Hal D��� Deposu")]
        HalDisiDeposu = 6,

        [Display(Name = "Hal ��i ��yeri")]
        HalIciIsyeri = 7,

        [Display(Name = "Hal D��� ��yeri")]
        HalDisiIsyeri = 8,

        [Display(Name = "S�nai ��letme")]
        S�naiIsletme = 9,

        [Display(Name = "Da��t�m Merkezi")]
        Dag�t�mMerkezi = 12,

        [Display(Name = "Yurt D���")]
        YurtDisi = 16,

        [Display(Name = "Bireysel T�ketim")]
        BireyselT�ketim = 18,

        [Display(Name = "Perakende Sat�� Yeri")]
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