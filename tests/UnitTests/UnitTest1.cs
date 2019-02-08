using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var outcome = 105;
            var a = 7;
            var actual = OddNum(a);
            Assert.Equal(outcome, actual);
        }

        public void Test2()
        {
            var expected = 3;
                var a = -3;
            var actual = OddNum(a);
            Assert.Equal(expected, actual);
               
        }
        int OddNum(int x)
        {
            var b = 1;
            var pro = 1;
            if (x < 0)
            {
                x = -x;
            }
            for (b = 1; b <= x; b++)
            {
                if (b % 2 != 0)
                {
                    pro *= b;
                }


            }
            return pro;
        }
    }
}
