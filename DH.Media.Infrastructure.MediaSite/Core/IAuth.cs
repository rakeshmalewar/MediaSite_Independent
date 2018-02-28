using RestSharp;

namespace DH.Media.Infrastructure.MediaSite.Core
{
    internal interface IAuth
    {
        void Authenticate(IRestClient client, IRestRequest request);
    }
}
