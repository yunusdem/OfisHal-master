using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VoambrIrsaliyeGozlemRaporuConfiguration : EntityTypeConfiguration<VoambrIrsaliyeGozlemRaporu>
    {
        public VoambrIrsaliyeGozlemRaporuConfiguration()
        {
            //HasNoKey();

            ToTable("VOAMBR_IRSALIYE_GOZLEM_RAPORU");

            Property(e => e.Adet).HasColumnName("ADET");

            Property(e => e.AmbarAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AMBAR_ADI");

            Property(e => e.AmbarId).HasColumnName("AMBAR_ID");

            Property(e => e.AmbarKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AMBAR_KODU")
                .IsFixedLength();

            Property(e => e.AmbarPrimi).HasColumnName("AMBAR_PRIMI");

            Property(e => e.BolgeKodu)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BOLGE_KODU");

            Property(e => e.DizaynId).HasColumnName("DIZAYN_ID");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.FiyatListesi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("FIYAT_LISTESI");

            Property(e => e.GeldigiYer)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("GELDIGI_YER");

            Property(e => e.GenelToplam).HasColumnName("GENEL_TOPLAM");

            Property(e => e.Gonderen)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("GONDEREN");

            Property(e => e.HammaliyeFiyati).HasColumnName("HAMMALIYE_FIYATI");

            Property(e => e.Havale).HasColumnName("HAVALE");

            Property(e => e.IrsaliyeId).HasColumnName("IRSALIYE_ID");

            Property(e => e.IrsaliyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IRSALIYE_NO")
                .IsFixedLength();

            Property(e => e.IrsaliyeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("IRSALIYE_TARIHI");

            Property(e => e.KapAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("KAP_ADI");

            Property(e => e.Kesinti).HasColumnName("KESINTI");

            Property(e => e.MalAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAL_ADI");

            Property(e => e.Masraf).HasColumnName("MASRAF");

            Property(e => e.MuameleBirimFiyat).HasColumnName("MUAMELE_BIRIM_FIYAT");

            Property(e => e.MuameleDizaynId).HasColumnName("MUAMELE_DIZAYN_ID");

            Property(e => e.MuameleKdvOrani).HasColumnName("MUAMELE_KDV_ORANI");

            Property(e => e.NavlunKdvOrani).HasColumnName("NAVLUN_KDV_ORANI");

            Property(e => e.OdenecekTutar).HasColumnName("ODENECEK_TUTAR");

            Property(e => e.PlakaNo)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PLAKA_NO");

            Property(e => e.Prim).HasColumnName("PRIM");

            Property(e => e.SatHamaliyeAdlandirma)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SAT_HAMALIYE_ADLANDIRMA");

            Property(e => e.SatNakliyeAdlandirma)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SAT_NAKLIYE_ADLANDIRMA");

            Property(e => e.ToplamTutar).HasColumnName("TOPLAM_TUTAR");

            Property(e => e.Tutar).HasColumnName("TUTAR");

            Property(e => e.Yazihane)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("YAZIHANE");

            Property(e => e.YazihaneKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("YAZIHANE_KODU")
                .IsFixedLength();
        }
    }
}
