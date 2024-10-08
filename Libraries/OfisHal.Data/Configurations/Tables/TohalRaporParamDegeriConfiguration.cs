using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalRaporParamDegeriConfiguration : EntityTypeConfiguration<TohalRaporParamDegeri>
    {
        public TohalRaporParamDegeriConfiguration()
        {
            HasKey(e => new { e.KullaniciId, e.RaporId, e.ParametreId, e.SiraNo });

            ToTable("TOHAL_RAPOR_PARAM_DEGERI");

            Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            Property(e => e.RaporId).HasColumnName("RAPOR_ID");

            Property(e => e.ParametreId).HasColumnName("PARAMETRE_ID");

            Property(e => e.SiraNo).HasColumnName("SIRA_NO");

            Property(e => e.IlkSayi).HasColumnName("ILK_SAYI");

            Property(e => e.IlkString)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ILK_STRING");

            Property(e => e.IlkTarih)
                .HasColumnType("datetime")
                .HasColumnName("ILK_TARIH");

            Property(e => e.SonSayi).HasColumnName("SON_SAYI");

            Property(e => e.SonString)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SON_STRING");

            Property(e => e.SonTarih)
                .HasColumnType("datetime")
                .HasColumnName("SON_TARIH");

            Property(e => e.Tip).HasColumnName("TIP");

            HasRequired(d => d.Kullanici)
                .WithMany(p => p.TohalRaporParamDegeris)
                .HasForeignKey(d => d.KullaniciId)
                .WillCascadeOnDelete(false);
        }
    }
}
