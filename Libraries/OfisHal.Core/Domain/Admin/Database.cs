namespace OfisHal.Core.Domain.Admin
{
    public class Database : BaseModel<int>
    {
        public int CustomerId { get; set; }

        public string DatabaseName { get; set; }

        public string FriendlyName { get; set; }
        
        public bool IsActive { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
