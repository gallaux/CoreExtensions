using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetStandardExtensions.Extensions;
using NetStandardExtensions.Helpers;
using System;

namespace NetStandardExtensionsTests
{
    [TestClass]
    public class StringTests
    {
        private const char nonBreakingSpace = '\u00a0';

        [TestMethod]
        public void String_ReplaceNonBreakingSpaces_ShouldReturnStringWithRegularSpaces()
        {
            var expected = "Lorem Ipsum Dolor Sit";
            var str = $"Lorem{nonBreakingSpace}Ipsum{nonBreakingSpace}Dolor{nonBreakingSpace}Sit";

            // Helper
            Assert.AreEqual(expected, StringHelper.ReplaceNonBreakingSpaces(str));
            
            // Extension
            Assert.AreEqual(expected, str.ReplaceNonBreakingSpaces());
        }

        [TestMethod]
        public void String_ReplaceNonBreakingSpaces_NullStringShouldReturnNull()
        {
            var expected = null as string;
            var nullStr = null as string;

            // Helper
            Assert.AreEqual(expected, StringHelper.ReplaceNonBreakingSpaces(nullStr));
            
            // Extension
            Assert.AreEqual(expected, nullStr.ReplaceNonBreakingSpaces());
        }

        [TestMethod]
        public void String_Slice_ReturnSlicedString_FromStartToEndIndex()
        {
            var expected = "loWo";
            var str = "helloWorld";

            // Helper
            Assert.AreEqual(expected, StringHelper.Slice(str, 3, 6));

            // Extension
            Assert.AreEqual(expected, str.Slice(3, 6));
        }

        [TestMethod]
        public void String_Slice_ReturnsSlicedString_FromStartIndexToEndOfString()
        {
            var expected = "loWorld";
            var str = "helloWorld";

            // Helper
            Assert.AreEqual(expected, StringHelper.Slice(str, 3));

            // Extension
            Assert.AreEqual(expected, str.Slice(3));
        }

        [TestMethod]
        public void String_Slice_ThrowsArgumentOutOfRangeException_IfIndexOutOfBound()
        {
            var str = "helloWorld";

            Assert.ThrowsException<ArgumentOutOfRangeException> (() => StringHelper.Slice(str, -3));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => StringHelper.Slice(str, 3, 20));
        }

        [TestMethod]
        public void String_Slice_ThrowsNullReferenceException_IfStringIsNull()
        {
            var str = null as string;

            Assert.ThrowsException<NullReferenceException>(() => StringHelper.Slice(str, 3));
        }
    }
}