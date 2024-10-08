using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalMakbuzdanCariKartBilgileriniSoyleConfiguration : EntityTypeConfiguration<VohalMakbuzdanCariKartBilgileriniSoyle>
    {
        public VohalMakbuzdanCariKartBilgileriniSoyleConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_MAKBUZDAN_CARI_KART_BILGILERINI_SOYLE");

            Property(e => e.Adres)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ADRES");

            Property(e => e.BabaAdi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BABA_ADI");

            Property(e => e.BagkurNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BAGKUR_NO")
                .IsFixedLength();

            Property(e => e.BeldeAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BELDE_ADI");

            Property(e => e.BeldeId).HasColumnName("BELDE_ID");

            Property(e => e.BorsaSicilNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BORSA_SICIL_NO")
                .IsFixedLength();

            Property(e => e.Dogum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DOGUM");

            Property(e => e.IlAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IL_ADI");

            Property(e => e.IlId).HasColumnName("IL_ID");

            Property(e => e.IlceAdi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ILCE_ADI");

            Property(e => e.IlceId).HasColumnName("ILCE_ID");

            Property(e => e.KisilikTipi).HasColumnName("KISILIK_TIPI");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.MuafiyetBelgeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MUAFIYET_BELGE_NO")
                .IsFixedLength();

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
