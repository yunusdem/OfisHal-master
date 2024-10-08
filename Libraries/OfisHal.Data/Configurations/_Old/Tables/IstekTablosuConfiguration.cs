using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class IstekTablosuConfiguration : EntityTypeConfiguration<IstekTablosu>
    {
        public IstekTablosuConfiguration()
        {
            HasKey(e => new { e.IstekZamani, e.ProgramId, e.EvrakTuru, e.EvrakId, e.IslemTuru, e.SiraNo });

            ToTable("ISTEK_TABLOSU");

            HasIndex(e => e.Guid);

            Property(e => e.IstekZamani)
                .HasColumnType("datetime")
                .HasColumnName("ISTEK_ZAMANI");

            Property(e => e.ProgramId).HasColumnName("PROGRAM_ID");

            Property(e => e.EvrakTuru).HasColumnName("EVRAK_TURU");

            Property(e => e.EvrakId).HasColumnName("EVRAK_ID");

            Property(e => e.IslemTuru).HasColumnName("ISLEM_TURU");

            Property(e => e.SiraNo).HasColumnName("SIRA_NO");

            Property(e => e.BelediyeAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BELEDIYE_ADI");

            Property(e => e.Durum).HasColumnName("DURUM");

            Property(e => e.Guid).HasColumnName("GUID");

            Property(e => e.HataMesaji)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasColumnName("HATA_MESAJI");

            Property(e => e.HksKullaniciAdi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HKS_KULLANICI_ADI");

            Property(e => e.HksServisSifresi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HKS_SERVIS_SIFRESI");

            Property(e => e.HksSifre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HKS_SIFRE");

            Property(e => e.IslemeAlinmaZamani)
                .HasColumnType("datetime")
                .HasColumnName("ISLEME_ALINMA_ZAMANI");

            Property(e => e.Istek)
                .IsRequired()
                .IsUnicode(false)
                .HasColumnName("ISTEK");

            Property(e => e.VeriTabaniAdi)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VERI_TABANI_ADI");

            Property(e => e.XmlVersiyon)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("XML_VERSIYON");
        }
    }
}
