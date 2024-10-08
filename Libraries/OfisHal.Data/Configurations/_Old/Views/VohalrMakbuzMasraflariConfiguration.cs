using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrMakbuzMasraflariConfiguration : EntityTypeConfiguration<VohalrMakbuzMasraflari>
    {
        public VohalrMakbuzMasraflariConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_MAKBUZ_MASRAFLARI");

            Property(e => e.HesapAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HESAP_ADI");

            Property(e => e.KdvOrani).HasColumnName("KDV_ORANI");

            Property(e => e.KdvTutari).HasColumnName("KDV_TUTARI");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.MasrafTutari).HasColumnName("MASRAF_TUTARI");
        }
    }
}
