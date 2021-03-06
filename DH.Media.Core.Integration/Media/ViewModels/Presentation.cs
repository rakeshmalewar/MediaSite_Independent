﻿using DH.Media.Core.Enterprise.Common;
using System;

namespace DH.Media.Core.Integration.Media.ViewModels
{
    public class Presentation
    {
        #region Properties
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PrimaryPresenter { get; set; }
        public string Owner { get; set; }
        public string ThumbnailUrl { get; set; }
        public int Duration { get; set; }
        public DateTime? RecordDate { get; set; }
        public string AuthorizationTicket { get; set; }
        public string PlaybackUrl => string.Concat(ConfigurationHelper.MediaSitePlaybackUrl, Id);

        #endregion
    }
}
