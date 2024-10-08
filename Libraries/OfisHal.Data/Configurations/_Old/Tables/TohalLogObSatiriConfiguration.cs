using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class TohalLogObSatiriConfiguration : EntityTypeConfiguration<TohalLogObSatiri>
    {
        public TohalLogObSatiriConfiguration()
        {
            //HasNoKey();

            ToTable("TOHAL_LOG_OB_SATIRI");

            Property(e => e.Islem).HasColumnName("ISLEM");

            Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            Property(e => e.OBankaHesabiId).HasColumnName("O_BANKA_HESABI_ID");

            Property(e => e.OBankaId).HasColumnName("O_BANKA_ID");

            Property(e => e.OBaskasinaAit).HasColumnName("O_BASKASINA_AIT");

            Property(e => e.OMeblag).HasColumnName("O_MEBLAG");

            Property(e => e.OOdemeAraciNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("O_ODEME_ARACI_NO")
                .IsFixedLength();

            Property(e => e.OOdemeAraciSahibi).HasColumnName("O_ODEME_ARACI_SAHIBI");

            Property(e => e.OSonrakiBordroId).HasColumnName("O_SONRAKI_BORDRO_ID");

            Property(e => e.OTur).HasColumnName("O_TUR");

            Property(e => e.OVadeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("O_VADE_TARIHI");

            Property(e => e.OdemeAraciId).HasColumnName("ODEME_ARACI_ID");

            Property(e => e.OdemeBordrosuId).HasColumnName("ODEME_BORDROSU_ID");

            Property(e => e.SBankaHesabiId).HasColumnName("S_BANKA_HESABI_ID");

            Property(e => e.SBankaId).HasColumnName("S_BANKA_ID");

            Property(e => e.SBaskasinaAit).HasColumnName("S_BASKASINA_AIT");

            Property(e => e.SMeblag).HasColumnName("S_MEBLAG");

            Property(e => e.SOdemeAraciNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("S_ODEME_ARACI_NO")
                .IsFixedLength();

            Property(e => e.SOdemeAraciSahibi).HasColumnName("S_ODEME_ARACI_SAHIBI");

            Property(e => e.SSonrakiBordroId).HasColumnName("S_SONRAKI_BORDRO_ID");

            Property(e => e.STur).HasColumnName("S_TUR");

            Property(e => e.SVadeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("S_VADE_TARIHI");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.Zaman)
                .HasColumnType("datetime")
                .HasColumnName("ZAMAN");
        }
    }
}
