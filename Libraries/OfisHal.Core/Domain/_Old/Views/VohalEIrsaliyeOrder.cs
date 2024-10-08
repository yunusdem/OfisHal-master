

using System;
using System.Collections.Generic;

namespace OfisHal.Web.Models
{
    public class VohalEIrsaliyeOrder
    {
        public int DepoFisiId { get; set; }
        public string Id { get; set; }
        public DateTime? IssueDate { get; set; }
        public int? SalesOrderId { get; set; }
    }
}