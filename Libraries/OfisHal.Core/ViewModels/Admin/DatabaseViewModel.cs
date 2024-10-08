using System.ComponentModel.DataAnnotations;

namespace OfisHal.Core.ViewModels.Admin
{
    public class DatabaseViewModel
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        [Required]
        [StringLength(55)]
        [Display(Name = "Veritabanı Sistem Adı")]
        //[System.Web.Mvc.Remote("CheckDatabaseName", "CustomerDatabases", "Id,CustomerId")]
        public string DatabaseName { get; set; }

        [Required]
        [StringLength(75, MinimumLength = 4)]
        [Display(Name = "Veritabanı Görünen Ad")]
        public string FriendlyName {  get; set; }

        [Display(Name = "Etkin mi?")]
        public bool IsActive { get; set; }
    }
}
