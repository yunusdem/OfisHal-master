using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalbMuhFisiConfiguration : EntityTypeConfiguration<VohalbMuhFisi>
    {
        public VohalbMuhFisiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALB_MUH_FISI");

            Property(e => e.Ad)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.Adres)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ADRES");

            Property(e => e.FirmaAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("FIRMA_ADI");

            Property(e => e.FisNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FIS_NO")
                .IsFixedLength();

            Property(e => e.Hakkinda)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("HAKKINDA");

            Property(e => e.Kod)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KOD")
                .IsFixedLength();

            Property(e => e.Konu).HasColumnName("KONU");

            Property(e => e.Meblag).HasColumnName("MEBLAG");

            Property(e => e.MuhFisId).HasColumnName("MUH_FIS_ID");

            Property(e => e.MuhFisSatiriAciklma)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MUH_FIS_SATIRI_ACIKLMA");

            Property(e => e.MuhFisiSatiriTipi).HasColumnName("MUH_FISI_SATIRI_TIPI");

            Property(e => e.MuhFisiTarihi)
                .HasColumnType("datetime")
                .HasColumnName("MUH_FISI_TARIHI");

            Property(e => e.MuhHesapId).HasColumnName("MUH_HESAP_ID");

            Property(e => e.MuhHesapTipi).HasColumnName("MUH_HESAP_TIPI");

            Property(e => e.MuhHesapTur).HasColumnName("MUH_HESAP_TUR");

            Property(e => e.Tur).HasColumnName("TUR");

            Property(e => e.UstHesapAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UST_HESAP_ADI");

            Property(e => e.UstHesapKodu)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UST_HESAP_KODU")
                .IsFixedLength();

            Property(e => e.UstKod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("UST_KOD");

            Property(e => e.YevmiyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("YEVMIYE_NO")
                .IsFixedLength();
        }
    }
}
