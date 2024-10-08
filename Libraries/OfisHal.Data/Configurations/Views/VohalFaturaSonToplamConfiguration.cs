using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class VohalFaturaSonToplamConfiguration : EntityTypeConfiguration<VohalFaturaSonToplam>
    {
        public VohalFaturaSonToplamConfiguration()
        {
            HasKey(e => e.FaturaId);
            //HasNoKey();

            ToTable("VOHAL_FATURA_SON_TOPLAM");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.FaturaSonToplam).HasColumnName("FATURA_SON_TOPLAM");
        }
    }
}
