using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalFaturaSatiriKullanilanKunyeConfiguration : EntityTypeConfiguration<VohalFaturaSatiriKullanilanKunye>
    {
        public VohalFaturaSatiriKullanilanKunyeConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_FATURA_SATIRI_KULLANILAN_KUNYE");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.FaturaSatiriId).HasColumnName("FATURA_SATIRI_ID");

            Property(e => e.FaturaSatiriNo).HasColumnName("FATURA_SATIRI_NO");

            Property(e => e.KunyeSatirId).HasColumnName("KUNYE_SATIR_ID");

            Property(e => e.Miktar).HasColumnName("MIKTAR");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.SatisKunye)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SATIS_KUNYE")
                .IsFixedLength();

            Property(e => e.SatisKunyeId).HasColumnName("SATIS_KUNYE_ID");

            Property(e => e.StokKunye)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STOK_KUNYE")
                .IsFixedLength();

            Property(e => e.StokKunyeId).HasColumnName("STOK_KUNYE_ID");
        }
    }
}
