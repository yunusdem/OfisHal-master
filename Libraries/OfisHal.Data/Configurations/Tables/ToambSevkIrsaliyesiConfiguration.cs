using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class ToambSevkIrsaliyesiConfiguration : EntityTypeConfiguration<ToambSevkIrsaliyesi>
    {
        public ToambSevkIrsaliyesiConfiguration()
        {
            HasKey(e => e.IrsaliyeId);

            ToTable("TOAMB_SEVK_IRSALIYESI");

            Property(e => e.IrsaliyeId).HasColumnName("IRSALIYE_ID");

            Property(e => e.AmbarId).HasColumnName("AMBAR_ID");

            Property(e => e.EklemeZamani)
                .HasColumnType("datetime")
                .HasColumnName("EKLEME_ZAMANI");

            Property(e => e.EkleyenId).HasColumnName("EKLEYEN_ID");

            Property(e => e.GeldigiYerId).HasColumnName("GELDIGI_YER_ID");

            Property(e => e.GenelToplam).HasColumnName("GENEL_TOPLAM");

            Property(e => e.GuncellemeZamani)
                .HasColumnType("datetime")
                .HasColumnName("GUNCELLEME_ZAMANI");

            Property(e => e.GuncelleyenId).HasColumnName("GUNCELLEYEN_ID");

            Property(e => e.Havale).HasColumnName("HAVALE");

            Property(e => e.IrsaliyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IRSALIYE_NO")
                .IsFixedLength();

            Property(e => e.IrsaliyeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("IRSALIYE_TARIHI");

            Property(e => e.Kdv).HasColumnName("KDV");

            Property(e => e.KdvOrani).HasColumnName("KDV_ORANI");

            Property(e => e.Kesinti).HasColumnName("KESINTI");

            Property(e => e.Odendi).HasColumnName("ODENDI");

            Property(e => e.PlakaId).HasColumnName("PLAKA_ID");

            Property(e => e.Sofor)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SOFOR");

            Property(e => e.SoforNot)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SOFOR_NOT");

            Property(e => e.ToplamTutar).HasColumnName("TOPLAM_TUTAR");

            Property(e => e.TutariDegistir).HasColumnName("TUTARI_DEGISTIR");

            HasOptional(d => d.Ekleyen)
                .WithMany(p => p.ToambSevkIrsaliyesiEkleyens)
                .HasForeignKey(d => d.EkleyenId);

            HasOptional(d => d.GeldigiYer)
                .WithMany(p => p.ToambSevkIrsaliyesiGeldigiYers)
                .HasForeignKey(d => d.GeldigiYerId);

            HasOptional(d => d.Guncelleyen)
                .WithMany(p => p.ToambSevkIrsaliyesiGuncelleyens)
                .HasForeignKey(d => d.GuncelleyenId);

            HasOptional(d => d.Plaka)
                .WithMany(p => p.ToambSevkIrsaliyesiPlakas)
                .HasForeignKey(d => d.PlakaId);
        }
    }
}
