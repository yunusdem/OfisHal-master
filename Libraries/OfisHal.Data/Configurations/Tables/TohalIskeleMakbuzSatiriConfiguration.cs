using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class TohalIskeleMakbuzSatiriConfiguration : EntityTypeConfiguration<TohalIskeleMakbuzSatiri>
    {
        public TohalIskeleMakbuzSatiriConfiguration()
        {
            //HasNoKey();

            HasKey(x => x.Id);

            ToTable("TOHAL_ISKELE_MAKBUZ_SATIRI");

            Property(e => e.Id).HasColumnName("ID");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.Guid).HasColumnName("GUID");

            Property(e => e.KapSayisi).HasColumnName("KAP_SAYISI");

            Property(e => e.KdvOrani).HasColumnName("KDV_ORANI");

            Property(e => e.MalId).HasColumnName("MAL_ID");

            Property(e => e.Miktar).HasColumnName("MIKTAR");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.SatisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("SATIS_TARIHI");

            Property(e => e.Tutar).HasColumnName("TUTAR");
        }
    }
}
