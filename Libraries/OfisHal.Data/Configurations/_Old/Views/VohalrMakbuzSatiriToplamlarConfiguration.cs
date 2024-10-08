using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrMakbuzSatiriToplamlarConfiguration : EntityTypeConfiguration<VohalrMakbuzSatiriToplamlar>
    {
        public VohalrMakbuzSatiriToplamlarConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_MAKBUZ_SATIRI_TOPLAMLAR");

            Property(e => e.FaturaToplami).HasColumnName("FATURA_TOPLAMI");

            Property(e => e.IadeliKapTutari).HasColumnName("IADELI_KAP_TUTARI");

            Property(e => e.Kdv).HasColumnName("KDV");

            Property(e => e.KdvAciklamasi)
                .HasMaxLength(62)
                .IsUnicode(false)
                .HasColumnName("KDV_ACIKLAMASI");

            Property(e => e.KdvOrani).HasColumnName("KDV_ORANI");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.MalTutari).HasColumnName("MAL_TUTARI");

            Property(e => e.NetYekun).HasColumnName("NET_YEKUN");

            Property(e => e.ToplamMasraflar).HasColumnName("TOPLAM_MASRAFLAR");

            Property(e => e.VergilerDahilToplam).HasColumnName("VERGILER_DAHIL_TOPLAM");
        }
    }
}
