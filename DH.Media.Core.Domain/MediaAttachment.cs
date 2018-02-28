using System.Collections.Generic;
using Newtonsoft.Json;

namespace DH.Media.Core.Domain
{
    /// <summary>
    /// Media Attachment Class
    /// </summary>
    public class MediaAttachment
    {
        /// <summary>
        /// MediaAttachment Constructor
        /// </summary>
        public MediaAttachment()
        {
            
        }

        /// <summary>
        /// Media Attachment Id
        /// </summary>
        public int MediaAttachmentId { get; set; }

        /// <summary>
        /// Attachment Thumbnail Url
        /// </summary>
        public string AttachmentThumbnailUrl { get; set; }

        /// <summary>
        /// Attachment Url
        /// </summary>
        public string AttachmentUrl { get; set; }

        
    }
}
