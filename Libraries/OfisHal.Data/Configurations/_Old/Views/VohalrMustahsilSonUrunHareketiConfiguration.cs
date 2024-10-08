using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrMustahsilSonUrunHareketiConfiguration : EntityTypeConfiguration<VohalrMustahsilSonUrunHareketi>
    {
        public VohalrMustahsilSonUrunHareketiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_MUSTAHSIL_SON_URUN_HAREKETI");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.DokumNo)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DOKUM_NO")
                .IsFixedLength();

            Property(e => e.KapSayisi).HasColumnName("KAP_SAYISI");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.Miktar).HasColumnName("MIKTAR");

            Property(e => e.MustahsilAd)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MUSTAHSIL_AD");

            Property(e => e.MustahsilKod)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MUSTAHSIL_KOD")
                .IsFixedLength();

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.UrunAd)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("URUN_AD");
        }
    }
}
