using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrTicariKarlilikEkstreConfiguration : EntityTypeConfiguration<VohalrTicariKarlilikEkstre>
    {
        public VohalrTicariKarlilikEkstreConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_TICARI_KARLILIK_EKSTRE");

            Property(e => e.Ad)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.AlinanKap).HasColumnName("ALINAN_KAP");

            Property(e => e.Alis).HasColumnName("ALIS");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.SatilanKap).HasColumnName("SATILAN_KAP");

            Property(e => e.Satis).HasColumnName("SATIS");

            Property(e => e.Tutar).HasColumnName("TUTAR");
        }
    }
}
