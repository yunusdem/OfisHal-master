using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrHesapAdListeConfiguration : EntityTypeConfiguration<VohalrHesapAdListe>
    {
        public VohalrHesapAdListeConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_HESAP_AD_LISTE");

            Property(e => e.HesapAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HESAP_ADI");

            Property(e => e.HesapId)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .HasColumnName("HESAP_ID");

            Property(e => e.HesapKodu)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HESAP_KODU")
                .IsFixedLength();
        }
    }
}
