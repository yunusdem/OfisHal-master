using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VoambAramaSevkIrsaliyesiConfiguration : EntityTypeConfiguration<VoambAramaSevkIrsaliyesi>
    {
        public VoambAramaSevkIrsaliyesiConfiguration()
        {
            //HasNoKey();

            ToTable("VOAMB_ARAMA_SEVK_IRSALIYESI");

            Property(e => e.AmbarAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AMBAR_ADI");

            Property(e => e.AmbarId).HasColumnName("AMBAR_ID");

            Property(e => e.AmbarKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AMBAR_KODU")
                .IsFixedLength();

            Property(e => e.GeldigiYer)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("GELDIGI_YER");

            Property(e => e.GeldigiYerId).HasColumnName("GELDIGI_YER_ID");

            Property(e => e.GenelToplam).HasColumnName("GENEL_TOPLAM");

            Property(e => e.IrsaliyeId).HasColumnName("IRSALIYE_ID");

            Property(e => e.IrsaliyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IRSALIYE_NO")
                .IsFixedLength();

            Property(e => e.IrsaliyeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("IRSALIYE_TARIHI");

            Property(e => e.KayitId).HasColumnName("KAYIT_ID");

            Property(e => e.KdvOrani).HasColumnName("KDV_ORANI");

            Property(e => e.Kesinti).HasColumnName("KESINTI");

            Property(e => e.Odendi).HasColumnName("ODENDI");

            Property(e => e.PlakaId).HasColumnName("PLAKA_ID");

            Property(e => e.PlakaNo)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PLAKA_NO");

            Property(e => e.Sofor)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SOFOR");

            Property(e => e.ToplamTutar).HasColumnName("TOPLAM_TUTAR");
        }
    }
}
