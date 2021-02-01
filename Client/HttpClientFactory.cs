using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Client
{
    public sealed class HttpClientFactory
    {
        public static HttpClient Create()
        {
            return Create(Constants.ServiceUrl);
        }

        public static HttpClient Create(string baseAddress)
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri(baseAddress)
            };
            return client;
        }
    }
}
