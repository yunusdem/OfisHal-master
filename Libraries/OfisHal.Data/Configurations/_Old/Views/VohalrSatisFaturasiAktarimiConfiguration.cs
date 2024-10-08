using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrSatisFaturasiAktarimiConfiguration : EntityTypeConfiguration<VohalrSatisFaturasiAktarimi>
    {
        public VohalrSatisFaturasiAktarimiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_SATIS_FATURASI_AKTARIMI");

            Property(e => e.CariAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CARI_ADI");

            Property(e => e.CariKod)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CARI_KOD")
                .IsFixedLength();

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.Faturano)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("FATURANO");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.IadesizKapKdv).HasColumnName("IADESIZ_KAP_KDV");

            Property(e => e.IadesizKapKdvOrani).HasColumnName("IADESIZ_KAP_KDV_ORANI");

            Property(e => e.Iskonto).HasColumnName("ISKONTO");

            Property(e => e.IskontoOrani).HasColumnName("ISKONTO_ORANI");

            Property(e => e.KapMiktari).HasColumnName("KAP_MIKTARI");

            Property(e => e.KdvOrani).HasColumnName("KDV_ORANI");

            Property(e => e.KdvliIadesizKap).HasColumnName("KDVLI_IADESIZ_KAP");

            Property(e => e.KdvsizIadesizKap).HasColumnName("KDVSIZ_IADESIZ_KAP");

            Property(e => e.MalKdv).HasColumnName("MAL_KDV");

            Property(e => e.MalMiktari).HasColumnName("MAL_MIKTARI");

            Property(e => e.Marka)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MARKA");

            Property(e => e.Nakliye).HasColumnName("NAKLIYE");

            Property(e => e.NakliyeKdv).HasColumnName("NAKLIYE_KDV");

            Property(e => e.NetTutar).HasColumnName("NET_TUTAR");

            Property(e => e.RehinFiyat).HasColumnName("REHIN_FIYAT");

            Property(e => e.RehinIadeliKap).HasColumnName("REHIN_IADELI_KAP");

            Property(e => e.RehinMiktar).HasColumnName("REHIN_MIKTAR");

            Property(e => e.RehinToplamMiktar).HasColumnName("REHIN_TOPLAM_MIKTAR");

            Property(e => e.RehinToplamTutar).HasColumnName("REHIN_TOPLAM_TUTAR");

            Property(e => e.Rusum).HasColumnName("RUSUM");

            Property(e => e.RusumKdv).HasColumnName("RUSUM_KDV");

            Property(e => e.RusumOrani).HasColumnName("RUSUM_ORANI");

            Property(e => e.Rusumtoplam).HasColumnName("RUSUMTOPLAM");

            Property(e => e.SIskonto).HasColumnName("S_ISKONTO");

            Property(e => e.SIskontoOrani).HasColumnName("S_ISKONTO_ORANI");

            Property(e => e.SatHamaliyeAdlandirma)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SAT_HAMALIYE_ADLANDIRMA");

            Property(e => e.SatNakliyeAdlandirma)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SAT_NAKLIYE_ADLANDIRMA");

            Property(e => e.SonToplam).HasColumnName("SON_TOPLAM");

            Property(e => e.StokKodu)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STOK_KODU")
                .IsFixedLength();

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.Veresiye).HasColumnName("VERESIYE");

            Property(e => e.VergiKimlikNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VERGI_KIMLIK_NO")
                .IsFixedLength();

            Property(e => e.Yukleme).HasColumnName("YUKLEME");

            Property(e => e.YuklemeKdv).HasColumnName("YUKLEME_KDV");
        }
    }
}
