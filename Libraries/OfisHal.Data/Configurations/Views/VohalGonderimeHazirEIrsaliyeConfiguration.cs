using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class VohalGonderimeHazirEIrsaliyeConfiguration : EntityTypeConfiguration<VohalGonderimeHazirEIrsaliye>
    {
        public VohalGonderimeHazirEIrsaliyeConfiguration()
        {
            HasKey(e => e.FaturaId);
            //HasNoKey();

            ToTable("VOHAL_GONDERIME_HAZIR_E_IRSALIYE");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.EBelgeTuru).HasColumnName("E_BELGE_TURU");

            Property(e => e.EIrsaliyeBelgesi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("E_IRSALIYE_BELGESI");

            Property(e => e.EIrsaliyeDurumu).HasColumnName("E_IRSALIYE_DURUMU");

            Property(e => e.EIrsaliyeHataAciklamasi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("E_IRSALIYE_HATA_ACIKLAMASI");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.IrsaliyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IRSALIYE_NO")
                .IsFixedLength();

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.ToplamTutar).HasColumnName("TOPLAM_TUTAR");

            Property(e => e.Unvan)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNVAN");
        }
    }
}
