using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrEntegreEdilmeyenStokHareketiConfiguration : EntityTypeConfiguration<VohalrEntegreEdilmeyenStokHareketi>
    {
        public VohalrEntegreEdilmeyenStokHareketiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_ENTEGRE_EDILMEYEN_STOK_HAREKETI");

            Property(e => e.Bakiye).HasColumnName("BAKIYE");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.DokumNo)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DOKUM_NO")
                .IsFixedLength();

            Property(e => e.GeldigiYer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GELDIGI_YER");

            Property(e => e.IrsaliyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IRSALIYE_NO")
                .IsFixedLength();

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

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

            Property(e => e.Plaka)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PLAKA");

            Property(e => e.StokGirisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("STOK_GIRIS_TARIHI");

            Property(e => e.StokTipi).HasColumnName("STOK_TIPI");
        }
    }
}
