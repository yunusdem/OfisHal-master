using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class TohksIskeleKunyeListesiConfiguration : EntityTypeConfiguration<TohksIskeleKunyeListesi>
    {
        public TohksIskeleKunyeListesiConfiguration()
        {
            //HasNoKey();
            HasKey(e => e.Kunye);

            ToTable("TOHKS_ISKELE_KUNYE_LISTESI");

            Property(e => e.BelgeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BELGE_NO");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.GirisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("GIRIS_TARIHI");

            Property(e => e.Guid).HasColumnName("GUID");

            Property(e => e.KapMiktar).HasColumnName("KAP_MIKTAR");

            Property(e => e.KiloMiktar).HasColumnName("KILO_MIKTAR");

            Property(e => e.Kunye)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("KUNYE");

            Property(e => e.MalId).HasColumnName("MAL_ID");

            Property(e => e.PlakaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PLAKA_NO");

            Property(e => e.Sifat).HasColumnName("SIFAT");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.TeslimatYeriId).HasColumnName("TESLIMAT_YERI_ID");
        }
    }
}
