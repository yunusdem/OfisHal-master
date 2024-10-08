using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalMakbuzConfiguration : EntityTypeConfiguration<TohalMakbuz>
    {
        public TohalMakbuzConfiguration()
        {
            HasKey(e => e.MakbuzId);

            ToTable("TOHAL_MAKBUZ");

            HasIndex(e => e.DokumNo)
                .IsUnique();

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.Aciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.Bagkur).HasColumnName("BAGKUR");

            Property(e => e.BagkurDosyaId).HasColumnName("BAGKUR_DOSYA_ID");

            Property(e => e.BagkurHesaplanmasin).HasColumnName("BAGKUR_HESAPLANMASIN");

            Property(e => e.BagkurOrani).HasColumnName("BAGKUR_ORANI");

            Property(e => e.BildirimTuru).HasColumnName("BILDIRIM_TURU");

            Property(e => e.Borsa).HasColumnName("BORSA");

            Property(e => e.BorsaOrani).HasColumnName("BORSA_ORANI");

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.CariyeIslemeSekli).HasColumnName("CARIYE_ISLEME_SEKLI");

            Property(e => e.DigHksBildirimSekli).HasColumnName("DIG_HKS_BILDIRIM_SEKLI");

            Property(e => e.DokumNo)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DOKUM_NO")
                .IsFixedLength();

            Property(e => e.EFaturaBolgeKodu)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_BOLGE_KODU");

            Property(e => e.EFaturaDurumu).HasColumnName("E_FATURA_DURUMU");

            Property(e => e.EFaturaEttn)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_ETTN");

            Property(e => e.EFaturaGibDurumu).HasColumnName("E_FATURA_GIB_DURUMU");

            Property(e => e.EFaturaHataAciklamasi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_HATA_ACIKLAMASI");

            Property(e => e.EFaturaNot)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("E_FATURA_NOT");

            Property(e => e.EklemeZamani)
                .HasColumnType("datetime")
                .HasColumnName("EKLEME_ZAMANI");

            Property(e => e.EkleyenId).HasColumnName("EKLEYEN_ID");

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.FaturaTarihi)
                .HasColumnType("datetime")
                .HasColumnName("FATURA_TARIHI");

            Property(e => e.FaturaZamani)
                .HasColumnType("datetime")
                .HasColumnName("FATURA_ZAMANI");

            Property(e => e.GeldigiYer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GELDIGI_YER");

            Property(e => e.GibFirmamizPostaKutusuId).HasColumnName("GIB_FIRMAMIZ_POSTA_KUTUSU_ID");

            Property(e => e.GibMuhatapPostaKutusuId).HasColumnName("GIB_MUHATAP_POSTA_KUTUSU_ID");

            Property(e => e.GuncellemeZamani)
                .HasColumnType("datetime")
                .HasColumnName("GUNCELLEME_ZAMANI");

            Property(e => e.GuncelleyenId).HasColumnName("GUNCELLEYEN_ID");

            Property(e => e.HalId).HasColumnName("HAL_ID");

            Property(e => e.HksMalinNiteligi).HasColumnName("HKS_MALIN_NITELIGI");

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

            Property(e => e.KapSayisi).HasColumnName("KAP_SAYISI");

            Property(e => e.KdvToplami).HasColumnName("KDV_TOPLAMI");

            Property(e => e.Kesildi).HasColumnName("KESILDI");

            Property(e => e.Komisyon).HasColumnName("KOMISYON");

            Property(e => e.KomisyonKdv).HasColumnName("KOMISYON_KDV");

            Property(e => e.KomisyonKdvOrani).HasColumnName("KOMISYON_KDV_ORANI");

            Property(e => e.KomisyonOrani).HasColumnName("KOMISYON_ORANI");

            Property(e => e.MakbuzGuncellemeZamani)
                .HasColumnType("datetime")
                .HasColumnName("MAKBUZ_GUNCELLEME_ZAMANI");

            Property(e => e.MakbuzGuncelleyenId).HasColumnName("MAKBUZ_GUNCELLEYEN_ID");

            Property(e => e.MalToplami).HasColumnName("MAL_TOPLAMI");

            Property(e => e.MarkaId).HasColumnName("MARKA_ID");

            Property(e => e.MasrafKdvToplami).HasColumnName("MASRAF_KDV_TOPLAMI");

            Property(e => e.MasrafToplami).HasColumnName("MASRAF_TOPLAMI");

            Property(e => e.Navlun).HasColumnName("NAVLUN");

            Property(e => e.NavlunKdv).HasColumnName("NAVLUN_KDV");

            Property(e => e.NavlunKdvOrani).HasColumnName("NAVLUN_KDV_ORANI");

            Property(e => e.OrtakId).HasColumnName("ORTAK_ID");

            Property(e => e.OrtaklikOrani).HasColumnName("ORTAKLIK_ORANI");

            Property(e => e.Plaka)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PLAKA");

            Property(e => e.Rusum).HasColumnName("RUSUM");

            Property(e => e.RusumOrani).HasColumnName("RUSUM_ORANI");

            Property(e => e.Sifati).HasColumnName("SIFATI");

            Property(e => e.StokGirisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("STOK_GIRIS_TARIHI");

            Property(e => e.Stopaj).HasColumnName("STOPAJ");

            Property(e => e.StopajOrani).HasColumnName("STOPAJ_ORANI");

            Property(e => e.TeslimatYeriId).HasColumnName("TESLIMAT_YERI_ID");

            Property(e => e.UlkeId).HasColumnName("ULKE_ID");

            Property(e => e.Vade).HasColumnName("VADE");

            Property(e => e.YerId).HasColumnName("YER_ID");

            HasOptional(d => d.BagkurDosya)
                .WithMany(p => p.TohalMakbuzs)
                .HasForeignKey(d => d.BagkurDosyaId);

            HasRequired(d => d.CariKart)
                .WithMany(p => p.TohalMakbuzCariKarts)
                .HasForeignKey(d => d.CariKartId)
                .WillCascadeOnDelete(false);

            HasRequired(d => d.Ekleyen)
                .WithMany(p => p.TohalMakbuzEkleyens)
                .HasForeignKey(d => d.EkleyenId)
                .WillCascadeOnDelete(false);

            HasOptional(d => d.GibFirmamizPostaKutusu)
                .WithMany(p => p.TohalMakbuzGibFirmamizPostaKutusus)
                .HasForeignKey(d => d.GibFirmamizPostaKutusuId);

            HasOptional(d => d.GibMuhatapPostaKutusu)
                .WithMany(p => p.TohalMakbuzGibMuhatapPostaKutusus)
                .HasForeignKey(d => d.GibMuhatapPostaKutusuId);

            HasRequired(d => d.Guncelleyen)
                .WithMany(p => p.TohalMakbuzGuncelleyens)
                .HasForeignKey(d => d.GuncelleyenId)
                .WillCascadeOnDelete(false);

            HasOptional(d => d.Hal)
                .WithMany(p => p.TohalMakbuzs)
                .HasForeignKey(d => d.HalId);

            HasRequired(d => d.MakbuzGuncelleyen)
                .WithMany(p => p.TohalMakbuzMakbuzGuncelleyens)
                .HasForeignKey(d => d.MakbuzGuncelleyenId)
                .WillCascadeOnDelete(false);

            HasRequired(d => d.Marka)
                .WithMany(p => p.TohalMakbuzs)
                .HasForeignKey(d => d.MarkaId)
                .WillCascadeOnDelete(false);

            HasOptional(d => d.Ortak)
                .WithMany(p => p.TohalMakbuzOrtaks)
                .HasForeignKey(d => d.OrtakId);

            HasOptional(d => d.TeslimatYeri)
                .WithMany(p => p.TohalMakbuzs)
                .HasForeignKey(d => d.TeslimatYeriId);

            HasOptional(d => d.Ulke)
                .WithMany(p => p.TohalMakbuzs)
                .HasForeignKey(d => d.UlkeId);

            HasOptional(d => d.Yer)
                .WithMany(p => p.TohalMakbuzs)
                .HasForeignKey(d => d.YerId);
        }
    }
}
