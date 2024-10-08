using OfisHal.Core.ViewModels;
using OfisHal.Data.Context;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using OfisHal.Core;

namespace OfisHal.Web.Controllers
{
    public class AccountController : BaseController
    {
        private readonly CatalogDb _context;

        public AccountController(CatalogDb context) => _context = context;

        [AllowAnonymous]
        public ActionResult Login(string path)
        {
            ViewData["Title"] = "Oturum aç";
            return View(new LoginViewModel { Path = path });
        }

        [HttpPost, AllowAnonymous, ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel model)
        {
            //TODO: ilgili cookie'nin domain gibi bilgileri değiştirilerek diğer domainlerden bağlanabilirliği ve dönüş url'inin sadece çalışılan domainden olduğunun kontrolü gerekiyor
            // claims identity ile çalışıldığı için oradan bir çözüm bulunabilir. tek app pool üzerinden validation yapıldığından durum sorunlu: https://stackoverflow.com/a/6463427
            if (ModelState.IsValid)
            {
                model.Password = model.Password.HashPassword();

                var user = await _context.Users
                    .Include(u => u.Role)
                    .Include(u => u.Customer.Databases)
                    .FirstOrDefaultAsync(u => u.IsActive && u.UserName.Equals(model.UserName, StringComparison.CurrentCultureIgnoreCase) /*&& u.Password.Equals(model.Password, StringComparison.Ordinal)*/);

                if (user == null)
                    ModelState.AddModelError(string.Empty, "Geçersiz oturum açma girişimi.");
                else
                {
                    var issueDateUtc = DateTime.UtcNow;
                    var expirationUtc = issueDateUtc.AddMinutes(FormsAuthentication.Timeout.Minutes);

                    if (model.RememberMe)
                        expirationUtc = issueDateUtc.AddMonths(1);

                    var ticket = new FormsAuthenticationTicket(2, model.UserName, issueDateUtc, expirationUtc, model.RememberMe, $"{user.Id}|{user.Role.RoleName}", FormsAuthentication.FormsCookiePath);

                    var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(ticket))
                    {
                        Domain = FormsAuthentication.CookieDomain,
                        Expires = ticket.Expiration,
                        HttpOnly = true,
                        Path = FormsAuthentication.FormsCookiePath,
                        SameSite = FormsAuthentication.CookieSameSite,
                        Secure = FormsAuthentication.RequireSSL,
                    };

                    Response.Cookies.Add(cookie);
                    Response.Cookies.Add(new HttpCookie(Constants.WorkSpaceCookieName, user.Customer.Databases.FirstOrDefault().DatabaseName));

                    if (string.IsNullOrWhiteSpace(model.Path))
                        model.Path = FormsAuthentication.DefaultUrl;

                    if (!Url.IsLocalUrl(model.Path))
                        return RedirectToAction(nameof(Index));
                    return Redirect(model.Path);
                }
            }

            ViewData["Title"] = "Oturum aç";
            return View(model);
        }

        [AllowAnonymous]
        public ActionResult ForgotPassword()
        {
            ViewData["Title"] = "Parolanızı mı unuttunuz?";
            return View();
        }

        [HttpPost, AllowAnonymous, ValidateAntiForgeryToken]
        public async Task<ActionResult> ForgotPassword(ForgotPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _context.Users.FirstOrDefaultAsync(u => u.UserName.Equals(model.UserName, StringComparison.CurrentCultureIgnoreCase));

                if (user != null)
                {
                    var newPassword = Guid.NewGuid().ToString("N").Substring(0, 6);

                    user.Password = newPassword.HashPassword();

                    _context.Entry(user).State = EntityState.Modified;
                    await _context.SaveChangesAsync();

                    ViewData["Title"] = "Parolanız değiştirildi";
                    return View("ForgotPasswordConfirmation", (object)newPassword);
                }
            }

            ViewData["Title"] = "Parolanızı mı unuttunuz?";
            return View(model);
        }

        public ActionResult Logout() => Redirect("https://www.esgiris.com/signout/");

        #region Manage

        public ActionResult Index(bool? psw = null)
        {
            if (psw.HasValue)
                ViewData["StatusMessage"] = psw == true ? "Parolanız değiştirildi." : "Hata oluştu.";

            ViewData["Title"] = "Hesabım";
            return View();
        }

        public ActionResult ChangePassword()
        {
            ViewData["Title"] = "Parolayı Değiştir";
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<ActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.OldPassword = model.OldPassword.HashPassword();

                var userId = User.GetUserId();

                var user = await _context.Users.FirstOrDefaultAsync(u => u.Id == userId);

                if (user != null)
                {
                    if (user.Password.Equals(model.OldPassword, StringComparison.Ordinal))
                    {
                        user.Password = model.NewPassword.HashPassword();
                        _context.Entry(user).State = EntityState.Modified;
                        if (await _context.SaveChangesAsync() > 0)
                            return Logout();
                    }
                    else
                        ModelState.AddModelError(nameof(ChangePasswordViewModel.OldPassword), "Parola Hatalı");
                }
                else
                    ModelState.AddModelError(string.Empty, "Kullanıcı bulunamadı!");
            }

            ViewData["Title"] = "Parolayı Değiştir";
            return View(model);
        }
        #endregion
    }
}
