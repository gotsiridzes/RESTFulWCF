using System;
using System.Net.Http;

namespace Client
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            //var stringsResult = await ServiceClient.GetStringsAsync();

            //var enteredResult = await ServiceClient.TestInput("test dataaa");

            var compositeTypes = await ServiceClient.GetCompositeTypes();

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
