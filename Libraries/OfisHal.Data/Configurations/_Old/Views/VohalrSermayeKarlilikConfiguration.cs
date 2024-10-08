using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrSermayeKarlilikConfiguration : EntityTypeConfiguration<VohalrSermayeKarlilik>
    {
        public VohalrSermayeKarlilikConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_SERMAYE_KARLILIK");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.DokumNo)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DOKUM_NO")
                .IsFixedLength();

            Property(e => e.GirenMiktar).HasColumnName("GIREN_MIKTAR");

            Property(e => e.IrsaliyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IRSALIYE_NO")
                .IsFixedLength();

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.MalMaliyeti).HasColumnName("MAL_MALIYETI");

            Property(e => e.Marka)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MARKA");

            Property(e => e.Masraf).HasColumnName("MASRAF");

            Property(e => e.Miktar).HasColumnName("MIKTAR");

            Property(e => e.MustahsilAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MUSTAHSIL_ADI");

            Property(e => e.MustahsilKodu)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MUSTAHSIL_KODU")
                .IsFixedLength();

            Property(e => e.NetTutar).HasColumnName("NET_TUTAR");

            Property(e => e.Satis).HasColumnName("SATIS");

            Property(e => e.SatisMasrafi).HasColumnName("SATIS_MASRAFI");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
        }
    }
}
