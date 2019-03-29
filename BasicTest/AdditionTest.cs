using Basic;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class AdditionTest
    {
        private IAddition _addition;
        [SetUp]
        public void Setup()
        {
            _addition = new Addition();
        }

        [Test]
        public void Addition_Test_for_NotImplementedException()
        {

            Assert.DoesNotThrow(() => _addition.Add(1, 1));
            //or
            Assert.That(() => _addition.Add(1, 1), Throws.Nothing);
        }
        [Test]
        public void Addition_Test_for_valueZero()
        {
            Assert.That(() => _addition.Add(0, 0), Is.EqualTo(0));
        }
        [Test]
        public void Addition_Test_for_Value3_and_5()
        {
            Assert.That(() => _addition.Add(3, 5), Is.EqualTo(8));
        }
        [Test]
        public void Addition_Test_for_Negative_Value()
        {
            Assert.That(() => _addition.Add(-30, -90), Is.EqualTo(-120));
        }
        [Test]
        public void Addition_Test_for_Negative_And_Positive_Value()
        {
            Assert.That(() => _addition.Add(-5, 10), Is.EqualTo(5));
        }
        [Test]
        public void Addition_Test_for_Positive_Negative_Value()
        {
            Assert.That(() => _addition.Add(10, -5), Is.EqualTo(5));
        }
        [Test]
        [TestCase(1, 5)]
        [TestCase(6, 5)]
        [TestCase(-7, 80)]
        [TestCase(51, -5)]
        public void Addition_Test_for_Summary(int first, int second)
        {
            Assert.That(() => _addition.Add(first, second), Is.GreaterThan(5));
        }
    }
}