using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalRehinFisiConfiguration : EntityTypeConfiguration<TohalRehinFisi>
    {
        public TohalRehinFisiConfiguration()
        {
            HasKey(e => e.RehinFisiId);

            ToTable("TOHAL_REHIN_FISI");

            Property(e => e.RehinFisiId).HasColumnName("REHIN_FISI_ID");

            Property(e => e.ElleDegistirildi).HasColumnName("ELLE_DEGISTIRILDI");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.Guid)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("GUID");

            Property(e => e.KapId).HasColumnName("KAP_ID");

            Property(e => e.KapMiktari).HasColumnName("KAP_MIKTARI");

            Property(e => e.MarkaId).HasColumnName("MARKA_ID");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.Tutar).HasColumnName("TUTAR");

            HasRequired(d => d.Fatura)
                .WithMany(p => p.TohalRehinFisis)
                .HasForeignKey(d => d.FaturaId)
                .WillCascadeOnDelete(false);

            HasRequired(d => d.Kap)
                .WithMany(p => p.TohalRehinFisis)
                .HasForeignKey(d => d.KapId)
                .WillCascadeOnDelete(false);

            HasOptional(d => d.Marka)
                .WithMany(p => p.TohalRehinFisis)
                .HasForeignKey(d => d.MarkaId);
        }
    }
}
