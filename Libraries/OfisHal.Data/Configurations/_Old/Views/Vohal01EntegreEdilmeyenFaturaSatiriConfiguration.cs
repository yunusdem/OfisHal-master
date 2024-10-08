using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class Vohal01EntegreEdilmeyenFaturaSatiriConfiguration : EntityTypeConfiguration<Vohal01EntegreEdilmeyenFaturaSatiri>
    {
        public Vohal01EntegreEdilmeyenFaturaSatiriConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_01_ENTEGRE_EDILMEYEN_FATURA_SATIRI");

            Property(e => e.Aciklama)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.CiroPrimi).HasColumnName("CIRO_PRIMI");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.FaturaSatiriId).HasColumnName("FATURA_SATIRI_ID");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.KapId).HasColumnName("KAP_ID");

            Property(e => e.KapMiktari).HasColumnName("KAP_MIKTARI");

            Property(e => e.KdvOrani).HasColumnName("KDV_ORANI");

            Property(e => e.Kesildi).HasColumnName("KESILDI");

            Property(e => e.MalAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAL_ADI");

            Property(e => e.MalId).HasColumnName("MAL_ID");

            Property(e => e.MalMiktari).HasColumnName("MAL_MIKTARI");

            Property(e => e.Marka)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MARKA");

            Property(e => e.MarkaId).HasColumnName("MARKA_ID");

            Property(e => e.RefNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("REF_NO");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.StokKunyeId).HasColumnName("STOK_KUNYE_ID");

            Property(e => e.StokTipi).HasColumnName("STOK_TIPI");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.Tutar).HasColumnName("TUTAR");
        }
    }
}
