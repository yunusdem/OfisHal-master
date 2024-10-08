using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrRusumKdvRaporuConfiguration : EntityTypeConfiguration<VohalrRusumKdvRaporu>
    {
        public VohalrRusumKdvRaporuConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_RUSUM_KDV_RAPORU");

            Property(e => e.Ad)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.FaturaToplami).HasColumnName("FATURA_TOPLAMI");

            Property(e => e.IrsaliyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IRSALIYE_NO")
                .IsFixedLength();

            Property(e => e.KdvSatir).HasColumnName("KDV_SATIR");

            Property(e => e.MalKdv).HasColumnName("MAL_KDV");

            Property(e => e.MalTutari).HasColumnName("MAL_TUTARI");

            Property(e => e.Rusum).HasColumnName("RUSUM");

            Property(e => e.RusumKdv).HasColumnName("RUSUM_KDV");

            Property(e => e.RusumKdvIliskisi).HasColumnName("RUSUM_KDV_ILISKISI");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.VergiDairesiAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("VERGI_DAIRESI_ADI");

            Property(e => e.VergiKimlikNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VERGI_KIMLIK_NO")
                .IsFixedLength();
        }
    }
}
