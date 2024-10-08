using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrIadesizKapTakibiConfiguration : EntityTypeConfiguration<VohalrIadesizKapTakibi>
    {
        public VohalrIadesizKapTakibiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_IADESIZ_KAP_TAKIBI");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.FaturaSatiriId).HasColumnName("FATURA_SATIRI_ID");

            Property(e => e.IadesizKapKdv).HasColumnName("IADESIZ_KAP_KDV");

            Property(e => e.KapBedeli).HasColumnName("KAP_BEDELI");

            Property(e => e.KapMiktari).HasColumnName("KAP_MIKTARI");

            Property(e => e.MalAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAL_ADI");

            Property(e => e.Marka)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MARKA");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
        }
    }
}
