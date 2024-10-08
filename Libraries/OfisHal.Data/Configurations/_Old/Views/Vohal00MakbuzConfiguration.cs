using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class Vohal00MakbuzConfiguration : EntityTypeConfiguration<Vohal00Makbuz>
    {
        public Vohal00MakbuzConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_00_MAKBUZ");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.CariyeIslemeSekli).HasColumnName("CARIYE_ISLEME_SEKLI");

            Property(e => e.EklemeZamani)
                .HasColumnType("datetime")
                .HasColumnName("EKLEME_ZAMANI");

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.KapSayisi).HasColumnName("KAP_SAYISI");

            Property(e => e.KdvTutari).HasColumnName("KDV_TUTARI");

            Property(e => e.Kesildi).HasColumnName("KESILDI");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.MasrafToplami).HasColumnName("MASRAF_TOPLAMI");

            Property(e => e.NetToplam).HasColumnName("NET_TOPLAM");

            Property(e => e.OrtakId).HasColumnName("ORTAK_ID");

            Property(e => e.OrtaklikOrani).HasColumnName("ORTAKLIK_ORANI");

            Property(e => e.StokGirisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("STOK_GIRIS_TARIHI");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
        }
    }
}
