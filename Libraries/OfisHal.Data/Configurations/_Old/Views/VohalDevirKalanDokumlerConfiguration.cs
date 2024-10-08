using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalDevirKalanDokumlerConfiguration : EntityTypeConfiguration<VohalDevirKalanDokumler>
    {
        public VohalDevirKalanDokumlerConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_DEVIR_KALAN_DOKUMLER");

            Property(e => e.Aciklama)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.BildirimTuru).HasColumnName("BILDIRIM_TURU");

            Property(e => e.BildirimciAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BILDIRIMCI_ADI");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.HalId).HasColumnName("HAL_ID");

            Property(e => e.KapId).HasColumnName("KAP_ID");

            Property(e => e.KapSayisi).HasColumnName("KAP_SAYISI");

            Property(e => e.KunyeBelgeNo)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KUNYE_BELGE_NO")
                .IsFixedLength();

            Property(e => e.KunyePlakaNo)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KUNYE_PLAKA_NO")
                .IsFixedLength();

            Property(e => e.KunyeRusum).HasColumnName("KUNYE_RUSUM");

            Property(e => e.KunyeSifati).HasColumnName("KUNYE_SIFATI");

            Property(e => e.KunyeTuru).HasColumnName("KUNYE_TURU");

            Property(e => e.KunyeZamani)
                .HasColumnType("datetime")
                .HasColumnName("KUNYE_ZAMANI");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.MalId).HasColumnName("MAL_ID");

            Property(e => e.MalSahibiAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAL_SAHIBI_ADI");

            Property(e => e.MarkaId).HasColumnName("MARKA_ID");

            Property(e => e.Miktar).HasColumnName("MIKTAR");

            Property(e => e.OrtaklikOrani).HasColumnName("ORTAKLIK_ORANI");

            Property(e => e.Plaka)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PLAKA");

            Property(e => e.Sifati).HasColumnName("SIFATI");

            Property(e => e.StokGirisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("STOK_GIRIS_TARIHI");

            Property(e => e.StokKunye)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STOK_KUNYE")
                .IsFixedLength();

            Property(e => e.StokKunyesi)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STOK_KUNYESI")
                .IsFixedLength();

            Property(e => e.StokTipi).HasColumnName("STOK_TIPI");

            Property(e => e.UreticiAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("URETICI_ADI");

            Property(e => e.UretimYeriId).HasColumnName("URETIM_YERI_ID");

            Property(e => e.YerId).HasColumnName("YER_ID");
        }
    }
}
