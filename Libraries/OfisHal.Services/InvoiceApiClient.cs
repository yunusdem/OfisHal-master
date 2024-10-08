using Newtonsoft.Json;
using OfisHal.Data.Context;
using OfisHal.Services.IceSvc;
using RestSharp;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace OfisHal.Services
{
    public class InvoiceApiClient
    {
        private readonly Db _context;
        private readonly RestClient _client;

        public InvoiceApiClient(Db context)
        {
            _context = context;
            _client = new RestClient(WebConfigurationManager.AppSettings["App:ApiInvoiceUrl"]);
        }

        public Task<ApiResponse<string>> PreviewDespatchAdviceAsync(DespatchAdvice invoice) => ExecAsync<string>("DespatchAdvice", invoice, Method.PUT);

        public Task<ApiResponse<bool>> CreateDespatchAdviceAsync(DespatchAdvice invoice) => ExecAsync<bool>("DespatchAdvice", invoice, Method.POST);

        public Task<ApiResponse<string>> PreviewCreditNoteAsync(Invoice invoice) => ExecAsync<string>("CreditNote", invoice, Method.PUT);

        public Task<ApiResponse<bool>> CreateCreditNoteAsync(Invoice invoice) => ExecAsync<bool>("CreditNote", invoice, Method.POST);

        public Task<ApiResponse<string>> PreviewInvoiceAsync(Invoice invoice) => ExecAsync<string>("Invoice", invoice, Method.PUT);

        public Task<ApiResponse<bool>> CreateInvoiceAsync(Invoice invoice) => ExecAsync<bool>("Invoice", invoice, Method.POST);

        public async Task<ApiResponse<List<User>>> FindUserAsync(string identity, UserSearchDocumentType type)
        {
            var integratorInfo = await GetIntegratorInfo();

            var request = new RestRequest("FindUser", Method.GET, DataFormat.Json);
            request.AddHeader("Accept", MediaTypeNames.Text.Plain);

            request.AddQueryParameter(nameof(identity), identity);
            request.AddQueryParameter(nameof(type), type.ToString());
            request.AddQueryParameter("provider", integratorInfo.Provider.ToString());
            request.AddQueryParameter("userName", integratorInfo.UserName);
            request.AddQueryParameter("password", integratorInfo.Password);
            request.AddQueryParameter("appName", integratorInfo.AppName);
            request.AddQueryParameter("testMode", integratorInfo.TestMode.ToString());

            var res = await _client.ExecuteAsync<ApiResponse<List<string>>>(request);

            if (res.IsSuccessful && res.Data?.Result?.Count > 0)
            {
                return new ApiResponse<List<User>>
                {
                    ErrorMessage = res.Data?.ErrorMessage,
                    StatusCode = res.Data?.StatusCode ?? (int)res.StatusCode,
                    Success = res.Data?.Success ?? res.IsSuccessful,
                    Version = res.Data?.Version,
                    Result = JsonConvert.DeserializeObject<List<User>>(string.Concat(res?.Data?.Result.Select(x => x.Replace(@"\""", string.Empty).Trim('"'))))
                };
            }
            else
                return new ApiResponse<List<User>> { Success = false, ErrorMessage = res.ErrorMessage ?? res.ErrorException.Message, StatusCode = (int)res.StatusCode, Version = "1.0" };
        }

        private async Task<ApiResponse<T>> ExecAsync<T>(string endpoint, Invoice invoice, Method method)
        {
            var integratorInfo = await GetIntegratorInfo();

            var request = new RestRequest(endpoint, method, DataFormat.Json);
            request.AddHeader("Accept", MediaTypeNames.Text.Plain);
            _client.AddHandler(MediaTypeNames.Text.Plain, () => new RestSharp.Serializers.NewtonsoftJson.JsonNetSerializer());
            _client.AddHandler("application/json", () => new RestSharp.Serializers.NewtonsoftJson.JsonNetSerializer());

            invoice.UserName = integratorInfo.UserName;
            invoice.Password = integratorInfo.Password;
            invoice.TestMode = integratorInfo.TestMode;
            invoice.Provider = integratorInfo.Provider;
            invoice.AppName = integratorInfo.AppName;

            request.AddBody(invoice);
            var res = await _client.ExecuteAsync<ApiResponse<T>>(request);

            return res.Data;
        }

        private async Task<ApiResponse<T>> ExecAsync<T>(string endpoint, DespatchAdvice invoice, Method method)
        {
            var integratorInfo = await GetIntegratorInfo();

            var request = new RestRequest(endpoint, method, DataFormat.Json);
            request.AddHeader("Accept", MediaTypeNames.Text.Plain);
            _client.AddHandler(MediaTypeNames.Text.Plain, () => new RestSharp.Serializers.NewtonsoftJson.JsonNetSerializer());
            _client.AddHandler("application/json", () => new RestSharp.Serializers.NewtonsoftJson.JsonNetSerializer());

            invoice.UserName = integratorInfo.UserName;
            invoice.Password = integratorInfo.Password;
            invoice.TestMode = integratorInfo.TestMode;
            invoice.Provider = integratorInfo.Provider;
            invoice.AppName = integratorInfo.AppName;

            request.AddBody(invoice);
            var res = await _client.ExecuteAsync<ApiResponse<T>>(request);

            return res.Data;
        }

        private async Task<IntegratorInfo> GetIntegratorInfo()
        {
            var userInfo = await _context.TohalKullanicis.Select(x => new { x.EntegratorKullaniciAdi, x.EntegratorKullaniciSifresi, EntegratorProvider = (IntegratorProvider)(x.YaziciId ?? 0) }).FirstOrDefaultAsync();

            return new IntegratorInfo
            {
                Password = userInfo?.EntegratorKullaniciSifresi,
                UserName = userInfo?.EntegratorKullaniciAdi,
                AppName = "Hal",
                Provider = userInfo.EntegratorProvider,
                TestMode = false,
            };
        }
    }

    public class ApiResponse<T>
    {
        [JsonProperty("version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        [JsonProperty("success", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public bool Success { get; set; }

        [JsonProperty("statusCode", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public int StatusCode { get; set; }

        [JsonProperty("errorMessage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMessage { get; set; }

        [JsonProperty("result", Required = Required.AllowNull, NullValueHandling = NullValueHandling.Ignore)]
        public T Result { get; set; }
    }

    public class IntegratorInfo
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public string AppName { get; set; }

        public IntegratorProvider Provider { get; set; }

        public bool TestMode { get; set; } = false;
    }
}
