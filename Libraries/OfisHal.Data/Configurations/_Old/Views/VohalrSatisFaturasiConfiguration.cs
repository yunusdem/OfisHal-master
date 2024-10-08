using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrSatisFaturasiConfiguration : EntityTypeConfiguration<VohalrSatisFaturasi>
    {
        public VohalrSatisFaturasiConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_SATIS_FATURASI");

            Property(e => e.Adres)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ADRES");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.CariKod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CARI_KOD")
                .IsFixedLength();

            Property(e => e.EFaturaNot)
                .HasMaxLength(1024)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_NOT");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.FiyatKurusSayisi).HasColumnName("FIYAT_KURUS_SAYISI");

            Property(e => e.IadesizKapKdv).HasColumnName("IADESIZ_KAP_KDV");

            Property(e => e.IadesizKapKdvOrani).HasColumnName("IADESIZ_KAP_KDV_ORANI");

            Property(e => e.IrsaliyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IRSALIYE_NO")
                .IsFixedLength();

            Property(e => e.Iskonto).HasColumnName("ISKONTO");

            Property(e => e.IskontoOrani).HasColumnName("ISKONTO_ORANI");

            Property(e => e.KdvliIadesizKap).HasColumnName("KDVLI_IADESIZ_KAP");

            Property(e => e.KdvsizIadesizKap).HasColumnName("KDVSIZ_IADESIZ_KAP");

            Property(e => e.Kesildi).HasColumnName("KESILDI");

            Property(e => e.KisilikTipi).HasColumnName("KISILIK_TIPI");

            Property(e => e.MagazaAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAGAZA_ADI");

            Property(e => e.MagazaKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MAGAZA_KODU")
                .IsFixedLength();

            Property(e => e.MalKdv).HasColumnName("MAL_KDV");

            Property(e => e.Masraf).HasColumnName("MASRAF");

            Property(e => e.MasrafKdv).HasColumnName("MASRAF_KDV");

            Property(e => e.MasrafToplami).HasColumnName("MASRAF_TOPLAMI");

            Property(e => e.Nakliye).HasColumnName("NAKLIYE");

            Property(e => e.NakliyeKdv).HasColumnName("NAKLIYE_KDV");

            Property(e => e.NakliyeKdvOrani).HasColumnName("NAKLIYE_KDV_ORANI");

            Property(e => e.OdemeSekli).HasColumnName("ODEME_SEKLI");

            Property(e => e.RehinIadeliKap).HasColumnName("REHIN_IADELI_KAP");

            Property(e => e.RehinToplami).HasColumnName("REHIN_TOPLAMI");

            Property(e => e.Rusum).HasColumnName("RUSUM");

            Property(e => e.RusumKdv).HasColumnName("RUSUM_KDV");

            Property(e => e.RusumKdvOrani).HasColumnName("RUSUM_KDV_ORANI");

            Property(e => e.RusumOrani).HasColumnName("RUSUM_ORANI");

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

            Property(e => e.SatRusumKdvIliskisi).HasColumnName("SAT_RUSUM_KDV_ILISKISI");

            Property(e => e.Sehir)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SEHIR");

            Property(e => e.SehirId).HasColumnName("SEHIR_ID");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.Tip).HasColumnName("TIP");

            Property(e => e.Unvan)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNVAN");

            Property(e => e.Vade).HasColumnName("VADE");

            Property(e => e.Veresiye).HasColumnName("VERESIYE");

            Property(e => e.VeresiyeTahsilEdilen).HasColumnName("VERESIYE_TAHSIL_EDILEN");

            Property(e => e.VergiDairesi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("VERGI_DAIRESI");

            Property(e => e.VergiDairesiId).HasColumnName("VERGI_DAIRESI_ID");

            Property(e => e.VergiKimlikNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VERGI_KIMLIK_NO")
                .IsFixedLength();

            Property(e => e.Yukleme).HasColumnName("YUKLEME");

            Property(e => e.YuklemeKdv).HasColumnName("YUKLEME_KDV");

            Property(e => e.YuklemeKdvOrani).HasColumnName("YUKLEME_KDV_ORANI");
        }
    }
}
