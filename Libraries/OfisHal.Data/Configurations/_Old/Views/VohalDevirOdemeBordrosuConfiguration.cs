using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalDevirOdemeBordrosuConfiguration : EntityTypeConfiguration<VohalDevirOdemeBordrosu>
    {
        public VohalDevirOdemeBordrosuConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_DEVIR_ODEME_BORDROSU");

            Property(e => e.Aciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.BankaHesabiId).HasColumnName("BANKA_HESABI_ID");

            Property(e => e.BankaId).HasColumnName("BANKA_ID");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.IslemTuru).HasColumnName("ISLEM_TURU");

            Property(e => e.Meblag).HasColumnName("MEBLAG");

            Property(e => e.OdemeAraciId).HasColumnName("ODEME_ARACI_ID");

            Property(e => e.OdemeAraciNo)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ODEME_ARACI_NO")
                .IsFixedLength();

            Property(e => e.SatirAciklama)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SATIR_ACIKLAMA");

            Property(e => e.SonIslemBankaHesabiId).HasColumnName("SON_ISLEM_BANKA_HESABI_ID");

            Property(e => e.SonIslemTuru).HasColumnName("SON_ISLEM_TURU");

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
