
namespace DH.Media.Infrastructure.MediaSite.Mappings
{
    /// <summary>
    /// Authorization Ticket
    /// </summary>
    internal class AuthorizationTicket
    {
        #region Public Properties
        public string Username { get; set; }

        public string ResourceId { get; set; }

        public int MinutesToLive { get; set; }

        #endregion
    }
}
