using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Project.Tests {
    [TestClass]
    public class ProjectTests {
        [TestMethod]
        [DataRow("cat", "hat", false)]
        [DataRow("cat", "bat", false)]
        [DataRow("cat", "act", true)]
        [DataRow("cat", "tac", true)]
        [DataRow("cat", "fact", false)]
        public void anagram_test(string word1, string word2, bool result) {
            Assert.AreEqual(Project.Anagram.isAnagram(word1, word2), result);
        }

        [TestMethod]
        [DataRow(25, new int[]{1,0,0,0})]
        [DataRow(37, new int[]{1,1,0,2})]
        [DataRow(44, new int[]{1,1,1,4})]
        [DataRow(108, new int[]{4,0,1,3})]
        [DataRow(172, new int[]{6,2,0,2})]
        [DataRow(344, new int[]{13,1,1,4})]
        public void coin_test(int coins, int[] result) {
            CollectionAssert.AreEqual(Project.Coin.getCoins(coins), result);
        }

        [TestMethod]
        [DataRow()]
        public void palindrome_test() {
            Assert.IsTrue(false);
        }

        [TestMethod]
        [DataRow()]
        public void allergy_test() {
            Assert.IsTrue(false);
        }

        [TestMethod]
        [DataRow()]
        public void number_to_word_test() {
            Assert.IsTrue(false);
        }
    }
}