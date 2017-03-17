using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode58_LengthOfLastWord
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void s_is_bc_should_return_2()
        {
            LastWordLengthShouldBe("bc", 2);
        }

        private static void LastWordLengthShouldBe(string s, int expected)
        {
            Assert.AreEqual(expected, new Solution().LengthOfLastWord(s));
        }
    }

    public class Solution
    {
        public int LengthOfLastWord(string s)
        {
            return s.Length;
        }
    }
}