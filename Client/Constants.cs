using System;
using System.Collections.Generic;
using System.Text;

namespace Client
{
    public static class Constants
    {
        internal static string ServiceUrl = "http://localhost:8080/Service.svc";
        public static class Methods
        {
            internal static string GetDatausingDataContracts = "api/GetDataUsingDataContracts";
            internal static string GetStrings = "api/GetStrings";
        }
    }
}
