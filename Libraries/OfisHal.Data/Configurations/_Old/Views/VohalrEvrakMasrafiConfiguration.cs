using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrEvrakMasrafiConfiguration : EntityTypeConfiguration<VohalrEvrakMasrafi>
    {
        public VohalrEvrakMasrafiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_EVRAK_MASRAFI");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.HesapAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HESAP_ADI");

            Property(e => e.Kdv).HasColumnName("KDV");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.Masraf).HasColumnName("MASRAF");

            Property(e => e.SiparisId).HasColumnName("SIPARIS_ID");

            Property(e => e.Tip).HasColumnName("TIP");

            Property(e => e.Tutar).HasColumnName("TUTAR");
        }
    }
}
