using NewNlsSdk.DataContracts;
using RestSharp;
using Restub.Toolbox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewNlsSdk
{
    /// <remarks>
    /// NewNls API Client, athentication primitives.
    /// </remarks>
    public partial class NewNlsClient
    {
        /////// <summary>
        /////// Acquires a JWT token for the NewNls API.
        /////// </summary>
        /////// <param name="clientAccount">Account identifier.</param>
        /////// <param name="clientSecret">Client secret or password.</param>
        ////internal NewNlsAuthToken GetAuthToken(string clientAccount, string clientSecret)
        ////{
        ////    var body = string.Format("grant_type=client_credentials&client_id={0}&client_secret={1}", clientAccount, clientSecret);
        ////    var req = new RestRequest();

        ////   //// return Post<NewNlsAuthToken>("token", body, r => AddAuthQueryString(r, req));
        ////    return Post<NewNlsAuthToken>("token/", body, r =>
        ////    {
        ////        InitAuthRequest(r);
        ////        //r.AlwaysMultipartFormData = true;
        ////    });
        ////}

        public void InitAuthRequest(IRestRequest initReq)
        {
            //initReq.AddHeader("Content-type", "application/x-www-form-urlencoded");
            initReq.AddHeader("Accept", "application/json");
         }

        public void AddAuthQueryString(object req, IRestRequest initReq)
        {
            InitAuthRequest(initReq);
            initReq.AddQueryString(req);
        }
    }
}
