using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalHesapHareketiConfiguration : EntityTypeConfiguration<TohalHesapHareketi>
    {
        public TohalHesapHareketiConfiguration()
        {
            HasKey(e => e.HesapHareketiId);

            ToTable("TOHAL_HESAP_HAREKETI");

            Property(e => e.HesapHareketiId).HasColumnName("HESAP_HAREKETI_ID");

            Property(e => e.Aciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.EklemeZamani)
                .HasColumnType("datetime")
                .HasColumnName("EKLEME_ZAMANI");

            Property(e => e.EkleyenId).HasColumnName("EKLEYEN_ID");

            Property(e => e.GuncellemeZamani)
                .HasColumnType("datetime")
                .HasColumnName("GUNCELLEME_ZAMANI");

            Property(e => e.GuncelleyenId).HasColumnName("GUNCELLEYEN_ID");

            Property(e => e.HareketTipi).HasColumnName("HAREKET_TIPI");

            Property(e => e.HesapId).HasColumnName("HESAP_ID");

            Property(e => e.Kdv).HasColumnName("KDV");

            Property(e => e.KdvOrani).HasColumnName("KDV_ORANI");

            Property(e => e.Meblag).HasColumnName("MEBLAG");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.Tip).HasColumnName("TIP");

            HasRequired(d => d.Ekleyen)
                .WithMany(p => p.TohalHesapHareketiEkleyens)
                .HasForeignKey(d => d.EkleyenId)
                .WillCascadeOnDelete(false);

            HasRequired(d => d.Guncelleyen)
                .WithMany(p => p.TohalHesapHareketiGuncelleyens)
                .HasForeignKey(d => d.GuncelleyenId)
                .WillCascadeOnDelete(false);

            HasRequired(d => d.Hesap)
                .WithMany(p => p.TohalHesapHareketis)
                .HasForeignKey(d => d.HesapId)
                .WillCascadeOnDelete(false);
        }
    }
}
