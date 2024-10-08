using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VoambNavlunFaturasiSatiriConfiguration : EntityTypeConfiguration<VoambNavlunFaturasiSatiri>
    {
        public VoambNavlunFaturasiSatiriConfiguration()
        {
            //HasNoKey();

            ToTable("VOAMB_NAVLUN_FATURASI_SATIRI");

            Property(e => e.Adet).HasColumnName("ADET");

            Property(e => e.EFaturaUneceKisaltma)
                .IsRequired()
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_UNECE_KISALTMA");

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.GeldigiYer)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("GELDIGI_YER");

            Property(e => e.GeldigiYerId).HasColumnName("GELDIGI_YER_ID");

            Property(e => e.Gonderen)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("GONDEREN");

            Property(e => e.GonderenId).HasColumnName("GONDEREN_ID");

            Property(e => e.IrsaliyeId).HasColumnName("IRSALIYE_ID");

            Property(e => e.IrsaliyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IRSALIYE_NO")
                .IsFixedLength();

            Property(e => e.IrsaliyeSatiriId).HasColumnName("IRSALIYE_SATIRI_ID");

            Property(e => e.KapAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("KAP_ADI");

            Property(e => e.KapId).HasColumnName("KAP_ID");

            Property(e => e.KapKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAP_KODU")
                .IsFixedLength();

            Property(e => e.MalAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAL_ADI");

            Property(e => e.MalId).HasColumnName("MAL_ID");

            Property(e => e.MalKodu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MAL_KODU")
                .IsFixedLength();

            Property(e => e.MuameleFiyati).HasColumnName("MUAMELE_FIYATI");

            Property(e => e.MuameleKdv).HasColumnName("MUAMELE_KDV");

            Property(e => e.MuameleKdvOrani).HasColumnName("MUAMELE_KDV_ORANI");

            Property(e => e.MuameleTutar).HasColumnName("MUAMELE_TUTAR");

            Property(e => e.NavlunFaturaSatiriId).HasColumnName("NAVLUN_FATURA_SATIRI_ID");

            Property(e => e.NavlunFaturasiId).HasColumnName("NAVLUN_FATURASI_ID");

            Property(e => e.NavlunFiyati).HasColumnName("NAVLUN_FIYATI");

            Property(e => e.NavlunKdv).HasColumnName("NAVLUN_KDV");

            Property(e => e.NavlunKdvOrani).HasColumnName("NAVLUN_KDV_ORANI");

            Property(e => e.NavlunTutar).HasColumnName("NAVLUN_TUTAR");

            Property(e => e.PlakaId).HasColumnName("PLAKA_ID");

            Property(e => e.PlakaNo)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PLAKA_NO");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.ToplamAdet).HasColumnName("TOPLAM_ADET");
        }
    }
}
