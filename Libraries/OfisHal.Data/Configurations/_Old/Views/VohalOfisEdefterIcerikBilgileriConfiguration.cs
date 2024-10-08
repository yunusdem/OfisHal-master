using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalOfisEdefterIcerikBilgileriConfiguration : EntityTypeConfiguration<VohalOfisEdefterIcerikBilgileri>
    {
        public VohalOfisEdefterIcerikBilgileriConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_OFIS_EDEFTER_ICERIK_BILGILERI");

            Property(e => e.Aciklama)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.AlacakToplami).HasColumnName("ALACAK_TOPLAMI");

            Property(e => e.AltHesapAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ALT_HESAP_ADI");

            Property(e => e.AltHesapKodu)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ALT_HESAP_KODU")
                .IsFixedLength();

            Property(e => e.AnaHesapAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ANA_HESAP_ADI");

            Property(e => e.AnaHesapId).HasColumnName("ANA_HESAP_ID");

            Property(e => e.AnaHesapKodu)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ANA_HESAP_KODU")
                .IsFixedLength();

            Property(e => e.BorcToplami).HasColumnName("BORC_TOPLAMI");

            Property(e => e.DebitCreditCode)
                .IsRequired()
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("DEBIT_CREDIT_CODE");

            Property(e => e.DokumanAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DOKUMAN_ADI");

            Property(e => e.DokumanNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DOKUMAN_NO")
                .IsFixedLength();

            Property(e => e.DokumanTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DOKUMAN_TARIHI");

            Property(e => e.DokumanTipi)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("DOKUMAN_TIPI");

            Property(e => e.FirmaVkn)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FIRMA_VKN")
                .IsFixedLength();

            Property(e => e.Hakkinda)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("HAKKINDA");

            Property(e => e.KayitTarihi)
                .HasColumnType("datetime")
                .HasColumnName("KAYIT_TARIHI");

            Property(e => e.Meblag).HasColumnName("MEBLAG");

            Property(e => e.MuhFisId).HasColumnName("MUH_FIS_ID");

            Property(e => e.MuhFisNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MUH_FIS_NO")
                .IsFixedLength();

            Property(e => e.MuhFisTarih)
                .HasColumnType("datetime")
                .HasColumnName("MUH_FIS_TARIH");

            Property(e => e.OdemeSekli)
                .IsRequired()
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("ODEME_SEKLI");

            Property(e => e.SubeAdi).HasColumnName("SUBE_ADI");

            Property(e => e.SubeId).HasColumnName("SUBE_ID");

            Property(e => e.YevmiyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("YEVMIYE_NO")
                .IsFixedLength();

            Property(e => e.YevmiyeSatirNo).HasColumnName("YEVMIYE_SATIR_NO");
        }
    }
}
