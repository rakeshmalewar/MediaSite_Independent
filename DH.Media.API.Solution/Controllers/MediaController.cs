using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.ModelBinding;
//using Microsoft.Web.Http;
using DH.Media.Core.Application.Media;
using DH.Media.Core.Enterprise.Common;
using DH.Media.Core.Enterprise.Common.Models;
using DH.Media.Core.Application.Media.ViewModels;
using System.Web.Http;

namespace DH.Media.API.Solution.Controllers
{
    /// <summary>
    /// Manage all media operations
    /// </summary>  
   // [ApiVersion("1.0")]
    public class MediaController : BaseController
    {
        #region Variables
        private readonly IMediaApplication _mediaApplication;
        #endregion

        #region Constructor

        /// <summary>
        /// Constructor for MediaController
        /// </summary>
        /// <param name="mediaApplication">WhitelistApplication Interface</param>
        public MediaController(IMediaApplication mediaApplication)
        {
            _mediaApplication = mediaApplication;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Get list of Media Videos
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="sortAndPaginationQueryModel"></param>
        /// <param name="search"></param>
        /// <returns>MediaResponse Object</returns>
        [HttpGet]
        [ResponseType(typeof(MediaSiteResponse<MediaResponse>))]
        [Route("api/v{version:apiVersion}/media/{tenantId}/content")]
        public HttpResponseMessage GetMediaVideos(string tenantId, [ModelBinder]SortAndPaginationQueryModel sortAndPaginationQueryModel, [FromUri] string search = null) //http://localhost:50020/api/v1.0/80C641E8-E12F-406A-BB31-9557CE7D9F66/MediasiteVideos?Search=stroke&top=10&skip=0
        {
            return BuildResponse(_mediaApplication.GetMediaVideos(tenantId, search, sortAndPaginationQueryModel));
        }

        /// <summary>
        /// Get Media Auth Ticket
        /// </summary>
        /// <param name="tenantId">Tenant Id</param>               
        /// <returns></returns>
        [HttpGet]
        [ResponseType(typeof(MediaSiteResponse<string>))]
        [Route("api/v{version:apiVersion}/media/{tenantId}/authorization-ticket")]
        public HttpResponseMessage GetMediaAuthTicket(string tenantId)
        {
            return BuildResponse(_mediaApplication.GetAuthorizationTicket(Request.RequestUri.Query));
        }

        /// <summary>
        /// Simplify API : Get Media object for Presentation Id
        /// </summary>
        /// <param name="presentationId">Presentation Id</param>        
        /// <returns>MediaPresentationResponse Object</returns>
        [HttpGet]
        [ResponseType(typeof(MediaSiteResponse<MediaPresentationResponse>))]
        [Route("api/v{version:apiVersion}/media/{presentationId}/presentation")]
        public HttpResponseMessage GetMediaPresentation(string presentationId)
        {
            return BuildResponse(_mediaApplication.GetPresentation(presentationId));
        }

        #endregion
    }
}
