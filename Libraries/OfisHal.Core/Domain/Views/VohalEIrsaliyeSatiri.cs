

using System;
using System.Collections.Generic;

namespace OfisHal.Core.Domain
{
    public class VohalEIrsaliyeSatiri
    {
        public int DepoFisiId { get; set; }
        public int? Id { get; set; }
        public string DeliveredQuantity { get; set; }
        public double? DeliveredUnitPrice { get; set; }
        public string DeliveredQuantityUnit { get; set; }
        public int? OrderLineId { get; set; }
        public string OrderId { get; set; }
        public int? SalesOrderId { get; set; }
        public DateTime? OrderIssueDate { get; set; }
        public string ItemName { get; set; }
        public string ItemCode { get; set; }
        public string BuyersItemIdentification { get; set; }
        public string CurrencyCode { get; set; }
        public double? DiscountRate { get; set; }
        public int? LineNo { get; set; }
        public double? RowAmount { get; set; }
        public string Kap { get; set; }
        public string Darali { get; set; }
        public string Dara { get; set; }
        public int? MalHksId { get; set; }
    }
}