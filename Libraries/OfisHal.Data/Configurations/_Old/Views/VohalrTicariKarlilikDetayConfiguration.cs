using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrTicariKarlilikDetayConfiguration : EntityTypeConfiguration<VohalrTicariKarlilikDetay>
    {
        public VohalrTicariKarlilikDetayConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_TICARI_KARLILIK_DETAY");

            Property(e => e.Ad)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.Iskonto).HasColumnName("ISKONTO");

            Property(e => e.KapMiktari).HasColumnName("KAP_MIKTARI");

            Property(e => e.Kg).HasColumnName("KG");

            Property(e => e.Masraf).HasColumnName("MASRAF");

            Property(e => e.Tutar).HasColumnName("TUTAR");
        }
    }
}
