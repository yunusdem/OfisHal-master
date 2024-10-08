using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrMakbuzXsltConfiguration : EntityTypeConfiguration<VohalrMakbuzXslt>
    {
        public VohalrMakbuzXsltConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_MAKBUZ_XSLT");

            Property(e => e.Adres)
                .IsRequired()
                .HasMaxLength(603)
                .IsUnicode(false)
                .HasColumnName("ADRES");

            Property(e => e.Bagkur).HasColumnName("BAGKUR");

            Property(e => e.BagkurOrani).HasColumnName("BAGKUR_ORANI");

            Property(e => e.Borsa).HasColumnName("BORSA");

            Property(e => e.BorsaOrani).HasColumnName("BORSA_ORANI");

            Property(e => e.CariAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CARI_ADI");

            Property(e => e.DigAdres)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DIG_ADRES");

            Property(e => e.DigEposta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DIG_EPOSTA");

            Property(e => e.DigSicilKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DIG_SICIL_KODU")
                .IsFixedLength();

            Property(e => e.DigVergiKimlikNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DIG_VERGI_KIMLIK_NO")
                .IsFixedLength();

            Property(e => e.DokumNo)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DOKUM_NO")
                .IsFixedLength();

            Property(e => e.DuzenlemeZamani)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("DUZENLEME_ZAMANI");

            Property(e => e.EFaturaEttn)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_ETTN");

            Property(e => e.EPosta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("E_POSTA");

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.FaturaTarihi)
                .HasColumnType("datetime")
                .HasColumnName("FATURA_TARIHI");

            Property(e => e.FirIbanNo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FIR_IBAN_NO");

            Property(e => e.FirMersisNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FIR_MERSIS_NO")
                .IsFixedLength();

            Property(e => e.FirWebAdresi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FIR_WEB_ADRESI");

            Property(e => e.FirmaAdresi)
                .IsRequired()
                .HasMaxLength(575)
                .IsUnicode(false)
                .HasColumnName("FIRMA_ADRESI");

            Property(e => e.FirmaSehir)
                .IsRequired()
                .HasMaxLength(403)
                .IsUnicode(false)
                .HasColumnName("FIRMA_SEHIR");

            Property(e => e.FirmaTelefonNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FIRMA_TELEFON_NO");

            Property(e => e.FirmaVergiDairesiAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("FIRMA_VERGI_DAIRESI_ADI");

            Property(e => e.IadeliKapTutari).HasColumnName("IADELI_KAP_TUTARI");

            Property(e => e.Imza)
                .HasColumnType("image")
                .HasColumnName("IMZA");

            Property(e => e.IrsaliyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IRSALIYE_NO")
                .IsFixedLength();

            Property(e => e.Logo)
                .HasColumnType("image")
                .HasColumnName("LOGO");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.Masraflar).HasColumnName("MASRAFLAR");

            Property(e => e.Plaka)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PLAKA");

            Property(e => e.Rusum).HasColumnName("RUSUM");

            Property(e => e.Sehir)
                .IsRequired()
                .HasMaxLength(403)
                .IsUnicode(false)
                .HasColumnName("SEHIR");

            Property(e => e.StokGirisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("STOK_GIRIS_TARIHI");

            Property(e => e.Stopaj).HasColumnName("STOPAJ");

            Property(e => e.StopajOrani).HasColumnName("STOPAJ_ORANI");

            Property(e => e.VergiDairesi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("VERGI_DAIRESI");

            Property(e => e.VergiKimlikNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VERGI_KIMLIK_NO")
                .IsFixedLength();
        }
    }
}
