using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalGonderimeHazirEMustahsilFaturasiMakbuzuConfiguration : EntityTypeConfiguration<VohalGonderimeHazirEMustahsilFaturasiMakbuzu>
    {
        public VohalGonderimeHazirEMustahsilFaturasiMakbuzuConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_GONDERIME_HAZIR_E_MUSTAHSIL_FATURASI_MAKBUZU");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.DokumNo)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DOKUM_NO")
                .IsFixedLength();

            Property(e => e.EBelgeTuru).HasColumnName("E_BELGE_TURU");

            Property(e => e.EFaturaDurumu).HasColumnName("E_FATURA_DURUMU");

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.ToplamTutar).HasColumnName("TOPLAM_TUTAR");

            Property(e => e.Unvan)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNVAN");
        }
    }
}
