using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Core.Domain.Configurations
{
    internal class VohalAramaDokumdenKunyeConfiguration : EntityTypeConfiguration<VohalAramaDokumdenKunye>
    {
        public VohalAramaDokumdenKunyeConfiguration()
        {
            //HasNoKey();
            HasKey(e => e.StokHareketiId);
            ToTable("VOHAL_ARAMA_DOKUMDEN_KUNYE");

            Property(e => e.KapAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("KAP_ADI");

            Property(e => e.KapId).HasColumnName("KAP_ID");

            Property(e => e.KapSayisi).HasColumnName("KAP_SAYISI");

            Property(e => e.Kunye)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KUNYE")
                .IsFixedLength();

            Property(e => e.KunyeId).HasColumnName("KUNYE_ID");

            Property(e => e.MalAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAL_ADI");

            Property(e => e.MalId).HasColumnName("MAL_ID");

            Property(e => e.Marka)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MARKA");

            Property(e => e.MarkaId).HasColumnName("MARKA_ID");

            Property(e => e.Miktar).HasColumnName("MIKTAR");

            Property(e => e.MustahsilAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MUSTAHSIL_ADI");

            Property(e => e.SatilanKap).HasColumnName("SATILAN_KAP");

            Property(e => e.SatilanMiktar).HasColumnName("SATILAN_MIKTAR");

            Property(e => e.StokHareketiId).HasColumnName("STOK_HAREKETI_ID");
        }
    }
}
