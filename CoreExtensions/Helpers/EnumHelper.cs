using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace CoreExtensions.Helpers
{
    /// <summary>
    /// Enum helper class
    /// </summary>
    public class EnumHelper
    {
        /// <summary>
        /// Retrieves the Name property on the Display attribute
        /// of the current enum value, or the enum's member name if the Display attribute is not present
        /// </summary>
        /// <param name="val">This enum member to get the name for</param>
        /// <returns>The Name property on the Display attribute, if present</returns>
        public static string GetDisplayName(Enum val)
        {
            return val.GetType()
                .GetMember(val.ToString())
                .FirstOrDefault()
                ?.GetCustomAttribute<DisplayAttribute>(false)
                ?.GetName()
                ?? val.ToString();
        }
    }
}