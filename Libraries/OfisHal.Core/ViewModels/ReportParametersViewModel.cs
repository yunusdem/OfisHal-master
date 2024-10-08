using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OfisHal.Core.ViewModels
{
    /// <devdoc>
    /// Bu dosya linked referance şeklinde EsHal.Api projesine referans edilmektedir. Dosya isim veya konumu değiştirilirken bu dikkate alınmalıdır.
    /// </devdoc>
    public class ReportParametersViewModel
    {
        public IList<Tab> Tabs { get; set; } = new List<Tab>();
    }

    public class Tab
    {
        public ParameterTabType Type { get; set; }

        public IList<Parameter> Parameters { get; set; } = new List<Parameter>();
    }

    public class Parameter
    {
        public string Name { get; set; }

        public string Label { get; set; }

        public bool IsNullable {  get; set; }

        public bool IsRange {  get; set; }

        public ParameterValueType ValueType { get; set; }

        public ParameterControlType ControlType => FindControlType(Name);

        public IEnumerable<string> Options { get; set; } = new List<string>();

        public object DefaultValue {  get; set; }

        public int GroupSortOrder
        {
            get
            {
                if (ControlType == ParameterControlType.ComboBox)
                    return 1;
                else if (ControlType == ParameterControlType.CheckBox)
                    return 2;
                else
                    return 3;
            }
        }

        internal ParameterControlType FindControlType(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                name = name.TrimStart('@');

                if (name.Contains("pFirmamizAdi") || name.Contains("pFirmaAdresi") || name.Contains("pYazihaneNo") || name.Contains("pFirmaAdresi"))
                    return ParameterControlType.Hidden;
                if (name.StartsWith("pCB_") || name.StartsWith("CB_"))
                    return ParameterControlType.ComboBox;
                if (name.StartsWith("pCHK_") || name.StartsWith("CHK_"))
                    return ParameterControlType.CheckBox;
                if (name.StartsWith("MSK_") || name.StartsWith("pMSK_") || name.Contains("MustahsilKod") || name.Contains("MustahsilKodu"))
                    return ParameterControlType.SearchProducerCode;
                if (name.StartsWith("MSA_") || name.StartsWith("pMSA_") || name.Contains("MuhtahsilAdi") || name.Contains("MustahsilAdi"))
                    return ParameterControlType.SearchProducerName;
                if (name.StartsWith("MTK_") || name.StartsWith("pMTK_"))
                    return ParameterControlType.SearchCustomerCode;
                if (name.StartsWith("MTA_") || name.StartsWith("pMTA_") || name.EndsWith("MusteriAd"))
                    return ParameterControlType.SearchCustomerName;
                if (name.StartsWith("MLK_") || name.StartsWith("pMLK_") || name.StartsWith("MDR_MLK_"))
                    return ParameterControlType.SearchProductCode;
                if (name.StartsWith("MLA_") || name.StartsWith("pMLA_") || name.StartsWith("MDR_MLA_"))
                    return ParameterControlType.SearchProductName;
                if (name.StartsWith("KPA_") || name.StartsWith("pKPA"))
                    return ParameterControlType.SearchContainerName;
                if (name.StartsWith("KPK_") || name.StartsWith("pKPK"))
                    return ParameterControlType.SearchContainerCode;
                if (name.StartsWith("MRA_") || name.EndsWith("Marka"))
                    return ParameterControlType.Brands;
                if (name.StartsWith("pBNK_"))
                    return ParameterControlType.Banks;
                if (name.StartsWith("pKLA_"))
                    return ParameterControlType.User;
                if (name.EndsWith("sehir", StringComparison.InvariantCultureIgnoreCase))
                    return ParameterControlType.Cities;
            }
            
            return ParameterControlType.Standart;
        }
    }

    public enum ParameterTabType
    {
        [Display(Name = "Ürün Adı")]
        ProductName,

        [Display(Name = "Müşteri Adı")]
        CustomerName,

        [Display(Name = "Müstahsil Adı")]
        ProducerName,

        [Display(Name = "Marka")]
        Brand,

        [Display(Name = "Durum")]
        Status,

        [Display(Name = "Diğer Parametreler")]
        Others
    }

    public enum ParameterValueType
    {
        Numeric,
        Currency,
        Boolean,
        Date,
        DateTime,
        Time,
        String
    }

    public enum ParameterControlType
    {
        Standart,
        ComboBox, // CB_ ve pCB_
        CheckBox, // pCHK_

        // müstahsil
        SearchProducerCode,
        SearchProducerName,

        User, //pKLA_

        // müşteri
        SearchCustomerCode, // MTK_
        SearchCustomerName, // MTA_

        // mal / ürün
        SearchProductCode,
        SearchProductName,

        // kap
        SearchContainerCode,
        SearchContainerName,

        Brands,
        Banks,  // pBNK_
        Cities,
        Hidden // pFirmamizAdi, pFirmaAdresi, pYazihaneNo
    }
}
