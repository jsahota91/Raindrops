using NUnit.Framework;
using Raindrops;

namespace RaindropsTest
{
    public class FactorsShould
    {

        [TestCase(28, "Plong")]
        [TestCase(42, "Plong")]
        public void GivenNumberNHasAFactorOf7_ReturnStringPlong(int n, string expected)
        {
            Assert.That(Program.Factors(n), Is.EqualTo(expected));
        }

        [TestCase(23, "23")]
        [TestCase(34, "34")]
        public void GivenNumberNHasNoneOfTheFactors_ReturnNumberN(int n, string expected)
        {
            Assert.That(Program.Factors(n), Is.EqualTo(expected));
        }
    }
}