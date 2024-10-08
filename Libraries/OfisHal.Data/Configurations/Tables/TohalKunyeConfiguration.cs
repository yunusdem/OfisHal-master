using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalKunyeConfiguration : EntityTypeConfiguration<TohalKunye>
    {
        public TohalKunyeConfiguration()
        {
            HasKey(e => e.KunyeId);

            ToTable("TOHAL_KUNYE");

            Property(e => e.KunyeId).HasColumnName("KUNYE_ID");

            Property(e => e.BelgeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BELGE_NO")
                .IsFixedLength();

            Property(e => e.BildirimciAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BILDIRIMCI_ADI");

            Property(e => e.Kod)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KOD")
                .IsFixedLength();

            Property(e => e.KunyeZamani)
                .HasColumnType("datetime")
                .HasColumnName("KUNYE_ZAMANI");

            Property(e => e.MalSahibiAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAL_SAHIBI_ADI");

            Property(e => e.PlakaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PLAKA_NO")
                .IsFixedLength();

            Property(e => e.Rusum).HasColumnName("RUSUM");

            Property(e => e.Sifat).HasColumnName("SIFAT");

            Property(e => e.Tur).HasColumnName("TUR");

            Property(e => e.UreticiAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("URETICI_ADI");

            Property(e => e.UretimYeriId).HasColumnName("URETIM_YERI_ID");

            HasOptional(d => d.UretimYeri)
                .WithMany(p => p.TohalKunyes)
                .HasForeignKey(d => d.UretimYeriId);
        }
    }
}
