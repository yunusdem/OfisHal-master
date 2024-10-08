using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrYuklemeNakliyeRaporuAliConfiguration : EntityTypeConfiguration<VohalrYuklemeNakliyeRaporuAli>
    {
        public VohalrYuklemeNakliyeRaporuAliConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_YUKLEME_NAKLIYE_RAPORU_ALIS");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.Nakliye).HasColumnName("NAKLIYE");

            Property(e => e.NakliyeKdv).HasColumnName("NAKLIYE_KDV");

            Property(e => e.SatHamaliyeAdlandirma)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SAT_HAMALIYE_ADLANDIRMA");

            Property(e => e.SatNakliyeAdlandirma)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SAT_NAKLIYE_ADLANDIRMA");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.Unvan)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNVAN");

            Property(e => e.Yukleme).HasColumnName("YUKLEME");

            Property(e => e.YuklemeKdv).HasColumnName("YUKLEME_KDV");
        }
    }
}
