using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Core.Domain.Configurations
{
    internal class VohalGonderimeHazirEMustahsilMakbuzuConfiguration : EntityTypeConfiguration<VohalGonderimeHazirEMustahsilMakbuzu>
    {
        public VohalGonderimeHazirEMustahsilMakbuzuConfiguration()
        {
            //HasNoKey();

            HasKey(e => e.FaturaId);

            ToTable("VOHAL_GONDERIME_HAZIR_E_MUSTAHSIL_MAKBUZU");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.EBelgeTuru).HasColumnName("E_BELGE_TURU");

            Property(e => e.EFaturaDurumu).HasColumnName("E_FATURA_DURUMU");

            Property(e => e.EFaturaHataAciklamasi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_HATA_ACIKLAMASI");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.ToplamTutar).HasColumnName("TOPLAM_TUTAR");

            Property(e => e.Unvan)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNVAN");
        }
    }
}
