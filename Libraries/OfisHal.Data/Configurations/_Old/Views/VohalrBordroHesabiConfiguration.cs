using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrBordroHesabiConfiguration : EntityTypeConfiguration<VohalrBordroHesabi>
    {
        public VohalrBordroHesabiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_BORDRO_HESABI");

            Property(e => e.DigKiloOndalikSayisi).HasColumnName("DIG_KILO_ONDALIK_SAYISI");

            Property(e => e.FaturaNo)
                .HasMaxLength(43)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO");

            Property(e => e.KapMiktari).HasColumnName("KAP_MIKTARI");

            Property(e => e.Kdv).HasColumnName("KDV");

            Property(e => e.KdvsizTutar).HasColumnName("KDVSIZ_TUTAR");

            Property(e => e.KiloMiktari).HasColumnName("KILO_MIKTARI");

            Property(e => e.MahsupEdilen).HasColumnName("MAHSUP_EDILEN");

            Property(e => e.Rusum).HasColumnName("RUSUM");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.Tevkifat).HasColumnName("TEVKIFAT");
        }
    }
}
