using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalAdanaHalSatisBildirimiConfiguration : EntityTypeConfiguration<VohalAdanaHalSatisBildirimi>
    {
        public VohalAdanaHalSatisBildirimiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_ADANA_HAL_SATIS_BILDIRIMI");

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.FaturaTarihi)
                .HasColumnType("datetime")
                .HasColumnName("FATURA_TARIHI");

            Property(e => e.FirmaKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FIRMA_KODU")
                .IsFixedLength();

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.HksCinsId).HasColumnName("HKS_CINS_ID");

            Property(e => e.HksTurId).HasColumnName("HKS_TUR_ID");

            Property(e => e.HksUrunId).HasColumnName("HKS_URUN_ID");

            Property(e => e.MT)
                .IsRequired()
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("M_T");

            Property(e => e.MalAlisKunyesi)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MAL_ALIS_KUNYESI")
                .IsFixedLength();

            Property(e => e.MalSatisKunyesi)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MAL_SATIS_KUNYESI")
                .IsFixedLength();

            Property(e => e.MustahsilAdi)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("MUSTAHSIL_ADI");

            Property(e => e.MustahsilKimlikNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MUSTAHSIL_KIMLIK_NO")
                .IsFixedLength();

            Property(e => e.MusteriAdi)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("MUSTERI_ADI");

            Property(e => e.MusteriSehir)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MUSTERI_SEHIR");

            Property(e => e.MusteriVergiNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MUSTERI_VERGI_NO")
                .IsFixedLength();

            Property(e => e.Parca).HasColumnName("PARCA");

            Property(e => e.Plaka)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PLAKA")
                .IsFixedLength();

            Property(e => e.Safi).HasColumnName("SAFI");

            Property(e => e.Sifre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SIFRE");

            Property(e => e.Sifreniz)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SIFRENIZ");

            Property(e => e.TukIl)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("TUK_IL");

            Property(e => e.TukIlce)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("TUK_ILCE");

            Property(e => e.TukYeri)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("TUK_YERI");

            Property(e => e.Tutar).HasColumnName("TUTAR");

            Property(e => e.UreticiBelde)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("URETICI_BELDE");

            Property(e => e.UreticiIl)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("URETICI_IL");

            Property(e => e.UreticiIlce)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("URETICI_ILCE");

            Property(e => e.UrunKodu)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("URUN_KODU")
                .IsFixedLength();
        }
    }
}
