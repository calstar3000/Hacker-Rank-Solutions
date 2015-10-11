using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace HackerRank.Tests.Implementation.Encryption
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        [TestCase("if man was meant to stay on the ground god would have given us roots",
            "imtgdvs fearwer mayoogo anouuio ntnnlvt wttddes aohghn sseoau")]
        [TestCase("have a nice day", "hae and via ecy")]
        [TestCase("feed the dog", "fto ehg ee dd")]
        [TestCase("chillout", "clu hlt io")]
        public void TestEncryptionSolution(string decryptedText, string expected)
        {
            // Arrange
            decryptedText = decryptedText.Replace(" ", "");

            // Act
            string encryptedText = new Solutions.Implementation.Encryption.Solution().GetSolution(decryptedText);

            NUnit.Framework.Assert.AreEqual(expected, encryptedText);
        }
    }
}
