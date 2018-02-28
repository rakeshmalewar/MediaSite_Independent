using System.Collections.Generic;

namespace DH.Media.Infrastructure.MediaSite
{
    /// <summary>
    /// Provides Generic Responce Template 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericResponse<T>
    {
        #region Properties
        public List<T> Value { get; set; }

        #endregion
    }
}
