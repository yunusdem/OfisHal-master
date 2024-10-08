using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class VohalRehinFisiConfiguration : EntityTypeConfiguration<VohalRehinFisi>
    {
        public VohalRehinFisiConfiguration()
        {
            HasKey(e => new { e.FaturaId, e.SatirNo });
            //HasNoKey();

            ToTable("VOHAL_REHIN_FISI");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.ElleDegistirildi).HasColumnName("ELLE_DEGISTIRILDI");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.FaturaTarihi)
                .HasColumnType("datetime")
                .HasColumnName("FATURA_TARIHI");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.GonderenAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("GONDEREN_ADI");

            Property(e => e.GonderenId).HasColumnName("GONDEREN_ID");

            Property(e => e.GonderenKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GONDEREN_KODU")
                .IsFixedLength();

            Property(e => e.Guid)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("GUID");

            Property(e => e.Iadeli).HasColumnName("IADELI");

            Property(e => e.KapAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("KAP_ADI");

            Property(e => e.KapId).HasColumnName("KAP_ID");

            Property(e => e.KapKodu)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAP_KODU")
                .IsFixedLength();

            Property(e => e.KapMiktari).HasColumnName("KAP_MIKTARI");

            Property(e => e.Marka)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MARKA");

            Property(e => e.MarkaId).HasColumnName("MARKA_ID");

            Property(e => e.RehinFisiId).HasColumnName("REHIN_FISI_ID");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.Tutar).HasColumnName("TUTAR");
        }
    }
}
