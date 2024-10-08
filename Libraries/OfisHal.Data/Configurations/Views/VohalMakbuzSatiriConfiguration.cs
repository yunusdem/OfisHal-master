using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalMakbuzSatiriConfiguration : EntityTypeConfiguration<VohalMakbuzSatiri>
    {
        public VohalMakbuzSatiriConfiguration()
        {
            //HasNoKey();
            HasKey(x => x.SatirNo);

            ToTable("VOHAL_MAKBUZ_SATIRI");

            Property(e => e.DigerMalAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DIGER_MAL_ADI");

            Property(e => e.EFaturaUneceKisaltma)
                .IsRequired()
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_UNECE_KISALTMA");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.KapIcindekiMalMiktari).HasColumnName("KAP_ICINDEKI_MAL_MIKTARI");

            Property(e => e.KapSayisi).HasColumnName("KAP_SAYISI");

            Property(e => e.KdvOrani).HasColumnName("KDV_ORANI");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.MalAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAL_ADI");

            Property(e => e.MalBirimi)
                .IsRequired()
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("MAL_BIRIMI");

            Property(e => e.MalId).HasColumnName("MAL_ID");

            Property(e => e.MalKodu)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MAL_KODU")
                .IsFixedLength();

            Property(e => e.Miktar).HasColumnName("MIKTAR");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.SatisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("SATIS_TARIHI");

            Property(e => e.Tutar).HasColumnName("TUTAR");
        }
    }
}
