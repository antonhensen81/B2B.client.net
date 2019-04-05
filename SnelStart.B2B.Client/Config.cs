﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using SnelStart.B2B.Client.Interceptors;

namespace SnelStart.B2B.Client
{
    public class Config
    {
        private static readonly Lazy<HttpClient> DefaultHttpClientProviderInstance = new Lazy<HttpClient>(() =>
        {
            var handler = new HttpClientHandler
            {
                CookieContainer = new CookieContainer(),
                UseCookies = true
            };
            return new HttpClient(handler);
        });

        private static readonly Func<HttpClient> DefaultHttpClientProvider =
            () => DefaultHttpClientProviderInstance.Value;

        private Action<string> _logger = x => { };

        public Func<HttpClient> HttpClientProvider { get; set; } = DefaultHttpClientProvider;

        public Uri AuthUri { get; }
        public Uri ApiBaseUriVersioned { get; }
        public string SubscriptionKey { get; }
        public string KoppelSleutel { get; }
        public int ConnectionLeaseTimeoutInMilliseconds { get; set; } = (int)TimeSpan.FromMinutes(1).TotalMilliseconds;
        public int DnsRefreshTimeoutInMilliseconds { get; set; } = (int)TimeSpan.FromMinutes(1).TotalMilliseconds;
        public bool ConfigureDnsRefreshTimeoutEnabled { get; set; } = true;
        public List<IRequestInterceptor> RequestInterceptors { get; } = new List<IRequestInterceptor>();

        public Action<string> Logger
        {
            get
            {
                return _logger;
            }
            set
            {
                IsLoggerEnabled = true;
                _logger = value;
            }
        }

        public bool IsLoggerEnabled { get; private set; } = false;

        public Config(string subscriptionKey, string koppelSleutel)
            : this(
                  subscriptionKey,
                  koppelSleutel,
                  new Uri("https://auth-tst.snelstart.nl"),
                  new Uri("http://localhost:41586")
//                  new Uri("https://b2bapi-tst.snelstart.nl")
            )
        {

        }

        public Config(string subscriptionKey, string koppelSleutel, Uri authUri, Uri apiUri)
        {
            if (string.IsNullOrWhiteSpace(subscriptionKey))
            {
                throw new ArgumentException("Parameter cannot be null or whitespace", nameof(subscriptionKey));
            }

            if (string.IsNullOrWhiteSpace(koppelSleutel))
            {
                throw new ArgumentException("Parameter cannot be null or whitespace", nameof(koppelSleutel));
            }
            if (authUri == null)
            {
                throw new ArgumentException("Parameter cannot be null", nameof(authUri));
            }

            if (apiUri == null)
            {
                throw new ArgumentException("Parameter cannot be null", nameof(apiUri));
            }

            SubscriptionKey = subscriptionKey;
            KoppelSleutel = koppelSleutel;
            AuthUri = new Uri(authUri, "b2b/token");
            ApiBaseUriVersioned = new Uri(apiUri, "v2");
        }

        internal UsernamePasswordPair GetApiUsernamePassword()
        {
            var decodedKoppelingSleutel = Base64Decode(KoppelSleutel);
            var koppelingKeyParts = GetKoppelingKeyParts(decodedKoppelingSleutel);

            return new UsernamePasswordPair(koppelingKeyParts[0], koppelingKeyParts[1]);
        }

        private string Base64Decode(string userKey)
        {
            var data = Convert.FromBase64String(userKey);
            var result = Encoding.UTF8.GetString(data);
            return result;
        }

        private string[] GetKoppelingKeyParts(string userKey)
        {
            var result = userKey.Split(new[] { ":" }, StringSplitOptions.None);
            return result;
        }

    }
}