using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrRehinOdendiDetayiConfiguration : EntityTypeConfiguration<VohalrRehinOdendiDetayi>
    {
        public VohalrRehinOdendiDetayiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_REHIN_ODENDI_DETAYI");

            Property(e => e.IadeMiktari).HasColumnName("IADE_MIKTARI");

            Property(e => e.RehinFisiId).HasColumnName("REHIN_FISI_ID");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
        }
    }
}
