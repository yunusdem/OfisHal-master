using Autofac;
using Autofac.Integration.Mvc;
using Hangfire;
using Hangfire.SqlServer;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.Interop;
using OfisHal.Core;
using OfisHal.Core.Framework.Engines;
using OfisHal.Data.Context;
using OfisHal.Services;
using OfisHal.Web;
using Owin;
using System;
using System.IO;
using System.Security.Claims;
using System.Threading;
using System.Web;
using System.Web.Helpers;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Routing;

[assembly: OwinStartup(typeof(Startup))]
namespace OfisHal.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMvc();
            ConfigureServices(app);
            ConfigureAuthentication(app);
        }

        private void ConfigureServices(IAppBuilder app)
        {
            var builder = new ContainerBuilder();
            #region Mvc Core
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterModelBinders(typeof(MvcApplication).Assembly);
            builder.RegisterModelBinderProvider();
            builder.RegisterModule<AutofacWebTypesModule>();
            builder.RegisterSource(new ViewRegistrationSource());
            builder.RegisterFilterProvider();

            GlobalConfiguration.Configuration.UseSqlServerStorage("HangFireDb");

            app.UseHangfireServer();

            #region Services
            builder.RegisterType<TenantService>().As<ITenantService>();
            builder.RegisterType<CatalogDb>().AsSelf().InstancePerRequest();
            //builder.RegisterType<Db>().AsSelf().InstancePerRequest();

            builder.Register(ctx => {
                var provider = ctx.Resolve<ITenantService>();
                return new Db(provider.GetConnectionString());
            }).AsSelf().InstancePerRequest();

            builder.RegisterType<DataServices>().As<IDataServices>().InstancePerRequest();
            builder.RegisterType<InvoiceService>().As<IInvoiceService>().InstancePerLifetimeScope();
            builder.RegisterType<HksService>().As<IHksService>().InstancePerLifetimeScope();
            builder.RegisterType<SmtpService>().As<ISmtpService>().InstancePerLifetimeScope();
            builder.RegisterType<FileService>().As<IFileService>().InstancePerRequest();
            #endregion

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            app.UseAutofacMiddleware(container);
            app.UseAutofacMvc();
            #endregion
        }

        private void ConfigureAuthentication(IAppBuilder app)
        {
            var ticketDataFormat = new AspNetTicketDataFormat(new DataProtectorShim(
                    DataProtectionProvider.Create(new DirectoryInfo(HostingEnvironment.MapPath("~/App_Data/Keys")),
                    builder =>
                    {
                        builder.SetApplicationName("LoginApp");
                        builder.Services.AddSingleton<IConfigureOptions<KeyManagementOptions>>(s => new ConfigureOptions<KeyManagementOptions>(o => o.XmlRepository = new KeyXmlRepository()));
                    })
                    .CreateProtector("Microsoft.AspNetCore.Authentication.Cookies.CookieAuthenticationMiddleware", CookieAuthenticationDefaults.AuthenticationType, "v2")));
            
            //app.UseCookieAuthentication(new CookieAuthenticationOptions
            //{
            //    LoginPath = new PathString("/account/login"),
            //    CookieName = ".Esg.HalAuth",
            //    ReturnUrlParameter = "path",
            //    AuthenticationType = CookieAuthenticationDefaults.AuthenticationType,
            //    //TicketDataFormat = ticketDataFormat,
            //    CookieManager = new ChunkingCookieManager(),
            //    Provider = new CookieAuthenticationProvider { OnApplyRedirect = ApplyRedirect }
            //});
        }

        private static void ApplyRedirect(CookieApplyRedirectContext context)
        {
            if (Uri.TryCreate(context.RedirectUri, UriKind.Absolute, out var absoluteUri) && !HttpContext.Current.Request.IsLocal)
            {
                var path = PathString.FromUriComponent(absoluteUri);
                if (path == context.OwinContext.Request.PathBase + context.Options.LoginPath)
                    context.RedirectUri = "https://www.esgiris.com" + new QueryString(context.Options.ReturnUrlParameter, context.Request.Uri.PathAndQuery);
            }

            context.Response.Redirect(context.RedirectUri);
        }

        private void ConfigureMvc()
        {
            #region Filters
            var filters = GlobalFilters.Filters;
            filters.Add(new HandleErrorAttribute());
            filters.Add(new RequireHttpsAttribute(true));
            filters.Add(new DbFilter());
            #endregion

            #region Routes
            AreaRegistration.RegisterAllAreas();

            var routes = RouteTable.Routes;
            routes.AppendTrailingSlash = true;
            routes.LowercaseUrls = true;
            routes.RouteExistingFiles = false;

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute("Default", "{controller}/{action}/{id}", new { controller = "Dashboard", action = "Index", id = UrlParameter.Optional });
            #endregion

            MvcHandler.DisableMvcResponseHeader = true;

            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new AppRazorViewEngine());

            AntiForgeryConfig.CookieName = string.Concat(Constants.CookiePrefix, "Aft");
            AntiForgeryConfig.RequireSsl = true;
            AntiForgeryConfig.SuppressXFrameOptionsHeader = true;
            AntiForgeryConfig.UniqueClaimTypeIdentifier = ClaimTypes.NameIdentifier;
        }
    }
}
