using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalStokHareketiConfiguration : EntityTypeConfiguration<TohalStokHareketi>
    {
        public TohalStokHareketiConfiguration()
        {
            HasKey(e => e.StokHareketiId);

            ToTable("TOHAL_STOK_HAREKETI");

            HasIndex(e => e.StokKunyeId);

            Property(e => e.StokHareketiId).HasColumnName("STOK_HAREKETI_ID");

            Property(e => e.Aciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.AlisKunyeId).HasColumnName("ALIS_KUNYE_ID");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.GirisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("GIRIS_TARIHI");

            Property(e => e.KapId).HasColumnName("KAP_ID");

            Property(e => e.KapSayisi).HasColumnName("KAP_SAYISI");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.MalId).HasColumnName("MAL_ID");

            Property(e => e.Miktar).HasColumnName("MIKTAR");

            Property(e => e.SatilanKap).HasColumnName("SATILAN_KAP");

            Property(e => e.SatilanMiktar).HasColumnName("SATILAN_MIKTAR");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.StokKunyeId).HasColumnName("STOK_KUNYE_ID");

            Property(e => e.StokTipi).HasColumnName("STOK_TIPI");

            Property(e => e.Guid).HasColumnName("GUID");

            HasOptional(d => d.AlisKunye)
                .WithMany(p => p.TohalStokHareketiAlisKunyes)
                .HasForeignKey(d => d.AlisKunyeId);

            HasOptional(d => d.Kap)
                .WithMany(p => p.TohalStokHareketis)
                .HasForeignKey(d => d.KapId);

            HasRequired(d => d.Makbuz)
                .WithMany(p => p.TohalStokHareketis)
                .HasForeignKey(d => d.MakbuzId)
                .WillCascadeOnDelete(false);

            HasRequired(d => d.Mal)
                .WithMany(p => p.TohalStokHareketis)
                .HasForeignKey(d => d.MalId)
                .WillCascadeOnDelete(false);

            HasOptional(d => d.StokKunye)
                .WithMany(p => p.TohalStokHareketiStokKunyes)
                .HasForeignKey(d => d.StokKunyeId);
        }
    }
}
