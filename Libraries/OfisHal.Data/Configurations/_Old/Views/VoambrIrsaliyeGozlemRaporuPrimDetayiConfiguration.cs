using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VoambrIrsaliyeGozlemRaporuPrimDetayiConfiguration : EntityTypeConfiguration<VoambrIrsaliyeGozlemRaporuPrimDetayi>
    {
        public VoambrIrsaliyeGozlemRaporuPrimDetayiConfiguration()
        {
            //HasNoKey();

            ToTable("VOAMBR_IRSALIYE_GOZLEM_RAPORU_PRIM_DETAYI");

            Property(e => e.Adet).HasColumnName("ADET");

            Property(e => e.AmbarPrimFiyat).HasColumnName("AMBAR_PRIM_FIYAT");

            Property(e => e.AmbarPrimi).HasColumnName("AMBAR_PRIMI");

            Property(e => e.IrsaliyeId).HasColumnName("IRSALIYE_ID");

            Property(e => e.IrsaliyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IRSALIYE_NO")
                .IsFixedLength();

            Property(e => e.IrsaliyeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("IRSALIYE_TARIHI");

            Property(e => e.Prim).HasColumnName("PRIM");

            Property(e => e.PrimSahibi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PRIM_SAHIBI");

            Property(e => e.PrimSahibiId).HasColumnName("PRIM_SAHIBI_ID");

            Property(e => e.PrimSahibiKodu)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PRIM_SAHIBI_KODU")
                .IsFixedLength();

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");
        }
    }
}
