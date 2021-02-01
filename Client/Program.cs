using System;
using System.Net.Http;

namespace Client
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            //var dynamicData = await ServiceClient.GetDynamicData(1);

            //var person = await ServiceClient.GetPerson(1);

            var people = await ServiceClient.ListPeople();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
