using OfisHal.Core;
using OfisHal.Core.Domain.Admin;
using OfisHal.Data.Context;
using System;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OfisHal.Services
{
    public interface ITenantService
    {
        string GetConnectionString();
        Core.Domain.Admin.Database GetCurrentWorkSpace();
        Customer GetCurrentTenant();
        SelectList GetWorkSpaces(int? selectedId = null, bool exceptCurrent = false);
    }

    public class TenantService : ITenantService
    {
        private readonly CatalogDb _catalogDb;
        private readonly HttpContextBase _httpContext;

        public TenantService(CatalogDb catalogDb, HttpContextBase httpContext)
        {
            _catalogDb = catalogDb;
            _httpContext = httpContext;
        }

        public Customer GetCurrentTenant()
        {
            var userId = _httpContext.User.GetUserId();
            return _catalogDb.Customers.Include(x => x.Databases).FirstOrDefault(x => !x.DeletedOn.HasValue && x.IsActive && x.Users.Any(y => y.IsActive && y.Id == userId));
        }

        public Core.Domain.Admin.Database GetCurrentWorkSpace()
        {
            var tenant = GetCurrentTenant();
            var currentDbId = _httpContext.Request.GetCookie<int>(Constants.WorkSpaceCookieName);

            if (tenant != null && currentDbId > 0)
                return tenant.Databases.FirstOrDefault(x => x.Id == currentDbId && x.IsActive);
            return null;
        }

        public SelectList GetWorkSpaces(int? selectedId = null, bool exceptCurrent = false)
        {
            var tenant = GetCurrentTenant();

            if (tenant == null)
                return null;

            var currentId = _httpContext.Request.GetCookie<int>(Constants.WorkSpaceCookieName);

            if (selectedId > 0)
                currentId = selectedId.Value;

            var workspaces = tenant.Databases
                .Where(d => d.IsActive && (!exceptCurrent || d.Id != currentId))
                .Select(d => new
                {
                    d.Id,
                    Name = (string.IsNullOrEmpty(d.FriendlyName) ? d.DatabaseName : d.FriendlyName)
                });

            return new SelectList(workspaces, "Id", "Name", currentId);
        }

        public string GetConnectionString()
        {
            var currentDb = GetCurrentWorkSpace();
            var con = new SqlConnectionStringBuilder(ConfigurationManager.ConnectionStrings["Db"].ConnectionString);

            if (currentDb != null && !string.IsNullOrWhiteSpace(con?.ConnectionString))
                con.InitialCatalog = currentDb.DatabaseName;
            return con.ConnectionString;
        }
    }
}
