using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Client
{
    public static class ServiceClient
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
                var httpUri = new Uri(httpClient.BaseAddress, uri);
                using (var response = await httpClient.PostAsync(httpUri, new StringContent(content, Encoding.UTF8, "application/json")))
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
                var httpUri = new Uri(httpClient.BaseAddress, uri);
                using (var response = await httpClient.PostAsJsonAsync<TContent>(httpUri, content))
                {
                    if (response.IsSuccessStatusCode)
                        return await response.Content.ReadAsAsync<TResponse>();
                    else
                        return default(TResponse);
                }
            }
        }

        public static async Task<IEnumerable<string>> GetStringsAsync()
        {
            var result = await GetAsync<IEnumerable<string>>(Constants.Methods.GetStrings);
            return result;
        }

        public static async Task<string> TestInput(string value)
        {
            var result = await GetAsync<string>($"api/getdata/{value}");
            return result;
        }

        //public static async Task<IEnumerable<dynamic>> GetCompositeTypes()
        //{
        //    var result = await GetAsync<dynamic>("api/GetDataUsingDataContracts");
        //    return result;
        //}

        public static async Task<IEnumerable<CompositeType>> GetCompositeTypes()
        {
            var result = await GetAsync<IEnumerable<CompositeType>>(Constants.Methods.GetDatausingDataContracts);
            return result;
        }


    }
}