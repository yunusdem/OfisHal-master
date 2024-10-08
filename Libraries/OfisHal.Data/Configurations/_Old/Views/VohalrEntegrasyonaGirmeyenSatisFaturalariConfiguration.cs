using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrEntegrasyonaGirmeyenSatisFaturalariConfiguration : EntityTypeConfiguration<VohalrEntegrasyonaGirmeyenSatisFaturalari>
    {
        public VohalrEntegrasyonaGirmeyenSatisFaturalariConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_ENTEGRASYONA_GIRMEYEN_SATIS_FATURALARI");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.RefNo).HasColumnName("REF_NO");

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
