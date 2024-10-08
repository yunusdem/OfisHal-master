using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class Vohal01HesapHareketiConfiguration : EntityTypeConfiguration<Vohal01HesapHareketi>
    {
        public Vohal01HesapHareketiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_01_HESAP_HAREKETI");

            Property(e => e.Aciklama)
                .HasMaxLength(602)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.Grup).HasColumnName("GRUP");

            Property(e => e.HesapAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HESAP_ADI");

            Property(e => e.HesapHareketiId).HasColumnName("HESAP_HAREKETI_ID");

            Property(e => e.HesapId).HasColumnName("HESAP_ID");

            Property(e => e.HesapKodu)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HESAP_KODU")
                .IsFixedLength();

            Property(e => e.Miktar).HasColumnName("MIKTAR");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.Tip).HasColumnName("TIP");
        }
    }
}
