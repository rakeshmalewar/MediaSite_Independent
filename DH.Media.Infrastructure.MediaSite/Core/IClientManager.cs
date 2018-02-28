using RestSharp;

namespace DH.Media.Infrastructure.MediaSite.Core
{
    public interface IClientManager
    {
        RestClient Client { get; }
    }
}
