using System.Runtime.Serialization;
using Restub.DataContracts;

namespace NewNlsSdk.DataContracts
{
    [DataContract]
    public class NewNlsAuthToken : AuthToken
    {
        [DataMember(Name = "api_key")]
        public string ApiKey { get; set; } // "eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJzY29wZSI6WyJvcmRlcjphbGw..."
    }
}
