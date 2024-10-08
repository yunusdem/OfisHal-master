using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalOfisEdefterIcerikMasterConfiguration : EntityTypeConfiguration<VohalOfisEdefterIcerikMaster>
    {
        public VohalOfisEdefterIcerikMasterConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_OFIS_EDEFTER_ICERIK_MASTER");

            Property(e => e.AlacakToplami).HasColumnName("ALACAK_TOPLAMI");

            Property(e => e.BorcToplami).HasColumnName("BORC_TOPLAMI");

            Property(e => e.FirmaVkn)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FIRMA_VKN")
                .IsFixedLength();

            Property(e => e.Hakkinda)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("HAKKINDA");

            Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");

            Property(e => e.MuhFisNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MUH_FIS_NO")
                .IsFixedLength();

            Property(e => e.MuhFisTarih)
                .HasColumnType("datetime")
                .HasColumnName("MUH_FIS_TARIH");

            Property(e => e.YevmiyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("YEVMIYE_NO")
                .IsFixedLength();
        }
    }
}
