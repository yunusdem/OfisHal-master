using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrAlisFaturasiKapDetayConfiguration : EntityTypeConfiguration<VohalrAlisFaturasiKapDetay>
    {
        public VohalrAlisFaturasiKapDetayConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_ALIS_FATURASI_KAP_DETAY");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.HesapKodu)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HESAP_KODU")
                .IsFixedLength();

            Property(e => e.MasrafTutari).HasColumnName("MASRAF_TUTARI");
        }
    }
}
