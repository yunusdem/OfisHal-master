using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalObSatiriConfiguration : EntityTypeConfiguration<TohalObSatiri>
    {
        public TohalObSatiriConfiguration()
        {
            HasKey(e => new { e.OdemeBordrosuId, e.SatirNo });

            ToTable("TOHAL_OB_SATIRI");

            Property(e => e.OdemeBordrosuId).HasColumnName("ODEME_BORDROSU_ID");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.Aciklama)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.OdemeAraciId).HasColumnName("ODEME_ARACI_ID");

            Property(e => e.OdemeAraciSahibi).HasColumnName("ODEME_ARACI_SAHIBI");

            Property(e => e.SonrakiBordroId).HasColumnName("SONRAKI_BORDRO_ID");

            HasRequired(d => d.OdemeAraci)
                .WithMany(p => p.TohalObSatiris)
                .HasForeignKey(d => d.OdemeAraciId)
                .WillCascadeOnDelete(false);

            HasRequired(d => d.OdemeBordrosu)
                .WithMany(p => p.TohalObSatiriOdemeBordrosus)
                .HasForeignKey(d => d.OdemeBordrosuId)
                .WillCascadeOnDelete(false);

            HasOptional(d => d.SonrakiBordro)
                .WithMany(p => p.TohalObSatiriSonrakiBordroes)
                .HasForeignKey(d => d.SonrakiBordroId);
        }
    }
}
