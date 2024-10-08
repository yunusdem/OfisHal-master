using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class VohalMarkaConfiguration : EntityTypeConfiguration<VohalMarka>
    {
        public VohalMarkaConfiguration()
        {
            HasKey(e => e.MarkaId);
            //HasNoKey();

            ToTable("VOHAL_MARKA");

            Property(e => e.Ad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.HalKomisyoncusu).HasColumnName("HAL_KOMISYONCUSU");

            Property(e => e.Kapandi).HasColumnName("KAPANDI");

            Property(e => e.KisilikTipi).HasColumnName("KISILIK_TIPI");

            Property(e => e.Kod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KOD")
                .IsFixedLength();

            Property(e => e.Marka)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MARKA");

            Property(e => e.MarkaId).HasColumnName("MARKA_ID");

            Property(e => e.RusumAlinmasin).HasColumnName("RUSUM_ALINMASIN");

            Property(e => e.VergiKimlikNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VERGI_KIMLIK_NO")
                .IsFixedLength();
        }
    }
}
