using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode58_LengthOfLastWord
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void s_is_bc_should_return_2()
        {
            var s = "bc";
            Assert.AreEqual(2, new Solution().LengthOfLastWord(s));
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
