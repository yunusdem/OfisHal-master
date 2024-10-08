using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalKayitsizMusteriConfiguration : EntityTypeConfiguration<VohalKayitsizMusteri>
    {
        public VohalKayitsizMusteriConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_KAYITSIZ_MUSTERI");

            Property(e => e.Adres)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ADRES");

            Property(e => e.BeldeAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BELDE_ADI");

            Property(e => e.BeldeId).HasColumnName("BELDE_ID");

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

            Property(e => e.HalAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HAL_ADI");

            Property(e => e.HalId).HasColumnName("HAL_ID");

            Property(e => e.HksBilgisiAlindi).HasColumnName("HKS_BILGISI_ALINDI");

            Property(e => e.HksId).HasColumnName("HKS_ID");

            Property(e => e.Ihracatci).HasColumnName("IHRACATCI");

            Property(e => e.IlAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IL_ADI");

            Property(e => e.IlId).HasColumnName("IL_ID");

            Property(e => e.IlceAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ILCE_ADI");

            Property(e => e.IlceId).HasColumnName("ILCE_ID");

            Property(e => e.KayitsizMusteriId).HasColumnName("KAYITSIZ_MUSTERI_ID");

            Property(e => e.KisilikTipi).HasColumnName("KISILIK_TIPI");

            Property(e => e.Komisyoncu).HasColumnName("KOMISYONCU");

            Property(e => e.PlakaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PLAKA_NO")
                .IsFixedLength();

            Property(e => e.Sehir)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SEHIR");

            Property(e => e.SehirId).HasColumnName("SEHIR_ID");

            Property(e => e.Sifati).HasColumnName("SIFATI");

            Property(e => e.Unvan)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNVAN");

            Property(e => e.VergiDairesi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("VERGI_DAIRESI");

            Property(e => e.VergiDairesiId).HasColumnName("VERGI_DAIRESI_ID");

            Property(e => e.VergiKimlikNo)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VERGI_KIMLIK_NO")
                .IsFixedLength();
        }
    }
}
