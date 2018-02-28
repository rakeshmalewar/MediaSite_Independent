using DH.Media.Core.Enterprise.Common;
using DH.Media.Infrastructure.MediaSite.Core;
using DH.Media.Infrastructure.MediaSite.Mappings;

namespace DH.Media.Infrastructure.MediaSite
{
    /// <summary>
    /// Provides Media Base Context
    /// </summary>
    public class BaseContext
    {
        #region Connection Object 

        private readonly ConnectMap _mediasiteConn = new ConnectMap();

        #endregion

        #region Fields

        private IClientManager _clientManagerField;

        #endregion

        #region Interface
        protected IClientManager ClientManager => _clientManagerField ?? (_clientManagerField = new ClientManager(_mediasiteConn));

        #endregion

        #region Constructor 

        /// <summary>
        /// Base Context Constructor
        /// </summary>
        protected BaseContext()
        {
            var username = "AppTest";
            var password = "Apptest2017!";
            var apikey = "4854ce06-fbe0-4346-8ae1-4b465d373c9f";

            _mediasiteConn.UserName = username;
            _mediasiteConn.Password = password;
            _mediasiteConn.ApiKey = apikey;
            _mediasiteConn.EndpointAddress = ConfigurationHelper.MsEndPointUri;
        }

        #endregion
    }
}
