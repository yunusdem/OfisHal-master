using OfisHal.Core.Domain.Admin;
using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace OfisHal.Core.ViewModels.Admin
{
    public class CustomerDetailsViewModel
    {
        public int Id { get; set; }

        [Required, Display(Name = "Uygulama Türü")]
        public CustomerType? CustomerType { get; set; }

        [Required, StringLength(250, MinimumLength = 3), Display(Name = "Müşteri Adı / Ünvanı")]
        public string Title { get; set; }

        [Required, StringLength(35, MinimumLength = 3), Display(Name = "Vergi Kimlik Numarası")]
        [Remote("TaxNumberCheck", "Customers", AdditionalFields = nameof(Id), HttpMethod = "POST", ErrorMessage = "Bu vergi numarası başka bir müşteriye tanımlıdır")]
        public string TaxNumber { get; set; }

        [Required, StringLength(35, MinimumLength = 3), Display(Name = "Alt Alan Adı")]
        [Remote("DomainNameCheck", "Customers", AdditionalFields = nameof(Id), HttpMethod = "POST", ErrorMessage = "Bu alt alan adı başka bir müşteriye tanımlıdır")]
        public string DomainName { get; set; }

        public int UsersCount { get; set; }

        public int DatabasesCount { get; set; }

        [Display(Name = "Etkin mi?")]
        public bool IsActive { get; set; }

        [Display(Name = "Eklendiği Tarih")]
        public DateTime? CreatedOn { get; set; }

        [Display(Name = "Güncelleyen")]
        public DateTime? UpdatedOn { get; set; }

        [Display(Name = "Silen")]
        public DateTime? DeletedOn { get; set; }
    }
}
