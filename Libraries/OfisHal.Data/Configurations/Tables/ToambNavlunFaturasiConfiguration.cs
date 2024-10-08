using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class ToambNavlunFaturasiConfiguration : EntityTypeConfiguration<ToambNavlunFaturasi>
    {
        public ToambNavlunFaturasiConfiguration()
        {
            HasKey(e => e.NavlunFaturasiId);

            ToTable("TOAMB_NAVLUN_FATURASI");

            Property(e => e.NavlunFaturasiId).HasColumnName("NAVLUN_FATURASI_ID");

            Property(e => e.DizaynId).HasColumnName("DIZAYN_ID");

            Property(e => e.EFaturaDurumu).HasColumnName("E_FATURA_DURUMU");

            Property(e => e.EFaturaEttn)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_ETTN");

            Property(e => e.EFaturaGibDurumu).HasColumnName("E_FATURA_GIB_DURUMU");

            Property(e => e.EFaturaHataAciklamasi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_HATA_ACIKLAMASI");

            Property(e => e.EklemeZamani)
                .HasColumnType("datetime")
                .HasColumnName("EKLEME_ZAMANI");

            Property(e => e.EkleyenId).HasColumnName("EKLEYEN_ID");

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.FaturaTarihi)
                .HasColumnType("datetime")
                .HasColumnName("FATURA_TARIHI");

            Property(e => e.GenelToplam).HasColumnName("GENEL_TOPLAM");

            Property(e => e.GibFirmamizPostaKutusuId).HasColumnName("GIB_FIRMAMIZ_POSTA_KUTUSU_ID");

            Property(e => e.GibMuhatapPostaKutusuId).HasColumnName("GIB_MUHATAP_POSTA_KUTUSU_ID");

            Property(e => e.GuncellemeZamani)
                .HasColumnType("datetime")
                .HasColumnName("GUNCELLEME_ZAMANI");

            Property(e => e.GuncelleyenId).HasColumnName("GUNCELLEYEN_ID");

            Property(e => e.Kdv).HasColumnName("KDV");

            Property(e => e.KdvOrani).HasColumnName("KDV_ORANI");

            Property(e => e.Kesildi).HasColumnName("KESILDI");

            Property(e => e.MuameleToplam).HasColumnName("MUAMELE_TOPLAM");

            Property(e => e.NavlunToplam).HasColumnName("NAVLUN_TOPLAM");

            Property(e => e.Odendi).HasColumnName("ODENDI");

            Property(e => e.Toplam).HasColumnName("TOPLAM");

            Property(e => e.YazihaneId).HasColumnName("YAZIHANE_ID");

            Property(e => e.Zaman)
                .HasColumnType("datetime")
                .HasColumnName("ZAMAN");

            HasOptional(d => d.Dizayn)
                .WithMany(p => p.ToambNavlunFaturasis)
                .HasForeignKey(d => d.DizaynId);

            HasOptional(d => d.Ekleyen)
                .WithMany(p => p.ToambNavlunFaturasiEkleyens)
                .HasForeignKey(d => d.EkleyenId);

            HasOptional(d => d.Guncelleyen)
                .WithMany(p => p.ToambNavlunFaturasiGuncelleyens)
                .HasForeignKey(d => d.GuncelleyenId);

            HasRequired(d => d.Yazihane)
                .WithMany(p => p.ToambNavlunFaturasis)
                .HasForeignKey(d => d.YazihaneId)
                .WillCascadeOnDelete(false);
        }
    }
}
