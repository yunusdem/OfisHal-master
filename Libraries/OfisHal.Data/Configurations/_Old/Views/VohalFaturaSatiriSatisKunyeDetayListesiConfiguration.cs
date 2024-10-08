using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalFaturaSatiriSatisKunyeDetayListesiConfiguration : EntityTypeConfiguration<VohalFaturaSatiriSatisKunyeDetayListesi>
    {
        public VohalFaturaSatiriSatisKunyeDetayListesiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_FATURA_SATIRI_SATIS_KUNYE_DETAY_LISTESI");

            Property(e => e.BelgeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BELGE_NO")
                .IsFixedLength();

            Property(e => e.BildirimTarihi)
                .HasColumnType("datetime")
                .HasColumnName("BILDIRIM_TARIHI");

            Property(e => e.BildirimciAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BILDIRIMCI_ADI");

            Property(e => e.BirimFiyati).HasColumnName("BIRIM_FIYATI");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.FaturaSatiriId).HasColumnName("FATURA_SATIRI_ID");

            Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");

            Property(e => e.Kod)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KOD")
                .IsFixedLength();

            Property(e => e.KunyeId).HasColumnName("KUNYE_ID");

            Property(e => e.MalSahibiAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAL_SAHIBI_ADI");

            Property(e => e.MalinAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MALIN_ADI");

            Property(e => e.MalinCinsi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MALIN_CINSI");

            Property(e => e.MalinGidecegiYer)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MALIN_GIDECEGI_YER");

            Property(e => e.MalinMiktari).HasColumnName("MALIN_MIKTARI");

            Property(e => e.MalinTuru)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MALIN_TURU");

            Property(e => e.MalinUretildigiYer)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MALIN_URETILDIGI_YER");

            Property(e => e.MiktarBirimAdi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MIKTAR_BIRIM_ADI")
                .IsFixedLength();

            Property(e => e.Nereden)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NEREDEN");

            Property(e => e.Nereye)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NEREYE");

            Property(e => e.PlakaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PLAKA_NO")
                .IsFixedLength();

            Property(e => e.Rusum).HasColumnName("RUSUM");

            Property(e => e.Sifat).HasColumnName("SIFAT");

            Property(e => e.UreticiAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("URETICI_ADI");

            Property(e => e.UretimTarihi)
                .HasColumnType("datetime")
                .HasColumnName("URETIM_TARIHI");

            Property(e => e.UretimYeriId).HasColumnName("URETIM_YERI_ID");
        }
    }
}
