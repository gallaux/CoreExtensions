using System.Text.RegularExpressions;

namespace NetStandardExtensions.Helpers
{
    /// <summary>
    /// Helper class to process strings
    /// </summary>
    public class StringHelper
    {
        /// <summary>
        /// Replaces non-breaking spaces with standard spaces in a string
        /// </summary>
        /// <param name="value">String to find/replace spaces</param>
        /// <returns>String containing original string with non-breaking spaces replaced</returns>
        public static string ReplaceNonBreakingSpaces(string value)
        {
            return value == null ? value : Regex.Replace(value, "\\u00a0", " ");
        }

        /// <summary>
        /// Extracts a portion of a string, selected from start index to end index
        /// Similar to JavaScript's string.slice() method
        /// </summary>
        /// <param name="value">String to slice</param>
        /// <param name="startIndex">The start index</param>
        /// <param name="endIndex">The end index</param>
        /// <returns>Sliced substring</returns>
        public static string Slice(string value, int startIndex, int? endIndex = null)
        {
            return value.Substring(startIndex, value.Length - (endIndex ?? startIndex));
        }
    }
}