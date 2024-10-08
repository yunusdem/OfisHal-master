using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class Vohal02FaturaConfiguration : EntityTypeConfiguration<Vohal02Fatura>
    {
        public Vohal02FaturaConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_02_FATURA");

            Property(e => e.EkleyenId).HasColumnName("EKLEYEN_ID");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.FaturaToplami).HasColumnName("FATURA_TOPLAMI");

            Property(e => e.IadesizKap).HasColumnName("IADESIZ_KAP");

            Property(e => e.KapToplami).HasColumnName("KAP_TOPLAMI");

            Property(e => e.KdvTutari).HasColumnName("KDV_TUTARI");

            Property(e => e.Kesildi).HasColumnName("KESILDI");

            Property(e => e.KesintiTutari).HasColumnName("KESINTI_TUTARI");

            Property(e => e.KrediKartiTahsilati).HasColumnName("KREDI_KARTI_TAHSILATI");

            Property(e => e.MasrafKesintiDahilFaturaToplami).HasColumnName("MASRAF_KESINTI_DAHIL_FATURA_TOPLAMI");

            Property(e => e.MasrafTutari).HasColumnName("MASRAF_TUTARI");

            Property(e => e.NakitTahsilat).HasColumnName("NAKIT_TAHSILAT");

            Property(e => e.Nakliye).HasColumnName("NAKLIYE");

            Property(e => e.NetMalTutari).HasColumnName("NET_MAL_TUTARI");

            Property(e => e.RehinDahilFaturaToplami).HasColumnName("REHIN_DAHIL_FATURA_TOPLAMI");

            Property(e => e.RehinTutari).HasColumnName("REHIN_TUTARI");

            Property(e => e.Tahsilat).HasColumnName("TAHSILAT");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.Tip).HasColumnName("TIP");

            Property(e => e.Unvan)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNVAN");

            Property(e => e.Veresiye).HasColumnName("VERESIYE");

            Property(e => e.VeresiyeTutari).HasColumnName("VERESIYE_TUTARI");

            Property(e => e.Yukleme).HasColumnName("YUKLEME");
        }
    }
}
