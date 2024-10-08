using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalbMakbuzConfiguration : EntityTypeConfiguration<VohalbMakbuz>
    {
        public VohalbMakbuzConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALB_MAKBUZ");

            Property(e => e.Aciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.AdTarih)
                .HasMaxLength(210)
                .IsUnicode(false)
                .HasColumnName("AD_TARIH");

            Property(e => e.Bagkur).HasColumnName("BAGKUR");

            Property(e => e.BagkurOrani).HasColumnName("BAGKUR_ORANI");

            Property(e => e.BekleyenHareketSayisi).HasColumnName("BEKLEYEN_HAREKET_SAYISI");

            Property(e => e.Borsa).HasColumnName("BORSA");

            Property(e => e.BorsaOrani).HasColumnName("BORSA_ORANI");

            Property(e => e.CariAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CARI_ADI");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.CariKodu)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CARI_KODU")
                .IsFixedLength();

            Property(e => e.DokumNo)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DOKUM_NO")
                .IsFixedLength();

            Property(e => e.EklemeZamani)
                .HasColumnType("datetime")
                .HasColumnName("EKLEME_ZAMANI");

            Property(e => e.EkleyenKullaniciAdi)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EKLEYEN_KULLANICI_ADI");

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.FaturaTarihi)
                .HasColumnType("datetime")
                .HasColumnName("FATURA_TARIHI");

            Property(e => e.GeldigiYer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GELDIGI_YER");

            Property(e => e.GelenKap).HasColumnName("GELEN_KAP");

            Property(e => e.GelenMiktar).HasColumnName("GELEN_MIKTAR");

            Property(e => e.GuncellemeZamani)
                .HasColumnType("datetime")
                .HasColumnName("GUNCELLEME_ZAMANI");

            Property(e => e.GuncelleyenKullaniciAdi)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GUNCELLEYEN_KULLANICI_ADI");

            Property(e => e.IadeliKapTutari).HasColumnName("IADELI_KAP_TUTARI");

            Property(e => e.IadesizKapKdv).HasColumnName("IADESIZ_KAP_KDV");

            Property(e => e.IadesizKapKdvOrani).HasColumnName("IADESIZ_KAP_KDV_ORANI");

            Property(e => e.IadesizKapKomisyonaDahil).HasColumnName("IADESIZ_KAP_KOMISYONA_DAHIL");

            Property(e => e.IadesizKapTutari).HasColumnName("IADESIZ_KAP_TUTARI");

            Property(e => e.IrsaliyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IRSALIYE_NO")
                .IsFixedLength();

            Property(e => e.Kesildi).HasColumnName("KESILDI");

            Property(e => e.KodTarih)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("KOD_TARIH")
                .IsFixedLength();

            Property(e => e.Komisyon).HasColumnName("KOMISYON");

            Property(e => e.KomisyonKdv).HasColumnName("KOMISYON_KDV");

            Property(e => e.KomisyonKdvOrani).HasColumnName("KOMISYON_KDV_ORANI");

            Property(e => e.KomisyonOrani).HasColumnName("KOMISYON_ORANI");

            Property(e => e.MakbuzGuncellemeZamani)
                .HasColumnType("datetime")
                .HasColumnName("MAKBUZ_GUNCELLEME_ZAMANI");

            Property(e => e.MakbuzGuncelleyenKullaniciAdi)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MAKBUZ_GUNCELLEYEN_KULLANICI_ADI");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.MakbuzdakiKap).HasColumnName("MAKBUZDAKI_KAP");

            Property(e => e.MakbuzdakiMiktar).HasColumnName("MAKBUZDAKI_MIKTAR");

            Property(e => e.MalKdv).HasColumnName("MAL_KDV");

            Property(e => e.MalTutari).HasColumnName("MAL_TUTARI");

            Property(e => e.Marka)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MARKA");

            Property(e => e.MarkaId).HasColumnName("MARKA_ID");

            Property(e => e.Masraf).HasColumnName("MASRAF");

            Property(e => e.MasrafKdv).HasColumnName("MASRAF_KDV");

            Property(e => e.Navlun).HasColumnName("NAVLUN");

            Property(e => e.NavlunKdv).HasColumnName("NAVLUN_KDV");

            Property(e => e.NavlunKdvOrani).HasColumnName("NAVLUN_KDV_ORANI");

            Property(e => e.OrtakAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ORTAK_ADI");

            Property(e => e.OrtakId).HasColumnName("ORTAK_ID");

            Property(e => e.OrtaklikOrani).HasColumnName("ORTAKLIK_ORANI");

            Property(e => e.Plaka)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PLAKA");

            Property(e => e.Rusum).HasColumnName("RUSUM");

            Property(e => e.RusumOrani).HasColumnName("RUSUM_ORANI");

            Property(e => e.SatilanKap).HasColumnName("SATILAN_KAP");

            Property(e => e.SatilanMiktar).HasColumnName("SATILAN_MIKTAR");

            Property(e => e.StokGirisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("STOK_GIRIS_TARIHI");

            Property(e => e.Stopaj).HasColumnName("STOPAJ");

            Property(e => e.StopajOrani).HasColumnName("STOPAJ_ORANI");

            Property(e => e.Vade).HasColumnName("VADE");
        }
    }
}
