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

        [TestMethod]
        public void s_is_bc_and_3_spaces_should_return_2()
        {
            LastWordLengthShouldBe("bc   ", 2);
        }

        [TestMethod]
        public void s_is_bc_space_xyz_should_return_3()
        {
            LastWordLengthShouldBe("bc xyz", 3);
        }

        [TestMethod]
        public void s_is_space_a_should_return_1()
        {
            LastWordLengthShouldBe(" a", 1);
        }
    }

    public class Solution
    {
        public int LengthOfLastWord(string s)
        {
            var isEndSpaceClear = false;
            var endCharIndex = s.Length - 1;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (!isEndSpaceClear && !IsSpace(s[i]))
                {
                    isEndSpaceClear = true;
                    endCharIndex = i;
                }
                else if (isEndSpaceClear && IsSpace(s[i]))
                {
                    return endCharIndex - i;
                }
            }

            return isEndSpaceClear ? endCharIndex + 1 : 0;
        }

        private static bool IsSpace(char @char)
        {
            return @char == ' ';
        }
    }
}