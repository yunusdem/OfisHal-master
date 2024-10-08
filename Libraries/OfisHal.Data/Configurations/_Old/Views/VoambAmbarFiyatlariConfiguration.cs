using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VoambAmbarFiyatlariConfiguration : EntityTypeConfiguration<VoambAmbarFiyatlari>
    {
        public VoambAmbarFiyatlariConfiguration()
        {
            //HasNoKey();

            ToTable("VOAMB_AMBAR_FIYATLARI");

            Property(e => e.Aciklama)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");

            Property(e => e.AmbarFiyatiId).HasColumnName("AMBAR_FIYATI_ID");

            Property(e => e.AmbarId).HasColumnName("AMBAR_ID");

            Property(e => e.AmbarPrimi).HasColumnName("AMBAR_PRIMI");

            Property(e => e.GeldigiYer)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("GELDIGI_YER");

            Property(e => e.GeldigiYerId).HasColumnName("GELDIGI_YER_ID");

            Property(e => e.Gonderen)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("GONDEREN");

            Property(e => e.GonderenId).HasColumnName("GONDEREN_ID");

            Property(e => e.Hammaliye).HasColumnName("HAMMALIYE");

            Property(e => e.HammaliyePrimi).HasColumnName("HAMMALIYE_PRIMI");

            Property(e => e.Kap)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("KAP");

            Property(e => e.KapId).HasColumnName("KAP_ID");

            Property(e => e.Mal)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAL");

            Property(e => e.MalGrubu)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("MAL_GRUBU");

            Property(e => e.MalGrupId).HasColumnName("MAL_GRUP_ID");

            Property(e => e.MalId).HasColumnName("MAL_ID");

            Property(e => e.Muamele).HasColumnName("MUAMELE");

            Property(e => e.Navlun).HasColumnName("NAVLUN");

            Property(e => e.Prim).HasColumnName("PRIM");

            Property(e => e.PrimSahibi)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("PRIM_SAHIBI");

            Property(e => e.PrimSahibiId).HasColumnName("PRIM_SAHIBI_ID");

            Property(e => e.PrimSahibiKodu)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PRIM_SAHIBI_KODU")
                .IsFixedLength();

            Property(e => e.SatirNo).HasColumnName("SATIR_NO");

            Property(e => e.Yazihane)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("YAZIHANE");

            Property(e => e.YazihaneId).HasColumnName("YAZIHANE_ID");
        }
    }
}
