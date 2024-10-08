using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class VohalMagazaConfiguration : EntityTypeConfiguration<VohalMagaza>
    {
        public VohalMagazaConfiguration()
        {
            HasKey(e => e.MagazaId);
            //HasNoKey();

            ToTable("VOHAL_MAGAZA");

            Property(e => e.Ad)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.Adres)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ADRES");

            Property(e => e.BeldeAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BELDE_ADI");

            Property(e => e.BeldeHksId).HasColumnName("BELDE_HKS_ID");

            Property(e => e.BeldeId).HasColumnName("BELDE_ID");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.CariSifati).HasColumnName("CARI_SIFATI");

            Property(e => e.EFaturaBolgeKodu)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_BOLGE_KODU");

            Property(e => e.EIrsaliyePostaKutusu)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("E_IRSALIYE_POSTA_KUTUSU");

            Property(e => e.EIrsaliyePostaKutusuId).HasColumnName("E_IRSALIYE_POSTA_KUTUSU_ID");

            Property(e => e.EnCokKullanilan).HasColumnName("EN_COK_KULLANILAN");

            Property(e => e.Faks)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FAKS");

            Property(e => e.GidecegiYer).HasColumnName("GIDECEGI_YER");

            Property(e => e.GidecegiYerWebSiraNo).HasColumnName("GIDECEGI_YER_WEB_SIRA_NO");

            Property(e => e.HksId).HasColumnName("HKS_ID");

            Property(e => e.IlAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IL_ADI");

            Property(e => e.IlHksId).HasColumnName("IL_HKS_ID");

            Property(e => e.IlId).HasColumnName("IL_ID");

            Property(e => e.IlceAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ILCE_ADI");

            Property(e => e.IlceHksId).HasColumnName("ILCE_HKS_ID");

            Property(e => e.IlceId).HasColumnName("ILCE_ID");

            Property(e => e.Kod)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KOD")
                .IsFixedLength();

            Property(e => e.MagazaId).HasColumnName("MAGAZA_ID");

            Property(e => e.PlakaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PLAKA_NO")
                .IsFixedLength();

            Property(e => e.PostaKodu)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("POSTA_KODU");

            Property(e => e.PostaKoduId).HasColumnName("POSTA_KODU_ID");

            Property(e => e.Tel1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TEL1");

            Property(e => e.Tel2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TEL2");
        }
    }
}
