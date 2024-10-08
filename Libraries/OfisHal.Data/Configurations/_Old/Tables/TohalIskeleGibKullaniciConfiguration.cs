using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class TohalIskeleGibKullaniciConfiguration : EntityTypeConfiguration<TohalIskeleGibKullanici>
    {
        public TohalIskeleGibKullaniciConfiguration()
        {
            //HasNoKey();

            ToTable("TOHAL_ISKELE_GIB_KULLANICI");

            HasIndex(e => new { e.Vkn, e.PkTipi, e.PostaKutusu, e.DokumanTipi });

            Property(e => e.DokumanTipi).HasColumnName("DOKUMAN_TIPI");

            Property(e => e.IslemZamani)
                .HasColumnType("datetime")
                .HasColumnName("ISLEM_ZAMANI");

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
