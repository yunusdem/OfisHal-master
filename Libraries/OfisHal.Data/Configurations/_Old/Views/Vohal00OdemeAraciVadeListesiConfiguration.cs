using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class Vohal00OdemeAraciVadeListesiConfiguration : EntityTypeConfiguration<Vohal00OdemeAraciVadeListesi>
    {
        public Vohal00OdemeAraciVadeListesiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_00_ODEME_ARACI_VADE_LISTESI");

            Property(e => e.Banka)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BANKA");

            Property(e => e.BankaId).HasColumnName("BANKA_ID");

            Property(e => e.CariAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CARI_ADI");

            Property(e => e.IslemTuru).HasColumnName("ISLEM_TURU");

            Property(e => e.Meblag).HasColumnName("MEBLAG");

            Property(e => e.OdemeAraciId).HasColumnName("ODEME_ARACI_ID");

            Property(e => e.OdemeAraciNo)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ODEME_ARACI_NO")
                .IsFixedLength();

            Property(e => e.OdemeAraciTuru)
                .IsRequired()
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("ODEME_ARACI_TURU");

            Property(e => e.Tur).HasColumnName("TUR");

            Property(e => e.VadeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("VADE_TARIHI");
        }
    }
}
