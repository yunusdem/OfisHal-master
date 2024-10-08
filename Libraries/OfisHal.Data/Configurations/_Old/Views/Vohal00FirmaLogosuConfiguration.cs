using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class Vohal00FirmaLogosuConfiguration : EntityTypeConfiguration<Vohal00FirmaLogosu>
    {
        public Vohal00FirmaLogosuConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_00_FIRMA_LOGOSU");

            Property(e => e.Logo)
                .IsRequired()
                .HasColumnType("image")
                .HasColumnName("LOGO");

            Property(e => e.SahipId).HasColumnName("SAHIP_ID");

            Property(e => e.SahipTuru).HasColumnName("SAHIP_TURU");
        }
    }
}
