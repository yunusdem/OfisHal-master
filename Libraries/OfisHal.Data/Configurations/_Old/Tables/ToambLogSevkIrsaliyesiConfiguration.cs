using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class ToambLogSevkIrsaliyesiConfiguration : EntityTypeConfiguration<ToambLogSevkIrsaliyesi>
    {
        public ToambLogSevkIrsaliyesiConfiguration()
        {
            //HasNoKey();

            ToTable("TOAMB_LOG_SEVK_IRSALIYESI");

            Property(e => e.IrsaliyeId).HasColumnName("IRSALIYE_ID");

            Property(e => e.Islem).HasColumnName("ISLEM");

            Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            Property(e => e.OAmbarId).HasColumnName("O_AMBAR_ID");

            Property(e => e.OGeldigiYerId).HasColumnName("O_GELDIGI_YER_ID");

            Property(e => e.OIrsaliyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("O_IRSALIYE_NO")
                .IsFixedLength();

            Property(e => e.OIrsaliyeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("O_IRSALIYE_TARIHI");

            Property(e => e.OKdv).HasColumnName("O_KDV");

            Property(e => e.OKdvOrani).HasColumnName("O_KDV_ORANI");

            Property(e => e.OKesinti).HasColumnName("O_KESINTI");

            Property(e => e.OOdendi).HasColumnName("O_ODENDI");

            Property(e => e.OPlakaId).HasColumnName("O_PLAKA_ID");

            Property(e => e.OSofor)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("O_SOFOR");

            Property(e => e.OSoforNot)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("O_SOFOR_NOT");

            Property(e => e.OToplamTutar).HasColumnName("O_TOPLAM_TUTAR");

            Property(e => e.OTutariDegistir).HasColumnName("O_TUTARI_DEGISTIR");

            Property(e => e.SAmbarId).HasColumnName("S_AMBAR_ID");

            Property(e => e.SGeldigiYerId).HasColumnName("S_GELDIGI_YER_ID");

            Property(e => e.SIrsaliyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("S_IRSALIYE_NO")
                .IsFixedLength();

            Property(e => e.SIrsaliyeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("S_IRSALIYE_TARIHI");

            Property(e => e.SKdv).HasColumnName("S_KDV");

            Property(e => e.SKdvOrani).HasColumnName("S_KDV_ORANI");

            Property(e => e.SKesinti).HasColumnName("S_KESINTI");

            Property(e => e.SOdendi).HasColumnName("S_ODENDI");

            Property(e => e.SPlakaId).HasColumnName("S_PLAKA_ID");

            Property(e => e.SSofor)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("S_SOFOR");

            Property(e => e.SSoforNot)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("S_SOFOR_NOT");

            Property(e => e.SToplamTutar).HasColumnName("S_TOPLAM_TUTAR");

            Property(e => e.STutariDegistir).HasColumnName("S_TUTARI_DEGISTIR");

            Property(e => e.Zaman)
                .HasColumnType("datetime")
                .HasColumnName("ZAMAN");
        }
    }
}
