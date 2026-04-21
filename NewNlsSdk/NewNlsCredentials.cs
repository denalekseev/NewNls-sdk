using NewNlsSdk.DataContracts;
using Restub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewNlsSdk
{
    /// <summary>
    /// Evotor API Credentials.
    /// </summary>
    public class NewNlsCredentials : Credentials<NewNlsClient, NewNlsAuthToken>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EvotorCredentials"/> class.
        /// </summary>
        public NewNlsCredentials()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvotorCredentials"/> class.
        /// </summary>
        /// <param name="clientAccount">Client account.</param>
        /// <param name="clientSecret">Client secret.</param>
        public NewNlsCredentials(string apiKey)
        {
            ApiKey = apiKey;
        }

        /// <summary>
        /// Gets or sets ApiKey
        /// </summary>
        public string ApiKey { get; set; }

        public override NewNlsAuthToken Authenticate(NewNlsClient client)
        {
            return new NewNlsAuthToken()
            {
                ApiKey = this.ApiKey,
            };
        }
    }
}
