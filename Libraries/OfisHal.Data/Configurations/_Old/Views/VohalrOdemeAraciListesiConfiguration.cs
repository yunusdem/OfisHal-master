using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrOdemeAraciListesiConfiguration : EntityTypeConfiguration<VohalrOdemeAraciListesi>
    {
        public VohalrOdemeAraciListesiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_ODEME_ARACI_LISTESI");

            Property(e => e.Aciklama)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.BankaAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BANKA_ADI");

            Property(e => e.BankaId).HasColumnName("BANKA_ID");

            Property(e => e.Durum)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DURUM");

            Property(e => e.IslemTuru).HasColumnName("ISLEM_TURU");

            Property(e => e.Meblag).HasColumnName("MEBLAG");

            Property(e => e.OdemeAraciId).HasColumnName("ODEME_ARACI_ID");

            Property(e => e.OdemeAraciNo)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ODEME_ARACI_NO")
                .IsFixedLength();

            Property(e => e.SahibiId).HasColumnName("SAHIBI_ID");

            Property(e => e.SahibininAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SAHIBININ_ADI");

            Property(e => e.SahibininKodu)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SAHIBININ_KODU")
                .IsFixedLength();

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.Tur).HasColumnName("TUR");

            Property(e => e.VadeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("VADE_TARIHI");
        }
    }
}
