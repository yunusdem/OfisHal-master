using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrBankaEsktreConfiguration : EntityTypeConfiguration<VohalrBankaEsktre>
    {
        public VohalrBankaEsktreConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_BANKA_ESKTRE");

            Property(e => e.Aciklama)
                .HasMaxLength(435)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.Alacak).HasColumnName("ALACAK");

            Property(e => e.BankaAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BANKA_ADI");

            Property(e => e.BankaId).HasColumnName("BANKA_ID");

            Property(e => e.Borc).HasColumnName("BORC");

            Property(e => e.HesapAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HESAP_ADI");

            Property(e => e.HesapNo)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HESAP_NO")
                .IsFixedLength();

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
        }
    }
}
