using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public static partial class ServiceClient
    {
        private static async Task<TContent> GetAsync<TContent>(string uri)
        {
            using (var httpClient = HttpClientFactory.Create())
            {
                var builder = new UriBuilder(httpClient.BaseAddress);
                builder.Path = string.Join('/',builder.Path, uri);

                using (var response = await httpClient.GetAsync(builder.Uri))
                {
                    if (response.IsSuccessStatusCode)
                        return await response.Content.ReadAsAsync<TContent>();
                    else
                        return default(TContent);
                }
            }
        }

        private static async Task<TResponse> PostAsync<TResponse>(string uri, string content)
        {
            using (var httpClient = HttpClientFactory.Create())
            {
                var builder = new UriBuilder(httpClient.BaseAddress);
                builder.Path = string.Join('/',builder.Path, uri);

                using (var response = await httpClient.PostAsync(builder.Uri, new StringContent(content, Encoding.UTF8, "application/json")))
                {
                    if (response.IsSuccessStatusCode)
                        return await response.Content.ReadAsAsync<TResponse>();
                    else
                        return default(TResponse);
                }
            }
        }

        private static async Task<TResponse> PostAsync<TContent, TResponse>(string uri, TContent content)
        {
            using (var httpClient = HttpClientFactory.Create())
            {
                var builder = new UriBuilder(httpClient.BaseAddress);
                builder.Path = string.Join('/',builder.Path, uri);

                using (var response = await httpClient.PostAsJsonAsync<TContent>(builder.Uri, content))
                {
                    if (response.IsSuccessStatusCode)
                        return await response.Content.ReadAsAsync<TResponse>();
                    else
                        return default(TResponse);
                }
            }
        }
    }
}
