using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class Vohalr00EntegreEdilmeyenStokHareketiConfiguration : EntityTypeConfiguration<Vohalr00EntegreEdilmeyenStokHareketi>
    {
        public Vohalr00EntegreEdilmeyenStokHareketiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_00_ENTEGRE_EDILMEYEN_STOK_HAREKETI");

            Property(e => e.Bakiye).HasColumnName("BAKIYE");

            Property(e => e.DokumNo)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DOKUM_NO")
                .IsFixedLength();

            Property(e => e.GirisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("GIRIS_TARIHI");

            Property(e => e.KapId).HasColumnName("KAP_ID");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.MalId).HasColumnName("MAL_ID");

            Property(e => e.MarkaId).HasColumnName("MARKA_ID");

            Property(e => e.Miktar).HasColumnName("MIKTAR");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.StokHareketiId).HasColumnName("STOK_HAREKETI_ID");

            Property(e => e.StokTipi).HasColumnName("STOK_TIPI");
        }
    }
}
