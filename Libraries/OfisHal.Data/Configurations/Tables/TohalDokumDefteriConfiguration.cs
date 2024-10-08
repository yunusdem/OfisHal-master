using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class TohalDokumDefteriConfiguration : EntityTypeConfiguration<TohalDokumDefteri>
    {
        public TohalDokumDefteriConfiguration()
        {
            //HasNoKey();

            HasKey(x => x.Id);

            ToTable("TOHAL_DOKUM_DEFTERI");

            Property(e => e.Aciklama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.Id).HasColumnName("ID");

            Property(e => e.CiroPrimi).HasColumnName("CIRO_PRIMI");

            Property(e => e.FaturaSatiriId).HasColumnName("FATURA_SATIRI_ID");

            Property(e => e.Fiyat).HasColumnName("FIYAT");

            Property(e => e.KapSayisi).HasColumnName("KAP_SAYISI");

            Property(e => e.KdvOrani).HasColumnName("KDV_ORANI");

            Property(e => e.MakbuzId).HasColumnName("MAKBUZ_ID");

            Property(e => e.MalId).HasColumnName("MAL_ID");

            Property(e => e.Miktar).HasColumnName("MIKTAR");

            Property(e => e.StokHareketiId).HasColumnName("STOK_HAREKETI_ID");

            Property(e => e.Tutar).HasColumnName("TUTAR");

            HasOptional(d => d.FaturaSatiri)
                .WithMany()
                .HasForeignKey(d => d.FaturaSatiriId);

            HasRequired(d => d.Makbuz)
                .WithMany()
                .HasForeignKey(d => d.MakbuzId)
                .WillCascadeOnDelete(false);

            HasRequired(d => d.Mal)
                .WithMany()
                .HasForeignKey(d => d.MalId)
                .WillCascadeOnDelete(false);
        }
    }
}
