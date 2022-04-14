using NetStandardExtensions.Helpers;
using System.Collections.Generic;

namespace NetStandardExtensions.Extensions
{
    /// <summary>
    /// Adds extensions to the List class
    /// </summary>
    public static class ListExtension
    {
        /// <summary>
        /// Move item at oldIndex to newIndex
        /// </summary>
        /// <param name="oldIndex">The index of the item to move</param>
        /// <param name="newIndex">The new index of the item once moved</param>
        public static void MoveItem<T>(this List<T> list, int oldIndex, int newIndex)
        {
            ListHelper.MoveItem(list, oldIndex, newIndex);
        }
    }
}