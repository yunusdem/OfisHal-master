using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrDokumKontrolConfiguration : EntityTypeConfiguration<VohalrDokumKontrol>
    {
        public VohalrDokumKontrolConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_DOKUM_KONTROL");

            Property(e => e.DigKiloOndalikSayisi).HasColumnName("DIG_KILO_ONDALIK_SAYISI");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.KapSayisi).HasColumnName("KAP_SAYISI");

            Property(e => e.Kod)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KOD")
                .IsFixedLength();

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.Miktar).HasColumnName("MIKTAR");

            Property(e => e.Tip).HasColumnName("TIP");

            Property(e => e.Tutar).HasColumnName("TUTAR");
        }
    }
}
