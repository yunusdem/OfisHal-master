using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalGibKullaniciConfiguration : EntityTypeConfiguration<TohalGibKullanici>
    {
        public TohalGibKullaniciConfiguration()
        {
            HasKey(e => e.GibKullaniciId, e => e.IsClustered(false));

            ToTable("TOHAL_GIB_KULLANICI");

            HasIndex(e => new { e.Vkn, e.PkTipi, e.PostaKutusu, e.DokumanTipi })
                .IsUnique();

            Property(e => e.GibKullaniciId).HasColumnName("GIB_KULLANICI_ID");

            Property(e => e.DokumanTipi).HasColumnName("DOKUMAN_TIPI");

            Property(e => e.KayitSekli).HasColumnName("KAYIT_SEKLI");

            Property(e => e.KayitZamani)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_ZAMANI");

            Property(e => e.PkTipi).HasColumnName("PK_TIPI");

            Property(e => e.PostaKutusu)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("POSTA_KUTUSU")
                /*.UseCollation("SQL_Latin1_General_CP1254_CS_AS")*/;

            Property(e => e.Silindi).HasColumnName("SILINDI");

            Property(e => e.Tip).HasColumnName("TIP");

            Property(e => e.Unvan)
                .IsRequired()
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("UNVAN");

            Property(e => e.Vkn)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VKN")
                .IsFixedLength();
        }
    }
}
