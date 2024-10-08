using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class TohksKayitliKunyeListesiConfiguration : EntityTypeConfiguration<TohksKayitliKunyeListesi>
    {
        public TohksKayitliKunyeListesiConfiguration()
        {
            //HasNoKey();
            HasKey(e => e.Id);

            ToTable("TOHKS_KAYITLI_KUNYE_LISTESI");

            Property(e => e.Id).HasColumnName("ID");
            Property(e => e.BelgeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BELGE_NO")
                .IsFixedLength();

            Property(e => e.BildirimTarihi)
                .HasColumnType("datetime")
                .HasColumnName("BILDIRIM_TARIHI");

            Property(e => e.BildirimTuru).HasColumnName("BILDIRIM_TURU");

            Property(e => e.BildirimciVergiNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BILDIRIMCI_VERGI_NO")
                .IsFixedLength();

            Property(e => e.GidecekIsyeriId).HasColumnName("GIDECEK_ISYERI_ID");

            Property(e => e.IslemeAlinmaZamani)
                .HasColumnType("datetime")
                .HasColumnName("ISLEME_ALINMA_ZAMANI");

            Property(e => e.KalanMiktar).HasColumnName("KALAN_MIKTAR");

            Property(e => e.KunyeId).HasColumnName("KUNYE_ID");

            Property(e => e.KunyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KUNYE_NO")
                .IsFixedLength();

            Property(e => e.MalId).HasColumnName("MAL_ID");

            Property(e => e.MalinAdi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MALIN_ADI");

            Property(e => e.MalinCinsKodNo).HasColumnName("MALIN_CINS_KOD_NO");

            Property(e => e.MalinCinsi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MALIN_CINSI");

            Property(e => e.MalinKodNo).HasColumnName("MALIN_KOD_NO");

            Property(e => e.MalinMiktari).HasColumnName("MALIN_MIKTARI");

            Property(e => e.MalinSahibiVergiNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MALIN_SAHIBI_VERGI_NO")
                .IsFixedLength();

            Property(e => e.MalinSatisFiyati).HasColumnName("MALIN_SATIS_FIYATI");

            Property(e => e.MalinTuru)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MALIN_TURU");

            Property(e => e.MalinTuruKodNo).HasColumnName("MALIN_TURU_KOD_NO");

            Property(e => e.MiktarBirimId).HasColumnName("MIKTAR_BIRIM_ID");

            Property(e => e.MiktarBirimiAd)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MIKTAR_BIRIMI_AD")
                .IsFixedLength();

            Property(e => e.PlakaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PLAKA_NO")
                .IsFixedLength();

            Property(e => e.RusumMiktari).HasColumnName("RUSUM_MIKTARI");

            Property(e => e.Sifat).HasColumnName("SIFAT");

            Property(e => e.Tip).HasColumnName("TIP");

            Property(e => e.UreticiVergiNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("URETICI_VERGI_NO")
                .IsFixedLength();
        }
    }
}
