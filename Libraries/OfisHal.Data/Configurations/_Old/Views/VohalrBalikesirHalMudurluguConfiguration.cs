using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrBalikesirHalMudurluguConfiguration : EntityTypeConfiguration<VohalrBalikesirHalMudurlugu>
    {
        public VohalrBalikesirHalMudurluguConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_BALIKESIR_HAL_MUDURLUGU");

            Property(e => e.AdiSoyadi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ADI_SOYADI");

            Property(e => e.Cinsi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CINSI");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.FiyatKurusBasamakSayisi).HasColumnName("FIYAT_KURUS_BASAMAK_SAYISI");

            Property(e => e.Fiyati).HasColumnName("FIYATI");

            Property(e => e.Kasa).HasColumnName("KASA");

            Property(e => e.KdvOrani).HasColumnName("KDV_ORANI");

            Property(e => e.Kg).HasColumnName("KG");

            Property(e => e.MiktarBasamakSayisi).HasColumnName("MIKTAR_BASAMAK_SAYISI");

            Property(e => e.SeriNo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("SERI_NO");

            Property(e => e.SicilNo)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SICIL_NO")
                .IsFixedLength();

            Property(e => e.Tarihi)
                .HasColumnType("datetime")
                .HasColumnName("TARIHI");

            Property(e => e.Tutari).HasColumnName("TUTARI");

            Property(e => e.VergiDairesi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("VERGI_DAIRESI");
        }
    }
}
