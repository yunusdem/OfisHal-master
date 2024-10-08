using OfisHal.Core.Domain.Admin;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Threading;
using System.Threading.Tasks;

namespace OfisHal.Data.Context
{
    public class CatalogDb : DbContext
    {
        public CatalogDb() : base("name=CatalogDb")
        {
            Configuration.AutoDetectChangesEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<Customer> Customers { get; set; }

        public virtual DbSet<Core.Domain.Admin.Database> Databases { get; set; }

        public virtual DbSet<Role> Roles { get; set; }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #region Customer
            modelBuilder.Entity<Customer>().HasIndex(e => e.TaxNumber).IsUnique();

            modelBuilder.Entity<Customer>().Property(e => e.Title)
                .IsRequired()
                .HasMaxLength(250);

            modelBuilder.Entity<Customer>().Property(e => e.TaxNumber)
                .IsUnicode(false)
                .IsRequired()
                .HasMaxLength(35);

            modelBuilder.Entity<Customer>().Property(e => e.CreatedOn)
                .HasColumnType("datetimeoffset")
                .HasPrecision(0);

            modelBuilder.Entity<Customer>().Property(e => e.UpdatedOn)
                .HasColumnType("datetimeoffset")
                .HasPrecision(0);

            modelBuilder.Entity<Customer>().Property(e => e.DeletedOn)
                .HasColumnType("datetimeoffset")
                .HasPrecision(0);
            #endregion

            #region Database
            modelBuilder.Entity<Core.Domain.Admin.Database>().Property(e => e.FriendlyName)
                .IsRequired()
                .HasMaxLength(75);

            modelBuilder.Entity<Core.Domain.Admin.Database>().HasIndex(e => e.DatabaseName).IsUnique();

            modelBuilder.Entity<Core.Domain.Admin.Database>().Property(e => e.DatabaseName)
                .IsUnicode(false)
                .IsRequired()
                .HasMaxLength(55);
            #endregion

            #region Role
            modelBuilder.Entity<Role>().HasIndex(e => e.RoleName).IsUnique();

            modelBuilder.Entity<Role>().Property(e => e.RoleName)
                .IsUnicode(false)
                .IsRequired()
                .HasMaxLength(25);

            modelBuilder.Entity<Role>().HasMany(e => e.Users)
                .WithRequired(e => e.Role)
                .HasForeignKey(e => e.RoleId);
            #endregion

            #region User
            modelBuilder.Entity<User>().HasIndex(e => e.UserName).IsUnique();

            modelBuilder.Entity<User>().Property(e => e.UserName)
                .IsUnicode(false)
                .IsRequired()
                .HasMaxLength(55);

            modelBuilder.Entity<User>().Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(256);
            #endregion

            base.OnModelCreating(modelBuilder);
        }

        #region SaveChanges Overrides
        public override Task<int> SaveChangesAsync() => SaveChangesAsync(CancellationToken.None);

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            try
            {
                return base.SaveChangesAsync(cancellationToken);
            }
            catch (DbEntityValidationException e)
            {
                throw new FormattedDbEntityValidationException(e);
            }
        }

        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                throw new FormattedDbEntityValidationException(e);
            }
        }
        #endregion
    }
}
