using System;
using System.Net.Http;

namespace Client
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            //var dynamicData = await ServiceClient.GetDynamicData(1);

            var person = await ServiceClient.Get(1);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
