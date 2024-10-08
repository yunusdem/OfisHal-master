using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Core.Domain.Configurations
{
    internal class VohalDokumTanimlariConfiguration : EntityTypeConfiguration<VohalDokumTanimlari>
    {
        public VohalDokumTanimlariConfiguration()
        {
            //HasNoKey();
            HasKey(e => e.DokFaturaSiraNo);
            ToTable("VOHAL_DOKUM_TANIMLARI");

            Property(e => e.DokAyniMallariToplamaSekli).HasColumnName("DOK_AYNI_MALLARI_TOPLAMA_SEKLI");

            Property(e => e.DokBagkurOrani).HasColumnName("DOK_BAGKUR_ORANI");

            Property(e => e.DokBirimHamaliye).HasColumnName("DOK_BIRIM_HAMALIYE");

            Property(e => e.DokBirimNakliye).HasColumnName("DOK_BIRIM_NAKLIYE");

            Property(e => e.DokBorsaOrani).HasColumnName("DOK_BORSA_ORANI");

            Property(e => e.DokBorsaStopajOrani).HasColumnName("DOK_BORSA_STOPAJ_ORANI");

            Property(e => e.DokCariIslemeDegissin).HasColumnName("DOK_CARI_ISLEME_DEGISSIN");

            Property(e => e.DokCariyeIslemeSekli).HasColumnName("DOK_CARIYE_ISLEME_SEKLI");

            Property(e => e.DokDokumAmbar).HasColumnName("DOK_DOKUM_AMBAR");

            Property(e => e.DokDokumDefterGosterimi).HasColumnName("DOK_DOKUM_DEFTER_GOSTERIMI");

            Property(e => e.DokDokumDefterTipi).HasColumnName("DOK_DOKUM_DEFTER_TIPI");

            Property(e => e.DokDokumDefteriVar).HasColumnName("DOK_DOKUM_DEFTERI_VAR");

            Property(e => e.DokFaturaSiraNo).HasColumnName("DOK_FATURA_SIRA_NO");

            Property(e => e.DokFiyatGirilsin).HasColumnName("DOK_FIYAT_GIRILSIN");

            Property(e => e.DokHamaliyeHesaplamaSekli).HasColumnName("DOK_HAMALIYE_HESAPLAMA_SEKLI");

            Property(e => e.DokHizmetBedeliHesabiId).HasColumnName("DOK_HIZMET_BEDELI_HESABI_ID");

            Property(e => e.DokHizmetBedeliHesabiKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DOK_HIZMET_BEDELI_HESABI_KODU")
                .IsFixedLength();

            Property(e => e.DokKapKomisyonaDahil).HasColumnName("DOK_KAP_KOMISYONA_DAHIL");

            Property(e => e.DokKapliEntegrasyonYap).HasColumnName("DOK_KAPLI_ENTEGRASYON_YAP");

            Property(e => e.DokKomisyonKdvOrani).HasColumnName("DOK_KOMISYON_KDV_ORANI");

            Property(e => e.DokKomisyonOrani).HasColumnName("DOK_KOMISYON_ORANI");

            Property(e => e.DokMustahsilCiroSiniri).HasColumnName("DOK_MUSTAHSIL_CIRO_SINIRI");

            Property(e => e.DokNavlunKdvOrani).HasColumnName("DOK_NAVLUN_KDV_ORANI");

            Property(e => e.DokOtomatikHamaliye).HasColumnName("DOK_OTOMATIK_HAMALIYE");

            Property(e => e.DokRusumOrani).HasColumnName("DOK_RUSUM_ORANI");

            Property(e => e.DokSatirdaStokGirisTarihi).HasColumnName("DOK_SATIRDA_STOK_GIRIS_TARIHI");

            Property(e => e.DokStopajOrani).HasColumnName("DOK_STOPAJ_ORANI");

            Property(e => e.DokToplamaMalCalisir).HasColumnName("DOK_TOPLAMA_MAL_CALISIR");

            Property(e => e.DokTuccarKapKdvOrani).HasColumnName("DOK_TUCCAR_KAP_KDV_ORANI");

            Property(e => e.IadeliKapTutarRehindenAl).HasColumnName("IADELI_KAP_TUTAR_REHINDEN_AL");
        }
    }
}
