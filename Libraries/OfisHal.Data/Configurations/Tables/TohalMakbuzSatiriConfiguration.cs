using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalMakbuzSatiriConfiguration : EntityTypeConfiguration<TohalMakbuzSatiri>
    {
        public TohalMakbuzSatiriConfiguration()
        {
            HasKey(e => new { e.MakbuzId, e.SatirNo });

            ToTable("TOHAL_MAKBUZ_SATIRI");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.KapSayisi).HasColumnName("KAP_SAYISI");

            Property(e => e.KdvOrani).HasColumnName("KDV_ORANI");

            Property(e => e.MalId).HasColumnName("MAL_ID");

            Property(e => e.Miktar).HasColumnName("MIKTAR");

            Property(e => e.SatisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("SATIS_TARIHI");

            Property(e => e.Tutar).HasColumnName("TUTAR");

            HasRequired(d => d.Makbuz)
                .WithMany(p => p.TohalMakbuzSatiris)
                .HasForeignKey(d => d.MakbuzId)
                .WillCascadeOnDelete(false);

            HasOptional(d => d.Mal)
                .WithMany(p => p.TohalMakbuzSatiris)
                .HasForeignKey(d => d.MalId);
        }
    }
}
