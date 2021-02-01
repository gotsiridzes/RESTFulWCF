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
        public static async Task<dynamic> GetPersonDynamic(int id)
        {
            var result = await GetAsync<dynamic>($"api/get/{id}");

            return result;
        }

        public static async Task<Person> GetPerson(int id)
        {
            var result = await GetAsync<Person>($"api/get/{id}");

            return result;
        }

        public static async Task<IEnumerable<Person>> ListPeople()
        {
            var result = await GetAsync<IEnumerable<Person>>(Constants.Methods.ListPeople);

            return result;
        }




    }
}