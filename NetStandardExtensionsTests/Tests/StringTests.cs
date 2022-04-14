using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetStandardExtensions.Extensions;
using NetStandardExtensions.Helpers;

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
    }
}