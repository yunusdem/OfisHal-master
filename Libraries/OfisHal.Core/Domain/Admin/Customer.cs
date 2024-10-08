using System;
using System.Collections.Generic;

namespace OfisHal.Core.Domain.Admin
{
    public class Customer : BaseModel<int>
    {
        public CustomerType AppType { get; set; }

        public string Title { get; set; }

        public string TaxNumber { get; set; }

        public bool IsActive { get; set; }

        public DateTimeOffset CreatedOn { get; set; }

        public DateTimeOffset? UpdatedOn { get; set; }

        public DateTimeOffset? DeletedOn { get; set; }

        public virtual ICollection<User> Users { get; set; } = new HashSet<User>();

        public virtual ICollection<Database> Databases { get; set; } = new HashSet<Database>();
    }
}
