using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalbHalTeslimBelgesiConfiguration : EntityTypeConfiguration<VohalbHalTeslimBelgesi>
    {
        public VohalbHalTeslimBelgesiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALB_HAL_TESLIM_BELGESI");

            Property(e => e.AdiSoyadi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ADI_SOYADI");

            Property(e => e.AmbarNo)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AMBAR_NO")
                .IsFixedLength();

            Property(e => e.AracPlaka)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ARAC_PLAKA");

            Property(e => e.BeldeAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BELDE_ADI");

            Property(e => e.BelgeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BELGE_NO")
                .IsFixedLength();

            Property(e => e.GelisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("GELIS_TARIHI");

            Property(e => e.HalNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("HAL_NO")
                .IsFixedLength();

            Property(e => e.IlAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IL_ADI");

            Property(e => e.IlceAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ILCE_ADI");

            Property(e => e.Kg).HasColumnName("KG");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.MalinCinsi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MALIN_CINSI");

            Property(e => e.MalinGeldigiYer)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MALIN_GELDIGI_YER");

            Property(e => e.ParcaSayisi).HasColumnName("PARCA_SAYISI");

            Property(e => e.StokKunyesi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STOK_KUNYESI")
                .IsFixedLength();
        }
    }
}
