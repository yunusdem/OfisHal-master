using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohksAlisFaturaSatiriIstekConfiguration : EntityTypeConfiguration<VohksAlisFaturaSatiriIstek>
    {
        public VohksAlisFaturaSatiriIstekConfiguration()
        {
            //HasNoKey();

            ToTable("VOHKS_ALIS_FATURA_SATIRI_ISTEK");

            Property(e => e.BeldeHksId).HasColumnName("BELDE_HKS_ID");

            Property(e => e.BildirimTuru).HasColumnName("BILDIRIM_TURU");

            Property(e => e.Birim).HasColumnName("BIRIM");

            Property(e => e.EPosta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("E_POSTA");

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.FaturaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FATURA_NO")
                .IsFixedLength();

            Property(e => e.FaturaSatiriId).HasColumnName("FATURA_SATIRI_ID");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.GsmNo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("GSM_NO");

            Property(e => e.HksId).HasColumnName("HKS_ID");

            Property(e => e.HksMalinNiteligi).HasColumnName("HKS_MALIN_NITELIGI");

            Property(e => e.HksUretimSekli).HasColumnName("HKS_URETIM_SEKLI");

            Property(e => e.IlHksId).HasColumnName("IL_HKS_ID");

            Property(e => e.IlceHksId).HasColumnName("ILCE_HKS_ID");

            Property(e => e.IrsaliyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IRSALIYE_NO")
                .IsFixedLength();

            Property(e => e.KunyeSatirId).HasColumnName("KUNYE_SATIR_ID");

            Property(e => e.MalMiktari).HasColumnName("MAL_MIKTARI");

            Property(e => e.MustahsilAdi)
                .IsRequired()
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

            Property(e => e.PlakaNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PLAKA_NO")
                .IsFixedLength();

            Property(e => e.Sifati).HasColumnName("SIFATI");

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

            Property(e => e.Unvan)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("UNVAN");

            Property(e => e.UrunHksId).HasColumnName("URUN_HKS_ID");

            Property(e => e.UrunHksKodu).HasColumnName("URUN_HKS_KODU");

            Property(e => e.VergiKimlikNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VERGI_KIMLIK_NO")
                .IsFixedLength();
        }
    }
}
