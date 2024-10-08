using Microsoft.AspNetCore.DataProtection.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Xml.Linq;

namespace OfisHal.Web
{
    public class KeyXmlRepository : IXmlRepository
    {
        /// <summary>
        /// This function must return a list of all the elements in the database
        /// </summary>
        /// <returns></returns>
        public IReadOnlyCollection<XElement> GetAllElements()
        {
            using (var con = new SqlConnection(WebConfigurationManager.ConnectionStrings["CatalogDb"].ConnectionString))
            {
                con.Open();
                using (var cmd = new SqlCommand("SELECT Xml FROM DataProtectionKeys", con))
                {
                    var dr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

                    var result = new List<XElement>();
                    while (dr.Read())
                        result.Add(XElement.Parse(dr.GetString(0)));

                    return result;
                }
            }
        }

        /// <summary>
        /// This function must write to the database (this is optional if this service never provides the authentication, only uses it)
        /// </summary>
        /// <param name="element"></param>
        /// <param name="friendlyName"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void StoreElement(XElement element, string friendlyName) => throw new NotImplementedException();
    }
}
