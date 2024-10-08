using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalGonderimeHazirEMustahsilFaturasiConfiguration : EntityTypeConfiguration<VohalGonderimeHazirEMustahsilFaturasi>
    {
        public VohalGonderimeHazirEMustahsilFaturasiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_GONDERIME_HAZIR_E_MUSTAHSIL_FATURASI");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.DokumNo)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DOKUM_NO")
                .IsFixedLength();

            Property(e => e.EBelgeTuru).HasColumnName("E_BELGE_TURU");

            Property(e => e.EFaturaDurumu).HasColumnName("E_FATURA_DURUMU");

            Property(e => e.EMustahsilMakbuzuBaslangici)
                .HasColumnType("datetime")
                .HasColumnName("E_MUSTAHSIL_MAKBUZU_BASLANGICI");

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.FaturaTarihi)
                .HasColumnType("datetime")
                .HasColumnName("FATURA_TARIHI");

            Property(e => e.GibFirmamizPostaKutusuId).HasColumnName("GIB_FIRMAMIZ_POSTA_KUTUSU_ID");

            Property(e => e.GibMuhatapPostaKutusuId).HasColumnName("GIB_MUHATAP_POSTA_KUTUSU_ID");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.MusFatDuzenlemeSekli).HasColumnName("MUS_FAT_DUZENLEME_SEKLI");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.ToplamTutar).HasColumnName("TOPLAM_TUTAR");

            Property(e => e.Unvan)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNVAN");
        }
    }
}
