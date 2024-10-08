using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class VohalSipariConfiguration : EntityTypeConfiguration<VohalSipari>
    {
        public VohalSipariConfiguration()
        {
            //HasNoKey();
            HasKey(x => x.SiparisId);
            ToTable("VOHAL_SIPARIS");

            Property(e => e.Aciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.Kapandi).HasColumnName("KAPANDI");

            Property(e => e.MusteriAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MUSTERI_ADI");

            Property(e => e.MusteriCariKartId).HasColumnName("MUSTERI_CARI_KART_ID");

            Property(e => e.MusteriKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MUSTERI_KODU")
                .IsFixedLength();

            Property(e => e.SiparisId).HasColumnName("SIPARIS_ID");

            Property(e => e.SiparisNo)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SIPARIS_NO")
                .IsFixedLength();

            Property(e => e.SiparisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("SIPARIS_TARIHI");
        }
    }
}
