using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalYaziciConfiguration : EntityTypeConfiguration<TohalYazici>
    {
        public TohalYaziciConfiguration()
        {
            HasKey(e => e.YaziciId);

            ToTable("TOHAL_YAZICI");

            Property(e => e.YaziciId).HasColumnName("YAZICI_ID");

            Property(e => e.Ad)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.AmbarNavlunFaturasiSiraNo).HasColumnName("AMBAR_NAVLUN_FATURASI_SIRA_NO");

            Property(e => e.BaglantiNoktasi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BAGLANTI_NOKTASI");

            Property(e => e.BelgeDizini)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BELGE_DIZINI");

            Property(e => e.BelgeYaziciModu).HasColumnName("BELGE_YAZICI_MODU");

            Property(e => e.CihazAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CIHAZ_ADI");

            Property(e => e.KopyaSayisi).HasColumnName("KOPYA_SAYISI");

            Property(e => e.MustahsilFaturasiSiraNo).HasColumnName("MUSTAHSIL_FATURASI_SIRA_NO");

            Property(e => e.PaperOrientation).HasColumnName("PAPER_ORIENTATION");

            Property(e => e.PaperSize).HasColumnName("PAPER_SIZE");

            Property(e => e.SatFaturaBelgesi).HasColumnName("SAT_FATURA_BELGESI");

            Property(e => e.SatisFaturasiSiraNo).HasColumnName("SATIS_FATURASI_SIRA_NO");

            Property(e => e.SiraNo).HasColumnName("SIRA_NO");
        }
    }
}
