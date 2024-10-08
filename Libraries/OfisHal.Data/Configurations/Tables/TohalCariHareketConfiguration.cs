using OfisHal.Core.Domain;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalCariHareketConfiguration : EntityTypeConfiguration<TohalCariHareket>
    {
        public TohalCariHareketConfiguration()
        {
            HasKey(e => e.CariHareketId);

            ToTable("TOHAL_CARI_HAREKET");

            Property(e => e.CariHareketId).HasColumnName("CARI_HAREKET_ID");

            Property(e => e.Aciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.Aciklama2)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA2");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.EklemeZamani)
                .HasColumnType("datetime")
                .HasColumnName("EKLEME_ZAMANI");

            Property(e => e.EkleyenId).HasColumnName("EKLEYEN_ID");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.GuncellemeZamani)
                .HasColumnType("datetime")
                .HasColumnName("GUNCELLEME_ZAMANI");

            Property(e => e.GuncelleyenId).HasColumnName("GUNCELLEYEN_ID");

            Property(e => e.IslemTipi).HasColumnName("ISLEM_TIPI");

            Property(e => e.KarsiCariKartId).HasColumnName("KARSI_CARI_KART_ID");

            Property(e => e.Meblag).HasColumnName("MEBLAG");

            Property(e => e.PosCihaziId).HasColumnName("POS_CIHAZI_ID");

            Property(e => e.RefNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("REF_NO")
                .IsFixedLength();

            Property(e => e.RehinCari).HasColumnName("REHIN_CARI");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.Tip).HasColumnName("TIP");

            HasRequired(d => d.CariKart)
                .WithMany(p => p.TohalCariHareketCariKarts)
                .HasForeignKey(d => d.CariKartId)
                .WillCascadeOnDelete(false);

            HasRequired(d => d.Ekleyen)
                .WithMany(p => p.TohalCariHareketEkleyens)
                .HasForeignKey(d => d.EkleyenId)
                .WillCascadeOnDelete(false);

            HasOptional(d => d.Fatura)
                .WithMany(p => p.TohalCariHarekets)
                .HasForeignKey(d => d.FaturaId)
                .WillCascadeOnDelete(false);

            HasRequired(d => d.Guncelleyen)
                .WithMany(p => p.TohalCariHareketGuncelleyens)
                .HasForeignKey(d => d.GuncelleyenId)
                .WillCascadeOnDelete(false);

            HasRequired(d => d.KarsiCariKart)
                .WithMany(p => p.TohalCariHareketKarsiCariKarts)
                .HasForeignKey(d => d.KarsiCariKartId)
                .WillCascadeOnDelete(false);

            HasOptional(d => d.PosCihazi)
                .WithMany(p => p.TohalCariHarekets)
                .HasForeignKey(d => d.PosCihaziId);

            HasMany(d => d.Faturas)
                .WithMany(e => e.CariHarekets)
                .Map(m =>
                    m.ToTable("TOHAL_FATURA_ODEME")
                    .MapLeftKey("CARI_HAREKET_ID")
                    .MapRightKey("FATURA_ID")
                );
            /*
            HasMany(d => d.Faturas)
                .WithMany(p => p.CariHarekets)
                .UsingEntity<Dictionary<string, object>>(
                    "TohalFaturaOdeme",
                    l => l.HasOne<TohalFatura>().WithMany().HasForeignKey("FaturaId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__TOHAL_FAT__FATUR__65370702"),
                    r => r.HasOne<TohalCariHareket>().WithMany().HasForeignKey("CariHareketId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__TOHAL_FAT__CARI___662B2B3B"),
                    j =>
                    {
                        j.HasKey("CariHareketId", "FaturaId").HasName("XPKTOHAL_FATURA_ODEME");

                        j.ToTable("TOHAL_FATURA_ODEME");

                        j.IndexerProperty<int>("CariHareketId").HasColumnName("CARI_HAREKET_ID");

                        j.IndexerProperty<int>("FaturaId").HasColumnName("FATURA_ID");
                    });;
            */
        }
    }
}
