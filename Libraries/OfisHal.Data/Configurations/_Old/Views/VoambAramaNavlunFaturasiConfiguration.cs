using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VoambAramaNavlunFaturasiConfiguration : EntityTypeConfiguration<VoambAramaNavlunFaturasi>
    {
        public VoambAramaNavlunFaturasiConfiguration()
        {
            //HasNoKey();

            ToTable("VOAMB_ARAMA_NAVLUN_FATURASI");

            Property(e => e.BolgeKodu)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BOLGE_KODU");

            Property(e => e.BolgeKoduId).HasColumnName("BOLGE_KODU_ID");

            Property(e => e.DizaynAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DIZAYN_ADI");

            Property(e => e.DizaynId).HasColumnName("DIZAYN_ID");

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.FaturaTarihi)
                .HasColumnType("datetime")
                .HasColumnName("FATURA_TARIHI");

            Property(e => e.Kesildi).HasColumnName("KESILDI");

            Property(e => e.NavlunFaturasiId).HasColumnName("NAVLUN_FATURASI_ID");

            Property(e => e.YazihaneAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("YAZIHANE_ADI");

            Property(e => e.YazihaneId).HasColumnName("YAZIHANE_ID");

            Property(e => e.YazihaneKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("YAZIHANE_KODU")
                .IsFixedLength();

            Property(e => e.YazihaneSiraNo).HasColumnName("YAZIHANE_SIRA_NO");
        }
    }
}
