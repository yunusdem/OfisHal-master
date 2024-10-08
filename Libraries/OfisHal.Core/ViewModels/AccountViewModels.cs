using System.ComponentModel.DataAnnotations;

namespace OfisHal.Core.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Şifre")]
        public string Password { get; set; }

        [Display(Name = "Beni hatırla")]
        public bool RememberMe { get; set; }

        public string Path {  get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} en az {2} karakter uzunluğunda olmalıdır.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Parola")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Parolayı onayla")]
        [Compare("Password", ErrorMessage = "Parola ve onay parolası eşleşmiyor.")]
        public string ConfirmPassword { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; }
    }

    public class ChangePasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Mevcut parola")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} en az {2} karakter uzunluğunda olmalıdır.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Yeni parola")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Yeni parolayı onaylayın")]
        [Compare("NewPassword", ErrorMessage = "Yeni parola ve onay parolası eşleşmiyor.")]
        public string ConfirmPassword { get; set; }
    }
}
