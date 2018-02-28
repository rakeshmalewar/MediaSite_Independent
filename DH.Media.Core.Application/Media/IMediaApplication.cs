using DH.Media.Core.Application.Media.ViewModels;
using DH.Media.Core.Enterprise.Common;
using DH.Media.Core.Enterprise.Common.Models;

namespace DH.Media.Core.Application.Media
{
    /// <summary>
    /// MediaApplication Interface
    /// </summary>
    public interface IMediaApplication
    {
        /// <summary>
        ///  Get list of Media videos
        /// </summary>
        /// <param name="tenantId"></param>
        /// <param name="searchCriteria"></param>
        /// <param name="sortAndPaginationQueryModel"></param>
        /// <returns>MediaResponse Object</returns>
        MediaSiteResponse<MediaResponse> GetMediaVideos(string tenantId, string searchCriteria, SortAndPaginationQueryModel sortAndPaginationQueryModel);

        /// <summary>
        /// Get Authorization Ticket
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        MediaSiteResponse<string> GetAuthorizationTicket(string query);

        /// <summary>
        /// Get Presentation
        /// </summary>
        /// <param name="presentationId">Presentation Id</param>
        /// <returns>MediaPresentationResponse Object</returns>
        MediaSiteResponse<MediaPresentationResponse> GetPresentation(string presentationId);
    }
}
