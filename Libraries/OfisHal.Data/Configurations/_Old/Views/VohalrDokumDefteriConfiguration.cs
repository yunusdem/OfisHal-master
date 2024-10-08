using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrDokumDefteriConfiguration : EntityTypeConfiguration<VohalrDokumDefteri>
    {
        public VohalrDokumDefteriConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_DOKUM_DEFTERI");

            Property(e => e.Bagkur).HasColumnName("BAGKUR");

            Property(e => e.Borsa).HasColumnName("BORSA");

            Property(e => e.DokDokumAmbar).HasColumnName("DOK_DOKUM_AMBAR");

            Property(e => e.DokDokumDefterTipi).HasColumnName("DOK_DOKUM_DEFTER_TIPI");

            Property(e => e.DokumNo)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DOKUM_NO")
                .IsFixedLength();

            Property(e => e.FaturaTarihi)
                .HasColumnType("datetime")
                .HasColumnName("FATURA_TARIHI");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.GeldigiYer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GELDIGI_YER");

            Property(e => e.IadesizKapKdv).HasColumnName("IADESIZ_KAP_KDV");

            Property(e => e.IadesizKapTutari).HasColumnName("IADESIZ_KAP_TUTARI");

            Property(e => e.KapAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("KAP_ADI");

            Property(e => e.KapSayisi).HasColumnName("KAP_SAYISI");

            Property(e => e.KdvOrani).HasColumnName("KDV_ORANI");

            Property(e => e.Komisyon).HasColumnName("KOMISYON");

            Property(e => e.KomisyonKdv).HasColumnName("KOMISYON_KDV");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.MakbuzNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MAKBUZ_NO")
                .IsFixedLength();

            Property(e => e.MalAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAL_ADI");

            Property(e => e.MalKdv).HasColumnName("MAL_KDV");

            Property(e => e.Marka)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MARKA");

            Property(e => e.Masraf).HasColumnName("MASRAF");

            Property(e => e.MasrafKdv).HasColumnName("MASRAF_KDV");

            Property(e => e.Miktar).HasColumnName("MIKTAR");

            Property(e => e.Mustahsil)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MUSTAHSIL");

            Property(e => e.Navlun).HasColumnName("NAVLUN");

            Property(e => e.NavlunKdv).HasColumnName("NAVLUN_KDV");

            Property(e => e.Plaka)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PLAKA");

            Property(e => e.Rusum).HasColumnName("RUSUM");

            Property(e => e.SatisFaturasiNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SATIS_FATURASI_NO");

            Property(e => e.SatisFaturasiTarihi)
                .HasColumnType("datetime")
                .HasColumnName("SATIS_FATURASI_TARIHI");

            Property(e => e.StokGirisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("STOK_GIRIS_TARIHI");

            Property(e => e.Stopaj).HasColumnName("STOPAJ");

            Property(e => e.Tip).HasColumnName("TIP");

            Property(e => e.Tutar).HasColumnName("TUTAR");
        }
    }
}
