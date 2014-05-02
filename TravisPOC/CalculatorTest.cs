using NUnit.Framework;

namespace TravisPOC
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void AddTest()
        {
            //arrange 
            const int a = 1;
            const int b = 2;
            var calculator = new Calculator();

            //act
            var result = calculator.Add(a, b);

            //assert
            Assert.That(result, Is.EqualTo(4));
        }
    }
}
