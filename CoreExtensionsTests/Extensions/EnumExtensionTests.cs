using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;
using CoreExtensions.Extensions;

namespace CoreExtensionsTests.Extensions
{
    [TestClass]
    public class EnumExtensionsTests
    {
        #region Constants, Enums, and Variables

        private enum TestEnum
        {
            [Display(Name = "Enum Test Name")]
            TestWithName,
            TestWithoutName
        }

        #endregion

        #region Methods

        [TestMethod]
        public void ShouldReturnEnumDisplayName()
        {
            var testEnumWithDisplayName = TestEnum.TestWithName;
            Assert.AreEqual("Enum Test Name", testEnumWithDisplayName.GetDisplayName());
        }

        [TestMethod]
        public void ShouldReturnEnumMemberName()
        {
            var testEnumWithoutDisplayName = TestEnum.TestWithoutName;
            Assert.AreEqual("TestWithoutName", testEnumWithoutDisplayName.GetDisplayName());
        }

        #endregion
    }
}