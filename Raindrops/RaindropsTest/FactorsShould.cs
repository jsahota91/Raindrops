using NUnit.Framework;
using Raindrops;

namespace RaindropsTest
{
    public class FactorsShould
    {

        [TestCase(28, "Plong")]
        [TestCase(42, "Plong")]
        public void GivenNumbernHasAFactorOf7_ReturnStringPlong(int n, string expected)
        {
            Assert.That(Program.Factors(n), Is.EqualTo(expected));
        }

        
    }
}