using CoreExtensions.Helpers;
using System;

namespace CoreExtensions.Extensions
{
    /// <summary>
    /// Adds extensions to the Enum class
    /// </summary>
    public static class EnumExtension
    {
        /// <summary>
        /// Retrieves the Name property on the Display attribute
        /// of the current enum value, or the enum's member name if the Display attribute is not present
        /// </summary>
        /// <param name="val">This enum member to get the name for</param>
        /// <returns>The Name property on the Display attribute, if present</returns>
        public static string GetDisplayName(this Enum val)
        {
            return EnumHelper.GetDisplayName(val);
        }
    }
}