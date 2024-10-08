using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrStokHareketiMusteriBazliConfiguration : EntityTypeConfiguration<VohalrStokHareketiMusteriBazli>
    {
        public VohalrStokHareketiMusteriBazliConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_STOK_HAREKETI_MUSTERI_BAZLI");

            Property(e => e.DigKiloOndalikSayisi).HasColumnName("DIG_KILO_ONDALIK_SAYISI");

            Property(e => e.Kap)
                .HasColumnType("numeric(11, 1)")
                .HasColumnName("KAP");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.MalAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAL_ADI");

            Property(e => e.Miktar).HasColumnName("MIKTAR");
        }
    }
}
