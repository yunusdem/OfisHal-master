using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrDokumRaporConfiguration : EntityTypeConfiguration<VohalrDokumRapor>
    {
        public VohalrDokumRaporConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_DOKUM_RAPOR");

            Property(e => e.Islem).HasColumnName("ISLEM");

            Property(e => e.KullaniciAdi)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KULLANICI_ADI");

            Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.OAciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("O_ACIKLAMA");

            Property(e => e.OBagkur).HasColumnName("O_BAGKUR");

            Property(e => e.OBorsa).HasColumnName("O_BORSA");

            Property(e => e.OCariAd)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("O_CARI_AD");

            Property(e => e.OCariKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("O_CARI_KODU")
                .IsFixedLength();

            Property(e => e.OCariyeIslemeSekli).HasColumnName("O_CARIYE_ISLEME_SEKLI");

            Property(e => e.ODokumNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("O_DOKUM_NO")
                .IsFixedLength();

            Property(e => e.OFaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("O_FATURA_NO")
                .IsFixedLength();

            Property(e => e.OFaturaTarihi)
                .HasColumnType("datetime")
                .HasColumnName("O_FATURA_TARIHI");

            Property(e => e.OIadeliKapTutari).HasColumnName("O_IADELI_KAP_TUTARI");

            Property(e => e.OIadesizKapKdv).HasColumnName("O_IADESIZ_KAP_KDV");

            Property(e => e.OIadesizKapKomisyonaDahil).HasColumnName("O_IADESIZ_KAP_KOMISYONA_DAHIL");

            Property(e => e.OIadesizKapTutari).HasColumnName("O_IADESIZ_KAP_TUTARI");

            Property(e => e.OIrsaliyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("O_IRSALIYE_NO")
                .IsFixedLength();

            Property(e => e.OKesildi).HasColumnName("O_KESILDI");

            Property(e => e.OKomisyon).HasColumnName("O_KOMISYON");

            Property(e => e.OKomisyonKdv).HasColumnName("O_KOMISYON_KDV");

            Property(e => e.OMarkaId).HasColumnName("O_MARKA_ID");

            Property(e => e.ONavlun).HasColumnName("O_NAVLUN");

            Property(e => e.ONavlunKdv).HasColumnName("O_NAVLUN_KDV");

            Property(e => e.OPlaka)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("O_PLAKA");

            Property(e => e.ORusum).HasColumnName("O_RUSUM");

            Property(e => e.OStokGirisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("O_STOK_GIRIS_TARIHI");

            Property(e => e.OStopaj).HasColumnName("O_STOPAJ");

            Property(e => e.SAciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("S_ACIKLAMA");

            Property(e => e.SBagkur).HasColumnName("S_BAGKUR");

            Property(e => e.SBorsa).HasColumnName("S_BORSA");

            Property(e => e.SCariAd)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("S_CARI_AD");

            Property(e => e.SCariKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("S_CARI_KODU")
                .IsFixedLength();

            Property(e => e.SCariyeIslemeSekli).HasColumnName("S_CARIYE_ISLEME_SEKLI");

            Property(e => e.SDokumNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("S_DOKUM_NO")
                .IsFixedLength();

            Property(e => e.SFaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("S_FATURA_NO")
                .IsFixedLength();

            Property(e => e.SFaturaTarihi)
                .HasColumnType("datetime")
                .HasColumnName("S_FATURA_TARIHI");

            Property(e => e.SIadeliKapTutari).HasColumnName("S_IADELI_KAP_TUTARI");

            Property(e => e.SIadesizKapKdv).HasColumnName("S_IADESIZ_KAP_KDV");

            Property(e => e.SIadesizKapKomisyonaDahil).HasColumnName("S_IADESIZ_KAP_KOMISYONA_DAHIL");

            Property(e => e.SIadesizKapTutari).HasColumnName("S_IADESIZ_KAP_TUTARI");

            Property(e => e.SIrsaliyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("S_IRSALIYE_NO")
                .IsFixedLength();

            Property(e => e.SKesildi).HasColumnName("S_KESILDI");

            Property(e => e.SKomisyon).HasColumnName("S_KOMISYON");

            Property(e => e.SKomisyonKdv).HasColumnName("S_KOMISYON_KDV");

            Property(e => e.SMarkaId).HasColumnName("S_MARKA_ID");

            Property(e => e.SNavlun).HasColumnName("S_NAVLUN");

            Property(e => e.SNavlunKdv).HasColumnName("S_NAVLUN_KDV");

            Property(e => e.SPlaka)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("S_PLAKA");

            Property(e => e.SRusum).HasColumnName("S_RUSUM");

            Property(e => e.SStokGirisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("S_STOK_GIRIS_TARIHI");

            Property(e => e.SStopaj).HasColumnName("S_STOPAJ");

            Property(e => e.SatirDegisiklikMakbuz).HasColumnName("SATIR_DEGISIKLIK_MAKBUZ");

            Property(e => e.SatirDegisiklikStok).HasColumnName("SATIR_DEGISIKLIK_STOK");

            Property(e => e.SatirMasrafDegisiklik).HasColumnName("SATIR_MASRAF_DEGISIKLIK");

            Property(e => e.Zaman)
                .HasColumnType("datetime")
                .HasColumnName("ZAMAN");
        }
    }
}
