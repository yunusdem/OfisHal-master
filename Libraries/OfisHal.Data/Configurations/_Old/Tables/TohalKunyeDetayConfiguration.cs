using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class TohalKunyeDetayConfiguration : EntityTypeConfiguration<TohalKunyeDetay>
    {
        public TohalKunyeDetayConfiguration()
        {
            //HasNoKey();

            ToTable("TOHAL_KUNYE_DETAY");

            Property(e => e.BelgeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BELGE_NO")
                .IsFixedLength();

            Property(e => e.BildirimTarihi)
                .HasColumnType("datetime")
                .HasColumnName("BILDIRIM_TARIHI");

            Property(e => e.BildirimciAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BILDIRIMCI_ADI");

            Property(e => e.BildirimciVergiNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BILDIRIMCI_VERGI_NO")
                .IsFixedLength();

            Property(e => e.BirimFiyati).HasColumnName("BIRIM_FIYATI");

            Property(e => e.Guid)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("GUID");

            Property(e => e.IsletmeAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ISLETME_ADI");

            Property(e => e.KalanMiktar).HasColumnName("KALAN_MIKTAR");

            Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");

            Property(e => e.KunyeId).HasColumnName("KUNYE_ID");

            Property(e => e.MalSahibiAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAL_SAHIBI_ADI");

            Property(e => e.MalinAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MALIN_ADI");

            Property(e => e.MalinCinsi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MALIN_CINSI");

            Property(e => e.MalinGidecegiYer)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MALIN_GIDECEGI_YER");

            Property(e => e.MalinMiktari).HasColumnName("MALIN_MIKTARI");

            Property(e => e.MalinTuru)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MALIN_TURU");

            Property(e => e.MalinUretildigiYer)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MALIN_URETILDIGI_YER");

            Property(e => e.MiktarBirimAdi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MIKTAR_BIRIM_ADI")
                .IsFixedLength();

            Property(e => e.Nereden)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NEREDEN");

            Property(e => e.Nereye)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NEREYE");

            Property(e => e.PlakaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PLAKA_NO")
                .IsFixedLength();

            Property(e => e.Rusum).HasColumnName("RUSUM");

            Property(e => e.Sifat).HasColumnName("SIFAT");

            Property(e => e.UreticiAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("URETICI_ADI");

            Property(e => e.UreticiVergiNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("URETICI_VERGI_NO")
                .IsFixedLength();

            Property(e => e.UretimTarihi)
                .HasColumnType("datetime")
                .HasColumnName("URETIM_TARIHI");

            Property(e => e.UretimYeriId).HasColumnName("URETIM_YERI_ID");

            HasOptional(d => d.Kunye)
                .WithMany()
                .HasForeignKey(d => d.KunyeId);
        }
    }
}
