using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoreExtensions.Extensions;
using CoreExtensions.Helpers;
using System.Collections.Generic;
using System.Linq;

namespace CoreExtensionsTests
{
    [TestClass]
    public class ListTests
    {
        [TestMethod]
        public void List_MoveItem_SuccessfullyMovesListItem()
        {
            var listHelper = new List<int>() { 0, 1, 2, 3, 4 };
            var listExtension = new List<int>() { 0, 1, 2, 3, 4 };

            var oldIndex = 4;
            var newIndex = 1;
            var expected = new List<int>() { 0, 4, 1, 2, 3 };

            // Helper
            ListHelper.MoveItem(listHelper, oldIndex, newIndex);
            Assert.IsTrue(expected.SequenceEqual(listHelper));

            // Extension
            listExtension.MoveItem(oldIndex, newIndex);
            Assert.IsTrue(expected.SequenceEqual(listExtension));
        }
    }
}