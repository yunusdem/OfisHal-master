using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrTicariKarlilikConfiguration : EntityTypeConfiguration<VohalrTicariKarlilik>
    {
        public VohalrTicariKarlilikConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_TICARI_KARLILIK");

            Property(e => e.Alis).HasColumnName("ALIS");

            Property(e => e.AlisFaturasiMasrafi).HasColumnName("ALIS_FATURASI_MASRAFI");

            Property(e => e.AlisMalMiktari).HasColumnName("ALIS_MAL_MIKTARI");

            Property(e => e.Kod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KOD")
                .IsFixedLength();

            Property(e => e.MusteriAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MUSTERI_ADI");

            Property(e => e.Satis).HasColumnName("SATIS");

            Property(e => e.SatisFaturasiMasrafi).HasColumnName("SATIS_FATURASI_MASRAFI");

            Property(e => e.SatisMalMiktari).HasColumnName("SATIS_MAL_MIKTARI");

            Property(e => e.SiparisAciklamasi)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SIPARIS_ACIKLAMASI");

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
