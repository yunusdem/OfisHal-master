using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalOdemeBordrosuConfiguration : EntityTypeConfiguration<TohalOdemeBordrosu>
    {
        public TohalOdemeBordrosuConfiguration()
        {
            HasKey(e => e.OdemeBordrosuId);

            ToTable("TOHAL_ODEME_BORDROSU");

            Property(e => e.OdemeBordrosuId).HasColumnName("ODEME_BORDROSU_ID");

            Property(e => e.Aciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.BankaHesabiId).HasColumnName("BANKA_HESABI_ID");

            Property(e => e.BordroNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BORDRO_NO")
                .IsFixedLength();

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.Devir).HasColumnName("DEVIR");

            Property(e => e.EklemeZamani)
                .HasColumnType("datetime")
                .HasColumnName("EKLEME_ZAMANI");

            Property(e => e.EkleyenId).HasColumnName("EKLEYEN_ID");

            Property(e => e.GuncellemeZamani)
                .HasColumnType("datetime")
                .HasColumnName("GUNCELLEME_ZAMANI");

            Property(e => e.GuncelleyenId).HasColumnName("GUNCELLEYEN_ID");

            Property(e => e.IslemTuru).HasColumnName("ISLEM_TURU");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            HasOptional(d => d.BankaHesabi)
                .WithMany(p => p.TohalOdemeBordrosus)
                .HasForeignKey(d => d.BankaHesabiId);

            HasOptional(d => d.CariKart)
                .WithMany(p => p.TohalOdemeBordrosus)
                .HasForeignKey(d => d.CariKartId);

            HasRequired(d => d.Ekleyen)
                .WithMany(p => p.TohalOdemeBordrosuEkleyens)
                .HasForeignKey(d => d.EkleyenId)
                .WillCascadeOnDelete(false);

            HasRequired(d => d.Guncelleyen)
                .WithMany(p => p.TohalOdemeBordrosuGuncelleyens)
                .HasForeignKey(d => d.GuncelleyenId)
                .WillCascadeOnDelete(false);
        }
    }
}
