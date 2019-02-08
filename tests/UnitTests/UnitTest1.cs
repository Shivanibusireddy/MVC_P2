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
        [Fact]
        public void Test2()
        {
            var expected = 15;
                var a = -5;
            var actual = OddNum(a);
            Assert.Equal(expected, actual);
               
        }
        [Theory]
        [InlineData(-5, 15)]
        public void Test3(int a, int b) { Assert.Equal(b, OddNum(a)); }



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
