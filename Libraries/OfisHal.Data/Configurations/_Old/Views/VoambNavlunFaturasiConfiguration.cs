using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VoambNavlunFaturasiConfiguration : EntityTypeConfiguration<VoambNavlunFaturasi>
    {
        public VoambNavlunFaturasiConfiguration()
        {
            //HasNoKey();

            ToTable("VOAMB_NAVLUN_FATURASI");

            Property(e => e.AdetToplami).HasColumnName("ADET_TOPLAMI");

            Property(e => e.Adres)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ADRES");

            Property(e => e.DizaynAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DIZAYN_ADI");

            Property(e => e.DizaynId).HasColumnName("DIZAYN_ID");

            Property(e => e.EFaturaEttn)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_ETTN");

            Property(e => e.EklemeZamani)
                .HasColumnType("datetime")
                .HasColumnName("EKLEME_ZAMANI");

            Property(e => e.EkleyenId).HasColumnName("EKLEYEN_ID");

            Property(e => e.EkleyenKullaniciAdi)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EKLEYEN_KULLANICI_ADI");

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.FaturaTarihi)
                .HasColumnType("datetime")
                .HasColumnName("FATURA_TARIHI");

            Property(e => e.GenelToplam).HasColumnName("GENEL_TOPLAM");

            Property(e => e.GibFirmamizPostaKutusu)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("GIB_FIRMAMIZ_POSTA_KUTUSU");

            Property(e => e.GibFirmamizPostaKutusuId).HasColumnName("GIB_FIRMAMIZ_POSTA_KUTUSU_ID");

            Property(e => e.GibMuhatapPostaKutusu)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("GIB_MUHATAP_POSTA_KUTUSU");

            Property(e => e.GibMuhatapPostaKutusuId).HasColumnName("GIB_MUHATAP_POSTA_KUTUSU_ID");

            Property(e => e.GuncellemeZamani)
                .HasColumnType("datetime")
                .HasColumnName("GUNCELLEME_ZAMANI");

            Property(e => e.GuncellemeZamaniString)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("GUNCELLEME_ZAMANI_STRING");

            Property(e => e.GuncelleyenKullaniciAdi)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GUNCELLEYEN_KULLANICI_ADI");

            Property(e => e.HalAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HAL_ADI");

            Property(e => e.HalKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HAL_KODU")
                .IsFixedLength();

            Property(e => e.IlAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IL_ADI");

            Property(e => e.IlceAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ILCE_ADI");

            Property(e => e.KayitId).HasColumnName("KAYIT_ID");

            Property(e => e.Kdv).HasColumnName("KDV");

            Property(e => e.KdvOrani).HasColumnName("KDV_ORANI");

            Property(e => e.Kesildi).HasColumnName("KESILDI");

            Property(e => e.MuameleToplam).HasColumnName("MUAMELE_TOPLAM");

            Property(e => e.NavlunFaturasiId).HasColumnName("NAVLUN_FATURASI_ID");

            Property(e => e.NavlunToplam).HasColumnName("NAVLUN_TOPLAM");

            Property(e => e.Odendi).HasColumnName("ODENDI");

            Property(e => e.Toplam).HasColumnName("TOPLAM");

            Property(e => e.UlkeAdi)
                .IsRequired()
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("ULKE_ADI");

            Property(e => e.VergiDairesi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("VERGI_DAIRESI");

            Property(e => e.VergiKimlikNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VERGI_KIMLIK_NO")
                .IsFixedLength();

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

            Property(e => e.Zaman)
                .HasColumnType("datetime")
                .HasColumnName("ZAMAN");
        }
    }
}
