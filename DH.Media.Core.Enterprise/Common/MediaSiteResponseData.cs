using System.Runtime.Serialization;

namespace DH.Media.Core.Enterprise.Common
{
    /// <summary>
    /// CurbsideResponse object
    /// </summary>
    /// <typeparam name="T">Type T</typeparam>
    [DataContract(Name = "MediaSiteResponse{0}")]
    public class MediaSiteResponse<T>
    {
        #region Data members
        /// <summary>
        /// service custom code
        /// </summary>
        [DataMember]
        public int Code { get; set; }

        /// <summary>
        /// service custom message
        /// </summary>
        [DataMember]
        public string Message { get; set; }

        /// <summary>
        /// response object
        /// </summary>
        [DataMember]
        public T Data { get; set; }
        #endregion
    }
}
