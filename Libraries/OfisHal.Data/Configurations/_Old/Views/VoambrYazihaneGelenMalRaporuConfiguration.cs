using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VoambrYazihaneGelenMalRaporuConfiguration : EntityTypeConfiguration<VoambrYazihaneGelenMalRaporu>
    {
        public VoambrYazihaneGelenMalRaporuConfiguration()
        {
            //HasNoKey();

            ToTable("VOAMBR_YAZIHANE_GELEN_MAL_RAPORU");

            Property(e => e.Adet).HasColumnName("ADET");

            Property(e => e.AmbarAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AMBAR_ADI");

            Property(e => e.AmbarKodu)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AMBAR_KODU")
                .IsFixedLength();

            Property(e => e.DizaynAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DIZAYN_ADI");

            Property(e => e.DizaynDosyaAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DIZAYN_DOSYA_ADI");

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.GeldigiYer)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("GELDIGI_YER");

            Property(e => e.Gonderen)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("GONDEREN");

            Property(e => e.GonderenId).HasColumnName("GONDEREN_ID");

            Property(e => e.GonderenKodu)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GONDEREN_KODU")
                .IsFixedLength();

            Property(e => e.IrsaliyeId).HasColumnName("IRSALIYE_ID");

            Property(e => e.IrsaliyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IRSALIYE_NO")
                .IsFixedLength();

            Property(e => e.Kap)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("KAP");

            Property(e => e.KdvToplami).HasColumnName("KDV_TOPLAMI");

            Property(e => e.MalCinsi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAL_CINSI");

            Property(e => e.MalId).HasColumnName("MAL_ID");

            Property(e => e.MuameleTutar).HasColumnName("MUAMELE_TUTAR");

            Property(e => e.PlakaNo)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PLAKA_NO");

            Property(e => e.RefNo).HasColumnName("REF_NO");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.Tutar).HasColumnName("TUTAR");

            Property(e => e.YazihaneAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("YAZIHANE_ADI");

            Property(e => e.YazihaneId).HasColumnName("YAZIHANE_ID");

            Property(e => e.YazihaneKodu)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("YAZIHANE_KODU")
                .IsFixedLength();
        }
    }
}
