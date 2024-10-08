using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalHazirdaVeIslemdekiMakbuzlarConfiguration : EntityTypeConfiguration<VohalHazirdaVeIslemdekiMakbuzlar>
    {
        public VohalHazirdaVeIslemdekiMakbuzlarConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_HAZIRDA_VE_ISLEMDEKI_MAKBUZLAR");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.HazirdakiMakbuzSayisi).HasColumnName("HAZIRDAKI_MAKBUZ_SAYISI");

            Property(e => e.HazirdakiMakbuzTutari).HasColumnName("HAZIRDAKI_MAKBUZ_TUTARI");

            Property(e => e.IslemdekiMakbuzSayisi).HasColumnName("ISLEMDEKI_MAKBUZ_SAYISI");

            Property(e => e.IslemdekiMakbuzTutari).HasColumnName("ISLEMDEKI_MAKBUZ_TUTARI");

            Property(e => e.Kod)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KOD")
                .IsFixedLength();
        }
    }
}
