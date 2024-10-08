using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrMuhHesapMizaniConfiguration : EntityTypeConfiguration<VohalrMuhHesapMizani>
    {
        public VohalrMuhHesapMizaniConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_MUH_HESAP_MIZANI");

            Property(e => e.Ad)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.AlacakToplami).HasColumnName("ALACAK_TOPLAMI");

            Property(e => e.Ay).HasColumnName("AY");

            Property(e => e.BorcToplami).HasColumnName("BORC_TOPLAMI");

            Property(e => e.Kod)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KOD")
                .IsFixedLength();

            Property(e => e.KurusBasamakSayisi).HasColumnName("KURUS_BASAMAK_SAYISI");

            Property(e => e.Yil).HasColumnName("YIL");
        }
    }
}
