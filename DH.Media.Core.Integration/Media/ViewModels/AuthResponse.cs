using System;


namespace DH.Media.Core.Integration.Media.ViewModels
{
    /// <summary>
    ///Response for sAuthentication 
    /// </summary>
    public class AuthResponse
    {
        #region Properties
        public string TicketId { get; set; }
        public string Username { get; set; }
        public string ClientIpAddress { get; set; }
        public string Owner { get; set; }
        public string ResourceId { get; set; }
        public int MinutesToLive { get; set; }
        public DateTime? CreationTime { get; set; }
        public DateTime? ExpirationTime { get; set; }
        #endregion
    }
}
