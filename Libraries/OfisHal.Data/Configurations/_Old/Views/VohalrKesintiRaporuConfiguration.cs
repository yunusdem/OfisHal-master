using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrKesintiRaporuConfiguration : EntityTypeConfiguration<VohalrKesintiRaporu>
    {
        public VohalrKesintiRaporuConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_KESINTI_RAPORU");

            Property(e => e.BagkurMasrafi).HasColumnName("BAGKUR_MASRAFI");

            Property(e => e.BorsaMasrafi).HasColumnName("BORSA_MASRAFI");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.HesBagkurHesabiKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HES_BAGKUR_HESABI_KODU")
                .IsFixedLength();

            Property(e => e.HesBorsaHesabiKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HES_BORSA_HESABI_KODU")
                .IsFixedLength();

            Property(e => e.HesRusumHesabiKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HES_RUSUM_HESABI_KODU")
                .IsFixedLength();

            Property(e => e.HesStopajHesabiKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HES_STOPAJ_HESABI_KODU")
                .IsFixedLength();

            Property(e => e.MustahsilAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MUSTAHSIL_ADI");

            Property(e => e.MustahsilKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MUSTAHSIL_KODU")
                .IsFixedLength();

            Property(e => e.RusumMasrafi).HasColumnName("RUSUM_MASRAFI");

            Property(e => e.StopajMasrafi).HasColumnName("STOPAJ_MASRAFI");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.Tip).HasColumnName("TIP");

            Property(e => e.VergiKimlikNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VERGI_KIMLIK_NO")
                .IsFixedLength();
        }
    }
}
