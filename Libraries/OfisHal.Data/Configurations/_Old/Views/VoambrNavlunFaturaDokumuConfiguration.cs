using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VoambrNavlunFaturaDokumuConfiguration : EntityTypeConfiguration<VoambrNavlunFaturaDokumu>
    {
        public VoambrNavlunFaturaDokumuConfiguration()
        {
            //HasNoKey();

            ToTable("VOAMBR_NAVLUN_FATURA_DOKUMU");

            Property(e => e.Adet).HasColumnName("ADET");

            Property(e => e.BolgeKodu)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BOLGE_KODU");

            Property(e => e.BolgeKoduId).HasColumnName("BOLGE_KODU_ID");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.DizaynAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DIZAYN_ADI");

            Property(e => e.DizaynId).HasColumnName("DIZAYN_ID");

            Property(e => e.DosyaAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DOSYA_ADI");

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.FaturaTarihi)
                .HasColumnType("datetime")
                .HasColumnName("FATURA_TARIHI");

            Property(e => e.NavlunFaturasiId).HasColumnName("NAVLUN_FATURASI_ID");

            Property(e => e.Tutar).HasColumnName("TUTAR");

            Property(e => e.Yazihane)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("YAZIHANE");

            Property(e => e.YazihaneKodu)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("YAZIHANE_KODU")
                .IsFixedLength();
        }
    }
}
