using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohksFaturaSatiriIstekConfiguration : EntityTypeConfiguration<VohksFaturaSatiriIstek>
    {
        public VohksFaturaSatiriIstekConfiguration()
        {
            //HasNoKey();

            ToTable("VOHKS_FATURA_SATIRI_ISTEK");

            Property(e => e.BeldeHksId).HasColumnName("BELDE_HKS_ID");

            Property(e => e.BildirimTuru).HasColumnName("BILDIRIM_TURU");

            Property(e => e.BildirimciSifati).HasColumnName("BILDIRIMCI_SIFATI");

            Property(e => e.Birim).HasColumnName("BIRIM");

            Property(e => e.CariIlkMagazaHksId).HasColumnName("CARI_ILK_MAGAZA_HKS_ID");

            Property(e => e.CariKartGidecegiYerTipi).HasColumnName("CARI_KART_GIDECEGI_YER_TIPI");

            Property(e => e.CariKartYerHksId).HasColumnName("CARI_KART_YER_HKS_ID");

            Property(e => e.EPosta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("E_POSTA");

            Property(e => e.FaturaBeldeHksId).HasColumnName("FATURA_BELDE_HKS_ID");

            Property(e => e.FaturaGidecegiYerTipi).HasColumnName("FATURA_GIDECEGI_YER_TIPI");

            Property(e => e.FaturaGuid)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("FATURA_GUID");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.FaturaIlHksId).HasColumnName("FATURA_IL_HKS_ID");

            Property(e => e.FaturaIlceHksId).HasColumnName("FATURA_ILCE_HKS_ID");

            Property(e => e.FaturaMagazaBeldeHksId).HasColumnName("FATURA_MAGAZA_BELDE_HKS_ID");

            Property(e => e.FaturaMagazaIlHksId).HasColumnName("FATURA_MAGAZA_IL_HKS_ID");

            Property(e => e.FaturaMagazaIlceHksId).HasColumnName("FATURA_MAGAZA_ILCE_HKS_ID");

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.FaturaSatiriId).HasColumnName("FATURA_SATIRI_ID");

            Property(e => e.FaturaYerHksId).HasColumnName("FATURA_YER_HKS_ID");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.GsmNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("GSM_NO");

            Property(e => e.Guid)
                .IsRequired()
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("GUID");

            Property(e => e.HksId).HasColumnName("HKS_ID");

            Property(e => e.HksMalinNiteligi).HasColumnName("HKS_MALIN_NITELIGI");

            Property(e => e.HksUretimSekli).HasColumnName("HKS_URETIM_SEKLI");

            Property(e => e.HksUrunKodu).HasColumnName("HKS_URUN_KODU");

            Property(e => e.IlHksId).HasColumnName("IL_HKS_ID");

            Property(e => e.IlceHksId).HasColumnName("ILCE_HKS_ID");

            Property(e => e.IrsaliyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IRSALIYE_NO")
                .IsFixedLength();

            Property(e => e.IskontoluFiyat).HasColumnName("ISKONTOLU_FIYAT");

            Property(e => e.KunyeAlinabilir).HasColumnName("KUNYE_ALINABILIR");

            Property(e => e.KunyeIstekGuid)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("KUNYE_ISTEK_GUID");

            Property(e => e.KunyeSatirId).HasColumnName("KUNYE_SATIR_ID");

            Property(e => e.MagazaHksId).HasColumnName("MAGAZA_HKS_ID");

            Property(e => e.MalMiktari).HasColumnName("MAL_MIKTARI");

            Property(e => e.MustahsilAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MUSTAHSIL_ADI");

            Property(e => e.MustahsilEposta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MUSTAHSIL_EPOSTA");

            Property(e => e.MustahsilGsmNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MUSTAHSIL_GSM_NO");

            Property(e => e.MustahsilPlakaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MUSTAHSIL_PLAKA_NO")
                .IsFixedLength();

            Property(e => e.MustahsilTel1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MUSTAHSIL_TEL1");

            Property(e => e.MustahsilVergiKimlikNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MUSTAHSIL_VERGI_KIMLIK_NO")
                .IsFixedLength();

            Property(e => e.MusteriCariKartId).HasColumnName("MUSTERI_CARI_KART_ID");

            Property(e => e.PlakaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PLAKA_NO")
                .IsFixedLength();

            Property(e => e.Rusum).HasColumnName("RUSUM");

            Property(e => e.SatinAlaninSifati).HasColumnName("SATIN_ALANIN_SIFATI");

            Property(e => e.SatisKunye)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SATIS_KUNYE")
                .IsFixedLength();

            Property(e => e.SatisKunyeId).HasColumnName("SATIS_KUNYE_ID");

            Property(e => e.StokKunye)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STOK_KUNYE")
                .IsFixedLength();

            Property(e => e.StokKunyeId).HasColumnName("STOK_KUNYE_ID");

            Property(e => e.TeslimatYeri)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("TESLIMAT_YERI");

            Property(e => e.TeslimatYeriHksId).HasColumnName("TESLIMAT_YERI_HKS_ID");

            Property(e => e.TeslimatYeriId).HasColumnName("TESLIMAT_YERI_ID");

            Property(e => e.TeslimatYeriTipi).HasColumnName("TESLIMAT_YERI_TIPI");

            Property(e => e.Tip).HasColumnName("TIP");

            Property(e => e.UlkeHksId).HasColumnName("ULKE_HKS_ID");

            Property(e => e.Unvan)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNVAN");

            Property(e => e.UrunHksId).HasColumnName("URUN_HKS_ID");

            Property(e => e.VergiKimlikNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VERGI_KIMLIK_NO")
                .IsFixedLength();
        }
    }
}
