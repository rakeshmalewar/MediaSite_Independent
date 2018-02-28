﻿using System.Web.Mvc;


namespace DH.Media.API.App_Start
{
    /// <summary>
    /// Handles global filters
    /// </summary>
    public class FilterConfig
    {
        /// <summary>
        /// Registers global filters
        /// </summary>
        /// <param name="filters">GlobalFilterCollection</param>
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new AiHandleErrorAttribute());
        }
    }
}