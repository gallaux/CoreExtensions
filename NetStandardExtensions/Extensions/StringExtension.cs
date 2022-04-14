using NetStandardExtensions.Helpers;

namespace NetStandardExtensions.Extensions
{
    /// <summary>
    /// Adds extensions to the String class
    /// </summary>
    public static class StringExtension
    {
        /// <summary>
        /// Replaces non-breaking spaces with standard spaces in a string
        /// </summary>
        /// <param name="value">String to find/replace spaces</param>
        /// <returns>String containing original string with non-breaking spaces replaced</returns>
        public static string ReplaceNonBreakingSpaces(this string value)
        {
            return StringHelper.ReplaceNonBreakingSpaces(value);
        }
    }
}