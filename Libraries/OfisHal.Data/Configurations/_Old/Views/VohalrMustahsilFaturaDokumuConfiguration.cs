using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrMustahsilFaturaDokumuConfiguration : EntityTypeConfiguration<VohalrMustahsilFaturaDokumu>
    {
        public VohalrMustahsilFaturaDokumuConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_MUSTAHSIL_FATURA_DOKUMU");

            Property(e => e.Aciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.Bagkur).HasColumnName("BAGKUR");

            Property(e => e.BagkurOrani).HasColumnName("BAGKUR_ORANI");

            Property(e => e.Borsa).HasColumnName("BORSA");

            Property(e => e.BorsaOrani).HasColumnName("BORSA_ORANI");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.DigerIadeler).HasColumnName("DIGER_IADELER");

            Property(e => e.Durum)
                .IsRequired()
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DURUM");

            Property(e => e.FaturaNo)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.FaturaTarihi)
                .HasColumnType("datetime")
                .HasColumnName("FATURA_TARIHI");

            Property(e => e.IadesizKapKdv).HasColumnName("IADESIZ_KAP_KDV");

            Property(e => e.IadesizKapKdvOrani).HasColumnName("IADESIZ_KAP_KDV_ORANI");

            Property(e => e.IadesizKapKomisyonaDahil).HasColumnName("IADESIZ_KAP_KOMISYONA_DAHIL");

            Property(e => e.IadesizKapTutari).HasColumnName("IADESIZ_KAP_TUTARI");

            Property(e => e.Kdv).HasColumnName("KDV");

            Property(e => e.Kesildi).HasColumnName("KESILDI");

            Property(e => e.Komisyon).HasColumnName("KOMISYON");

            Property(e => e.KomisyonKdv).HasColumnName("KOMISYON_KDV");

            Property(e => e.KomisyonKdvOrani).HasColumnName("KOMISYON_KDV_ORANI");

            Property(e => e.KomisyonOrani).HasColumnName("KOMISYON_ORANI");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.Marka)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MARKA");

            Property(e => e.MarkaId).HasColumnName("MARKA_ID");

            Property(e => e.Masraf).HasColumnName("MASRAF");

            Property(e => e.Miktar).HasColumnName("MIKTAR");

            Property(e => e.MustahsilAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MUSTAHSIL_ADI");

            Property(e => e.MustahsilKodu)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MUSTAHSIL_KODU")
                .IsFixedLength();

            Property(e => e.Navlun).HasColumnName("NAVLUN");

            Property(e => e.NavlunKdv).HasColumnName("NAVLUN_KDV");

            Property(e => e.NavlunKdvOrani).HasColumnName("NAVLUN_KDV_ORANI");

            Property(e => e.Plaka)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PLAKA");

            Property(e => e.Rusum).HasColumnName("RUSUM");

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

            Property(e => e.Sehir)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SEHIR");

            Property(e => e.StokGirisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("STOK_GIRIS_TARIHI");

            Property(e => e.Stopaj).HasColumnName("STOPAJ");

            Property(e => e.StopajOrani).HasColumnName("STOPAJ_ORANI");

            Property(e => e.Tutar).HasColumnName("TUTAR");

            Property(e => e.VergiKimlikNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VERGI_KIMLIK_NO")
                .IsFixedLength();
        }
    }
}
