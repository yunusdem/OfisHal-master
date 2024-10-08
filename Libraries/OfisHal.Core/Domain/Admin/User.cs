namespace OfisHal.Core.Domain.Admin
{
    public class User : BaseModel<int>
    {
        public int RoleId { get; set; }

        public int CustomerId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public bool IsActive { get; set; }

        public virtual Role Role { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
