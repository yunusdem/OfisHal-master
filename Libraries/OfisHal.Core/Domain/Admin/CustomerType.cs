using System.ComponentModel.DataAnnotations;

namespace OfisHal.Core.Domain.Admin
{
    public enum CustomerType : byte
    {
        /// <summary>
        /// Es-Hal Tüccar
        /// </summary>
        [Display(Name = "Eshal Tüccar")]
        EsHalTuccar = 0,

        /// <summary>
        /// Es-Hal Komisyon
        /// </summary>
        [Display(Name = "Eshal Komisyon")]
        EsHalKomisyon = 1,

        /// <summary>
        /// Es-Hal İhracaat
        /// </summary>
        [Display(Name = "Eshal İhracaat")]
        EsHalIhracaat = 2,

        /// <summary>
        /// Ofis-Hal Tüccar
        /// </summary>
        [Display(Name = "Ofis Tüccar")]
        OfisTuccar = 3,

        /// <summary>
        /// Ofis-Hal Komisyon
        /// </summary>
        [Display(Name = "Ofis Komisyon")]
        OfisKomisyon = 4,

        /// <summary>
        /// Ofis-Hal İhracaat
        /// </summary>
        [Display(Name = "Ofis İhracaat")]
        OfisIhracaat = 5,

        /// <summary>
        /// Es-Ticari E-Belge
        /// </summary>
        [Display(Name = "EsTicari E-Belge")]
        EsTicariEBelge = 6,

        /// <summary>
        /// Es-Ticari Ticari
        /// </summary>
        [Display(Name = "EsTicari Ticari")]
        EsTicariTicari = 7,

        /// <summary>
        /// Es-Ticari Üretim
        /// </summary>
        [Display(Name = "EsTicari Üretim")]
        EsTicariUretim = 8,

        /// <summary>
        /// Es-Ticari Perakende
        /// </summary>
        [Display(Name = "EsTicari Perakende")]
        EsTicariPerakende = 9,

        /// <summary>
        /// Es-Ticari İhracaat
        /// </summary>
        [Display(Name = "EsTicari İhracaat")]
        EsTicariIhracaat = 10,

        /// <summary>
        /// Es-Döviz Vezne
        /// </summary>
        [Display(Name = "EsDöviz Vezne")]
        EsDovizVezne = 11,

        /// <summary>
        /// Es-Döviz Cari
        /// </summary>
        [Display(Name = "EsDöviz Cari")]
        EsDovizCari = 12,

        /// <summary>
        /// Es-Döviz Dedektif
        /// </summary>
        [Display(Name = "EsDöviz Dedektif")]
        EsDovizDedektif = 13,

        /// <summary>
        /// Es-Döviz Cep
        /// </summary>
        [Display(Name = "EsDöviz Cep")]
        EsDovizCep = 14,

        /// <summary>
        /// Ofis-Döviz Vezne
        /// </summary>
        [Display(Name = "Ofis Döviz Vezne")]
        OfisDovizVezne = 15,

        /// <summary>
        /// Ofis-Döviz Cari
        /// </summary>
        [Display(Name = "Ofis Döviz Cari")]
        OfisDovizCari = 16,

        /// <summary>
        /// Es-Kuyum Perakende
        /// </summary>
        [Display(Name = "EsKuyum Perakende")]
        EsKuyumPerakende = 17,

        /// <summary>
        /// Es-Kuyum Ticari
        /// </summary>
        [Display(Name = "EsKuyum Ticari")]
        EsKuyumTicari = 18,

        /// <summary>
        /// Es-Kuyum Üretim
        /// </summary>
        [Display(Name = "EsKuyum Üretim")]
        EsKuyumUretim = 19,
    }
}
