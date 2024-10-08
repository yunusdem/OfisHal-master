using OfisHal.Core.Domain.Admin;
using System.Collections.Generic;

namespace OfisHal.Core.ViewModels.Admin
{
    public class CustomersViewModel
    {
        public CustomerType? CustomerType { get; set; }

        public string Keywords { get; set; }

        public int TotalCount { get; set; }

        public int PageSize { get; set; }

        public int PageNumber { get; set; }

        public int PagerCount { get; set; }

        public IList<Customer> Items { get; set; }
    }
}
