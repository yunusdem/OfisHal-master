using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VoambrYazihaneBakiyeRaporuConfiguration : EntityTypeConfiguration<VoambrYazihaneBakiyeRaporu>
    {
        public VoambrYazihaneBakiyeRaporuConfiguration()
        {
            //HasNoKey();

            ToTable("VOAMBR_YAZIHANE_BAKIYE_RAPORU");

            Property(e => e.AlacakBakiye).HasColumnName("ALACAK_BAKIYE");

            Property(e => e.BorcBakiye).HasColumnName("BORC_BAKIYE");

            Property(e => e.Kod)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KOD")
                .IsFixedLength();

            Property(e => e.ToplamAlacak).HasColumnName("TOPLAM_ALACAK");

            Property(e => e.ToplamBorc).HasColumnName("TOPLAM_BORC");

            Property(e => e.Unvan)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNVAN");
        }
    }
}
