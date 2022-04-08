using System.Text.RegularExpressions;

namespace CoreExtensions.Helpers
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
    }
}