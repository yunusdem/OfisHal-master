using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalDonemOnayiConfiguration : EntityTypeConfiguration<VohalDonemOnayi>
    {
        public VohalDonemOnayiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_DONEM_ONAYI");

            Property(e => e.DonemOnayGunSayisi).HasColumnName("DONEM_ONAY_GUN_SAYISI");

            Property(e => e.DonemOnayTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DONEM_ONAY_TARIHI");
        }
    }
}
