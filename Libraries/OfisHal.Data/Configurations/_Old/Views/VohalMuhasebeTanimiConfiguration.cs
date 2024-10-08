using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalMuhasebeTanimiConfiguration : EntityTypeConfiguration<VohalMuhasebeTanimi>
    {
        public VohalMuhasebeTanimiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_MUHASEBE_TANIMI");

            Property(e => e.HesapKodu)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HESAP_KODU")
                .IsFixedLength();

            Property(e => e.MuhHesapId).HasColumnName("MUH_HESAP_ID");

            Property(e => e.Tur).HasColumnName("TUR");
        }
    }
}
