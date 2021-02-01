using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace RESTFulWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(Namespace = "")]
    public interface IService
    {

        [OperationContract, WebGet(UriTemplate = "api/getdata/{value}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        string GetData(string value);

        [OperationContract, WebGet(UriTemplate = "api/GetStrings", ResponseFormat = WebMessageFormat.Json, RequestFormat=WebMessageFormat.Json)]
        IEnumerable<string> GetStrings();

        [OperationContract, WebInvoke(UriTemplate="api/GetDataUsingDataContract", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, Method = "POST")]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        //[OperationContract, WebGet(UriTemplate = "api/GetDataUsingDataContract", ResponseFormat = WebMessageFormat.Json, RequestFormat=WebMessageFormat.Json)]
        CompositeType GetDataUsingDataContract();

        [OperationContract, WebGet(UriTemplate = "api/GetDataUsingDataContracts", ResponseFormat = WebMessageFormat.Json, RequestFormat=WebMessageFormat.Json)]
        IEnumerable<CompositeType> GetDataUsingDataContracts();
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
