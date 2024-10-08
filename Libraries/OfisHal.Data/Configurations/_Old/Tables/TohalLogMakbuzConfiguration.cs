using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class TohalLogMakbuzConfiguration : EntityTypeConfiguration<TohalLogMakbuz>
    {
        public TohalLogMakbuzConfiguration()
        {
            //HasNoKey();

            ToTable("TOHAL_LOG_MAKBUZ");

            Property(e => e.Islem).HasColumnName("ISLEM");

            Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.OAciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("O_ACIKLAMA");

            Property(e => e.OBagkur).HasColumnName("O_BAGKUR");

            Property(e => e.OBagkurOrani).HasColumnName("O_BAGKUR_ORANI");

            Property(e => e.OBildirimTuru).HasColumnName("O_BILDIRIM_TURU");

            Property(e => e.OBorsa).HasColumnName("O_BORSA");

            Property(e => e.OBorsaOrani).HasColumnName("O_BORSA_ORANI");

            Property(e => e.OCariKartId).HasColumnName("O_CARI_KART_ID");

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

            Property(e => e.OGeldigiYer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("O_GELDIGI_YER");

            Property(e => e.OIadeliKapTutari).HasColumnName("O_IADELI_KAP_TUTARI");

            Property(e => e.OIadesizKapKdv).HasColumnName("O_IADESIZ_KAP_KDV");

            Property(e => e.OIadesizKapKdvOrani).HasColumnName("O_IADESIZ_KAP_KDV_ORANI");

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

            Property(e => e.OKomisyonKdvOrani).HasColumnName("O_KOMISYON_KDV_ORANI");

            Property(e => e.OKomisyonOrani).HasColumnName("O_KOMISYON_ORANI");

            Property(e => e.OMarkaId).HasColumnName("O_MARKA_ID");

            Property(e => e.ONavlun).HasColumnName("O_NAVLUN");

            Property(e => e.ONavlunKdv).HasColumnName("O_NAVLUN_KDV");

            Property(e => e.ONavlunKdvOrani).HasColumnName("O_NAVLUN_KDV_ORANI");

            Property(e => e.OOrtakId).HasColumnName("O_ORTAK_ID");

            Property(e => e.OOrtaklikOrani).HasColumnName("O_ORTAKLIK_ORANI");

            Property(e => e.OPlaka)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("O_PLAKA");

            Property(e => e.ORusum).HasColumnName("O_RUSUM");

            Property(e => e.ORusumOrani).HasColumnName("O_RUSUM_ORANI");

            Property(e => e.OSifati).HasColumnName("O_SIFATI");

            Property(e => e.OStokGirisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("O_STOK_GIRIS_TARIHI");

            Property(e => e.OStopaj).HasColumnName("O_STOPAJ");

            Property(e => e.OStopajOrani).HasColumnName("O_STOPAJ_ORANI");

            Property(e => e.OVade).HasColumnName("O_VADE");

            Property(e => e.SAciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("S_ACIKLAMA");

            Property(e => e.SBagkur).HasColumnName("S_BAGKUR");

            Property(e => e.SBagkurOrani).HasColumnName("S_BAGKUR_ORANI");

            Property(e => e.SBildirimTuru).HasColumnName("S_BILDIRIM_TURU");

            Property(e => e.SBorsa).HasColumnName("S_BORSA");

            Property(e => e.SBorsaOrani).HasColumnName("S_BORSA_ORANI");

            Property(e => e.SCariKartId).HasColumnName("S_CARI_KART_ID");

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

            Property(e => e.SGeldigiYer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("S_GELDIGI_YER");

            Property(e => e.SIadeliKapTutari).HasColumnName("S_IADELI_KAP_TUTARI");

            Property(e => e.SIadesizKapKdv).HasColumnName("S_IADESIZ_KAP_KDV");

            Property(e => e.SIadesizKapKdvOrani).HasColumnName("S_IADESIZ_KAP_KDV_ORANI");

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

            Property(e => e.SKomisyonKdvOrani).HasColumnName("S_KOMISYON_KDV_ORANI");

            Property(e => e.SKomisyonOrani).HasColumnName("S_KOMISYON_ORANI");

            Property(e => e.SMarkaId).HasColumnName("S_MARKA_ID");

            Property(e => e.SNavlun).HasColumnName("S_NAVLUN");

            Property(e => e.SNavlunKdv).HasColumnName("S_NAVLUN_KDV");

            Property(e => e.SNavlunKdvOrani).HasColumnName("S_NAVLUN_KDV_ORANI");

            Property(e => e.SOrtakId).HasColumnName("S_ORTAK_ID");

            Property(e => e.SOrtaklikOrani).HasColumnName("S_ORTAKLIK_ORANI");

            Property(e => e.SPlaka)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("S_PLAKA");

            Property(e => e.SRusum).HasColumnName("S_RUSUM");

            Property(e => e.SRusumOrani).HasColumnName("S_RUSUM_ORANI");

            Property(e => e.SSifati).HasColumnName("S_SIFATI");

            Property(e => e.SStokGirisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("S_STOK_GIRIS_TARIHI");

            Property(e => e.SStopaj).HasColumnName("S_STOPAJ");

            Property(e => e.SStopajOrani).HasColumnName("S_STOPAJ_ORANI");

            Property(e => e.SVade).HasColumnName("S_VADE");

            Property(e => e.Zaman)
                .HasColumnType("datetime")
                .HasColumnName("ZAMAN");
        }
    }
}
