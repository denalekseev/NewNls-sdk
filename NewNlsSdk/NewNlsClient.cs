using System;
using System.Collections.Generic;
using System.Linq;
using NewNlsSdk.DataContracts;
using NewNlsSdk.Toolbox;
using RestSharp;
using RestSharp.Authenticators;
using Restub;
using Restub.DataContracts;

namespace NewNlsSdk
{
    /// <summary>
    /// NewNls API Client.
    /// </summary>
    public partial class NewNlsClient : RestubClient
    {
        /// <summary>
        /// Production API endpoint.
        /// </summary>
        public const string ProductionApiUrl = "https://89.221.50.35/wms_v7_test";

        /// <summary>
        /// Initializes a new instance of the <see cref="NewNlsClient"/> class.
        /// </summary>
        /// <param name="baseUrl">Base API endpoint.</param>
        /// <param name="credentials">Credentials.</param>
        public NewNlsClient(string baseUrl, NewNlsCredentials credentials)
            : base(baseUrl, credentials)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewNlsClient"/> class.
        /// </summary>
        /// <param name="сlient">REST API client.</param>
        /// <param name="credentials">Credentials.</param>
        public NewNlsClient(string baseUrl, string apiKey)
            : base(baseUrl, new NewNlsCredentials(apiKey))
        {
        }

        /// <inheritdoc/>
        public override string LibraryName =>
            $"{nameof(NewNlsSdk)}.{nameof(NewNlsClient)} v{LibraryVersion}, {base.LibraryName}";

        /// <inheritdoc/>
        protected override IAuthenticator GetAuthenticator() =>
            new NewNlsAuthenticator(this, (NewNlsCredentials)Credentials);

        /// <inheritdoc/>
        protected override IRestubSerializer CreateSerializer() =>
            new NewNlsSerializer();

        /// <inheritdoc/>
        protected override Exception CreateException(IRestResponse res, string msg, IHasErrors errors) =>
            new NewNlsException(res.StatusCode, msg, base.CreateException(res, msg, errors))
            {
                ErrorResponseText = res.Content,
            };
    }
}