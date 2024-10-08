using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalBankaHareketiConfiguration : EntityTypeConfiguration<TohalBankaHareketi>
    {
        public TohalBankaHareketiConfiguration()
        {
            HasKey(e => e.BankaHareketiId);

            ToTable("TOHAL_BANKA_HAREKETI");

            Property(e => e.BankaHareketiId).HasColumnName("BANKA_HAREKETI_ID");

            Property(e => e.Aciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.BankaHesabiId).HasColumnName("BANKA_HESABI_ID");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.EklemeZamani)
                .HasColumnType("datetime")
                .HasColumnName("EKLEME_ZAMANI");

            Property(e => e.EkleyenId).HasColumnName("EKLEYEN_ID");

            Property(e => e.GuncellemeZamani)
                .HasColumnType("datetime")
                .HasColumnName("GUNCELLEME_ZAMANI");

            Property(e => e.GuncelleyenId).HasColumnName("GUNCELLEYEN_ID");

            Property(e => e.HesapId).HasColumnName("HESAP_ID");

            Property(e => e.IslemTipi).HasColumnName("ISLEM_TIPI");

            Property(e => e.KarsiBankaHesabiId).HasColumnName("KARSI_BANKA_HESABI_ID");

            Property(e => e.Meblag).HasColumnName("MEBLAG");

            Property(e => e.PosCihaziId).HasColumnName("POS_CIHAZI_ID");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            HasOptional(d => d.BankaHesabi)
                .WithMany(p => p.TohalBankaHareketiBankaHesabis)
                .HasForeignKey(d => d.BankaHesabiId);

            HasOptional(d => d.CariKart)
                .WithMany(p => p.TohalBankaHareketis)
                .HasForeignKey(d => d.CariKartId);

            HasRequired(d => d.Ekleyen)
                .WithMany(p => p.TohalBankaHareketiEkleyens)
                .HasForeignKey(d => d.EkleyenId)
                .WillCascadeOnDelete(false);

            HasOptional(d => d.Guncelleyen)
                .WithMany(p => p.TohalBankaHareketiGuncelleyens)
                .HasForeignKey(d => d.GuncelleyenId);

            HasOptional(d => d.Hesap)
                .WithMany(p => p.TohalBankaHareketis)
                .HasForeignKey(d => d.HesapId);

            HasOptional(d => d.KarsiBankaHesabi)
                .WithMany(p => p.TohalBankaHareketiKarsiBankaHesabis)
                .HasForeignKey(d => d.KarsiBankaHesabiId);

            HasOptional(d => d.PosCihazi)
                .WithMany(p => p.TohalBankaHareketis)
                .HasForeignKey(d => d.PosCihaziId);
        }
    }
}
