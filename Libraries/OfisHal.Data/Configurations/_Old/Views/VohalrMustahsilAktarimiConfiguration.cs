using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrMustahsilAktarimiConfiguration : EntityTypeConfiguration<VohalrMustahsilAktarimi>
    {
        public VohalrMustahsilAktarimiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_MUSTAHSIL_AKTARIMI");

            Property(e => e.Carikod)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CARIKOD")
                .IsFixedLength();

            Property(e => e.Faturano)
                .HasMaxLength(31)
                .IsUnicode(false)
                .HasColumnName("FATURANO");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.IadesizKapKdv).HasColumnName("IADESIZ_KAP_KDV");

            Property(e => e.IadesizKapKdvOrani).HasColumnName("IADESIZ_KAP_KDV_ORANI");

            Property(e => e.IadesizKapTutari).HasColumnName("IADESIZ_KAP_TUTARI");

            Property(e => e.KdvOrani).HasColumnName("KDV_ORANI");

            Property(e => e.Komisyon).HasColumnName("KOMISYON");

            Property(e => e.KomisyonKdv).HasColumnName("KOMISYON_KDV");

            Property(e => e.KomisyonKdvOrani).HasColumnName("KOMISYON_KDV_ORANI");

            Property(e => e.KomisyonOrani).HasColumnName("KOMISYON_ORANI");

            Property(e => e.Miktar).HasColumnName("MIKTAR");

            Property(e => e.Navlun).HasColumnName("NAVLUN");

            Property(e => e.NavlunKdv).HasColumnName("NAVLUN_KDV");

            Property(e => e.NavlunKdvOrani).HasColumnName("NAVLUN_KDV_ORANI");

            Property(e => e.Stokkodu)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STOKKODU")
                .IsFixedLength();

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.Tutar).HasColumnName("TUTAR");
        }
    }
}
