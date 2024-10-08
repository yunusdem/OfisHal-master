using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VoambrAmbarFiyatListesiRaporuConfiguration : EntityTypeConfiguration<VoambrAmbarFiyatListesiRaporu>
    {
        public VoambrAmbarFiyatListesiRaporuConfiguration()
        {
            //HasNoKey();

            ToTable("VOAMBR_AMBAR_FIYAT_LISTESI_RAPORU");

            Property(e => e.Aciklama)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.Ad)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.AmbarPrimi).HasColumnName("AMBAR_PRIMI");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.Hammaliye).HasColumnName("HAMMALIYE");

            Property(e => e.HammaliyePrimi).HasColumnName("HAMMALIYE_PRIMI");

            Property(e => e.Kod)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KOD")
                .IsFixedLength();

            Property(e => e.Muamele).HasColumnName("MUAMELE");

            Property(e => e.Navlun).HasColumnName("NAVLUN");

            Property(e => e.PrimSahibiAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PRIM_SAHIBI_ADI");

            Property(e => e.PrimSahibiId).HasColumnName("PRIM_SAHIBI_ID");

            Property(e => e.PrimSahibiKodu)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PRIM_SAHIBI_KODU")
                .IsFixedLength();
        }
    }
}
