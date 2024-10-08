using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VoambrAmbarKesintiRaporu1Configuration : EntityTypeConfiguration<VoambrAmbarKesintiRaporu1>
    {
        public VoambrAmbarKesintiRaporu1Configuration()
        {
            //HasNoKey();

            ToTable("VOAMBR_AMBAR_KESINTI_RAPORU1");

            Property(e => e.Ad)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.Adet).HasColumnName("ADET");

            Property(e => e.AmbarPrimi).HasColumnName("AMBAR_PRIMI");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.IrsaliyeId).HasColumnName("IRSALIYE_ID");

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

            Property(e => e.Masraf).HasColumnName("MASRAF");

            Property(e => e.Navlun).HasColumnName("NAVLUN");

            Property(e => e.Plaka)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PLAKA");

            Property(e => e.PlakaId).HasColumnName("PLAKA_ID");

            Property(e => e.RefNo).HasColumnName("REF_NO");
        }
    }
}
