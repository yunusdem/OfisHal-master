using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrSatisIcmaliConfiguration : EntityTypeConfiguration<VohalrSatisIcmali>
    {
        public VohalrSatisIcmaliConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_SATIS_ICMALI");

            Property(e => e.DigFiyatKurusSayisi).HasColumnName("DIG_FIYAT_KURUS_SAYISI");

            Property(e => e.DigKiloOndalikSayisi).HasColumnName("DIG_KILO_ONDALIK_SAYISI");

            Property(e => e.DokRusumOrani).HasColumnName("DOK_RUSUM_ORANI");

            Property(e => e.FaturaNo)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.Fiyat2).HasColumnName("FIYAT2");

            Property(e => e.KapMiktari).HasColumnName("KAP_MIKTARI");

            Property(e => e.Kesildi).HasColumnName("KESILDI");

            Property(e => e.Kod)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KOD")
                .IsFixedLength();

            Property(e => e.MalAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAL_ADI");

            Property(e => e.MalId).HasColumnName("MAL_ID");

            Property(e => e.MalMiktari).HasColumnName("MAL_MIKTARI");

            Property(e => e.Marka)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MARKA");

            Property(e => e.NetTutar).HasColumnName("NET_TUTAR");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.Tur).HasColumnName("TUR");

            Property(e => e.Unvan)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNVAN");
        }
    }
}
