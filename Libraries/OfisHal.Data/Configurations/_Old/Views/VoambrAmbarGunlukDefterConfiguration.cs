using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VoambrAmbarGunlukDefterConfiguration : EntityTypeConfiguration<VoambrAmbarGunlukDefter>
    {
        public VoambrAmbarGunlukDefterConfiguration()
        {
            //HasNoKey();

            ToTable("VOAMBR_AMBAR_GUNLUK_DEFTER");

            Property(e => e.Adet).HasColumnName("ADET");

            Property(e => e.Ambar)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AMBAR");

            Property(e => e.AmbarPrimi).HasColumnName("AMBAR_PRIMI");

            Property(e => e.Hammaliye).HasColumnName("HAMMALIYE");

            Property(e => e.IrsaliyeId).HasColumnName("IRSALIYE_ID");

            Property(e => e.IrsaliyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IRSALIYE_NO")
                .IsFixedLength();

            Property(e => e.IrsaliyeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("IRSALIYE_TARIHI");

            Property(e => e.Kesinti).HasColumnName("KESINTI");

            Property(e => e.Kod)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KOD")
                .IsFixedLength();

            Property(e => e.Komisyon).HasColumnName("KOMISYON");

            Property(e => e.MuameleFiyat).HasColumnName("MUAMELE_FIYAT");

            Property(e => e.MuameleHammaliye).HasColumnName("MUAMELE_HAMMALIYE");

            Property(e => e.MuameleKdv).HasColumnName("MUAMELE_KDV");

            Property(e => e.Navlun).HasColumnName("NAVLUN");

            Property(e => e.NavlunKdv).HasColumnName("NAVLUN_KDV");

            Property(e => e.PlakaNo)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PLAKA_NO");

            Property(e => e.Yekun).HasColumnName("YEKUN");
        }
    }
}
