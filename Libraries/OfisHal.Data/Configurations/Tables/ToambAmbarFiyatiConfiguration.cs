using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class ToambAmbarFiyatiConfiguration : EntityTypeConfiguration<ToambAmbarFiyati>
    {
        public ToambAmbarFiyatiConfiguration()
        {
            HasKey(e => e.AmbarFiyatiId);

            ToTable("TOAMB_AMBAR_FIYATI");

            Property(e => e.AmbarFiyatiId).HasColumnName("AMBAR_FIYATI_ID");

            Property(e => e.Aciklama)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.AmbarId).HasColumnName("AMBAR_ID");

            Property(e => e.AmbarPrimi).HasColumnName("AMBAR_PRIMI");

            Property(e => e.GeldigiYerId).HasColumnName("GELDIGI_YER_ID");

            Property(e => e.GonderenId).HasColumnName("GONDEREN_ID");

            Property(e => e.Hammaliye).HasColumnName("HAMMALIYE");

            Property(e => e.HammaliyePrimi).HasColumnName("HAMMALIYE_PRIMI");

            Property(e => e.KapId).HasColumnName("KAP_ID");

            Property(e => e.MalGrupId).HasColumnName("MAL_GRUP_ID");

            Property(e => e.MalId).HasColumnName("MAL_ID");

            Property(e => e.Muamele).HasColumnName("MUAMELE");

            Property(e => e.Navlun).HasColumnName("NAVLUN");

            Property(e => e.Prim).HasColumnName("PRIM");

            Property(e => e.PrimSahibiId).HasColumnName("PRIM_SAHIBI_ID");

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.YazihaneId).HasColumnName("YAZIHANE_ID");

            HasRequired(d => d.Ambar)
                .WithMany(p => p.ToambAmbarFiyatiAmbars)
                .HasForeignKey(d => d.AmbarId)
                .WillCascadeOnDelete(false);

            HasOptional(d => d.GeldigiYer)
                .WithMany(p => p.ToambAmbarFiyatiGeldigiYers)
                .HasForeignKey(d => d.GeldigiYerId);

            HasOptional(d => d.Gonderen)
                .WithMany(p => p.ToambAmbarFiyatiGonderens)
                .HasForeignKey(d => d.GonderenId);

            HasOptional(d => d.Kap)
                .WithMany(p => p.ToambAmbarFiyatis)
                .HasForeignKey(d => d.KapId);

            HasOptional(d => d.MalGrup)
                .WithMany(p => p.ToambAmbarFiyatiMalGrups)
                .HasForeignKey(d => d.MalGrupId);

            HasOptional(d => d.Mal)
                .WithMany(p => p.ToambAmbarFiyatis)
                .HasForeignKey(d => d.MalId);

            HasOptional(d => d.Yazihane)
                .WithMany(p => p.ToambAmbarFiyatiYazihanes)
                .HasForeignKey(d => d.YazihaneId);
        }
    }
}
