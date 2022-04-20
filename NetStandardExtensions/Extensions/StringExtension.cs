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

        /// <summary>
        /// Extracts a portion of a string, selected from start index to end index
        /// Similar to JavaScript's string.slice() method
        /// </summary>
        /// <param name="value">String to slice</param>
        /// <param name="startIndex">The start index</param>
        /// <param name="endIndex">The end index</param>
        /// <returns>Sliced substring</returns>
        public static string Slice(this string value, int startIndex, int? endIndex = null)
        {
            return StringHelper.Slice(value, startIndex, endIndex);
        }
    }
}