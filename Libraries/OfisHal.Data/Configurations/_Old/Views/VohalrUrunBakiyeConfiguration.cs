using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrUrunBakiyeConfiguration : EntityTypeConfiguration<VohalrUrunBakiye>
    {
        public VohalrUrunBakiyeConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_URUN_BAKIYE");

            Property(e => e.Cikis).HasColumnName("CIKIS");

            Property(e => e.Giris).HasColumnName("GIRIS");

            Property(e => e.KapCikis)
                .HasColumnType("numeric(11, 1)")
                .HasColumnName("KAP_CIKIS");

            Property(e => e.KapGiris)
                .HasColumnType("numeric(11, 1)")
                .HasColumnName("KAP_GIRIS");

            Property(e => e.Kod)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KOD")
                .IsFixedLength();

            Property(e => e.MustahsilAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MUSTAHSIL_ADI");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.Urun)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("URUN");
        }
    }
}
