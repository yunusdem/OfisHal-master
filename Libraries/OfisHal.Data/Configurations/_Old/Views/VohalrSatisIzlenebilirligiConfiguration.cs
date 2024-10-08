using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrSatisIzlenebilirligiConfiguration : EntityTypeConfiguration<VohalrSatisIzlenebilirligi>
    {
        public VohalrSatisIzlenebilirligiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_SATIS_IZLENEBILIRLIGI");

            Property(e => e.BirimFiyati).HasColumnName("BIRIM_FIYATI");

            Property(e => e.DokumNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DOKUM_NO")
                .IsFixedLength();

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.FaturaTarihi)
                .HasColumnType("datetime")
                .HasColumnName("FATURA_TARIHI");

            Property(e => e.FaturaUnvani)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("FATURA_UNVANI");

            Property(e => e.FiyatKurusBasamakSayisi).HasColumnName("FIYAT_KURUS_BASAMAK_SAYISI");

            Property(e => e.KapMiktari).HasColumnName("KAP_MIKTARI");

            Property(e => e.MalKdv).HasColumnName("MAL_KDV");

            Property(e => e.Marka)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MARKA");

            Property(e => e.Miktar).HasColumnName("MIKTAR");

            Property(e => e.MiktarBasamakSayisi).HasColumnName("MIKTAR_BASAMAK_SAYISI");

            Property(e => e.MustahsilAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MUSTAHSIL_ADI");

            Property(e => e.MustahsilFatNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MUSTAHSIL_FAT_NO")
                .IsFixedLength();

            Property(e => e.MustahsilKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MUSTAHSIL_KODU")
                .IsFixedLength();

            Property(e => e.MusteriKodu)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MUSTERI_KODU")
                .IsFixedLength();

            Property(e => e.NetTutar).HasColumnName("NET_TUTAR");

            Property(e => e.UrunAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("URUN_ADI");

            Property(e => e.VergiDairesi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("VERGI_DAIRESI");

            Property(e => e.VergiNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VERGI_NO")
                .IsFixedLength();
        }
    }
}
