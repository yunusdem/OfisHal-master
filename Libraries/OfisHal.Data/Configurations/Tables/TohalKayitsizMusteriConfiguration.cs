using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalKayitsizMusteriConfiguration : EntityTypeConfiguration<TohalKayitsizMusteri>
    {
        public TohalKayitsizMusteriConfiguration()
        {
            HasKey(e => e.KayitsizMusteriId, e => e.IsClustered(false));

            ToTable("TOHAL_KAYITSIZ_MUSTERI");

            HasIndex(e => e.VergiKimlikNo)
                .IsUnique();

            Property(e => e.KayitsizMusteriId).HasColumnName("KAYITSIZ_MUSTERI_ID");

            Property(e => e.Adres)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ADRES");

            Property(e => e.BildirimTuru).HasColumnName("BILDIRIM_TURU");

            Property(e => e.CariSifati).HasColumnName("CARI_SIFATI");

            Property(e => e.EPosta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("E_POSTA");

            Property(e => e.GidecegiYerTipi).HasColumnName("GIDECEGI_YER_TIPI");

            Property(e => e.GidecegiYerWebSiraNo).HasColumnName("GIDECEGI_YER_WEB_SIRA_NO");

            Property(e => e.GsmNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GSM_NO");

            Property(e => e.HalId).HasColumnName("HAL_ID");

            Property(e => e.HksBilgisiAlindi).HasColumnName("HKS_BILGISI_ALINDI");

            Property(e => e.HksId).HasColumnName("HKS_ID");

            Property(e => e.Ihracatci).HasColumnName("IHRACATCI");

            Property(e => e.KisilikTipi).HasColumnName("KISILIK_TIPI");

            Property(e => e.Komisyoncu).HasColumnName("KOMISYONCU");

            Property(e => e.PlakaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PLAKA_NO")
                .IsFixedLength();

            Property(e => e.SehirId).HasColumnName("SEHIR_ID");

            Property(e => e.Sifati).HasColumnName("SIFATI");

            Property(e => e.Unvan)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNVAN");

            Property(e => e.VergiDairesiId).HasColumnName("VERGI_DAIRESI_ID");

            Property(e => e.VergiKimlikNo)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VERGI_KIMLIK_NO")
                .IsFixedLength();

            Property(e => e.YerId).HasColumnName("YER_ID");

            HasOptional(d => d.Hal)
                .WithMany(p => p.TohalKayitsizMusteris)
                .HasForeignKey(d => d.HalId);

            HasOptional(d => d.Sehir)
                .WithMany(p => p.TohalKayitsizMusteriSehirs)
                .HasForeignKey(d => d.SehirId);

            HasOptional(d => d.VergiDairesi)
                .WithMany(p => p.TohalKayitsizMusteriVergiDairesis)
                .HasForeignKey(d => d.VergiDairesiId);

            HasOptional(d => d.Yer)
                .WithMany(p => p.TohalKayitsizMusteris)
                .HasForeignKey(d => d.YerId);
        }
    }
}
