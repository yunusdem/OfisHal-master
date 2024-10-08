using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VoambSevkIrsaliyesiConfiguration : EntityTypeConfiguration<VoambSevkIrsaliyesi>
    {
        public VoambSevkIrsaliyesiConfiguration()
        {
            //HasNoKey();

            ToTable("VOAMB_SEVK_IRSALIYESI");

            Property(e => e.AmbarAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AMBAR_ADI");

            Property(e => e.AmbarId).HasColumnName("AMBAR_ID");

            Property(e => e.AmbarKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AMBAR_KODU")
                .IsFixedLength();

            Property(e => e.EklemeZamani)
                .HasColumnType("datetime")
                .HasColumnName("EKLEME_ZAMANI");

            Property(e => e.EkleyenId).HasColumnName("EKLEYEN_ID");

            Property(e => e.EkleyenKullaniciAdi)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EKLEYEN_KULLANICI_ADI");

            Property(e => e.GeldigiYer)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("GELDIGI_YER");

            Property(e => e.GeldigiYerId).HasColumnName("GELDIGI_YER_ID");

            Property(e => e.GenelToplam).HasColumnName("GENEL_TOPLAM");

            Property(e => e.GuncellemeZamani)
                .HasColumnType("datetime")
                .HasColumnName("GUNCELLEME_ZAMANI");

            Property(e => e.GuncellemeZamaniString)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("GUNCELLEME_ZAMANI_STRING");

            Property(e => e.GuncelleyenKullaniciAdi)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GUNCELLEYEN_KULLANICI_ADI");

            Property(e => e.IrsaliyeId).HasColumnName("IRSALIYE_ID");

            Property(e => e.IrsaliyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IRSALIYE_NO")
                .IsFixedLength();

            Property(e => e.IrsaliyeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("IRSALIYE_TARIHI");

            Property(e => e.KayitId).HasColumnName("KAYIT_ID");

            Property(e => e.KdvOrani).HasColumnName("KDV_ORANI");

            Property(e => e.Kesinti).HasColumnName("KESINTI");

            Property(e => e.KesintiTutari).HasColumnName("KESINTI_TUTARI");

            Property(e => e.Odendi).HasColumnName("ODENDI");

            Property(e => e.PlakaId).HasColumnName("PLAKA_ID");

            Property(e => e.PlakaNo)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PLAKA_NO");

            Property(e => e.ReferansNo)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("REFERANS_NO");

            Property(e => e.Sofor)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SOFOR");

            Property(e => e.SoforNot)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SOFOR_NOT");

            Property(e => e.ToplamTutar).HasColumnName("TOPLAM_TUTAR");

            Property(e => e.TutariDegistir).HasColumnName("TUTARI_DEGISTIR");
        }
    }
}
