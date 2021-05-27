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

        [TestCase(10, "Plang")]
        [TestCase(30, "Plang")]
        public void GivenNumberNHasFactorOf5_ReturnStringPlang(int n, string expected)
        {
            Assert.That(Program.Factors(n), Is.EqualTo(expected));
        }

        [TestCase(12, "Pling")]
        [TestCase(9, "Pling")]
        public void GivenNumberNHasFactorOf3_ReturnStringPling(int n, string expected)
        {
            Assert.That(Program.Factors(n), Is.EqualTo(expected));
        }

        [TestCase(15, "PlingPlang")]
        [TestCase(30, "PlingPlang")]
        public void GivenNumberNHasFactorOf3and5_ReturnStringPlingPlang(int n, string expected)
        {
            Assert.That(Program.Factors(n), Is.EqualTo(expected));
        }

        [TestCase(21, "PlingPlong")]
        [TestCase(42, "PlingPlong")]
        public void GivenNumberNHasFactorOf3and7_ReturnStringPlingPlong(int n, string expected)
        {
            Assert.That(Program.Factors(n), Is.EqualTo(expected));
        }
    }
}