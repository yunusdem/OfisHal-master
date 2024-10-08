using OfisHal.Core.Domain;
using OfisHal.Core.Extensions;
using OfisHal.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OfisHal.Services
{
    public interface IInvoiceService
    {
		/// <summary>
		/// xlst e göre seçili faturanın HTML çıktısı
		/// </summary>
		/// <param name="id">Fatura ID</param>
		/// <returns></returns>
		Task<string> PreviewXmlAsync(int id, bool ex = false, bool isDespatch = false);

        /// <summary>
        /// Seçilen faturaları entegrasyona gönder
        /// </summary>
        /// <param name="selectedIds">Fatura ID listesi</param>
        /// <param name="type">Belge türü</param>
        Task<List<Dictionary<string, string>>> SendSelectedAsync(List<int> selectedIds, bool isDespatch);

        /// <summary>
        /// Fatura kullanıcılarında listeleme
        /// </summary>
        /// <param name="identity">TC veya vergi Kimlik No'ya göre ara</param>
        /// <param name="isDespatch">False giderse efatura, true giderse eirsaliye kullanıcılarını arar</param>
        /// <param name="saveDb">Bulunan kullanıcıları yerel sistemde günceller</param>
        /// <returns></returns>
        Task<IEnumerable<TohalGibKullanici>> FindUserAsync(string identity, bool isDespatch = false, bool saveDb = false);
    }

    public class InvoiceService : IInvoiceService
    {
        private readonly Db _context;
        private readonly IDataServices _dataServices;
        private readonly InvoiceApiClient _client;

        public InvoiceService(Db context, IDataServices dataServices)
        {
            _context = context;
			_client = new InvoiceApiClient(_context);
            _dataServices = dataServices;
        }

		private async Task<Invoice> BuildInvoiceAsync(int id, string fileName = null, bool generateNewEttn = true)
		{
			var invoiceRec = await _context.VohalFaturas.FindAsync(id);
			var invoiceLines = await _context.VohalFaturaSatiriUrts.Where(x => x.FaturaId == id).ToListAsync();
			var tanim = await _context.TohalTanims.FirstOrDefaultAsync();
			var kullanici = await _context.VohalKullanicis.FirstOrDefaultAsync();
			var yerBilgi = _dataServices.YerGetir(tanim.DigYerId ?? 0);
			var imge = await _context.TohalImges.ToListAsync();

			if (invoiceRec == null)
				throw new ArgumentNullException(nameof(invoiceRec));

			if (tanim == null)
				throw new ArgumentNullException(nameof(tanim));

			if (yerBilgi == null)
				throw new ArgumentNullException(nameof(yerBilgi));

			if (invoiceLines.Count < 1)
				throw new ArgumentOutOfRangeException(nameof(invoiceLines));

			var pledgeLines = await _context.VohalRehinFisis.Where(x => x.FaturaId == id).Select(line => new Pledge
			{
				Brand = line.Marka.Trim(),
				ItemAmount = line.Fiyat,
				Name = line.KapAdi.Trim(),
				Quantity = line.KapMiktari,
				TotalAmount = line.Tutar,
			}).ToListAsync();

			var costLines = await _context.VohalEvrakMasrafis.OrderBy(x => x.SatirNo).Where(x => x.FaturaId == id).Select(line => new Cost
			{
				Code = line.HesapKodu,
				Name = line.HesapAdi,
				TaxAmount = line.Kdv,
				TaxAmountRate = line.KdvOrani,
				Amount = line.Masraf,
				AmountRate = line.KesintiOrani ?? 0
			}).ToListAsync();

			var itemLines = new List<InvoiceLine>();

			var taxExemptReason = string.Empty;
			var taxExemptReasonCode = string.Empty;

			var companyLogo = imge.FirstOrDefault(x => x.SahipTuru == 1)?.Imge;
			var companySign = imge.FirstOrDefault(x => x.SahipTuru == 2)?.Imge;

			invoiceLines.ForEach(line =>
			{
				var taxes = new List<Tax>();

				if (line.KdvOrani > 0)
					taxes.Add(new Tax { Amount = (line.Tutar - line.Iskonto) * (line.KdvOrani / 100), Index = taxes.Count, Rate = line.KdvOrani, Type = TaxType.KDV });
				else
					taxExemptReason = "Çiftçi malıdır";

				if (line.RusumOrani > 0)
					taxes.Add(new Tax { Amount = line.Rusum, Index = taxes.Count, Rate = line.RusumOrani, Type = TaxType.Rusum });
                //taxExemptReasonCode = "805";

                //taxes.Add(new Tax { Amount = (line.Tutar - line.Iskonto) * (2d / 100), Index = 1, Rate = 2, Type = TaxType.Konaklama });

                var lineItem = new InvoiceLine
				{
					Amount = line.Tutar,
					DiscountAmount = line.Iskonto,
					DiscountRate = line.IskontoOrani,
					HksId = line.MalHksId,
					Id = line.SatirNo,
					Index = line.SatirNo + 1,
					MustahsilAdiVkn = line.MustahsilAdiVkn?.Trim(),
					Name = line.MalAdi?.Trim(),
					NetAmount = line.Tutar - line.Iskonto,
					Note = string.Empty,
					Quantity = line.MalMiktari,
					SatisKunyesi = line.SatisKunyesi?.Trim(),
					UnitAmount = line.MalFiyati,
					UnitCode = line.MalBirimi?.Trim(),
					Taxes = taxes
				};

				itemLines.Add(lineItem);
			});

			var item = new Invoice
			{
				CustomerId = -1,
				FileName = fileName,
				IsArchive = !invoiceRec.GibMuhatapPostaKutusuId.HasValue,

				BankName = tanim.FirBankaAdi?.Trim(),
				Iban = tanim.FirIbanNo?.Trim(),
				Notes = new List<string>(),
				Id = invoiceRec.FaturaNo?.Trim(),
				Guid = invoiceRec.Guid?.Trim(),
				Uuid = generateNewEttn ? Guid.NewGuid().ToString() : invoiceRec.EFaturaEttn?.Trim(),
				DiscountAmount = invoiceRec.Iskonto,
				DiscountRate = invoiceRec.IskontoOrani,
				IssueDate = invoiceRec.Tarih.ToDatetimeOffsetFromUtc(),
				Scenario = (Scenario)(invoiceRec.EFaturaSenaryosu ?? 0),
				TaxExemptionReason = taxExemptReason,
				TaxExemptionReasonCode = taxExemptReasonCode,
				Type = invoiceRec.IadeFaturasi == true ? InvoiceType1.IADE : InvoiceType1.SATIS,

				CurrencyCode = CurrencyCode.TRY,

                PlateNo = invoiceRec.PlakaNo?.Trim(),

                ImageLogo = companyLogo?.Length > 0 ? Convert.ToBase64String(companyLogo) : string.Empty,
				ImageSignature = companySign?.Length > 0 ? Convert.ToBase64String(companySign) : string.Empty,

				From = new Company
				{
					City = yerBilgi.IlAdi,
					Country = yerBilgi.UlkeAdi,
					District = yerBilgi.IlceAdi,
					Alias = kullanici.EFaturaGondericiBirimi, //TODO: İrsaliye İse EIrsaliyeGondericiBirimi
                    MersisNo = tanim.FirMersisNo?.Trim(),
					Number = tanim.FirDaireNo?.Trim(),
					Name = tanim.DigFirmaAdi?.Trim(),
					Phone = tanim.DigTelefon?.Trim(),
					PostalCode = tanim.FirPostaKodu?.Trim(),
					Room = tanim.FirKapiNo?.Trim(),
					Street = tanim.DigAdres?.Trim(),
					TaxNumber = tanim.DigVergiKimlikNo?.Trim(),
					TaxOfficeId = Convert.ToString(tanim.DigVergiDairesiId),
                    //TaxOfficeName = "",
                    Email = tanim.DigEposta?.Trim(),
                    TicaretSicilNo = tanim.DigSicilKodu?.Trim(),
					Url = tanim.FirWebAdresi?.Trim()
				},
				To = new Company
				{
					City = invoiceRec.EFaturaIl?.Trim(),
					Country = invoiceRec.EFaturaUlke?.Trim(),
					District = invoiceRec.EFaturaIlce?.Trim(),
					Alias = invoiceRec.EFaturaEposta?.Trim(),
					MersisNo = string.Empty,
					Number = Convert.ToString(invoiceRec.EFaturaDaireNo),
					Name = invoiceRec.EFaturaMusteriAdi?.Trim(),
					Phone = invoiceRec.EFaturaTelefon?.Trim(),
					PostalCode = Convert.ToString(invoiceRec.EFaturaPostaKodu),
					Room = Convert.ToString(invoiceRec.EFaturaKapiNo),
					Street = invoiceRec.EFaturaMahalle?.Trim(),
					TaxNumber = invoiceRec.EFaturaVergiKimlikNo?.Trim(),
					//TaxOfficeId = "",
					TaxOfficeName = invoiceRec.EFaturaVergiDairesi?.Trim(),
					TicaretSicilNo = string.Empty,
					Url = invoiceRec.EFaturaWebAdresi?.Trim()
				},
				Lines = itemLines,
				Pledges = pledgeLines,
				Costs = costLines
			};

			if (!string.IsNullOrWhiteSpace(invoiceRec.EFaturaNot?.Trim()))
				item.Notes.Add(invoiceRec.EFaturaNot.Trim());

			return item;
		}

        private async Task<DespatchAdvice> BuildDespatchAdviceAsync(int id, string fileName = null, bool generateNewEttn = true)
        {
			var despatchAdviceRec = await _context.VohalEIrsaliyes.FirstOrDefaultAsync(x => x.FaturaId == id);

            if (despatchAdviceRec == null)
                throw new ArgumentNullException(nameof(despatchAdviceRec));

            var despatchAdviceLines = await _context.VohalEIrsaliyeSatiris.Where(x => x.DepoFisiId == despatchAdviceRec.DepoFisiId).ToListAsync();

            if (despatchAdviceLines.Count < 1)
                throw new ArgumentOutOfRangeException(nameof(despatchAdviceLines));

            var tanim = await _context.TohalTanims.FirstOrDefaultAsync();
            var kullanici = await _context.VohalKullanicis.FirstOrDefaultAsync();
            var yerBilgi = _dataServices.YerGetir(tanim.DigYerId ?? 0);
            var imge = await _context.TohalImges.ToListAsync();

            if (tanim == null)
                throw new ArgumentNullException(nameof(tanim));

            if (yerBilgi == null)
                throw new ArgumentNullException(nameof(yerBilgi));

            var itemLines = new List<DespatchAdviceLine>();

            var companyLogo = imge.FirstOrDefault(x => x.SahipTuru == 1)?.Imge;
            var companySign = imge.FirstOrDefault(x => x.SahipTuru == 2)?.Imge;

            despatchAdviceLines.ForEach(line =>
            {
                double.TryParse(line.DeliveredQuantity.Replace('.',','), out var qty);
                double.TryParse(line.Dara.Replace('.', ','), out var dara);
                double.TryParse(line.Darali.Replace('.', ','), out var darali);
                double.TryParse(line.Kap.Replace('.', ','), out var kap);

                var lineItem = new DespatchAdviceLine
				{
					Id = line.Id ?? 0,
					Index = line.LineNo ?? 0,
					Name = line.ItemName?.Trim(),
					Quantity = qty,
					UnitCode = line.DeliveredQuantityUnit?.Trim(),
					ItemCode = line.ItemCode?.Trim(),
					OrderLineId = Convert.ToString(line.OrderLineId),
					Dara = dara,
                    Darali = darali,
					Kap = kap
				};

                itemLines.Add(lineItem);
            });

			var item = new DespatchAdvice
			{
				CustomerId = -1,
				FileName = fileName,
				IsArchive = !despatchAdviceRec.GibMuhatapPostaKutusuId.HasValue,

				Notes = new List<string>(),
				Id = despatchAdviceRec.Id?.Trim(),
				Uuid = generateNewEttn ? Guid.NewGuid().ToString() : despatchAdviceRec.Uuid?.Trim(),
				IssueDate = despatchAdviceRec.IssueDate.ToDatetimeOffsetFromUtc(),
				ActualDespatchDate = despatchAdviceRec.ActualDespatchDate.ToDatetimeOffsetFromUtc(),
				ActualDespatchTime = despatchAdviceRec.ActualDespatchTime.ToDatetimeOffsetFromUtc(),
				Type = despatchAdviceRec.DespatchAdviceTypeCode,

				OrderId = despatchAdviceRec.FaturaId.ToString(),
				CurrencyCode = CurrencyCode.TRY,

				PlateNo = despatchAdviceRec.ShipmentLicensePlateId?.Trim(),

				ImageLogo = companyLogo?.Length > 0 ? Convert.ToBase64String(companyLogo) : string.Empty,
				ImageSignature = companySign?.Length > 0 ? Convert.ToBase64String(companySign) : string.Empty,

				From = new Company
				{
					City = yerBilgi.IlAdi?.Trim(),
					Country = yerBilgi.UlkeAdi?.Trim(),
					District = yerBilgi.IlceAdi?.Trim(),
					Alias = kullanici.EFaturaGondericiBirimi?.Trim(),
					MersisNo = tanim.FirMersisNo?.Trim(),
					Number = tanim.FirDaireNo?.Trim(),
					Name = tanim.DigFirmaAdi?.Trim(),
					Phone = tanim.DigTelefon?.Trim(),
					PostalCode = tanim.FirPostaKodu?.Trim(),
					Room = tanim.FirKapiNo?.Trim(),
					Street = tanim.DigAdres?.Trim(),
					TaxNumber = tanim.DigVergiKimlikNo?.Trim(),
					TaxOfficeId = Convert.ToString(tanim.DigVergiDairesiId),
					//TaxOfficeName = "",
					Email = tanim.DigEposta?.Trim(),
					TicaretSicilNo = tanim.DigSicilKodu?.Trim(),
					Url = tanim.FirWebAdresi?.Trim()
				},
				To = new Company
				{
					City = despatchAdviceRec.CustomerPartyCityName?.Trim(),
					Country = despatchAdviceRec.CustomerPartyCountryName?.Trim(),
					District = despatchAdviceRec.CustomerPartyCitySubdivisionName?.Trim(),
					Alias = despatchAdviceRec.AliciGibPostaKutusu?.Trim(),
					MersisNo = string.Empty,
					Number = Convert.ToString(despatchAdviceRec.CustomerPartyBuildingNumber),
					Name = despatchAdviceRec.CustomerPartyName?.Trim(),
					Phone = despatchAdviceRec.CustomerPartyTelephone?.Trim(),
					PostalCode = despatchAdviceRec.CustomerPartyPostalZone?.Trim(),
					Room = Convert.ToString(despatchAdviceRec.CustomerPartyApartmentNumber),
					Street = despatchAdviceRec.CustomerPartyStreetName?.Trim(),
					TaxNumber = despatchAdviceRec.CustomerPartyId?.Trim(),
					//TaxOfficeId = "",
					TaxOfficeName = despatchAdviceRec.CustomerPartyTaxScheme?.Trim(),
					TicaretSicilNo = string.Empty,
					Url = despatchAdviceRec.CustomerPartyWebsiteUri?.Trim()
				},
				Carrier = new Company
				{
					TaxNumber = tanim.DigVergiKimlikNo?.Trim()
				},
				Lines = itemLines
			};

            if (!string.IsNullOrWhiteSpace(despatchAdviceRec.Note?.Trim()))
                item.Notes.Add(despatchAdviceRec.Note.Trim());

            return item;
        }

		public async Task<string> PreviewXmlAsync(int id, bool ex = false, bool isDespatch = false)
		{
			var invoiceRec = _context.VohalFaturas.FirstOrDefault(x => x.FaturaId == id);

			if (invoiceRec == null)
				return string.Empty;

			var response = new ApiResponse<string> { Success = false, ErrorMessage = string.Empty };

			if (isDespatch)
            {
				var despatchAdvice = await BuildDespatchAdviceAsync(id);
                response = await _client.PreviewDespatchAdviceAsync(despatchAdvice);
            }
            else
            {
                var invoice = await BuildInvoiceAsync(id, ex ? "Invoice_ex.xslt" : string.Empty, false);

                if (invoiceRec.Tip == 0) // satış
                    response = await _client.PreviewCreditNoteAsync(invoice);
                else if (invoiceRec.Tip == 1) // alış
                    response = await _client.PreviewInvoiceAsync(invoice);
                else
                {
                    response.Success = false;
                    response.ErrorMessage = "Fatura tipi belirlenemedi";
                }
            }

            if (response == null)
				throw new ApplicationException("Fatura bilgisi alınamadı");
			else if (response.Success)
				return response.Result;
			else
			{
				if (response.ErrorMessage.IsLike("(Parameter '*')"))
				{
					foreach (Match m in Regex.Matches(response.ErrorMessage, @"'([A-Za-z0-9]*)"))
					{
						if (m.Success)
							throw new ArgumentNullException(m.Groups[1].Value);
					}
				}
				throw new ApplicationException(response.ErrorMessage);
			}
		}

        public async Task<List<Dictionary<string, string>>> SendSelectedAsync(List<int> selectedIds, bool isDespatch)
        {
            var resultMessage = new List<Dictionary<string, string>>();

            if (!selectedIds.Any())
            {
                resultMessage.Add(new Dictionary<string, string> { { "status", "error" }, { "message", "Beklenmedik bir hata oluştu" } });
                return resultMessage;
            }

            if (isDespatch)
            {
                var irsaliyeler = await _context.VohalEIrsaliyes.Where(x => selectedIds.Any(y => y == x.FaturaId)).ToListAsync();

                foreach (var despatchAdvice in irsaliyeler)
                {
                    var fatura = await _context.TohalFaturas.FindAsync(despatchAdvice.FaturaId);

                    if (fatura == null)
						continue;

                    // kullanıcıyı GIB'den tc/vkn ile kontrol et, eğer GIB'de varsa bizim sisteme ekle/güncelle
                    var users = await FindUserAsync(despatchAdvice.BuyerCustomerPartyId, true, false);

                    var invoice = await BuildDespatchAdviceAsync(despatchAdvice.FaturaId, null, true);

                    var result = await _client.CreateDespatchAdviceAsync(invoice);

                    if (result.Success)
                    {
                        fatura.EIrsaliyeDurumu = 1;
                        fatura.EIrsaliyeEttn = invoice.Uuid;
                        fatura.EIrsaliyeHataAciklamasi = null;

                        resultMessage.Add(new Dictionary<string, string> { { "status", "success" }, { "message", "Başarılı" } });
                    }
                    else
                    {
                        fatura.EIrsaliyeDurumu = 2;
                        fatura.EIrsaliyeEttn = null;
                        fatura.EIrsaliyeHataAciklamasi = result.ErrorMessage.Truncate(199);

                        resultMessage.Add(new Dictionary<string, string> { { "status", "error" }, { "message", result.ErrorMessage } });
                    }

                    _context.Entry(fatura).State = EntityState.Modified;
                }
            }
            else
			{
				var faturalar = await _context.TohalFaturas.Where(x => selectedIds.Any(y => y == x.FaturaId)).ToListAsync();

				foreach (var invoiceRec in faturalar)
				{
                    // kullanıcıyı GIB'den tc/vkn ile kontrol et, eğer GIB'de varsa bizim sisteme ekle/güncelle
                    var users = await FindUserAsync(invoiceRec.VergiKimlikNo, false, false);

                    var invoice = await BuildInvoiceAsync(invoiceRec.FaturaId, null, true);

					var result = new ApiResponse<bool> { Success = false, ErrorMessage = string.Empty };

					if (invoiceRec.Tip == 0)
					{
						if (invoice.IsArchive && !invoice.Costs.Any(x => x.Code.StartsWith("STOP")) && invoiceRec.KisilikTipi != 2)
						{
							result.Success = false;
							result.ErrorMessage = "Stopaj değeri gereklidir";
						}
						else
							result = await _client.CreateCreditNoteAsync(invoice);
					}
					else if (invoiceRec.Tip == 1)
						result = await _client.CreateInvoiceAsync(invoice);
					else
					{
						result.Success = false;
                        result.ErrorMessage = "Fatura tipi belirlenemedi";
                    }

                    if (result.Success)
					{
						invoiceRec.EFaturaDurumu = 1;
                        invoiceRec.EFaturaEttn = invoice.Uuid;
						invoiceRec.EFaturaHataAciklamasi = null;

						resultMessage.Add(new Dictionary<string, string> { { "status", "success" }, { "message", "Başarılı" } });
					}
                    else
					{
						invoiceRec.EFaturaDurumu = 2;
						invoiceRec.EFaturaEttn = null;
						invoiceRec.EFaturaHataAciklamasi = result.ErrorMessage.Truncate(199);

                        resultMessage.Add(new Dictionary<string, string> { { "status", "error" }, { "message", result.ErrorMessage } });
					}

					_context.Entry(invoiceRec).State = EntityState.Modified;
				}
			}

			await _context.SaveChangesAsync();
			return resultMessage;
		}

        /// <summary>
        /// Ön planda (dbcontext injectiondan geliyor) çalışacak kullanıcı bulma ve isteniyorsa veritabanına kayıt metodu
        /// </summary>
        /// <param name="identity">TC veya VKN ile arama yapar</param>
        /// <param name="isDespatch">true gelirse irsaliye kullanıcısı olarak false gelirse efatura kullanıcısı olarak arar</param>
        /// <param name="saveDb">true gelirse bulunan sonuçları veritabanına kaydeder/günceller</param>
        /// <returns>GIB'den gelen sonuçları TohalGibKullanici tipinde liste olarak bilgileri geri döner</returns>
        public async Task<IEnumerable<TohalGibKullanici>> FindUserAsync(string identity, bool isDespatch = false, bool saveDb = false)
        {
            var result = Enumerable.Empty<TohalGibKullanici>();

            if (!string.IsNullOrWhiteSpace(identity))
            {
				var response = await _client.FindUserAsync(identity, isDespatch ? UserSearchDocumentType.DESPATCHADVICE : UserSearchDocumentType.INVOICE);

                if (response.Success)
                {
                    var users = response.Result;

					if (users.Any())
					{
						result = users.Select(x => new TohalGibKullanici
						{
							KayitZamani = Convert.ToDateTime(x.CreationTime),
							PostaKutusu = x.Alias,
							Silindi = false,
							Unvan = x.Title,
							Vkn = x.Identifier,
							KayitSekli = 0, //(byte)(x.AccountType == "OZELENTEGRASYON" ? 1 : 0)
							PkTipi = (byte)(x.Unit == "PK" ? 1 : 0),
							Tip = (byte)(x.AccountType == "OZEL" ? 1 : 0),
							DokumanTipi = (byte)(isDespatch ? 1 : 0)
						});

						if (saveDb)
						{
							foreach (var user in result)
							{
								var localUser = await _context.TohalGibKullanicis.FirstOrDefaultAsync(x => x.PostaKutusu == user.PostaKutusu & x.DokumanTipi == user.DokumanTipi);

								if (localUser != null)
								{
									localUser.KayitZamani = user.KayitZamani;
									localUser.PostaKutusu = user.PostaKutusu;
									localUser.Unvan = user.Unvan;
									localUser.Vkn = user.Vkn;
									_context.Entry(localUser).State = EntityState.Modified;
								}
								else
									_context.TohalGibKullanicis.Add(user);

								//var cariUser = context.TohalCariKarts.FirstOrDefault(x => x.VergiKimlikNo == user.Vkn);
								//if(cariUser != null)
								//{
								//    var pkutu = localUser != null ? localUser : user;
								//    if(!isDespatch)
								//        cariUser.GibEFaturaPostaKutusuId = pkutu.GibKullaniciId;
								//    else
								//        cariUser.EIrsaliyePostaKutusuId = pkutu.GibKullaniciId;

								//    context.Entry(cariUser).State = EntityState.Modified;
								//}
							}

							await _context.SaveChangesAsync();
						}

						return result;
					}
				}
            }

            return result;
        }
	}
}
