using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Core.Domain.Configurations
{
    internal class TohalIskeleStokHareketiConfiguration : EntityTypeConfiguration<TohalIskeleStokHareketi>
    {
        public TohalIskeleStokHareketiConfiguration()
        {
            //HasNoKey();
            HasKey(e => e.Id);

            ToTable("TOHAL_ISKELE_STOK_HAREKETI");

            Property(e => e.Aciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.Id).HasColumnName("ID");

            Property(e => e.AlisKunyeId).HasColumnName("ALIS_KUNYE_ID");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.GirisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("GIRIS_TARIHI");

            Property(e => e.Guid).HasColumnName("GUID");

            Property(e => e.KapId).HasColumnName("KAP_ID");

            Property(e => e.KapSayisi).HasColumnName("KAP_SAYISI");

            Property(e => e.MalId).HasColumnName("MAL_ID");

            Property(e => e.Miktar).HasColumnName("MIKTAR");

            Property(e => e.SatilanKap).HasColumnName("SATILAN_KAP");

            Property(e => e.SatilanMiktar).HasColumnName("SATILAN_MIKTAR");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.StokHareketiId).HasColumnName("STOK_HAREKETI_ID");

            Property(e => e.StokKunyeId).HasColumnName("STOK_KUNYE_ID");

            Property(e => e.StokTipi).HasColumnName("STOK_TIPI");

            Property(e => e.VtStokKunyeId).HasColumnName("VT_STOK_KUNYE_ID");
        }
    }
}
