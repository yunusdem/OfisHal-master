using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalDokumDefteriFiyatBazindaConfiguration : EntityTypeConfiguration<VohalDokumDefteriFiyatBazinda>
    {
        public VohalDokumDefteriFiyatBazindaConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_DOKUM_DEFTERI_FIYAT_BAZINDA");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.KapSayisi).HasColumnName("KAP_SAYISI");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.MalAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAL_ADI");

            Property(e => e.MalId).HasColumnName("MAL_ID");

            Property(e => e.Miktar).HasColumnName("MIKTAR");

            Property(e => e.Tutar).HasColumnName("TUTAR");
        }
    }
}
