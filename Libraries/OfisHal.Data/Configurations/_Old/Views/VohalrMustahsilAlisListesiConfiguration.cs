using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrMustahsilAlisListesiConfiguration : EntityTypeConfiguration<VohalrMustahsilAlisListesi>
    {
        public VohalrMustahsilAlisListesiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_MUSTAHSIL_ALIS_LISTESI");

            Property(e => e.BirimFiyati).HasColumnName("BIRIM_FIYATI");

            Property(e => e.CariUnvan)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CARI_UNVAN");

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

            Property(e => e.Kunye)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KUNYE")
                .IsFixedLength();

            Property(e => e.MalKdv).HasColumnName("MAL_KDV");

            Property(e => e.Marka)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MARKA");

            Property(e => e.Miktar).HasColumnName("MIKTAR");

            Property(e => e.MiktarBasamakSayisi).HasColumnName("MIKTAR_BASAMAK_SAYISI");

            Property(e => e.MusteriKodu)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MUSTERI_KODU")
                .IsFixedLength();

            Property(e => e.RefNo).HasColumnName("REF_NO");

            Property(e => e.Tutar).HasColumnName("TUTAR");

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
