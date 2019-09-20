using System;
using System.Collections.Generic;
using System.Text;

namespace DoesItBlend
{
    /// <summary>
    /// Interface for items that can be blended
    /// </summary>
    interface IBlendables
    {
        /// <summary>
        /// Blends the object
        /// </summary>
        /// <returns>A string describing the blended object</returns>
        string Blend();
    }
}
