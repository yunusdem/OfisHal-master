using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrBagkurMuafiyetRaporuConfiguration : EntityTypeConfiguration<VohalrBagkurMuafiyetRaporu>
    {
        public VohalrBagkurMuafiyetRaporuConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_BAGKUR_MUAFIYET_RAPORU");

            Property(e => e.Ad)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("AD");

            Property(e => e.Adres)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ADRES");

            Property(e => e.BagkurNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BAGKUR_NO")
                .IsFixedLength();

            Property(e => e.CariKartId).HasColumnName("CARI_KART_ID");

            Property(e => e.GsmNumarasi)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("GSM_NUMARASI");

            Property(e => e.Kod)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KOD")
                .IsFixedLength();

            Property(e => e.MuafiyetBelgeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MUAFIYET_BELGE_NO")
                .IsFixedLength();

            Property(e => e.MuafiyetBitisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("MUAFIYET_BITIS_TARIHI");

            Property(e => e.Tel1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("TEL1");

            Property(e => e.VergiDairesiAdi)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("VERGI_DAIRESI_ADI");

            Property(e => e.VergiKimlikNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VERGI_KIMLIK_NO")
                .IsFixedLength();
        }
    }
}
