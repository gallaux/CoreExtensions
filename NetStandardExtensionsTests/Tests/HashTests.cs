using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetStandardExtensions.Helpers;
using System.IO;

namespace NetStandardExtensionsTests
{
    [TestClass]
    public class HashTests
    {
        private readonly string testFilePath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "Resources\\TestFile.txt");
        private readonly string testFileSha1Hash = "640AB2BAE07BEDC4C163F679A746F7AB7FB5D1FA";

        [TestMethod]
        public void Hash_GetSha1Hash_InvalidFilePathShouldReturnNull()
        {
            var expected = null as string;
            var invalidPath = "/InvalidFilePath";

            var hash = HashHelper.GetSha1Hash(invalidPath);

            Assert.AreEqual(expected, hash);
        }

        [TestMethod]
        public void Hash_GetSha1Hash_ValidFilePathShouldReturnHash()
        {
            var hash = HashHelper.GetSha1Hash(testFilePath);

            Assert.AreEqual(testFileSha1Hash, hash);
        }

        [TestMethod]
        public void Hash_GetSha1Hash_ValidStreamShouldReturnHash()
        {
            using (FileStream fs = File.OpenRead(testFilePath))
            {
                var hash = HashHelper.GetSha1Hash(fs);

                Assert.AreEqual(testFileSha1Hash, hash);
            }
        }
    }
}