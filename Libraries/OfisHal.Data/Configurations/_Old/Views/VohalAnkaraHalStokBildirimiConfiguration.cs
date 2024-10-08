using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalAnkaraHalStokBildirimiConfiguration : EntityTypeConfiguration<VohalAnkaraHalStokBildirimi>
    {
        public VohalAnkaraHalStokBildirimiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_ANKARA_HAL_STOK_BILDIRIMI");

            Property(e => e.Belde)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BELDE");

            Property(e => e.BildirimDurumu).HasColumnName("BILDIRIM_DURUMU");

            Property(e => e.Birim).HasColumnName("BIRIM");

            Property(e => e.CariAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CARI_ADI");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.CariKodu)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CARI_KODU")
                .IsFixedLength();

            Property(e => e.DokumNo)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DOKUM_NO")
                .IsFixedLength();

            Property(e => e.DonenAlanDegeri)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DONEN_ALAN_DEGERI");

            Property(e => e.Il)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IL");

            Property(e => e.Ilce)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ILCE");

            Property(e => e.KunyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KUNYE_NO")
                .IsFixedLength();

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.Miktar).HasColumnName("MIKTAR");

            Property(e => e.Plaka)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PLAKA");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.Sifati).HasColumnName("SIFATI");

            Property(e => e.Siralama).HasColumnName("SIRALAMA");

            Property(e => e.StokGirisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("STOK_GIRIS_TARIHI");

            Property(e => e.UretimSekli)
                .IsRequired()
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("URETIM_SEKLI");

            Property(e => e.UrunAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("URUN_ADI");

            Property(e => e.UrunCinsi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("URUN_CINSI");

            Property(e => e.VergiKimlikNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VERGI_KIMLIK_NO")
                .IsFixedLength();
        }
    }
}
