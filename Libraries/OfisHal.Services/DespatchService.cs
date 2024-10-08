using OfisHal.UBL.Despatch;
using OfisHal.Web.Models;
using System;
using System.Linq;

namespace OfisHal.Web.Services
{
    public class DespatchService
    {
        private readonly Db _context;

        public DespatchService(Db context) => 
            _context = context;

        public DespatchAdviceType d(VohalEIrsaliye despatchRec, TohalTanim tanim)
        {
            #region Tanımlar
            //string hazirlayanVKNTCKN = "4690567186";
            string _satici_unvan = "";
            string _alici_unvan = "";

            var lines = _context.VohalEIrsaliyeSatiris.Where(x => x.DepoFisiId == despatchRec.DepoFisiId).ToList();
            var linesCount = lines.Count();

            var prefix = string.IsNullOrWhiteSpace(tanim.EIrsaliyeOnEki) ? "EAI2019" : tanim.EIrsaliyeOnEki;
            var id = string.Concat(prefix, despatchRec.DepoFisiId.ToString()/*.PadLeft(16 - prefix.Length, '0')*/);
            #endregion

            #region FaturaBaslikBilgileri
            var _despectAdvice = new DespatchAdviceType
            {
                UBLVersionID = new() { Value = "2.1" },
                CustomizationID = new() { Value = "TR1.2.1" },
                ProfileID = new() { Value = "TEMELIRSALIYE" },
                DespatchAdviceTypeCode = new() { Value = despatchRec.DespatchAdviceTypeCode }, // SEVK sabiti
                CopyIndicator = new() { Value = false },
                ID = new() { Value = id },
                UUID = new() { Value = string.Empty }, // belli değil
                IssueDate = new() { Value = despatchRec.IssueDate },
                IssueTime = new() { Value = despatchRec.IssueTime },
                LineCountNumeric = new() { Value = 1 },
                Note = new NoteType[] { new() { Value = despatchRec.Note } },
                //UBLExtensions = new UBLExtensionType[] { new() { ExtensionContent = null } }
            };
            #endregion

            #region XSLT
            _despectAdvice.AdditionalDocumentReference = new DocumentReferenceType[]
            {
                new()
                {
                    ID = new() { Value = id },
                    IssueDate = new() { Value = despatchRec.IssueDate },
                    DocumentType = new() { Value = "XSLT" },
                    Attachment = new()
                    {
                        EmbeddedDocumentBinaryObject = new()
                        {
                            characterSetCode = "UTF-8",
                            encodingCode = "Base64",
                            filename = "",
                            mimeCode = "application/xml"
                        }
                    }
                }
            };
            #endregion

            #region Shipment
            _despectAdvice.Shipment = new()
            {
                ID = new() { Value = "" },
                GoodsItem = new GoodsItemType[1]
                {
                    new ()  {ValueAmount= new() { currencyID = despatchRec.CurrencyCode ,Value=Convert.ToDecimal(despatchRec.ShipmentValueAmount?.ToString ("0.00"))}}
                },
                ShipmentStage = new ShipmentStageType[1]
                {
                    new ()
                    {
                        TransportMeans= new () {RoadTransport= new () { LicensePlateID= new () {schemeID="PLAKA",Value=despatchRec.ShipmentLicensePlateId } }  },
                    }
                },
                Delivery = new()
                {
                    CarrierParty = new()
                    {
                        PartyIdentification = new PartyIdentificationType[1]
                        {
                            new () {  ID = new () {schemeID=( Tasiyici_vkn.ToString().Length==10? "VKN":"TCKN"),Value=Tasiyici_vkn } }
                        },
                        PartyName = new() { Name = new() { Value = Convert.ToString(despatchRec.ShipmentCarrierName) } },
                        PostalAddress = new()
                        {
                            CityName = new() { Value = Convert.ToString(despatchRec.ShipmentCityName) },
                            StreetName = new() { Value = Convert.ToString(despatchRec.ShipmentStreetName) },
                            Country = new() { Name = new() { Value = Convert.ToString(despatchRec.ShipmentCountryName) } },
                            Room = new() { Value = Convert.ToString(despatchRec.ShipmentRoom) },
                            BuildingNumber = new() { Value = Convert.ToString(despatchRec.ShipmentBuildingNumber) },
                            CitySubdivisionName = new() { Value = Convert.ToString(despatchRec.ShipmentCitySubdivisionName) },
                        },
                    },
                    Despatch = new()
                    {
                        ActualDespatchDate = new() { Value = despatchRec.ActualDespatchDate },
                        ActualDespatchTime = new() { Value = despatchRec.ActualDespatchDate }
                    },
                    DeliveryAddress = new()
                    {
                        Country = new() { Name = new() { Value = alici.Adres.Ulke } },
                        CityName = new() { Value = alici.Adres.Sehir },
                        CitySubdivisionName = new() { Value = alici.Adres.Ilce },
                        StreetName = new() { Value = alici.Adres.Cadde },
                        Room = new() { Value = alici.Adres.KapiNo },
                        BuildingName = new() { Value = alici.Adres.BinaAdi },
                        BuildingNumber = new() { Value = alici.Adres.BinaNo },
                        Postbox = new() { Value = alici.Adres.PostaKodu },
                        ID = new() { Value = "" }
                    }
                },
            };
            #endregion

            despatchRec.SupplierPartyName;
            despatchRec.SellerSupplierPartyName;

            despatchRec.CustomerPartyName;
            despatchRec.BuyerCustomerPartyName;

            despatchRec.ShipmentCityName;

            #region Gönderici
            _despectAdvice.DespatchSupplierParty = new()
            {
                Party = new()
                {
                    Contact = new()
                    {
                        ElectronicMail = new() { Value = despatchRec.SupplierPartyElectronicMail },
                        Telephone = new() { Value = despatchRec.SupplierPartyTelephone }
                    },
                    PartyName = new() { Name = new() { Value = _satici_unvan } },
                    PartyIdentification = new PartyIdentificationType[3]
                    {
                        new () { ID = new () { Value = satici.VKNTCKN, schemeID = (satici.VKNTCKN.Length==11?"TCKN": "VKN") } }
                        ,new () { ID = new () { Value = satici.Ticaret_sicil_no, schemeID ="TICARETSICILNO" } }
                        ,new () { ID = new () { Value = satici.Mersis_no, schemeID ="MERSISNO" } }
                    },
                    PartyTaxScheme = new() { TaxScheme = new() { Name = new() { Value = satici.VergiDairesi } } },
                    PostalAddress = new()
                    {
                        CityName = new() { Value = satici.Adres.Sehir },
                        StreetName = new() { Value = satici.Adres.Cadde },
                        Country = new() { Name = new() { Value = satici.Adres.Ulke } },
                        //Room = new RoomType { Value = "" },
                        //BuildingNumber = new BuildingNumberType { Value = "" },
                        CitySubdivisionName = new() { Value = satici.Adres.Ilce }
                    },
                },
            };
            #endregion

            #region Alıcı
            if (alici.Unvan != null && alici.Unvan?.Replace("  ", "").Replace(".", "").Trim().Length > 0)
                _alici_unvan = alici.Unvan?.Replace("  ", "").Replace(".", "").Trim();
            else
                _alici_unvan = alici.Ad?.Replace("  ", "") + " " + alici.Soyad?.Replace("  ", "");
            
            _despectAdvice.DeliveryCustomerParty = new()  //malları teslim alan taraf
            {
                Party = new()
                {
                    PartyName = new() { Name = new() { Value = _alici_unvan } },
                    PartyIdentification = new PartyIdentificationType[1]
                    {
                        new () { ID = new () { Value = alici.VKNTCKN, schemeID = (alici.VKNTCKN.Length==11?"TCKN": "VKN") } }
                    },
                    PartyTaxScheme = new() { TaxScheme = new() { Name = new() { Value = alici.VergiDairesi } } },
                    WebsiteURI = new() { Value = alici.WebSitesi },
                    PostalAddress = new()
                    {
                        Country = new() { Name = new() { Value = alici.Adres.Ulke } },
                        CityName = new() { Value = alici.Adres.Sehir },
                        CitySubdivisionName = new() { Value = alici.Adres.Ilce },
                        StreetName = new() { Value = alici.Adres.Cadde },
                        Room = new() { Value = alici.Adres.KapiNo },
                        BuildingName = new() { Value = alici.Adres.BinaAdi },
                        BuildingNumber = new() { Value = alici.Adres.BinaNo },
                        Postbox = new() { Value = alici.Adres.PostaKodu },
                        ID = new() { Value = alici.Adres.KapiNo }
                    },
                }
            };
            #endregion

            #region Satırlar
            _despectAdvice.DespatchLine = new DespatchLineType[linesCount];

            for (var i = 0; i < linesCount; i++)
            {
                var item = lines.ElementAtOrDefault(i);

                _despectAdvice.DespatchLine[i] = new()
                {
                    ID = new() { Value = Convert.ToString(item.Id) },
                    DeliveredQuantity = new() { unitCode = item.DeliveredQuantityUnit, Value = Convert.ToDecimal(Convert.ToDouble(item.DeliveredQuantity).ToString("0.00")) },
                    Item = new()
                    {
                        Name = new() { Value = item.ItemName },
                        SellersItemIdentification = new() { ID = new() { Value = item.ItemCode } }
                    },
                    OrderLineReference = new() { LineID = new() { Value = Convert.ToString(item.OrderLineId) } },
                    Shipment = new ShipmentType[1]
                    {
                      new ()
                        {
                            ID = new () {Value=""},
                            GoodsItem= new GoodsItemType[1]
                            {
                                new ()
                                {
                                    InvoiceLine= new InvoiceLineType[1]
                                   {
                                       new ()
                                       {
                                           ID= new () {Value="" },
                                           InvoicedQuantity= new () { Value=Convert.ToDecimal(Convert.ToDecimal(item.DeliveredQuantity).ToString("0.00")) },
                                           LineExtensionAmount= new () { currencyID=item.CurrencyCode, Value = Convert.ToDecimal(item.RowAmount?.ToString("0.00")) },
                                           Item = new ()
                                            {
                                                Name = new () { Value = item.ItemName },
                                                SellersItemIdentification = new () { ID = new () { Value = item.ItemCode } }
                                            },
                                           //Price= new () { PriceAmount =new () { currencyID=item.CurrencyCode, Value = Convert.ToDecimal(Convert.ToDecimal(irsaliyeSatirlari[i].birimFiyat.ToString("0.00"))) } }
                                       }
                                   }
                                }
                            }
                        }
                    }
                };
            }
            #endregion

            return _despectAdvice;
        }
    }
}
