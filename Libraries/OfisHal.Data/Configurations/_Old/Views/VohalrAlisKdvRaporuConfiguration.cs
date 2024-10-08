using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrAlisKdvRaporuConfiguration : EntityTypeConfiguration<VohalrAlisKdvRaporu>
    {
        public VohalrAlisKdvRaporuConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_ALIS_KDV_RAPORU");

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

            Property(e => e.IrsaliyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IRSALIYE_NO")
                .IsFixedLength();

            Property(e => e.Kdv).HasColumnName("KDV");

            Property(e => e.MalTutari).HasColumnName("MAL_TUTARI");

            Property(e => e.Rusum).HasColumnName("RUSUM");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.VergiKimlikNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VERGI_KIMLIK_NO")
                .IsFixedLength();
        }
    }
}
