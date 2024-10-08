using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrFaturaDegisiklikTakipConfiguration : EntityTypeConfiguration<VohalrFaturaDegisiklikTakip>
    {
        public VohalrFaturaDegisiklikTakipConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_FATURA_DEGISIKLIK_TAKIP");

            Property(e => e.DegisenSatirSayisi).HasColumnName("DEGISEN_SATIR_SAYISI");

            Property(e => e.DegisnMasrafSayisi).HasColumnName("DEGISN_MASRAF_SAYISI");

            Property(e => e.DegisnRehinSayisi).HasColumnName("DEGISN_REHIN_SAYISI");

            Property(e => e.Islem).HasColumnName("ISLEM");

            Property(e => e.KullaniciAdi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KULLANICI_ADI");

            Property(e => e.KullaniciId).HasColumnName("KULLANICI_ID");

            Property(e => e.OCariAd)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("O_CARI_AD");

            Property(e => e.OCariKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("O_CARI_KODU")
                .IsFixedLength();

            Property(e => e.ODegistirildi).HasColumnName("O_DEGISTIRILDI");

            Property(e => e.OFaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("O_FATURA_NO")
                .IsFixedLength();

            Property(e => e.OIadesizKapKdv).HasColumnName("O_IADESIZ_KAP_KDV");

            Property(e => e.OIadesizKapKdvOrani).HasColumnName("O_IADESIZ_KAP_KDV_ORANI");

            Property(e => e.OIhracatci).HasColumnName("O_IHRACATCI");

            Property(e => e.OIrsaliyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("O_IRSALIYE_NO")
                .IsFixedLength();

            Property(e => e.OIrsaliyeZamani)
                .HasColumnType("datetime")
                .HasColumnName("O_IRSALIYE_ZAMANI");

            Property(e => e.OIskonto).HasColumnName("O_ISKONTO");

            Property(e => e.OIskontoOrani).HasColumnName("O_ISKONTO_ORANI");

            Property(e => e.OKdvliIadesizKap).HasColumnName("O_KDVLI_IADESIZ_KAP");

            Property(e => e.OKdvsizIadesizKap).HasColumnName("O_KDVSIZ_IADESIZ_KAP");

            Property(e => e.OKesildi).HasColumnName("O_KESILDI");

            Property(e => e.OKrediKartiTahsilati).HasColumnName("O_KREDI_KARTI_TAHSILATI");

            Property(e => e.OMagazaId).HasColumnName("O_MAGAZA_ID");

            Property(e => e.ONakitTahsilat).HasColumnName("O_NAKIT_TAHSILAT");

            Property(e => e.ONakliye).HasColumnName("O_NAKLIYE");

            Property(e => e.ONakliyeKdv).HasColumnName("O_NAKLIYE_KDV");

            Property(e => e.ONakliyeKdvOrani).HasColumnName("O_NAKLIYE_KDV_ORANI");

            Property(e => e.OPlakaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("O_PLAKA_NO")
                .IsFixedLength();

            Property(e => e.OPosCihazi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("O_POS_CIHAZI");

            Property(e => e.ORehinIadeliKap).HasColumnName("O_REHIN_IADELI_KAP");

            Property(e => e.ORusum).HasColumnName("O_RUSUM");

            Property(e => e.ORusumKdv).HasColumnName("O_RUSUM_KDV");

            Property(e => e.ORusumKdvIliskisi).HasColumnName("O_RUSUM_KDV_ILISKISI");

            Property(e => e.ORusumKdvOrani).HasColumnName("O_RUSUM_KDV_ORANI");

            Property(e => e.OSiparisId).HasColumnName("O_SIPARIS_ID");

            Property(e => e.OSiparisNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("O_SIPARIS_NO")
                .IsFixedLength();

            Property(e => e.OTarih)
                .HasColumnType("datetime")
                .HasColumnName("O_TARIH");

            Property(e => e.OTip).HasColumnName("O_TIP");

            Property(e => e.OUnvan)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("O_UNVAN");

            Property(e => e.OVade).HasColumnName("O_VADE");

            Property(e => e.OVeresiye).HasColumnName("O_VERESIYE");

            Property(e => e.OYukleme).HasColumnName("O_YUKLEME");

            Property(e => e.OYuklemeKdv).HasColumnName("O_YUKLEME_KDV");

            Property(e => e.OYuklemeKdvOrani).HasColumnName("O_YUKLEME_KDV_ORANI");

            Property(e => e.ReferansNo).HasColumnName("REFERANS_NO");

            Property(e => e.SCariAd)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("S_CARI_AD");

            Property(e => e.SCariKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("S_CARI_KODU")
                .IsFixedLength();

            Property(e => e.SDegistirildi).HasColumnName("S_DEGISTIRILDI");

            Property(e => e.SFaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("S_FATURA_NO")
                .IsFixedLength();

            Property(e => e.SIadesizKapKdv).HasColumnName("S_IADESIZ_KAP_KDV");

            Property(e => e.SIadesizKapKdvOrani).HasColumnName("S_IADESIZ_KAP_KDV_ORANI");

            Property(e => e.SIhracatci).HasColumnName("S_IHRACATCI");

            Property(e => e.SIrsaliyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("S_IRSALIYE_NO")
                .IsFixedLength();

            Property(e => e.SIrsaliyeZamani)
                .HasColumnType("datetime")
                .HasColumnName("S_IRSALIYE_ZAMANI");

            Property(e => e.SIskonto).HasColumnName("S_ISKONTO");

            Property(e => e.SIskontoOrani).HasColumnName("S_ISKONTO_ORANI");

            Property(e => e.SKdvliIadesizKap).HasColumnName("S_KDVLI_IADESIZ_KAP");

            Property(e => e.SKdvsizIadesizKap).HasColumnName("S_KDVSIZ_IADESIZ_KAP");

            Property(e => e.SKesildi).HasColumnName("S_KESILDI");

            Property(e => e.SKrediKartiTahsilati).HasColumnName("S_KREDI_KARTI_TAHSILATI");

            Property(e => e.SMagazaId).HasColumnName("S_MAGAZA_ID");

            Property(e => e.SNakitTahsilat).HasColumnName("S_NAKIT_TAHSILAT");

            Property(e => e.SNakliye).HasColumnName("S_NAKLIYE");

            Property(e => e.SNakliyeKdv).HasColumnName("S_NAKLIYE_KDV");

            Property(e => e.SNakliyeKdvOrani).HasColumnName("S_NAKLIYE_KDV_ORANI");

            Property(e => e.SPlakaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("S_PLAKA_NO")
                .IsFixedLength();

            Property(e => e.SPosCihazi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("S_POS_CIHAZI");

            Property(e => e.SRehinIadeliKap).HasColumnName("S_REHIN_IADELI_KAP");

            Property(e => e.SRusum).HasColumnName("S_RUSUM");

            Property(e => e.SRusumKdv).HasColumnName("S_RUSUM_KDV");

            Property(e => e.SRusumKdvIliskisi).HasColumnName("S_RUSUM_KDV_ILISKISI");

            Property(e => e.SRusumKdvOrani).HasColumnName("S_RUSUM_KDV_ORANI");

            Property(e => e.SSiparisId).HasColumnName("S_SIPARIS_ID");

            Property(e => e.SSiparisNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("S_SIPARIS_NO")
                .IsFixedLength();

            Property(e => e.STarih)
                .HasColumnType("datetime")
                .HasColumnName("S_TARIH");

            Property(e => e.STip).HasColumnName("S_TIP");

            Property(e => e.SUnvan)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("S_UNVAN");

            Property(e => e.SVade).HasColumnName("S_VADE");

            Property(e => e.SVeresiye).HasColumnName("S_VERESIYE");

            Property(e => e.SYukleme).HasColumnName("S_YUKLEME");

            Property(e => e.SYuklemeKdv).HasColumnName("S_YUKLEME_KDV");

            Property(e => e.SYuklemeKdvOrani).HasColumnName("S_YUKLEME_KDV_ORANI");

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

            Property(e => e.TlKurusSayisi).HasColumnName("TL_KURUS_SAYISI");

            Property(e => e.Zaman)
                .HasColumnType("datetime")
                .HasColumnName("ZAMAN");
        }
    }
}
