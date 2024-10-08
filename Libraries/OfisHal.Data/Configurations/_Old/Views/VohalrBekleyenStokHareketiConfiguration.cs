﻿using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrBekleyenStokHareketiConfiguration : EntityTypeConfiguration<VohalrBekleyenStokHareketi>
    {
        public VohalrBekleyenStokHareketiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_BEKLEYEN_STOK_HAREKETI");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.DokumBilgisi)
                .HasMaxLength(31)
                .IsUnicode(false)
                .HasColumnName("DOKUM_BILGISI");

            Property(e => e.KalanKap).HasColumnName("KALAN_KAP");

            Property(e => e.KalanMiktar).HasColumnName("KALAN_MIKTAR");

            Property(e => e.KapAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("KAP_ADI");

            Property(e => e.KapId).HasColumnName("KAP_ID");

            Property(e => e.KapKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KAP_KODU")
                .IsFixedLength();

            Property(e => e.MalAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAL_ADI");

            Property(e => e.MalId).HasColumnName("MAL_ID");

            Property(e => e.MustahsilAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MUSTAHSIL_ADI");

            Property(e => e.MustahsilKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MUSTAHSIL_KODU")
                .IsFixedLength();

            Property(e => e.StokHareketiId).HasColumnName("STOK_HAREKETI_ID");
        }
    }
}
