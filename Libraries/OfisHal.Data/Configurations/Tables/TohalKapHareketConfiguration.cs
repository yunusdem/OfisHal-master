using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalKapHareketConfiguration : EntityTypeConfiguration<TohalKapHareket>
    {
        public TohalKapHareketConfiguration()
        {
            HasKey(e => e.KapHareketId);

            ToTable("TOHAL_KAP_HAREKET");

            Property(e => e.KapHareketId).HasColumnName("KAP_HAREKET_ID");

            Property(e => e.Aciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.EklemeZamani)
                .HasColumnType("datetime")
                .HasColumnName("EKLEME_ZAMANI");

            Property(e => e.EkleyenId).HasColumnName("EKLEYEN_ID");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.GuncellemeZamani)
                .HasColumnType("datetime")
                .HasColumnName("GUNCELLEME_ZAMANI");

            Property(e => e.GuncelleyenId).HasColumnName("GUNCELLEYEN_ID");

            Property(e => e.IslenecegiHesap).HasColumnName("ISLENECEGI_HESAP");

            Property(e => e.KapId).HasColumnName("KAP_ID");

            Property(e => e.Miktar).HasColumnName("MIKTAR");

            Property(e => e.RehinFisiId).HasColumnName("REHIN_FISI_ID");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.Tip).HasColumnName("TIP");

            Property(e => e.Tutar).HasColumnName("TUTAR");

            HasOptional(d => d.CariKart)
                .WithMany(p => p.TohalKapHarekets)
                .HasForeignKey(d => d.CariKartId);

            HasRequired(d => d.Ekleyen)
                .WithMany(p => p.TohalKapHareketEkleyens)
                .HasForeignKey(d => d.EkleyenId)
                .WillCascadeOnDelete(false);

            HasRequired(d => d.Guncelleyen)
                .WithMany(p => p.TohalKapHareketGuncelleyens)
                .HasForeignKey(d => d.GuncelleyenId)
                .WillCascadeOnDelete(false);

            HasRequired(d => d.Kap)
                .WithMany(p => p.TohalKapHarekets)
                .HasForeignKey(d => d.KapId)
                .WillCascadeOnDelete(false);

            HasOptional(d => d.RehinFisi)
                .WithMany(p => p.TohalKapHarekets)
                .HasForeignKey(d => d.RehinFisiId);
        }
    }
}
