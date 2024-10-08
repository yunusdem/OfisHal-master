using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class Vohal00MakbuzKesilmemisConfiguration : EntityTypeConfiguration<Vohal00MakbuzKesilmemis>
    {
        public Vohal00MakbuzKesilmemisConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_00_MAKBUZ_KESILMEMIS");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.CariyeIslemeSekli).HasColumnName("CARIYE_ISLEME_SEKLI");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.NetToplam).HasColumnName("NET_TOPLAM");

            Property(e => e.OrtakId).HasColumnName("ORTAK_ID");

            Property(e => e.OrtaklikOrani).HasColumnName("ORTAKLIK_ORANI");

            Property(e => e.StokGirisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("STOK_GIRIS_TARIHI");

            Property(e => e.StokTutari).HasColumnName("STOK_TUTARI");
        }
    }
}
