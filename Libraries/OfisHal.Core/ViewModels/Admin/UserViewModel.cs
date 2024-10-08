using System.ComponentModel.DataAnnotations;

namespace OfisHal.Core.ViewModels.Admin
{
    public class UserViewModel
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        [Required]
        [StringLength(55, MinimumLength = 4)]
        [Display(Name = "Kullanıcı Adı")]
        [System.Web.Mvc.Remote("CheckUserName", "CustomerUsers", "Id,CustomerId", ErrorMessage = "Bu kullanıcı adı mevcuttur")]
        public string UserName { get; set; }

        [Display(Name = "Parolayı Değiştir")]
        public bool ChangePassword {  get; set; }

        [RequiredIf(nameof(ChangePassword), true)]
        [StringLength(30, MinimumLength = 6)]
        [Display(Name = "Yeni Parola")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare(nameof(Password))]
        [Display(Name = "Yeni Parolayı Onayla")]
        [DataType(DataType.Password)]
        public string PasswordConfirm { get; set; }

        [Display(Name = "Etkin mi?")]
        public bool IsActive { get; set; }
    }
}
