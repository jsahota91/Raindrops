using NUnit.Framework;
using Raindrops;

namespace RaindropsTest
{
    public class FactorsShould
    {
        [TestCase(28, "Plong")]
        [TestCase(14, "Plong")]
        public void GivenNumberNHasAFactorOf7_ReturnStringPlong(int n, string expected)
        {
            Assert.That(Program.FactorResults(n), Is.EqualTo(expected));
        }

        [TestCase(23, "23")]
        [TestCase(34, "34")]
        public void GivenNumberNHasNoneOfTheFactors_ReturnNumberN(int n, string expected)
        {
            Assert.That(Program.FactorResults(n), Is.EqualTo(expected));
        }

        [TestCase(10, "Plang")]
        [TestCase(25, "Plang")]
        public void GivenNumberNHasFactorOf5_ReturnStringPlang(int n, string expected)
        {
            Assert.That(Program.FactorResults(n), Is.EqualTo(expected));
        }

        [TestCase(12, "Pling")]
        [TestCase(9, "Pling")]
        public void GivenNumberNHasFactorOf3_ReturnStringPling(int n, string expected)
        {
            Assert.That(Program.FactorResults(n), Is.EqualTo(expected));
        }

        [TestCase(15, "PlingPlang")]
        [TestCase(30, "PlingPlang")]
        public void GivenNumberNHasFactorOf3and5_ReturnStringPlingPlang(int n, string expected)
        {
            Assert.That(Program.FactorResults(n), Is.EqualTo(expected));
        }

        [TestCase(21, "PlingPlong")]
        [TestCase(42, "PlingPlong")]
        public void GivenNumberNHasFactorOf3and7_ReturnStringPlingPlong(int n, string expected)
        {
            Assert.That(Program.FactorResults(n), Is.EqualTo(expected));
        }

        [TestCase(35, "PlangPlong")]
        [TestCase(70, "PlangPlong")]
        public void GivenNumberNHasFactorOf5and7_ReturnStringPlangPlong(int n, string expected)
        {
            Assert.That(Program.FactorResults(n), Is.EqualTo(expected));
        }

        [TestCase(105, "PlingPlangPlong")]
        [TestCase(210, "PlingPlangPlong")]
        public void GivenNumberNHasFactorOf3and5and7_ReturnStringPlingPlangPlong(int n, string expected)
        {
            Assert.That(Program.FactorResults(n), Is.EqualTo(expected));
        }
    }
}