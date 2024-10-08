using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Web.Models.Configurations
{
    internal class VohalOfisEdefterBaslikBilgileriConfiguration : EntityTypeConfiguration<VohalOfisEdefterBaslikBilgileri>
    {
        public VohalOfisEdefterBaslikBilgileriConfiguration()
        {
            //HasNoKey();

            ToTable("VOHAL_OFIS_EDEFTER_BASLIK_BILGILERI");

            Property(e => e.FirmaCadde)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FIRMA_CADDE");

            Property(e => e.FirmaEposta)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FIRMA_EPOSTA");

            Property(e => e.FirmaSokak)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FIRMA_SOKAK");

            Property(e => e.FirmaTelefon)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FIRMA_TELEFON");

            Property(e => e.FirmaUnvan)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("FIRMA_UNVAN");

            Property(e => e.FirmaVkn)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FIRMA_VKN")
                .IsFixedLength();

            Property(e => e.FirmaWebAdresi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FIRMA_WEB_ADRESI");
        }
    }
}
