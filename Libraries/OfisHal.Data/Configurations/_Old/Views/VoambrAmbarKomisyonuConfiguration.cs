using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VoambrAmbarKomisyonuConfiguration : EntityTypeConfiguration<VoambrAmbarKomisyonu>
    {
        public VoambrAmbarKomisyonuConfiguration()
        {
            //HasNoKey();

            ToTable("VOAMBR_AMBAR_KOMISYONU");

            Property(e => e.Adet).HasColumnName("ADET");

            Property(e => e.AmbarAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AMBAR_ADI");

            Property(e => e.AmbarId).HasColumnName("AMBAR_ID");

            Property(e => e.AmbarKodu)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AMBAR_KODU")
                .IsFixedLength();

            Property(e => e.IrsaliyeId).HasColumnName("IRSALIYE_ID");

            Property(e => e.Komisyon).HasColumnName("KOMISYON");

            Property(e => e.PlakaNo)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PLAKA_NO");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
        }
    }
}
