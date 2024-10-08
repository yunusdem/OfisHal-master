using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrSiparisKarsilastirmasiConfiguration : EntityTypeConfiguration<VohalrSiparisKarsilastirmasi>
    {
        public VohalrSiparisKarsilastirmasiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_SIPARIS_KARSILASTIRMASI");

            Property(e => e.Birim).HasColumnName("BIRIM");

            Property(e => e.MalAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAL_ADI");

            Property(e => e.MalId).HasColumnName("MAL_ID");

            Property(e => e.SatinAlimMiktari).HasColumnName("SATIN_ALIM_MIKTARI");

            Property(e => e.SatinAlinanBirim)
                .IsRequired()
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("SATIN_ALINAN_BIRIM");

            Property(e => e.SatisBirimi)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("SATIS_BIRIMI");

            Property(e => e.SatisMiktari).HasColumnName("SATIS_MIKTARI");

            Property(e => e.SiparisId).HasColumnName("SIPARIS_ID");

            Property(e => e.SiparisMiktari).HasColumnName("SIPARIS_MIKTARI");

            Property(e => e.SiparisNo)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SIPARIS_NO")
                .IsFixedLength();
        }
    }
}
