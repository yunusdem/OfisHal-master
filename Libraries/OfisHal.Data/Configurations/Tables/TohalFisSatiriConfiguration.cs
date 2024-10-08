using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalFisSatiriConfiguration : EntityTypeConfiguration<TohalFisSatiri>
    {
        public TohalFisSatiriConfiguration()
        {
            HasKey(e => e.FisSatiriId);

            ToTable("TOHAL_FIS_SATIRI");

            Property(e => e.FisSatiriId).HasColumnName("FIS_SATIRI_ID");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.Dara).HasColumnName("DARA");

            Property(e => e.Darali).HasColumnName("DARALI");

            Property(e => e.FisId).HasColumnName("FIS_ID");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.FiyatFarki).HasColumnName("FIYAT_FARKI");

            Property(e => e.KapId).HasColumnName("KAP_ID");

            Property(e => e.KapMiktari).HasColumnName("KAP_MIKTARI");

            Property(e => e.MalId).HasColumnName("MAL_ID");

            Property(e => e.MalMiktari).HasColumnName("MAL_MIKTARI");

            Property(e => e.MarkaId).HasColumnName("MARKA_ID");

            Property(e => e.PiyasaFiyati).HasColumnName("PIYASA_FIYATI");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.Tutar).HasColumnName("TUTAR");

            HasOptional(d => d.CariKart)
                .WithMany(p => p.TohalFisSatiris)
                .HasForeignKey(d => d.CariKartId);

            HasRequired(d => d.Fis)
                .WithMany(p => p.TohalFisSatiris)
                .HasForeignKey(d => d.FisId)
                .WillCascadeOnDelete(false);

            HasOptional(d => d.Kap)
                .WithMany(p => p.TohalFisSatiris)
                .HasForeignKey(d => d.KapId);

            HasRequired(d => d.Mal)
                .WithMany(p => p.TohalFisSatiris)
                .HasForeignKey(d => d.MalId)
                .WillCascadeOnDelete(false);

            HasOptional(d => d.Marka)
                .WithMany(p => p.TohalFisSatiris)
                .HasForeignKey(d => d.MarkaId);
        }
    }
}
