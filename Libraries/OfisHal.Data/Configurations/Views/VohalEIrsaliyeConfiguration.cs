using OfisHal.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace OfisHal.Data.Configurations
{
    internal class VohalEIrsaliyeConfiguration : EntityTypeConfiguration<VohalEIrsaliye>
    {
        public VohalEIrsaliyeConfiguration()
        {
            //HasNoKey();

            HasKey(e=> e.DepoFisiId);

            ToTable("VOHAL_E_IRSALIYE");

            Property(e => e.ActualDespatchDate).HasColumnType("datetime");

            Property(e => e.ActualDespatchTime).HasColumnType("datetime");

            Property(e => e.AliciGibPostaKutusu)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("ALICI_GIB_POSTA_KUTUSU");

            Property(e => e.BuyerCustomerPartyAdresId).HasColumnName("BuyerCustomerParty_AdresId");

            Property(e => e.BuyerCustomerPartyApartmentNumber).HasColumnName("BuyerCustomerParty_ApartmentNumber");

            Property(e => e.BuyerCustomerPartyBuildingName).HasColumnName("BuyerCustomerParty_BuildingName");

            Property(e => e.BuyerCustomerPartyBuildingNumber).HasColumnName("BuyerCustomerParty_BuildingNumber");

            Property(e => e.BuyerCustomerPartyCityName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BuyerCustomerParty_CityName");

            Property(e => e.BuyerCustomerPartyCitySubdivisionName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BuyerCustomerParty_CitySubdivisionName");

            Property(e => e.BuyerCustomerPartyCountryName)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BuyerCustomerParty_CountryName");

            Property(e => e.BuyerCustomerPartyDistrict).HasColumnName("BuyerCustomerParty_District");

            Property(e => e.BuyerCustomerPartyElectronicMail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BuyerCustomerParty_ElectronicMail");

            Property(e => e.BuyerCustomerPartyId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BuyerCustomerParty_ID");

            Property(e => e.BuyerCustomerPartyName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BuyerCustomerParty_Name");

            Property(e => e.BuyerCustomerPartyPostalZone)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BuyerCustomerParty_PostalZone");

            Property(e => e.BuyerCustomerPartyRegion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BuyerCustomerParty_Region");

            Property(e => e.BuyerCustomerPartyRoom).HasColumnName("BuyerCustomerParty_Room");

            Property(e => e.BuyerCustomerPartyStreetName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BuyerCustomerParty_StreetName");

            Property(e => e.BuyerCustomerPartyTaxScheme)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("BuyerCustomerParty_TaxScheme");

            Property(e => e.BuyerCustomerPartyTelefax)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BuyerCustomerParty_Telefax");

            Property(e => e.BuyerCustomerPartyTelephone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BuyerCustomerParty_Telephone");

            Property(e => e.BuyerCustomerPartyWebsiteUri)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("BuyerCustomerParty_WebsiteURI");

            Property(e => e.CurrencyCode)
                .IsRequired()
                .HasMaxLength(3)
                .IsUnicode(false);

            Property(e => e.CustomerPartyAdresId).HasColumnName("CustomerParty_AdresId");

            Property(e => e.CustomerPartyApartmentNumber).HasColumnName("CustomerParty_ApartmentNumber");

            Property(e => e.CustomerPartyBuildingName).HasColumnName("CustomerParty_BuildingName");

            Property(e => e.CustomerPartyBuildingNumber).HasColumnName("CustomerParty_BuildingNumber");

            Property(e => e.CustomerPartyCityName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CustomerParty_CityName");

            Property(e => e.CustomerPartyCitySubdivisionName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CustomerParty_CitySubdivisionName");

            Property(e => e.CustomerPartyCountryName)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CustomerParty_CountryName");

            Property(e => e.CustomerPartyDistrict).HasColumnName("CustomerParty_District");

            Property(e => e.CustomerPartyElectronicMail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CustomerParty_ElectronicMail");

            Property(e => e.CustomerPartyId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CustomerParty_ID");

            Property(e => e.CustomerPartyName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CustomerParty_Name");

            Property(e => e.CustomerPartyPartyIdentification)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CustomerParty_PartyIdentification");

            Property(e => e.CustomerPartyPostalZone)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CustomerParty_PostalZone");

            Property(e => e.CustomerPartyRegion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CustomerParty_Region");

            Property(e => e.CustomerPartyRoom).HasColumnName("CustomerParty_Room");

            Property(e => e.CustomerPartyStreetName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CustomerParty_StreetName");

            Property(e => e.CustomerPartyTaxScheme)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CustomerParty_TaxScheme");

            Property(e => e.CustomerPartyTelefax)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CustomerParty_Telefax");

            Property(e => e.CustomerPartyTelephone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CustomerParty_Telephone");

            Property(e => e.CustomerPartyWebsiteUri)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CustomerParty_WebsiteURI");

            Property(e => e.DepoFisiId).HasColumnName("DEPO_FISI_ID");

            Property(e => e.DespatchAdviceTypeCode)
                .IsRequired()
                .HasMaxLength(4)
                .IsUnicode(false);

            Property(e => e.FaturaId).HasColumnName("FATURA_ID");

            Property(e => e.GibMuhatapPostaKutusuId).HasColumnName("GIB_MUHATAP_POSTA_KUTUSU_ID");

            Property(e => e.GondericiGibPostaKutusu)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("GONDERICI_GIB_POSTA_KUTUSU");

            Property(e => e.Id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ID")
                .IsFixedLength();

            Property(e => e.Irsaliyekodlist)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("IRSALIYEKODLIST");

            Property(e => e.IssueDate).HasColumnType("datetime");

            Property(e => e.IssueTime).HasColumnType("datetime");

            Property(e => e.Note)
                .HasMaxLength(1024)
                .IsUnicode(false);

            Property(e => e.PaperId).HasColumnName("PaperID");

            Property(e => e.RecipientId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RecipientID");

            Property(e => e.SellerSupplierPartyAdresId).HasColumnName("SellerSupplierParty_AdresId");

            Property(e => e.SellerSupplierPartyApartmentNumber).HasColumnName("SellerSupplierParty_ApartmentNumber");

            Property(e => e.SellerSupplierPartyBuildingName).HasColumnName("SellerSupplierParty_BuildingName");

            Property(e => e.SellerSupplierPartyBuildingNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SellerSupplierParty_BuildingNumber")
                .IsFixedLength();

            Property(e => e.SellerSupplierPartyCityName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SellerSupplierParty_CityName");

            Property(e => e.SellerSupplierPartyCitySubdivisionName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SellerSupplierParty_CitySubdivisionName");

            Property(e => e.SellerSupplierPartyCountryName)
                .IsRequired()
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("SellerSupplierParty_CountryName");

            Property(e => e.SellerSupplierPartyDistrict)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SellerSupplierParty_District");

            Property(e => e.SellerSupplierPartyElectronicMail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SellerSupplierParty_ElectronicMail");

            Property(e => e.SellerSupplierPartyId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SellerSupplierParty_ID");

            Property(e => e.SellerSupplierPartyName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SellerSupplierParty_Name");

            Property(e => e.SellerSupplierPartyPostalZone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SellerSupplierParty_PostalZone")
                .IsFixedLength();

            Property(e => e.SellerSupplierPartyRegion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SellerSupplierParty_Region");

            Property(e => e.SellerSupplierPartyRoom)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SellerSupplierParty_Room")
                .IsFixedLength();

            Property(e => e.SellerSupplierPartyStreetName)
                .IsRequired()
                .HasMaxLength(303)
                .IsUnicode(false)
                .HasColumnName("SellerSupplierParty_StreetName");

            Property(e => e.SellerSupplierPartyTaxScheme)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SellerSupplierParty_TaxScheme");

            Property(e => e.SellerSupplierPartyTelefax).HasColumnName("SellerSupplierParty_Telefax");

            Property(e => e.SellerSupplierPartyTelephone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SellerSupplierParty_Telephone");

            Property(e => e.SellerSupplierPartyWebsiteUri)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SellerSupplierParty_WebsiteURI");

            Property(e => e.ShipmentAdresId).HasColumnName("Shipment_AdresId");

            Property(e => e.ShipmentBuildingName).HasColumnName("Shipment_BuildingName");

            Property(e => e.ShipmentBuildingNumber).HasColumnName("Shipment_BuildingNumber");

            Property(e => e.ShipmentCarrierId).HasColumnName("Shipment_CarrierID");

            Property(e => e.ShipmentCarrierName).HasColumnName("Shipment_CarrierName");

            Property(e => e.ShipmentCityName).HasColumnName("Shipment_CityName");

            Property(e => e.ShipmentCitySubdivisionName).HasColumnName("Shipment_CitySubdivisionName");

            Property(e => e.ShipmentCountryName).HasColumnName("Shipment_CountryName");

            Property(e => e.ShipmentDistrict).HasColumnName("Shipment_District");

            Property(e => e.ShipmentLicensePlateId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Shipment_LicensePlateID")
                .IsFixedLength();

            Property(e => e.ShipmentPostalZone).HasColumnName("Shipment_PostalZone");

            Property(e => e.ShipmentRegion).HasColumnName("Shipment_Region");

            Property(e => e.ShipmentRoom).HasColumnName("Shipment_Room");

            Property(e => e.ShipmentStreetName).HasColumnName("Shipment_StreetName");

            Property(e => e.ShipmentValueAmount).HasColumnName("Shipment_ValueAmount");

            Property(e => e.SignatureAdresId).HasColumnName("Signature_AdresId");

            Property(e => e.SignatureBuildingName).HasColumnName("Signature_BuildingName");

            Property(e => e.SignatureBuildingNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Signature_BuildingNumber")
                .IsFixedLength();

            Property(e => e.SignatureCityName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("Signature_CityName");

            Property(e => e.SignatureCitySubdivisionName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("Signature_CitySubdivisionName");

            Property(e => e.SignatureCountryName)
                .IsRequired()
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("Signature_CountryName");

            Property(e => e.SignatureDistrict)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Signature_District");

            Property(e => e.SignatureId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Signature_ID");

            Property(e => e.SignaturePostalZone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Signature_PostalZone")
                .IsFixedLength();

            Property(e => e.SignatureRegion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("Signature_Region");

            Property(e => e.SignatureRoom)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Signature_Room")
                .IsFixedLength();

            Property(e => e.SignatureStreetName)
                .IsRequired()
                .HasMaxLength(303)
                .IsUnicode(false)
                .HasColumnName("Signature_StreetName");

            Property(e => e.SignatureWebsiteUri)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Signature_WebsiteURI");

            Property(e => e.SupplierPartyContactName).HasColumnName("SupplierParty_ContactName");

            Property(e => e.SupplierPartyElectronicMail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SupplierParty_ElectronicMail");

            Property(e => e.SupplierPartyName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SupplierParty_Name");

            Property(e => e.SupplierPartyPartyIdentification)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SupplierParty_PartyIdentification")
                .IsFixedLength();

            Property(e => e.SupplierPartyTaxScheme)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SupplierParty_TaxScheme");

            Property(e => e.SupplierPartyTelefax).HasColumnName("SupplierParty_Telefax");

            Property(e => e.SupplierPartyTelephone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SupplierParty_Telephone");

            Property(e => e.SupplierPhysicalLocationAdresId).HasColumnName("SupplierPhysicalLocation_AdresId");

            Property(e => e.SupplierPhysicalLocationBuildingName).HasColumnName("SupplierPhysicalLocation_BuildingName");

            Property(e => e.SupplierPhysicalLocationBuildingNumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SupplierPhysicalLocation_BuildingNumber")
                .IsFixedLength();

            Property(e => e.SupplierPhysicalLocationCityName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SupplierPhysicalLocation_CityName");

            Property(e => e.SupplierPhysicalLocationCitySubdivisionName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SupplierPhysicalLocation_CitySubdivisionName");

            Property(e => e.SupplierPhysicalLocationCountryName)
                .IsRequired()
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("SupplierPhysicalLocation_CountryName");

            Property(e => e.SupplierPhysicalLocationDistrict)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SupplierPhysicalLocation_District");

            Property(e => e.SupplierPhysicalLocationId)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SupplierPhysicalLocation_ID");

            Property(e => e.SupplierPhysicalLocationPostalZone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SupplierPhysicalLocation_PostalZone")
                .IsFixedLength();

            Property(e => e.SupplierPhysicalLocationRegion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("SupplierPhysicalLocation_Region");

            Property(e => e.SupplierPhysicalLocationRoom)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SupplierPhysicalLocation_Room")
                .IsFixedLength();

            Property(e => e.SupplierPhysicalLocationStreetName)
                .IsRequired()
                .HasMaxLength(303)
                .IsUnicode(false)
                .HasColumnName("SupplierPhysicalLocation_StreetName");

            Property(e => e.ToplamDara)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("TOPLAM_DARA");

            Property(e => e.ToplamDarali)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("TOPLAM_DARALI");

            Property(e => e.ToplamKap).HasColumnName("TOPLAM_KAP");

            Property(e => e.ToplamMiktar)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("TOPLAM_MIKTAR");

            Property(e => e.Uuid)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("UUID");
        }
    }
}
