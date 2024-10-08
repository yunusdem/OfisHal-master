using Newtonsoft.Json;
using OfisHal.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Web.Mvc;

namespace OfisHal.Services.Reports
{
    public partial class ReportsClient 
    {
        private string _baseUrl = WebConfigurationManager.AppSettings["App:ApiReportUrl"];
        private readonly HttpClient _httpClient;
        private readonly Lazy<JsonSerializerSettings> _settings;

        public ReportsClient()
        {
            _httpClient = new HttpClient();
            _settings = new Lazy<JsonSerializerSettings>(CreateSerializerSettings);
        }

        public void SetDatabaseId(string databaseId)
        {
            if (_httpClient.DefaultRequestHeaders.TryGetValues("DId", out var _))
                _httpClient.DefaultRequestHeaders.Remove("DId");
            _httpClient.DefaultRequestHeaders.Add("DId", databaseId);
        }

        private JsonSerializerSettings CreateSerializerSettings()
        {
            var settings = new JsonSerializerSettings();
            UpdateJsonSerializerSettings(settings);
            return settings;
        }

        public string BaseUrl
        {
            get => _baseUrl;
            set => _baseUrl = value;
        }

        protected JsonSerializerSettings JsonSerializerSettings => _settings.Value;

        partial void UpdateJsonSerializerSettings(JsonSerializerSettings settings);

        partial void PrepareRequest(HttpClient client, HttpRequestMessage request, string url);

        partial void PrepareRequest(HttpClient client, HttpRequestMessage request, StringBuilder urlBuilder);

        partial void ProcessResponse(HttpClient client, HttpResponseMessage response);

        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual Task<ICollection<string>> GetAllAsync(bool? ownFile) => GetAllAsync(ownFile, CancellationToken.None);

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<ICollection<string>> GetAllAsync(bool? ownFile, CancellationToken cancellationToken)
        {
            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : string.Empty).Append("/?");
            if (ownFile != null)
            {
                urlBuilder_.Append(Uri.EscapeDataString("ownFile") + "=").Append(Uri.EscapeDataString(ConvertToString(ownFile, CultureInfo.InvariantCulture))).Append("&");
            }
            urlBuilder_.Length--;

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<ICollection<string>>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                                throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual Task<ReportParametersViewModel> GetAsync(string fileName, bool? ownFile) => GetAsync(fileName, ownFile, CancellationToken.None);

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<ReportParametersViewModel> GetAsync(string fileName, bool? ownFile, CancellationToken cancellationToken)
        {
            if (fileName == null)
                throw new ArgumentNullException("fileName");

            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : string.Empty).Append("/{fileName}?");
            urlBuilder_.Replace("{fileName}", Uri.EscapeDataString(ConvertToString(fileName, CultureInfo.InvariantCulture)));
            if (ownFile != null)
            {
                urlBuilder_.Append(Uri.EscapeDataString("ownFile") + "=").Append(Uri.EscapeDataString(ConvertToString(ownFile, CultureInfo.InvariantCulture))).Append("&");
            }
            urlBuilder_.Length--;

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    request_.Method = new HttpMethod("GET");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200)
                        {
                            var objectResponse_ = await ReadObjectResponseAsync<ReportParametersViewModel>(response_, headers_, cancellationToken).ConfigureAwait(false);
                            if (objectResponse_.Object == null)
                            {
                                throw new ApiException("Response was null which was not expected.", status_, objectResponse_.Text, headers_, null);
                            }
                            return objectResponse_.Object;
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual Task<FileResponse> PostAsync(string fileName, FormCollection form, bool? ownFile, bool? pdf) => PostAsync(fileName, form, ownFile, pdf, CancellationToken.None);

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public virtual async Task<FileResponse> PostAsync(string fileName, FormCollection form, bool? ownFile, bool? pdf, CancellationToken cancellationToken)
        {
            if (fileName == null)
                throw new ArgumentNullException("fileName");

            if (form == null)
                throw new ArgumentNullException("form");

            var urlBuilder_ = new StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : string.Empty).Append("/{fileName}?");
            urlBuilder_.Replace("{fileName}", Uri.EscapeDataString(ConvertToString(fileName, CultureInfo.InvariantCulture)));
            if (ownFile != null)
            {
                urlBuilder_.Append(Uri.EscapeDataString("ownFile") + "=").Append(Uri.EscapeDataString(ConvertToString(ownFile, CultureInfo.InvariantCulture))).Append("&");
			}
			if (pdf != null)
			{
				urlBuilder_.Append(Uri.EscapeDataString("pdf") + "=").Append(Uri.EscapeDataString(ConvertToString(pdf, CultureInfo.InvariantCulture))).Append("&");
			}
			urlBuilder_.Length--;

            var client_ = _httpClient;
            var disposeClient_ = false;
            try
            {
                using (var request_ = new HttpRequestMessage())
                {
                    var content_ = new FormUrlEncodedContent(form.AllKeys.ToDictionary(k => k.Replace("p.", string.Empty), v => form[v]));
                    //content_.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
                    request_.Content = content_;
                    request_.Method = new HttpMethod("POST");
                    request_.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("application/json"));

                    PrepareRequest(client_, request_, urlBuilder_);

                    var url_ = urlBuilder_.ToString();
                    request_.RequestUri = new Uri(url_, UriKind.RelativeOrAbsolute);

                    PrepareRequest(client_, request_, url_);

                    var response_ = await client_.SendAsync(request_, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);
                    var disposeResponse_ = true;
                    try
                    {
                        var headers_ = Enumerable.ToDictionary(response_.Headers, h_ => h_.Key, h_ => h_.Value);
                        if (response_.Content != null && response_.Content.Headers != null)
                        {
                            foreach (var item_ in response_.Content.Headers)
                                headers_[item_.Key] = item_.Value;
                        }

                        ProcessResponse(client_, response_);

                        var status_ = (int)response_.StatusCode;
                        if (status_ == 200 || status_ == 206)
                        {
                            var responseStream_ = response_.Content == null ? Stream.Null : await response_.Content.ReadAsStreamAsync().ConfigureAwait(false);
                            var fileResponse_ = new FileResponse(status_, headers_, responseStream_, null, response_);
                            disposeClient_ = false; disposeResponse_ = false; // response and client are disposed by FileResponse
                            return fileResponse_;
                        }
                        else
                        {
                            var responseData_ = response_.Content == null ? null : await response_.Content.ReadAsStringAsync().ConfigureAwait(false);
                            throw new ApiException("The HTTP status code of the response was not expected (" + status_ + ").", status_, responseData_, headers_, null);
                        }
                    }
                    finally
                    {
                        if (disposeResponse_)
                            response_.Dispose();
                    }
                }
            }
            finally
            {
                if (disposeClient_)
                    client_.Dispose();
            }
        }

        protected readonly struct ObjectResponseResult<T>
        {
            public ObjectResponseResult(T responseObject, string responseText)
            {
                Object = responseObject;
                Text = responseText;
            }

            public T Object { get; }

            public string Text { get; }
        }

        public bool ReadResponseAsString { get; set; }

        protected virtual async Task<ObjectResponseResult<T>> ReadObjectResponseAsync<T>(HttpResponseMessage response, IReadOnlyDictionary<string, IEnumerable<string>> headers, CancellationToken cancellationToken)
        {
            if (response == null || response.Content == null)
            {
                return new ObjectResponseResult<T>(default, string.Empty);
            }

            if (ReadResponseAsString)
            {
                var responseText = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                try
                {
                    var typedBody = JsonConvert.DeserializeObject<T>(responseText, JsonSerializerSettings);
                    return new ObjectResponseResult<T>(typedBody, responseText);
                }
                catch (JsonException exception)
                {
                    var message = "Could not deserialize the response body string as " + typeof(T).FullName + ".";
                    throw new ApiException(message, (int)response.StatusCode, responseText, headers, exception);
                }
            }
            else
            {
                try
                {
                    using (var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                    using (var streamReader = new StreamReader(responseStream))
                    using (var jsonTextReader = new JsonTextReader(streamReader))
                    {
                        var serializer = JsonSerializer.Create(JsonSerializerSettings);
                        var typedBody = serializer.Deserialize<T>(jsonTextReader);
                        return new ObjectResponseResult<T>(typedBody, string.Empty);
                    }
                }
                catch (JsonException exception)
                {
                    var message = "Could not deserialize the response body stream as " + typeof(T).FullName + ".";
                    throw new ApiException(message, (int)response.StatusCode, string.Empty, headers, exception);
                }
            }
        }

        private string ConvertToString(object value, CultureInfo cultureInfo)
        {
            if (value == null)
                return string.Empty;

            if (value is Enum)
            {
                var name = Enum.GetName(value.GetType(), value);
                if (name != null)
                {
                    var field = IntrospectionExtensions.GetTypeInfo(value.GetType()).GetDeclaredField(name);
                    if (field != null)
                    {
                        if (CustomAttributeExtensions.GetCustomAttribute(field, typeof(EnumMemberAttribute)) is EnumMemberAttribute attribute)
                            return attribute.Value ?? name;
                    }

                    var converted = Convert.ToString(Convert.ChangeType(value, Enum.GetUnderlyingType(value.GetType()), cultureInfo));
                    return converted ?? string.Empty;
                }
            }
            else if (value is bool) 
            {
                return Convert.ToString((bool)value, cultureInfo).ToLowerInvariant();
            }
            else if (value is byte[])
            {
                return Convert.ToBase64String((byte[]) value);
            }
            else if (value.GetType().IsArray)
            {
                var array = Enumerable.OfType<object>((Array) value);
                return string.Join(",", Enumerable.Select(array, o => ConvertToString(o, cultureInfo)));
            }

            var result = Convert.ToString(value, cultureInfo);
            return result ?? string.Empty;
        }
    }

    public class FileResponse : IDisposable
    {
        private readonly IDisposable _client;
        private readonly IDisposable _response;

        public int StatusCode { get; private set; }

        public IReadOnlyDictionary<string, IEnumerable<string>> Headers { get; private set; }

        public Stream Stream { get; private set; }

        public bool IsPartial => StatusCode == 206;

        public FileResponse(int statusCode, IReadOnlyDictionary<string, IEnumerable<string>> headers, Stream stream, IDisposable client, IDisposable response)
        {
            StatusCode = statusCode;
            Headers = headers;
            Stream = stream;
            _client = client;
            _response = response;
        }

        public void Dispose()
        {
            Stream.Dispose();
            _response?.Dispose();
            _client?.Dispose();
        }
    }

    public class ApiException : Exception
    {
        public int StatusCode { get; private set; }

        public string Response { get; private set; }

        public IReadOnlyDictionary<string, IEnumerable<string>> Headers { get; private set; }

        public ApiException(string message, int statusCode, string response, IReadOnlyDictionary<string, IEnumerable<string>> headers, Exception innerException)
            : base(message + "\n\nStatus: " + statusCode + "\nResponse: \n" + ((response == null) ? "(null)" : response.Substring(0, response.Length >= 512 ? 512 : response.Length)), innerException)
        {
            StatusCode = statusCode;
            Response = response;
            Headers = headers;
        }

        public override string ToString() => string.Format("HTTP Response: \n\n{0}\n\n{1}", Response, base.ToString());
    }

    public class ApiException<TResult> : ApiException
    {
        public TResult Result { get; private set; }

        public ApiException(string message, int statusCode, string response, IReadOnlyDictionary<string, IEnumerable<string>> headers, TResult result, Exception innerException) : base(message, statusCode, response, headers, innerException) => 
            Result = result;
    }
}
