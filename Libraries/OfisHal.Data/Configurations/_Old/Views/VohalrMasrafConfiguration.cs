using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrMasrafConfiguration : EntityTypeConfiguration<VohalrMasraf>
    {
        public VohalrMasrafConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_MASRAF");

            Property(e => e.Aciklama)
                .IsRequired()
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.HesapAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("HESAP_ADI");

            Property(e => e.KapAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("KAP_ADI");

            Property(e => e.KapSayisi).HasColumnName("KAP_SAYISI");

            Property(e => e.Kdv).HasColumnName("KDV");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.Masraf).HasColumnName("MASRAF");

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

            Property(e => e.Toplam).HasColumnName("TOPLAM");
        }
    }
}
