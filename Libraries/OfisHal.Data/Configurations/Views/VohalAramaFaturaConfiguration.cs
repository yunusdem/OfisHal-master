using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Core.Domain.Configurations
{
    internal class VohalAramaFaturaConfiguration : EntityTypeConfiguration<VohalAramaFatura>
    {
        public VohalAramaFaturaConfiguration()
        {
            //HasNoKey();
            HasKey(e => e.FaturaId);

            ToTable("VOHAL_ARAMA_FATURA");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.EkleyenId).HasColumnName("EKLEYEN_ID");

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

            Property(e => e.MagazaAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAGAZA_ADI");

            Property(e => e.PV)
                .IsRequired()
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("P_V");

            Property(e => e.ReferansId).HasColumnName("REFERANS_ID");

            Property(e => e.ReferansNo)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("REFERANS_NO");

            Property(e => e.RehinDevri).HasColumnName("REHIN_DEVRI");

            Property(e => e.SiparisId).HasColumnName("SIPARIS_ID");

            Property(e => e.SonToplam).HasColumnName("SON_TOPLAM");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.Tip).HasColumnName("TIP");

            Property(e => e.Unvan)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNVAN");
        }
    }
}
