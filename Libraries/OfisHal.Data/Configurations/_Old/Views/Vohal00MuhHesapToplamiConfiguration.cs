using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class Vohal00MuhHesapToplamiConfiguration : EntityTypeConfiguration<Vohal00MuhHesapToplami>
    {
        public Vohal00MuhHesapToplamiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_00_MUH_HESAP_TOPLAMI");

            Property(e => e.AlacakToplami).HasColumnName("ALACAK_TOPLAMI");

            Property(e => e.Ay).HasColumnName("AY");

            Property(e => e.BorcToplami).HasColumnName("BORC_TOPLAMI");

            Property(e => e.MuhHesapId).HasColumnName("MUH_HESAP_ID");

            Property(e => e.Yil).HasColumnName("YIL");
        }
    }
}
