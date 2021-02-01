using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Client
{
    public static partial class ServiceClient
    {
        public static async Task<dynamic> GetDynamicData(int id)
        {
            var result = await GetAsync<dynamic>($"api/get/{id}");

            return result;
        }

        public static async Task<Person> Get(int id)
        {
            var result = await GetAsync<Person>($"api/get/{id}");

            return result;
        }


    }
}