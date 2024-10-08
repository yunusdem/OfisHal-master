using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalMagazaConfiguration : EntityTypeConfiguration<TohalMagaza>
    {
        public TohalMagazaConfiguration()
        {
            HasKey(e => e.MagazaId);

            ToTable("TOHAL_MAGAZA");

            Property(e => e.MagazaId).HasColumnName("MAGAZA_ID");

            Property(e => e.Ad)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.Adres)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ADRES");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.CariSifati).HasColumnName("CARI_SIFATI");

            Property(e => e.EFaturaBolgeKodu)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_BOLGE_KODU");

            Property(e => e.EIrsaliyePostaKutusuId).HasColumnName("E_IRSALIYE_POSTA_KUTUSU_ID");

            Property(e => e.EnCokKullanilan).HasColumnName("EN_COK_KULLANILAN");

            Property(e => e.Faks)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FAKS");

            Property(e => e.GidecegiYer).HasColumnName("GIDECEGI_YER");

            Property(e => e.GidecegiYerWebSiraNo).HasColumnName("GIDECEGI_YER_WEB_SIRA_NO");

            Property(e => e.HksId).HasColumnName("HKS_ID");

            Property(e => e.Kod)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KOD")
                .IsFixedLength();

            Property(e => e.PlakaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PLAKA_NO")
                .IsFixedLength();

            Property(e => e.PostaKoduId).HasColumnName("POSTA_KODU_ID");

            Property(e => e.SehirId).HasColumnName("SEHIR_ID");

            Property(e => e.Tel1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TEL1");

            Property(e => e.Tel2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TEL2");

            Property(e => e.YerId).HasColumnName("YER_ID");

            HasRequired(d => d.CariKart)
                .WithMany(p => p.TohalMagazas)
                .HasForeignKey(d => d.CariKartId)
                .WillCascadeOnDelete(false);

            HasOptional(d => d.EIrsaliyePostaKutusu)
                .WithMany(p => p.TohalMagazas)
                .HasForeignKey(d => d.EIrsaliyePostaKutusuId);

            HasOptional(d => d.PostaKodu)
                .WithMany(p => p.TohalMagazaPostaKodus)
                .HasForeignKey(d => d.PostaKoduId);

            HasOptional(d => d.Sehir)
                .WithMany(p => p.TohalMagazaSehirs)
                .HasForeignKey(d => d.SehirId);

            HasOptional(d => d.Yer)
                .WithMany(p => p.TohalMagazas)
                .HasForeignKey(d => d.YerId);
        }
    }
}
