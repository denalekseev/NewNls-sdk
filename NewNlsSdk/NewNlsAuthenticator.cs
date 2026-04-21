using NewNlsSdk.DataContracts;
using Restub;

namespace NewNlsSdk
{
    /// <summary>
    /// NewNls API authenticator using credentials.
    /// </summary>
    internal class NewNlsAuthenticator : Authenticator<NewNlsClient, NewNlsAuthToken>
    {
        public NewNlsAuthenticator(NewNlsClient apiClient, NewNlsCredentials credentials)
            : base(apiClient, credentials)
        {
        }

        public override void InitAuthHeaders(NewNlsAuthToken authToken) =>
            AuthHeaders["Authorization"] = $"Bearer {authToken.ApiKey}";
    }
}
