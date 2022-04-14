using System.Collections.Generic;

namespace CoreExtensions.Helpers
{
    /// <summary>
    /// Helper class to manipulate Lists
    /// </summary>
    public class ListHelper
    {
        /// <summary>
        /// Move item at oldIndex to newIndex
        /// </summary>
        /// <param name="oldIndex">The index of the item to move</param>
        /// <param name="newIndex">The new index of the item once moved</param>
        /// <returns>The list with the item moved</returns>
        public static void MoveItem<T>(List<T> list, int oldIndex, int newIndex)
        {
            list.Insert(newIndex, list[oldIndex]);
            if (newIndex <= oldIndex) oldIndex++;
            list.RemoveAt(oldIndex);
        }
    }
}