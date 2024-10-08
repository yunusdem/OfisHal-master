using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrSiparisKarlilikRaporuConfiguration : EntityTypeConfiguration<VohalrSiparisKarlilikRaporu>
    {
        public VohalrSiparisKarlilikRaporuConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_SIPARIS_KARLILIK_RAPORU");

            Property(e => e.Aciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.AlisKapMiktari).HasColumnName("ALIS_KAP_MIKTARI");

            Property(e => e.AlisMiktari).HasColumnName("ALIS_MIKTARI");

            Property(e => e.AlisTutari).HasColumnName("ALIS_TUTARI");

            Property(e => e.FaturaMasrafi).HasColumnName("FATURA_MASRAFI");

            Property(e => e.Kapandi).HasColumnName("KAPANDI");

            Property(e => e.Kar).HasColumnName("KAR");

            Property(e => e.Masraf).HasColumnName("MASRAF");

            Property(e => e.SatisKapMiktari).HasColumnName("SATIS_KAP_MIKTARI");

            Property(e => e.SatisMiktari).HasColumnName("SATIS_MIKTARI");

            Property(e => e.SatisTutari).HasColumnName("SATIS_TUTARI");

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
