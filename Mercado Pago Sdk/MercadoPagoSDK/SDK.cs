using MercadoPago.Core;
using MercadoPago.Core.Annotations;
using MercadoPago.Exceptions;
using MercadoPago.Net;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.Reflection;

namespace MercadoPago
{
    public class SDK
    {
        private const string CLIENT_NAME = "MercadoPago-SDK-DotNet";
        private const string DEFAULT_BASE_URL = "https://api.mercadopago.com";
        private const string DEFAULT_METRICS_SCOPE = "prod";
        private const int DEFAULT_REQUESTS_RETRIES = 3;
        private const int DEFAULT_REQUESTS_TIMEOUT = 30000;
        private const string PRODUCT_ID = "BC32BHVTRPP001U8NHL0";
        private static readonly string _version;
        private static string _accessToken;
        private static string _appId;
        private static string _baseUrl = DEFAULT_BASE_URL;
        private static string _clientId;
        private static string _clientSecret;
        private static string _corporationId;
        private static string _integratorId;
        private static string _metricsScope = DEFAULT_METRICS_SCOPE;
        private static string _platformId;
        private static IWebProxy _proxy;
        private static string _refreshToken;
        private static int _requestsRetries = DEFAULT_REQUESTS_RETRIES;
        private static int _requestsTimeout = DEFAULT_REQUESTS_TIMEOUT;
        private static string _trackingId;
        private static string _userToken;

        static SDK()
        {
            _version = new AssemblyName(typeof(SDK).Assembly.FullName).Version.ToString(3);
            _trackingId = String.Format("platform:{0}|{1},type:SDK{2},so;", Environment.Version.Major, Environment.Version, _version);
        }

        /// <summary>
        /// MercadoPago AccessToken.
        /// </summary>
        public static string AccessToken
        {
            get { return _accessToken; }
            set
            {
                if (!string.IsNullOrEmpty(_accessToken))
                {
                    throw new MPConfException("accessToken setting can not be changed");
                }
                _accessToken = value;
            }
        }

        /// <summary>
        /// MercadoPAgo app id.
        /// </summary>
        public static string AppId
        {
            get { return _appId; }
            set
            {
                if (!string.IsNullOrEmpty(_appId))
                {
                    throw new MPConfException("appId setting can not be changed");
                }
                _appId = value;
            }
        }

        /// <summary>
        /// Api base URL. Currently https://api.mercadopago.com
        /// </summary>
        public static string BaseUrl
        {
            get { return _baseUrl; }
        }

        /// <summary>
        /// Property that represents a client id.
        /// </summary>
        public static string ClientId
        {
            get { return _clientId; }
            set
            {
                if (!string.IsNullOrEmpty(_clientId))
                {
                    throw new MPConfException("clientId setting can not be changed");
                }
                _clientId = value;
            }
        }

        /// <summary>
        /// Gets the client name.
        /// </summary>
        public static string ClientName
        {
            get { return CLIENT_NAME; }
        }

        /// <summary>
        /// Property that represent the client secret token.
        /// </summary>
        public static string ClientSecret
        {
            get { return _clientSecret; }
            set
            {
                if (!string.IsNullOrEmpty(_clientSecret))
                {
                    throw new MPConfException("clientSecret setting can not be changed");
                }
                _clientSecret = value;
            }
        }

        /// <summary>
        ///  Property that represent the corporation id.
        /// </summary>
        public static string CorporationId
        {
            get { return _corporationId; }
            set
            {
                if (!string.IsNullOrEmpty(_corporationId))
                {
                    throw new MPConfException("corporationId setting can not be changed");
                }
                _corporationId = value;
            }
        }

        /// <summary>
        ///  Property that represent the integrator id.
        /// </summary>
        public static string IntegratorId
        {
            get { return _integratorId; }
            set
            {
                if (!string.IsNullOrEmpty(_integratorId))
                {
                    throw new MPConfException("integratorId setting can not be changed");
                }
                _integratorId = value;
            }
        }

        /// <summary>
        /// Insight metrics scope
        /// </summary>
        public static string MetricsScope
        {
            get { return _metricsScope; }
            set { _metricsScope = value; }
        }

        /// <summary>
        ///  Property that represent the plataform id.
        /// </summary>
        public static string PlatformId
        {
            get { return _platformId; }
            set
            {
                if (!string.IsNullOrEmpty(_platformId))
                {
                    throw new MPConfException("platformId setting can not be changed");
                }
                _platformId = value;
            }
        }

        /// <summary>Gets the product ID.</summary>
        public static string ProductId
        {
            get { return PRODUCT_ID; }
        }

        public static IWebProxy Proxy
        {
            get { return _proxy; }
            set { _proxy = value; }
        }

        public static string RefreshToken
        {
            get { return _refreshToken; }
            set { _refreshToken = value; }
        }

        /// <summary>
        /// Api requests retries
        /// </summary>
        public static int RequestsRetries
        {
            get
            { return _requestsRetries; }
            set { _requestsRetries = value; }
        }

        /// <summary>
        /// Api requests timeout
        /// </summary>
        public static int RequestsTimeout
        {
            get { return _requestsTimeout; }
            set { _requestsTimeout = value; }
        }

        /// <summary>Gets the tracking ID.</summary>
        public static string TrackingId
        {
            get { return _trackingId; }
        }

        /// <summary>Gets the version of the SDK.</summary>
        public static string Version
        {
            get { return _version; }
        }

        /// <summary>
        /// Clean all the configuration variables
        /// (FOR TESTING PURPOSES ONLY)
        /// </summary>
        public static void CleanConfiguration()
        {
            _clientSecret = null;
            _clientId = null;
            _accessToken = null;
            _appId = null;
            _baseUrl = DEFAULT_BASE_URL;
            _requestsTimeout = DEFAULT_REQUESTS_TIMEOUT;
            _requestsRetries = DEFAULT_REQUESTS_RETRIES;
            _proxy = null;
        }

        public static JToken Get(String uri)
        {
            MPRESTClient client = new MPRESTClient();
            return client.ExecuteGenericRequest(HttpMethod.GET, uri, PayloadType.JSON, null);
        }

        /// <summary>
        /// Get the access token pointing to OAuth.
        /// </summary>
        /// <returns>A valid access token.</returns>
        public static string GetAccessToken()
        {
            if (String.IsNullOrEmpty(AccessToken))
            {
                AccessToken = MPCredentials.GetAccessToken();
            }
            return AccessToken;
        }

        public static string GetCorporationId()
        {
            return CorporationId;
        }

        public static string GetIntegratorId()
        {
            return IntegratorId;
        }

        public static string GetPlatformId()
        {
            return PlatformId;
        }

        /// <summary>
        /// Gets the custom user token.
        /// This method is deprecated and will be removed in a future version
        /// </summary>
        /// <returns>User token to return.</returns>
        // TODO; remove this method in a future major version
        [Obsolete("There is no use for this method.")]
        public static string GetUserToken()
        {
            return _userToken;
        }

        public static JToken Post(string uri, JObject payload)
        {
            MPRESTClient client = new MPRESTClient();
            return client.ExecuteGenericRequest(HttpMethod.POST, uri, PayloadType.JSON, payload);
        }

        public static JToken Put(string uri, JObject payload)
        {
            MPRESTClient client = new MPRESTClient();
            return client.ExecuteGenericRequest(HttpMethod.PUT, uri, PayloadType.JSON, payload);
        }

        /// <summary>
        /// Sets the access token.
        /// </summary>
        /// <param name="accessToken">Value of the access token.</param>
        public static void SetAccessToken(string accessToken)
        {
            if (!string.IsNullOrEmpty(AccessToken))
            {
                throw new MPException("Access_Token setting cannot be changed.");
            }

            AccessToken = accessToken;
        }

        /// <summary>
        /// Changes base Url
        /// (FOR TESTING PURPOSES ONLY)
        /// </summary>
        public static void SetBaseUrl(string baseUrl)
        {
            _baseUrl = baseUrl;
        }

        /// <summary>
        /// Dictionary based configuration. Valid configuration keys:
        /// clientSecret, clientId, accessToken, appId
        /// </summary>
        /// <param name="configurationParams"></param>
        public static void SetConfiguration(IDictionary<String, String> configurationParams)
        {
            if (configurationParams == null) throw new ArgumentException("Invalid configurationParams parameter");

            configurationParams.TryGetValue("clientSecret", out _clientSecret);
            configurationParams.TryGetValue("clientId", out _clientId);
            configurationParams.TryGetValue("accessToken", out _accessToken);
            configurationParams.TryGetValue("appId", out _appId);

            String requestsTimeoutStr;
            if (configurationParams.TryGetValue("requestsTimeout", out requestsTimeoutStr))
            {
                Int32.TryParse(requestsTimeoutStr, out _requestsTimeout);
            }

            String requestsRetriesStr;
            if (configurationParams.TryGetValue("requestsRetries", out requestsRetriesStr))
            {
                Int32.TryParse(requestsRetriesStr, out _requestsRetries);
            }

            String proxyHostName;
            String proxyPortStr;
            int proxyPort;
            if (configurationParams.TryGetValue("proxyHostName", out proxyHostName)
                && configurationParams.TryGetValue("proxyPort", out proxyPortStr)
                && Int32.TryParse(proxyPortStr, out proxyPort))
            {
                _proxy = new WebProxy(proxyHostName, proxyPort);

                String proxyUsername;
                String proxyPassword;
                if (configurationParams.TryGetValue("proxyUsername", out proxyUsername)
                    && configurationParams.TryGetValue("proxyPassword", out proxyPassword))
                {
                    _proxy.Credentials = new NetworkCredential(proxyUsername, proxyPassword);
                }
            }
        }

        /// <summary>
        /// Initializes the configurations based in a confiiguration object.
        /// </summary>
        /// <param name="config"></param>
        public static void SetConfiguration(Configuration config)
        {
            if (config == null) throw new ArgumentException("config parameter cannot be null");

            _clientSecret = GetConfigValue(config, "ClientSecret");
            _clientId = GetConfigValue(config, "ClientId");
            _accessToken = GetConfigValue(config, "AccessToken");
            _appId = GetConfigValue(config, "AppId");

            String requestsTimeoutStr = GetConfigValue(config, "RequestsTimeout");
            Int32.TryParse(requestsTimeoutStr, out _requestsTimeout);

            String requestsRetriesStr = GetConfigValue(config, "RequestsRetries");
            Int32.TryParse(requestsRetriesStr, out _requestsRetries);

            String proxyHostName = GetConfigValue(config, "ProxyHostName");
            String proxyPortStr = GetConfigValue(config, "ProxyPort");
            int proxyPort;
            if (!String.IsNullOrEmpty(proxyHostName) && Int32.TryParse(proxyPortStr, out proxyPort))
            {
                _proxy = new WebProxy(proxyHostName, proxyPort);

                String proxyUsername = GetConfigValue(config, "ProxyUsername");
                String proxyPassword = GetConfigValue(config, "ProxyPassword");
                if (!String.IsNullOrEmpty(proxyUsername) && !String.IsNullOrEmpty(proxyPassword))
                {
                    _proxy.Credentials = new NetworkCredential(proxyUsername, proxyPassword);
                }
            }
        }

        public static void SetCorporationId(string corporationId)
        {
            CorporationId = corporationId;
        }

        public static void SetIntegratorId(string integratorId)
        {
            IntegratorId = integratorId;
        }

        public static void SetPlatformId(string platformId)
        {
            PlatformId = platformId;
        }

        private static string GetConfigValue(Configuration config, string key)
        {
            string value = null;
            KeyValueConfigurationElement keyValue = config.AppSettings.Settings[key];
            if (keyValue != null)
            {
                value = keyValue.Value;
            }
            return value;
        }
    }
}