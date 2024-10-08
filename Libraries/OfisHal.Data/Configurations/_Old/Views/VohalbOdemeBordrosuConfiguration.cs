using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalbOdemeBordrosuConfiguration : EntityTypeConfiguration<VohalbOdemeBordrosu>
    {
        public VohalbOdemeBordrosuConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALB_ODEME_BORDROSU");

            Property(e => e.Aciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.Ad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.Adres)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ADRES");

            Property(e => e.BankaAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BANKA_ADI");

            Property(e => e.BordroNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BORDRO_NO")
                .IsFixedLength();

            Property(e => e.CariTipi).HasColumnName("CARI_TIPI");

            Property(e => e.IslemTuru).HasColumnName("ISLEM_TURU");

            Property(e => e.Kod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KOD")
                .IsFixedLength();

            Property(e => e.Meblag).HasColumnName("MEBLAG");

            Property(e => e.OdemeAraciNo)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ODEME_ARACI_NO")
                .IsFixedLength();

            Property(e => e.OdemeAraciTuru).HasColumnName("ODEME_ARACI_TURU");

            Property(e => e.OdemeBordrosuId).HasColumnName("ODEME_BORDROSU_ID");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.VadeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("VADE_TARIHI");
        }
    }
}
