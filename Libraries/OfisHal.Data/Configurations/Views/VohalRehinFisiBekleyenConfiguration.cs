using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Core.Domain.Configurations
{
    internal class VohalRehinFisiBekleyenConfiguration : EntityTypeConfiguration<VohalRehinFisiBekleyen>
    {
        public VohalRehinFisiBekleyenConfiguration()
        {
            //HasNoKey();
            HasKey(e => e.RehinFisiId);
            ToTable("VOHAL_REHIN_FISI_BEKLEYEN");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.FaturaTipi).HasColumnName("FATURA_TIPI");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.KalanMiktar).HasColumnName("KALAN_MIKTAR");

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

            Property(e => e.MusteriAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MUSTERI_ADI");

            Property(e => e.MusteriKodu)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MUSTERI_KODU")
                .IsFixedLength();

            Property(e => e.RefNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("REF_NO");

            Property(e => e.RehinFisiId).HasColumnName("REHIN_FISI_ID");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.Tutar).HasColumnName("TUTAR");

            Property(e => e.Veresiye).HasColumnName("VERESIYE");
        }
    }
}
