using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Core.Domain.Configurations
{
    internal class VohalAramaOdemeAraciConfiguration : EntityTypeConfiguration<VohalAramaOdemeAraci>
    {
        public VohalAramaOdemeAraciConfiguration()
        {
            //HasNoKey();
            HasKey(x => x.OdemeAraciId);
            ToTable("VOHAL_ARAMA_ODEME_ARACI");

            Property(e => e.BankaAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BANKA_ADI");

            Property(e => e.BankaHesabiId).HasColumnName("BANKA_HESABI_ID");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.CekBankaHesabiId).HasColumnName("CEK_BANKA_HESABI_ID");

            Property(e => e.Durum)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DURUM");

            Property(e => e.HesapAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HESAP_ADI");

            Property(e => e.IslemTuru).HasColumnName("ISLEM_TURU");

            Property(e => e.Meblag).HasColumnName("MEBLAG");

            Property(e => e.OdemeAraciId).HasColumnName("ODEME_ARACI_ID");

            Property(e => e.OdemeAraciNo)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ODEME_ARACI_NO")
                .IsFixedLength();

            Property(e => e.SonrakiBordroId).HasColumnName("SONRAKI_BORDRO_ID");

            Property(e => e.Tur).HasColumnName("TUR");

            Property(e => e.VadeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("VADE_TARIHI");

            Property(e => e.Veren)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("VEREN");

            Property(e => e.VerenId).HasColumnName("VEREN_ID");
        }
    }
}
