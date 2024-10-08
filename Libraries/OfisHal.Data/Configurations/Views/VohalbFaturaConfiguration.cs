using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class VohalbFaturaConfiguration : EntityTypeConfiguration<VohalbFatura>
    {
        public VohalbFaturaConfiguration()
        {
            HasKey(e => e.FaturaId);
            //HasNoKey();

            ToTable("VOHALB_FATURA");

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

            Property(e => e.CariUnvan)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CARI_UNVAN");

            Property(e => e.Degistirildi).HasColumnName("DEGISTIRILDI");

            Property(e => e.EklemeZamani)
                .HasColumnType("datetime")
                .HasColumnName("EKLEME_ZAMANI");

            Property(e => e.EkleyenId).HasColumnName("EKLEYEN_ID");

            Property(e => e.EkleyenKullaniciAdi)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EKLEYEN_KULLANICI_ADI");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.Guid)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("GUID");

            Property(e => e.GuncellemeZamani)
                .HasColumnType("datetime")
                .HasColumnName("GUNCELLEME_ZAMANI");

            Property(e => e.GuncellemeZamaniString)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("GUNCELLEME_ZAMANI_STRING");

            Property(e => e.GuncelleyenKullaniciAdi)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GUNCELLEYEN_KULLANICI_ADI");

            Property(e => e.IadeEdilenKapSayisi).HasColumnName("IADE_EDILEN_KAP_SAYISI");

            Property(e => e.IadesizKapKdv).HasColumnName("IADESIZ_KAP_KDV");

            Property(e => e.IadesizKapKdvOrani).HasColumnName("IADESIZ_KAP_KDV_ORANI");

            Property(e => e.IrsaliyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IRSALIYE_NO")
                .IsFixedLength();

            Property(e => e.IrsaliyeZamani)
                .HasColumnType("datetime")
                .HasColumnName("IRSALIYE_ZAMANI");

            Property(e => e.Iskonto).HasColumnName("ISKONTO");

            Property(e => e.IskontoOrani).HasColumnName("ISKONTO_ORANI");

            Property(e => e.KdvliIadesizKap).HasColumnName("KDVLI_IADESIZ_KAP");

            Property(e => e.KdvsizIadesizKap).HasColumnName("KDVSIZ_IADESIZ_KAP");

            Property(e => e.Kesildi).HasColumnName("KESILDI");

            Property(e => e.KisilikTipi).HasColumnName("KISILIK_TIPI");

            Property(e => e.MagazaId).HasColumnName("MAGAZA_ID");

            Property(e => e.MagazaKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MAGAZA_KODU")
                .IsFixedLength();

            Property(e => e.Nakliye).HasColumnName("NAKLIYE");

            Property(e => e.NakliyeKdv).HasColumnName("NAKLIYE_KDV");

            Property(e => e.NakliyeKdvOrani).HasColumnName("NAKLIYE_KDV_ORANI");

            Property(e => e.OdemeSekli).HasColumnName("ODEME_SEKLI");

            Property(e => e.ReferansNo)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("REFERANS_NO");

            Property(e => e.RehinDevri).HasColumnName("REHIN_DEVRI");

            Property(e => e.RehinIadeliKap).HasColumnName("REHIN_IADELI_KAP");

            Property(e => e.Rusum).HasColumnName("RUSUM");

            Property(e => e.RusumKdv).HasColumnName("RUSUM_KDV");

            Property(e => e.RusumKdvOrani).HasColumnName("RUSUM_KDV_ORANI");

            Property(e => e.SehirAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SEHIR_ADI");

            Property(e => e.SehirId).HasColumnName("SEHIR_ID");

            Property(e => e.SiparisId).HasColumnName("SIPARIS_ID");

            Property(e => e.SiparisNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SIPARIS_NO")
                .IsFixedLength();

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
