using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class ToambLogNavlunFaturasiConfiguration : EntityTypeConfiguration<ToambLogNavlunFaturasi>
    {
        public ToambLogNavlunFaturasiConfiguration()
        {
            //HasNoKey();

            ToTable("TOAMB_LOG_NAVLUN_FATURASI");

            Property(e => e.Islem).HasColumnName("ISLEM");

            Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            Property(e => e.NavlunFaturasiId).HasColumnName("NAVLUN_FATURASI_ID");

            Property(e => e.ODizaynId).HasColumnName("O_DIZAYN_ID");

            Property(e => e.OFaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("O_FATURA_NO")
                .IsFixedLength();

            Property(e => e.OGenelToplam).HasColumnName("O_GENEL_TOPLAM");

            Property(e => e.OKdv).HasColumnName("O_KDV");

            Property(e => e.OKdvOrani).HasColumnName("O_KDV_ORANI");

            Property(e => e.OKesildi).HasColumnName("O_KESILDI");

            Property(e => e.OMuameleToplam).HasColumnName("O_MUAMELE_TOPLAM");

            Property(e => e.ONavlunToplam).HasColumnName("O_NAVLUN_TOPLAM");

            Property(e => e.OOdendi).HasColumnName("O_ODENDI");

            Property(e => e.OTarih)
                .HasColumnType("datetime")
                .HasColumnName("O_TARIH");

            Property(e => e.OToplam).HasColumnName("O_TOPLAM");

            Property(e => e.OYazihaneId).HasColumnName("O_YAZIHANE_ID");

            Property(e => e.SDizaynId).HasColumnName("S_DIZAYN_ID");

            Property(e => e.SFaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("S_FATURA_NO")
                .IsFixedLength();

            Property(e => e.SGenelToplam).HasColumnName("S_GENEL_TOPLAM");

            Property(e => e.SKdv).HasColumnName("S_KDV");

            Property(e => e.SKdvOrani).HasColumnName("S_KDV_ORANI");

            Property(e => e.SKesildi).HasColumnName("S_KESILDI");

            Property(e => e.SMuameleToplam).HasColumnName("S_MUAMELE_TOPLAM");

            Property(e => e.SNavlunToplam).HasColumnName("S_NAVLUN_TOPLAM");

            Property(e => e.SOdendi).HasColumnName("S_ODENDI");

            Property(e => e.STarih)
                .HasColumnType("datetime")
                .HasColumnName("S_TARIH");

            Property(e => e.SToplam).HasColumnName("S_TOPLAM");

            Property(e => e.SYazihaneId).HasColumnName("S_YAZIHANE_ID");

            Property(e => e.Zaman)
                .HasColumnType("datetime")
                .HasColumnName("ZAMAN");
        }
    }
}
