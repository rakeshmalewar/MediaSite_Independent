using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DH.Media.Core.Enterprise.Enums
{
    /// <summary>
    /// Custom attribute for all enums.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IEnumAttribute<out T>
    {
        /// <summary>
        /// Generic type Value.
        /// </summary>
        T Value { get; }
    }
}
