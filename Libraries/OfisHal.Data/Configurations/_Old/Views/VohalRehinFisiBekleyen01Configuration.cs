using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalRehinFisiBekleyen01Configuration : EntityTypeConfiguration<VohalRehinFisiBekleyen01>
    {
        public VohalRehinFisiBekleyen01Configuration()
        {
            //HasNoKey();

            ToTable("VOHAL_REHIN_FISI_BEKLEYEN_01");

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

            Property(e => e.KapKodu).HasColumnName("KAP_KODU");

            Property(e => e.KapMiktari).HasColumnName("KAP_MIKTARI");

            Property(e => e.Marka).HasColumnName("MARKA");

            Property(e => e.RefNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("REF_NO");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
        }
    }
}
