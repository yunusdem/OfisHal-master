using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalSipariConfiguration : EntityTypeConfiguration<TohalSipari>
    {
        public TohalSipariConfiguration()
        {
            HasKey(e => e.SiparisId);

            ToTable("TOHAL_SIPARIS");

            Property(e => e.SiparisId).HasColumnName("SIPARIS_ID");

            Property(e => e.Aciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.Kapandi).HasColumnName("KAPANDI");

            Property(e => e.MarkaId).HasColumnName("MARKA_ID");

            Property(e => e.MusteriCariKartId).HasColumnName("MUSTERI_CARI_KART_ID");

            Property(e => e.SiparisNo)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SIPARIS_NO")
                .IsFixedLength();

            Property(e => e.SiparisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("SIPARIS_TARIHI");

            HasOptional(d => d.Marka)
                .WithMany(p => p.TohalSiparis)
                .HasForeignKey(d => d.MarkaId);

            HasOptional(d => d.MusteriCariKart)
                .WithMany(p => p.TohalSiparis)
                .HasForeignKey(d => d.MusteriCariKartId);
        }
    }
}
