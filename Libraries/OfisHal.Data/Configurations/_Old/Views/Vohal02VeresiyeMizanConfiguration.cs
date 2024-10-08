using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class Vohal02VeresiyeMizanConfiguration : EntityTypeConfiguration<Vohal02VeresiyeMizan>
    {
        public Vohal02VeresiyeMizanConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_02_VERESIYE_MIZAN");

            Property(e => e.Ad)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.AlacakToplami).HasColumnName("ALACAK_TOPLAMI");

            Property(e => e.Bakiye).HasColumnName("BAKIYE");

            Property(e => e.BankaHareketBakiye).HasColumnName("BANKA_HAREKET_BAKIYE");

            Property(e => e.BorcToplami).HasColumnName("BORC_TOPLAMI");

            Property(e => e.CariDevir).HasColumnName("CARI_DEVIR");

            Property(e => e.CariHareketBakiye).HasColumnName("CARI_HAREKET_BAKIYE");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.Kod)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KOD")
                .IsFixedLength();

            Property(e => e.OdemeBordrosuBakiye).HasColumnName("ODEME_BORDROSU_BAKIYE");

            Property(e => e.RehinKapHareketBakiye).HasColumnName("REHIN_KAP_HAREKET_BAKIYE");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
        }
    }
}
