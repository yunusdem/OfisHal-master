using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrNavlunKarsilastirmaRaporuConfiguration : EntityTypeConfiguration<VohalrNavlunKarsilastirmaRaporu>
    {
        public VohalrNavlunKarsilastirmaRaporuConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_NAVLUN_KARSILASTIRMA_RAPORU");

            Property(e => e.CariAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CARI_ADI");

            Property(e => e.CariKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CARI_KODU")
                .IsFixedLength();

            Property(e => e.DokumNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DOKUM_NO")
                .IsFixedLength();

            Property(e => e.IrsaliyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IRSALIYE_NO")
                .IsFixedLength();

            Property(e => e.KurusSayisi).HasColumnName("KURUS_SAYISI");

            Property(e => e.Marka)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MARKA");

            Property(e => e.Navlun).HasColumnName("NAVLUN");

            Property(e => e.OdemeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("ODEME_TARIHI");

            Property(e => e.OdenenNavlun).HasColumnName("ODENEN_NAVLUN");

            Property(e => e.StokGirisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("STOK_GIRIS_TARIHI");
        }
    }
}
