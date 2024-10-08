using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalAnkaraHalSatisBildirimiConfiguration : EntityTypeConfiguration<VohalAnkaraHalSatisBildirimi>
    {
        public VohalAnkaraHalSatisBildirimiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_ANKARA_HAL_SATIS_BILDIRIMI");

            Property(e => e.Belde)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BELDE");

            Property(e => e.BildirimDurumu).HasColumnName("BILDIRIM_DURUMU");

            Property(e => e.Birim).HasColumnName("BIRIM");

            Property(e => e.DokumNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DOKUM_NO")
                .IsFixedLength();

            Property(e => e.DokumSatirNo).HasColumnName("DOKUM_SATIR_NO");

            Property(e => e.DonenAlanDegeri)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DONEN_ALAN_DEGERI");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.Il)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IL");

            Property(e => e.Ilce)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ILCE");

            Property(e => e.KunyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KUNYE_NO")
                .IsFixedLength();

            Property(e => e.Miktar).HasColumnName("MIKTAR");

            Property(e => e.PlakaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PLAKA_NO")
                .IsFixedLength();

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.Siralama).HasColumnName("SIRALAMA");

            Property(e => e.StokGirisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("STOK_GIRIS_TARIHI");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.UrunAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("URUN_ADI");
        }
    }
}
