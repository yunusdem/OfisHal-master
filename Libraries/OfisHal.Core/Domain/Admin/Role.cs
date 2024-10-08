using System.Collections.Generic;

namespace OfisHal.Core.Domain.Admin
{
    public class Role : BaseModel<int>
    {
        public string RoleName { get; set; }

        public virtual ICollection<User> Users { get; set; } = new HashSet<User>();
    }
}
