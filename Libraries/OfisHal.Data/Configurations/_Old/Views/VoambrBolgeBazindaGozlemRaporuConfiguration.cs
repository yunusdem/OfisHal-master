using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VoambrBolgeBazindaGozlemRaporuConfiguration : EntityTypeConfiguration<VoambrBolgeBazindaGozlemRaporu>
    {
        public VoambrBolgeBazindaGozlemRaporuConfiguration()
        {
            //HasNoKey();

            ToTable("VOAMBR_BOLGE_BAZINDA_GOZLEM_RAPORU");

            Property(e => e.Ad)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.BolgeKodu)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BOLGE_KODU");

            Property(e => e.BolgeKoduId).HasColumnName("BOLGE_KODU_ID");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.DizaynAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DIZAYN_ADI");

            Property(e => e.DizaynId).HasColumnName("DIZAYN_ID");

            Property(e => e.DosyaAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DOSYA_ADI");

            Property(e => e.FaturaTarihi)
                .HasColumnType("datetime")
                .HasColumnName("FATURA_TARIHI");

            Property(e => e.KapAdedi).HasColumnName("KAP_ADEDI");

            Property(e => e.KdvTutari).HasColumnName("KDV_TUTARI");

            Property(e => e.Kod)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KOD")
                .IsFixedLength();

            Property(e => e.MuameleTutar).HasColumnName("MUAMELE_TUTAR");

            Property(e => e.NavlunFaturasiId).HasColumnName("NAVLUN_FATURASI_ID");

            Property(e => e.NavlunTutar).HasColumnName("NAVLUN_TUTAR");

            Property(e => e.Sayi).HasColumnName("SAYI");
        }
    }
}
