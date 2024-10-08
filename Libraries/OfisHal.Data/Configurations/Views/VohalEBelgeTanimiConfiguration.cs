using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Core.Domain.Configurations
{
    internal class VohalEBelgeTanimiConfiguration : EntityTypeConfiguration<VohalEBelgeTanimi>
    {
        public VohalEBelgeTanimiConfiguration()
        {
            //HasNoKey();
            HasKey(e => e.EArsivFaturasiSiraNo);
            ToTable("VOHAL_E_BELGE_TANIMI");

            Property(e => e.EArsivBaslangicTarihi)
                .HasColumnType("datetime")
                .HasColumnName("E_ARSIV_BASLANGIC_TARIHI");

            Property(e => e.EArsivFaturasiBasilsin).HasColumnName("E_ARSIV_FATURASI_BASILSIN");

            Property(e => e.EArsivFaturasiOnEki)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("E_ARSIV_FATURASI_ON_EKI")
                .IsFixedLength();

            Property(e => e.EArsivFaturasiSiraNo).HasColumnName("E_ARSIV_FATURASI_SIRA_NO");

            Property(e => e.EBelgeServerIp)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("E_BELGE_SERVER_IP")
                .IsFixedLength();

            Property(e => e.EBelgeServerPortu).HasColumnName("E_BELGE_SERVER_PORTU");

            Property(e => e.EFaturaBasilsin).HasColumnName("E_FATURA_BASILSIN");

            Property(e => e.EFaturaBaslangicTarihi)
                .HasColumnType("datetime")
                .HasColumnName("E_FATURA_BASLANGIC_TARIHI");

            Property(e => e.EFaturaExeYolu)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_EXE_YOLU");

            Property(e => e.EFaturaMustahsilVar).HasColumnName("E_FATURA_MUSTAHSIL_VAR");

            Property(e => e.EFaturaMustahsilVknVar).HasColumnName("E_FATURA_MUSTAHSIL_VKN_VAR");

            Property(e => e.EFaturaNotAdetOlsun).HasColumnName("E_FATURA_NOT_ADET_OLSUN");

            Property(e => e.EFaturaOnEki)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_ON_EKI")
                .IsFixedLength();

            Property(e => e.EFaturaPortalAdresi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_PORTAL_ADRESI");

            Property(e => e.EFaturaSenaryosu).HasColumnName("E_FATURA_SENARYOSU");

            Property(e => e.EFaturaSiraNo).HasColumnName("E_FATURA_SIRA_NO");

            Property(e => e.EFaturaYaziIleSekli).HasColumnName("E_FATURA_YAZI_ILE_SEKLI");

            Property(e => e.EIrsaliyeBasilsin).HasColumnName("E_IRSALIYE_BASILSIN");

            Property(e => e.EIrsaliyeBaslangicTarihi)
                .HasColumnType("datetime")
                .HasColumnName("E_IRSALIYE_BASLANGIC_TARIHI");

            Property(e => e.EIrsaliyeOnEki)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("E_IRSALIYE_ON_EKI")
                .IsFixedLength();

            Property(e => e.EIrsaliyeSiraNo).HasColumnName("E_IRSALIYE_SIRA_NO");

            Property(e => e.EIrsaliyedeFiyatVar).HasColumnName("E_IRSALIYEDE_FIYAT_VAR");

            Property(e => e.EMusFatArsivOnEki)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("E_MUS_FAT_ARSIV_ON_EKI")
                .IsFixedLength();

            Property(e => e.EMusFatArsivSiraNo).HasColumnName("E_MUS_FAT_ARSIV_SIRA_NO");

            Property(e => e.EMustahsilFaturasiOnEki)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("E_MUSTAHSIL_FATURASI_ON_EKI")
                .IsFixedLength();

            Property(e => e.EMustahsilFaturasiSiraNo).HasColumnName("E_MUSTAHSIL_FATURASI_SIRA_NO");

            Property(e => e.EMustahsilMakbuzuBasilsin).HasColumnName("E_MUSTAHSIL_MAKBUZU_BASILSIN");

            Property(e => e.EMustahsilMakbuzuBaslangicTarihi)
                .HasColumnType("datetime")
                .HasColumnName("E_MUSTAHSIL_MAKBUZU_BASLANGIC_TARIHI");

            Property(e => e.EMustahsilMakbuzuOnEki)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("E_MUSTAHSIL_MAKBUZU_ON_EKI")
                .IsFixedLength();

            Property(e => e.EMustahsilMakbuzuSiraNo).HasColumnName("E_MUSTAHSIL_MAKBUZU_SIRA_NO");

            Property(e => e.EntegratorCsvDizini)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ENTEGRATOR_CSV_DIZINI");

            Property(e => e.EntegratorYanitVermeSuresi).HasColumnName("ENTEGRATOR_YANIT_VERME_SURESI");

            Property(e => e.FirmalaraMakbuzKesilsin).HasColumnName("FIRMALARA_MAKBUZ_KESILSIN");

            Property(e => e.KdvMuafiyetNedeni)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("KDV_MUAFIYET_NEDENI");

            Property(e => e.MusFatDuzenlemeSekli).HasColumnName("MUS_FAT_DUZENLEME_SEKLI");

            Property(e => e.RptDosyalariKopyalansin).HasColumnName("RPT_DOSYALARI_KOPYALANSIN");

            Property(e => e.XsltDosyalariKopyalansin).HasColumnName("XSLT_DOSYALARI_KOPYALANSIN");
        }
    }
}
