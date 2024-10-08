using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalFiConfiguration : EntityTypeConfiguration<TohalFi>
    {
        public TohalFiConfiguration()
        {
            HasKey(e => e.FisId);

            ToTable("TOHAL_FIS");

            Property(e => e.FisId).HasColumnName("FIS_ID");

            Property(e => e.Aciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.FisNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FIS_NO")
                .IsFixedLength();

            Property(e => e.GuncellemeZamani)
                .HasColumnType("datetime")
                .HasColumnName("GUNCELLEME_ZAMANI");

            Property(e => e.KayitsizMusteriId).HasColumnName("KAYITSIZ_MUSTERI_ID");

            Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            Property(e => e.OdemeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("ODEME_TARIHI");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.Tip).HasColumnName("TIP");

            Property(e => e.Unvan)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNVAN");

            HasOptional(d => d.CariKart)
                .WithMany(p => p.TohalFis)
                .HasForeignKey(d => d.CariKartId);

            HasOptional(d => d.KayitsizMusteri)
                .WithMany(p => p.TohalFis)
                .HasForeignKey(d => d.KayitsizMusteriId);

            HasRequired(d => d.Kullanici)
                .WithMany(p => p.TohalFis)
                .HasForeignKey(d => d.KullaniciId)
                .WillCascadeOnDelete(false);
        }
    }
}
