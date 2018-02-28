using System;
using System.Collections.Generic;
using System.Net;
using System.ComponentModel;
using DH.Media.Core.Enterprise.Enums;

namespace DH.Media.Core.Enterprise.Common
{
    /// <summary>
    /// Services response codes, messages for below supported HTTPStatusCodes 
    /// 200 - OK            (Success)
    /// 201 - Created       (Success)
    /// 400 - Bad Request   (Client Error)
    /// 401 - Unauthorized  (Client Error)
    /// 403 - Forbidden     (Client Error)
    /// 404 - NotFound      (Client Error)
    /// 500 - Internal Server Error (Server Error)
    /// </summary>
    public enum ResponseCodes
    {
        #region HTTP Status Codes
        /// <summary>
        /// Success
        /// </summary>
        [HttpStatus(HttpStatusCode.OK)]
        [Description(Constants.SuccessMessage)]
        Ok = 2000,


        /// <summary>
        /// Access token expired
        /// </summary>
        [HttpStatus(HttpStatusCode.Unauthorized)]
        [Description(Constants.AccessTokenExpiredMessage)]
        AccessTokenExpired = 4132,

        /// <summary>
        /// Access token not found with request headers
        /// </summary>
        [HttpStatus(HttpStatusCode.Unauthorized)]
        [Description(Constants.NoAccessTokenMessage)]
        NoAccessToken = 4133,

        /// <summary>
        /// Insufficient User Privileges
        /// </summary>
        [HttpStatus(HttpStatusCode.Unauthorized)]
        [Description(Constants.InsufficientUserPrivilegesMessage)]
        InsufficientPrivileges = 4134,

        /// <summary>
        /// Unauthorized access token
        /// </summary>
        [HttpStatus(HttpStatusCode.Unauthorized)]
        [Description(Constants.UnauthorizedAccessTokenMessage)]
        UnauthorizedAccessToken = 4135,

        /// <summary>
        /// Invalid state token 
        /// </summary>
        [HttpStatus(HttpStatusCode.BadRequest)]
        [Description(Constants.InvalidStateTokenMessage)]
        InvalidStateToken = 4030,

        /// <summary>
        /// An unexpected error occurred. Please contact administrator
        /// </summary>
        [HttpStatus(HttpStatusCode.InternalServerError)]
        [Description(Constants.InternalServerErrorMessage)]
        InternalServerError = 5000,

        // <summary>
        /// Presentation video not found
        /// </summary>
        [HttpStatus(HttpStatusCode.NotFound)]
        [Description(Constants.PresentationVideoNotFoundMessage)]
        PresentationVideoNotfound = 4128

        #endregion
    }
}
