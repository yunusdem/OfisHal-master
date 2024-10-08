using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalAramaAlisFaturasiKunyeBildirimListesiConfiguration : EntityTypeConfiguration<VohalAramaAlisFaturasiKunyeBildirimListesi>
    {
        public VohalAramaAlisFaturasiKunyeBildirimListesiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_ARAMA_ALIS_FATURASI_KUNYE_BILDIRIM_LISTESI");

            Property(e => e.Durum)
                .IsRequired()
                .HasMaxLength(7)
                .IsUnicode(false);

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Fatura no")
                .IsFixedLength();

            Property(e => e.KayitId).HasColumnName("KAYIT_ID");

            Property(e => e.KünyeDurumu)
                .IsRequired()
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("Künye durumu");

            Property(e => e.MalAdı)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("Mal adı");

            Property(e => e.MüstahsilAdı)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("Müstahsil adı");

            Property(e => e.MüşteriAdı)
                .IsRequired()
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Müşteri adı");

            Property(e => e.PlakaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Plaka no")
                .IsFixedLength();

            Property(e => e.SatışKünyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Satış künye no")
                .IsFixedLength();

            Property(e => e.StokKünyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Stok künye no")
                .IsFixedLength();

            Property(e => e.Tarih).HasColumnType("datetime");
        }
    }
}
