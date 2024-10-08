using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalDokumSatiriHksIstekConfiguration : EntityTypeConfiguration<VohalDokumSatiriHksIstek>
    {
        public VohalDokumSatiriHksIstekConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_DOKUM_SATIRI_HKS_ISTEK");

            Property(e => e.BeldeHksId).HasColumnName("BELDE_HKS_ID");

            Property(e => e.Birim).HasColumnName("BIRIM");

            Property(e => e.CariDi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CARI_DI");

            Property(e => e.EPosta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("E_POSTA");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.GsmNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("GSM_NO");

            Property(e => e.HksId).HasColumnName("HKS_ID");

            Property(e => e.HksUretimSekli).HasColumnName("HKS_URETIM_SEKLI");

            Property(e => e.IlHksId).HasColumnName("IL_HKS_ID");

            Property(e => e.IlceHksId).HasColumnName("ILCE_HKS_ID");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.Miktar).HasColumnName("MIKTAR");

            Property(e => e.Plaka)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PLAKA");

            Property(e => e.Sifati).HasColumnName("SIFATI");

            Property(e => e.StokHareketiId).HasColumnName("STOK_HAREKETI_ID");

            Property(e => e.StokKunye)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STOK_KUNYE")
                .IsFixedLength();

            Property(e => e.StokKunyeId).HasColumnName("STOK_KUNYE_ID");

            Property(e => e.TeslimatYeri)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("TESLIMAT_YERI");

            Property(e => e.TeslimatYeriHksId).HasColumnName("TESLIMAT_YERI_HKS_ID");

            Property(e => e.TeslimatYeriId).HasColumnName("TESLIMAT_YERI_ID");

            Property(e => e.TeslimatYeriTipi).HasColumnName("TESLIMAT_YERI_TIPI");

            Property(e => e.UrunHksId).HasColumnName("URUN_HKS_ID");

            Property(e => e.UrunHksKodu).HasColumnName("URUN_HKS_KODU");

            Property(e => e.VergiKimlikNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VERGI_KIMLIK_NO")
                .IsFixedLength();
        }
    }
}
