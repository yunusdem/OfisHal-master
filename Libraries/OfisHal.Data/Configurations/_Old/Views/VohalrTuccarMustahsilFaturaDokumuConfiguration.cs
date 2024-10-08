using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrTuccarMustahsilFaturaDokumuConfiguration : EntityTypeConfiguration<VohalrTuccarMustahsilFaturaDokumu>
    {
        public VohalrTuccarMustahsilFaturaDokumuConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_TUCCAR_MUSTAHSIL_FATURA_DOKUMU");

            Property(e => e.Bagkur).HasColumnName("BAGKUR");

            Property(e => e.Borsa).HasColumnName("BORSA");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

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

            Property(e => e.IadesizKapTutari).HasColumnName("IADESIZ_KAP_TUTARI");

            Property(e => e.Kdv).HasColumnName("KDV");

            Property(e => e.Kesildi).HasColumnName("KESILDI");

            Property(e => e.Komisyon)
                .HasColumnType("numeric(1, 1)")
                .HasColumnName("KOMISYON");

            Property(e => e.KomisyonKdv)
                .HasColumnType("numeric(1, 1)")
                .HasColumnName("KOMISYON_KDV");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.Marka)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MARKA");

            Property(e => e.Masraf).HasColumnName("MASRAF");

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

            Property(e => e.Rusum)
                .HasColumnType("numeric(1, 1)")
                .HasColumnName("RUSUM");

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
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SEHIR");

            Property(e => e.Stopaj).HasColumnName("STOPAJ");

            Property(e => e.Tutar).HasColumnName("TUTAR");

            Property(e => e.VergiKimlikNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VERGI_KIMLIK_NO")
                .IsFixedLength();
        }
    }
}
