﻿using System;

namespace DH.Media.API
{
    /// <summary>
    /// AiHandleErrorAttribute Class
    /// </summary>
    public class AiHandleErrorAttribute : HandleErrorAttribute
        /// <summary>
        /// Provides Exception on AiHandle
        /// </summary>
        /// <param name="filterContext"></param>
                //If customError is Off, then AI HTTPModule will report the exception
                if (filterContext.HttpContext.IsCustomErrorEnabled)
                    var ai = new TelemetryClient();
            }
}