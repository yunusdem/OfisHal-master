using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class TohalIskeleMuhFisSatiriConfiguration : EntityTypeConfiguration<TohalIskeleMuhFisSatiri>
    {
        public TohalIskeleMuhFisSatiriConfiguration()
        {
            //HasNoKey();

            ToTable("TOHAL_ISKELE_MUH_FIS_SATIRI");

            Property(e => e.Aciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.Guid).HasColumnName("GUID");

            Property(e => e.Meblag).HasColumnName("MEBLAG");

            Property(e => e.MuhHesapId).HasColumnName("MUH_HESAP_ID");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.Tip).HasColumnName("TIP");
        }
    }
}
