using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;
using NetStandardExtensions.Extensions;
using NetStandardExtensions.Helpers;

namespace NetStandardExtensionsTests
{
    [TestClass]
    public class EnumTests
    {
        private enum TestEnum
        {
            [Display(Name = "Enum Test Name")]
            TestWithName,
            TestWithoutName
        }

        [TestMethod]
        public void Enum_GetDisplayName_ShouldReturnEnumDisplayName()
        {
            var expected = "Enum Test Name";
            var testEnumWithDisplayName = TestEnum.TestWithName;

            // Helper
            Assert.AreEqual(expected, EnumHelper.GetDisplayName(testEnumWithDisplayName));

            // Extension
            Assert.AreEqual(expected, testEnumWithDisplayName.GetDisplayName());
        }

        [TestMethod]
        public void Enum_GetDisplayName_ShouldReturnEnumMemberName()
        {
            var expected = "TestWithoutName";
            var testEnumWithoutDisplayName = TestEnum.TestWithoutName;

            // Helper
            Assert.AreEqual(expected, EnumHelper.GetDisplayName(testEnumWithoutDisplayName));

            // Extension
            Assert.AreEqual(expected, testEnumWithoutDisplayName.GetDisplayName());
        }
    }
}