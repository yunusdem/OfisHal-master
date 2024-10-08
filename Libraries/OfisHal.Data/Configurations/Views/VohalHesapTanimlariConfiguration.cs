using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Core.Domain.Configurations
{
    internal class VohalHesapTanimlariConfiguration : EntityTypeConfiguration<VohalHesapTanimlari>
    {
        public VohalHesapTanimlariConfiguration()
        {
            //HasNoKey();
            HasKey(x=>new {x.HesStopajHesabiId,x.HesStopajHesabiKodu });
            ToTable("VOHAL_HESAP_TANIMLARI");

            Property(e => e.HesBagkurHesabiId).HasColumnName("HES_BAGKUR_HESABI_ID");

            Property(e => e.HesBagkurHesabiKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HES_BAGKUR_HESABI_KODU")
                .IsFixedLength();

            Property(e => e.HesBorsaHesabiId).HasColumnName("HES_BORSA_HESABI_ID");

            Property(e => e.HesBorsaHesabiKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HES_BORSA_HESABI_KODU")
                .IsFixedLength();

            Property(e => e.HesCiroPrimiHesabiId).HasColumnName("HES_CIRO_PRIMI_HESABI_ID");

            Property(e => e.HesCiroPrimiHesabiKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HES_CIRO_PRIMI_HESABI_KODU")
                .IsFixedLength();

            Property(e => e.HesHamaliyeHesabiId).HasColumnName("HES_HAMALIYE_HESABI_ID");

            Property(e => e.HesHamaliyeHesabiKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HES_HAMALIYE_HESABI_KODU")
                .IsFixedLength();

            Property(e => e.HesIadesizSandikHesabiId).HasColumnName("HES_IADESIZ_SANDIK_HESABI_ID");

            Property(e => e.HesIadesizSandikHesabiKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HES_IADESIZ_SANDIK_HESABI_KODU")
                .IsFixedLength();

            Property(e => e.HesNakliyeHesabiId).HasColumnName("HES_NAKLIYE_HESABI_ID");

            Property(e => e.HesNakliyeHesabiKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HES_NAKLIYE_HESABI_KODU")
                .IsFixedLength();

            Property(e => e.HesNavlunHesabiId).HasColumnName("HES_NAVLUN_HESABI_ID");

            Property(e => e.HesNavlunHesabiKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HES_NAVLUN_HESABI_KODU")
                .IsFixedLength();

            Property(e => e.HesRehinHesabiId).HasColumnName("HES_REHIN_HESABI_ID");

            Property(e => e.HesRehinHesabiKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HES_REHIN_HESABI_KODU")
                .IsFixedLength();

            Property(e => e.HesRusumHesabiId).HasColumnName("HES_RUSUM_HESABI_ID");

            Property(e => e.HesRusumHesabiKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HES_RUSUM_HESABI_KODU")
                .IsFixedLength();

            Property(e => e.HesStopajHesabiId).HasColumnName("HES_STOPAJ_HESABI_ID");

            Property(e => e.HesStopajHesabiKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HES_STOPAJ_HESABI_KODU")
                .IsFixedLength();
        }
    }
}
