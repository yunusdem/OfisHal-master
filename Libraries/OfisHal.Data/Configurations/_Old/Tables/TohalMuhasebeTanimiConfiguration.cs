using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class TohalMuhasebeTanimiConfiguration : EntityTypeConfiguration<TohalMuhasebeTanimi>
    {
        public TohalMuhasebeTanimiConfiguration()
        {
            //HasNoKey();

            ToTable("TOHAL_MUHASEBE_TANIMI");

            Property(e => e.MuhHesapId).HasColumnName("MUH_HESAP_ID");

            Property(e => e.Tur).HasColumnName("TUR");

            HasRequired(d => d.MuhHesap)
                .WithMany()
                .HasForeignKey(d => d.MuhHesapId)
                .WillCascadeOnDelete(false);
        }
    }
}
