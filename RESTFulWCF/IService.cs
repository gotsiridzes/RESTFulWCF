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

        //[OperationContract, WebGet(UriTemplate = "api/getdata/{value}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        //string GetData(string value);

        //[OperationContract, WebGet(UriTemplate = "api/GetStrings", ResponseFormat = WebMessageFormat.Json, RequestFormat=WebMessageFormat.Json)]
        //IEnumerable<string> GetStrings();

        //[OperationContract, WebInvoke(UriTemplate="api/GetDataUsingDataContract", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json, Method = "POST")]
        //Person GetDataUsingDataContract(Person composite);

        ////[OperationContract, WebGet(UriTemplate = "api/GetDataUsingDataContract", ResponseFormat = WebMessageFormat.Json, RequestFormat=WebMessageFormat.Json)]
        //Person GetDataUsingDataContract();

        //[OperationContract, WebGet(UriTemplate = "api/GetDataUsingDataContract", ResponseFormat = WebMessageFormat.Json, RequestFormat=WebMessageFormat.Json)]
        //IEnumerable<Person> GetDataUsingDataContracts();

        [OperationContract, WebInvoke(BodyStyle = WebMessageBodyStyle.Bare, Method = "GET", UriTemplate = "api/get/{id}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        Person Get(string id);

        [OperationContract, WebInvoke(BodyStyle = WebMessageBodyStyle.Bare, Method = "POST", UriTemplate = "api/post", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        void Post(Person person);
        
        [OperationContract, WebInvoke(BodyStyle = WebMessageBodyStyle.Bare, Method = "GET", UriTemplate = "api/listpeople", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        IEnumerable<Person> List();
    }


    [DataContract]
    public class Person
    {
        [DataMember]
        public int Id { get; set; }
        
        [DataMember]
        public string FirstName { get; set; }
        
        [DataMember]
        public string LastName { get; set; }
    }
}
