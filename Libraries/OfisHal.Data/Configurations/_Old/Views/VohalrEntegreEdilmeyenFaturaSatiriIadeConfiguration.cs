using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrEntegreEdilmeyenFaturaSatiriIadeConfiguration : EntityTypeConfiguration<VohalrEntegreEdilmeyenFaturaSatiriIade>
    {
        public VohalrEntegreEdilmeyenFaturaSatiriIadeConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_ENTEGRE_EDILMEYEN_FATURA_SATIRI_IADE");

            Property(e => e.DigFiyatKurusSayisi).HasColumnName("DIG_FIYAT_KURUS_SAYISI");

            Property(e => e.DigKiloOndalikSayisi).HasColumnName("DIG_KILO_ONDALIK_SAYISI");

            Property(e => e.KapSayisi).HasColumnName("KAP_SAYISI");

            Property(e => e.Kesildi).HasColumnName("KESILDI");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.MalAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAL_ADI");

            Property(e => e.MalId).HasColumnName("MAL_ID");

            Property(e => e.MarkaAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MARKA_ADI");

            Property(e => e.MarkaId).HasColumnName("MARKA_ID");

            Property(e => e.Miktar).HasColumnName("MIKTAR");

            Property(e => e.StokTipi).HasColumnName("STOK_TIPI");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
        }
    }
}
