using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalDevirHesapHareketiBakiyeConfiguration : EntityTypeConfiguration<VohalDevirHesapHareketiBakiye>
    {
        public VohalDevirHesapHareketiBakiyeConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_DEVIR_HESAP_HAREKETI_BAKIYE");

            Property(e => e.HesapAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HESAP_ADI");

            Property(e => e.HesapHareketiBakiyesi).HasColumnName("HESAP_HAREKETI_BAKIYESI");

            Property(e => e.HesapId).HasColumnName("HESAP_ID");

            Property(e => e.KasaHareketiBakiyesi).HasColumnName("KASA_HAREKETI_BAKIYESI");
        }
    }
}
