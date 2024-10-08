using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalrMuhHesapEkstreConfiguration : EntityTypeConfiguration<VohalrMuhHesapEkstre>
    {
        public VohalrMuhHesapEkstreConfiguration()
        {
            //HasNoKey();

            ToTable("VOHALR_MUH_HESAP_EKSTRE");

            Property(e => e.Aciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.FisNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FIS_NO")
                .IsFixedLength();

            Property(e => e.Kod)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KOD")
                .IsFixedLength();

            Property(e => e.KurusBasamakSayisi).HasColumnName("KURUS_BASAMAK_SAYISI");

            Property(e => e.Meblag).HasColumnName("MEBLAG");

            Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");

            Property(e => e.Tip).HasColumnName("TIP");

            Property(e => e.YevmiyeNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("YEVMIYE_NO")
                .IsFixedLength();
        }
    }
}
