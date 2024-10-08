using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrSermayeKarlilikEkstreConfiguration : EntityTypeConfiguration<VohalrSermayeKarlilikEkstre>
    {
        public VohalrSermayeKarlilikEkstreConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_SERMAYE_KARLILIK_EKSTRE");

            Property(e => e.Ad)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.KapSayisi).HasColumnName("KAP_SAYISI");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.Miktar).HasColumnName("MIKTAR");

            Property(e => e.Tutar).HasColumnName("TUTAR");
        }
    }
}
