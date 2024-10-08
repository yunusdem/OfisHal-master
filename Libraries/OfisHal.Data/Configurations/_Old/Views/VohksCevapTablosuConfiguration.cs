using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohksCevapTablosuConfiguration : EntityTypeConfiguration<VohksCevapTablosu>
    {
        public VohksCevapTablosuConfiguration()
        {
            //HasNoKey();

            ToTable("VOHKS_CEVAP_TABLOSU");

            Property(e => e.Durum).HasColumnName("DURUM");

            Property(e => e.EvrakId).HasColumnName("EVRAK_ID");

            Property(e => e.EvrakNo)
                .IsUnicode(false)
                .HasColumnName("EVRAK_NO");

            Property(e => e.EvrakTuru).HasColumnName("EVRAK_TURU");

            Property(e => e.Guid).HasColumnName("GUID");

            Property(e => e.HataKodu).HasColumnName("HATA_KODU");

            Property(e => e.HataMesaji)
                .HasMaxLength(800)
                .IsUnicode(false)
                .HasColumnName("HATA_MESAJI");

            Property(e => e.IslemTuru).HasColumnName("ISLEM_TURU");

            Property(e => e.IstekTarih)
                .HasColumnType("datetime")
                .HasColumnName("ISTEK_TARIH");

            Property(e => e.SatirId).HasColumnName("SATIR_ID");
        }
    }
}
