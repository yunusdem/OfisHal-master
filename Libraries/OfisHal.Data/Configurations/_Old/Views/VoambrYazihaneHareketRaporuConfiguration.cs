using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VoambrYazihaneHareketRaporuConfiguration : EntityTypeConfiguration<VoambrYazihaneHareketRaporu>
    {
        public VoambrYazihaneHareketRaporuConfiguration()
        {
            //HasNoKey();

            ToTable("VOAMBR_YAZIHANE_HAREKET_RAPORU");

            Property(e => e.Dizayn)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DIZAYN");

            Property(e => e.DizaynId).HasColumnName("DIZAYN_ID");

            Property(e => e.DosyaAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DOSYA_ADI");

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.FaturaTarihi)
                .HasColumnType("datetime")
                .HasColumnName("FATURA_TARIHI");

            Property(e => e.Kdv).HasColumnName("KDV");

            Property(e => e.Kod)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KOD")
                .IsFixedLength();

            Property(e => e.Tutar).HasColumnName("TUTAR");

            Property(e => e.Yazihane)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("YAZIHANE");

            Property(e => e.YazihaneId).HasColumnName("YAZIHANE_ID");
        }
    }
}
