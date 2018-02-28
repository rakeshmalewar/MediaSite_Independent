using DH.Media.Core.Enterprise.Enums;

namespace DH.Media.Core.Enterprise.Common
{
    /// <summary>
    /// Manages service response
    /// </summary>
    public class ServiceResponse : SingletonBase<ServiceResponse>
    {
        #region Private Method

        private ServiceResponse() { }

        #endregion

        #region Public Methods
        /// <summary>
        /// Builds the service response
        /// </summary>
        /// <param name="code">ResponseCodes</param>
        /// <returns>MediaSiteResponse object</returns>
        public MediaSiteResponse BuildResponse(ResponseCodes code)
        {
            var mediasiteResponse = new MediaSiteResponse
            {
                Code = (int)code,
                Message = EnumManager.Instance.GetDescription(code)
            };
            return mediasiteResponse;
        }

        /// <summary>
        /// Builds the service response
        /// </summary>
        /// <param name="code">ResponseCodes</param>
        /// <param name="data">Object of type T</param>
        /// <returns>MediaSiteResponse object</returns>
        public MediaSiteResponse<T> BuildResponse<T>(ResponseCodes code, T data)
        {
            var curbsideResponse = new MediaSiteResponse<T>
            {
                Code = (int)code,
                Message = EnumManager.Instance.GetDescription(code),
                Data = data
            };

            return curbsideResponse;
        }

        public MediaSiteResponse<T> BuildErrorResponse<T>(ResponseCodes code)
        {
            var curbsideResponse = new MediaSiteResponse<T>
            {
                Code = (int)code,
                Message = EnumManager.Instance.GetDescription(code)
            };

            return curbsideResponse;
        }

        #endregion
    }
}
